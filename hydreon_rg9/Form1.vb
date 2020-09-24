Imports System
Imports System.Drawing
Imports System.Timers
Imports System.Windows.Forms
Imports System.Globalization
Imports System.IO
Imports System.IO.File
Imports System.Xml
'Imports System.Strings
Imports System.Data.SqlClient

Public Class Form1

    ' Variables globales
    Dim simulando As Boolean = False
    Dim bufferTX As String = ""
    Dim BufferRX As String = ""
    Dim dipSW1_txt = "0"
    Dim dipSW2_txt = "0"
    Dim dipSW3_txt = "0"
    Dim dipSW4_txt = "0"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Obtener información de puertos COM
        '*****************************************
        Try
            For Each serial_port As String In My.Computer.Ports.SerialPortNames
                cmbBox_PuertoSerie.Items.Add(serial_port)
            Next
        Catch ex As Exception
            If cmbBox_PuertoSerie.Items.Count < 0 Then
                MsgBox("No se encontró puerto Serial", MsgBoxStyle.Critical, "Error")
            End If
        End Try
        '*******************************************
    End Sub

    Sub abrirPuertoSerie(ByVal puerto As String)
        Try
            With comPuertoSerie
                If .IsOpen Then
                    .Close()
                End If
                .PortName = puerto
                .BaudRate = 115200
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
                .Parity = IO.Ports.Parity.None
                .DtrEnable = False
                .ReadBufferSize = 4096
                .ReadTimeout = 500
                .WriteBufferSize = 4096
                .WriteTimeout = 500
                .RtsEnable = True
                .Encoding = System.Text.Encoding.Default
                .Open()
            End With

        Catch ex As Exception
            MsgBox("Error al abrir el puerto serie: " &
                   ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btn_Recargar_PuertoSerie_Click(sender As Object, e As EventArgs) Handles Button_Recargar.Click
        ' Obtener información de puertos COM
        '*****************************************
        Try
            cmbBox_PuertoSerie.Items.Clear()
            For Each serial_port As String In My.Computer.Ports.SerialPortNames
                cmbBox_PuertoSerie.Items.Add(serial_port)
            Next
        Catch ex As Exception
            If cmbBox_PuertoSerie.Items.Count < 0 Then
                MsgBox("No se encontró puerto Serial", MsgBoxStyle.Critical, "Error")
            End If
        End Try
        '*******************************************
    End Sub

    Private Sub Button_Limpiar_Click(sender As Object, e As EventArgs) Handles Button_Limpiar.Click
        TextBox_Log_Serial.Text = ""
    End Sub

    Private Sub Button_Copiar_Click(sender As Object, e As EventArgs) Handles Button_Copiar.Click
        If TextBox_Log_Serial.Text <> String.Empty Then
            Clipboard.SetText(TextBox_Log_Serial.Text)
        Else
            Clipboard.Clear()
        End If
    End Sub

    Private Sub Button_Exportar_Click(sender As Object, e As EventArgs) Handles Button_Exportar.Click
        If TextBox_Log_Serial.Text <> String.Empty Then
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "Detektor USART Log File |*.txt"
            saveFileDialog1.AddExtension = True
            saveFileDialog1.CheckPathExists = True
            saveFileDialog1.FileName = CStr(Format(Now(), "yyyyMMdd")) + " - SCORT Test"
            saveFileDialog1.DefaultExt = ".txt"
            saveFileDialog1.Title = "Guardar Archivo de Pruebas Sistema SCORT"
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            saveFileDialog1.ShowDialog()
            My.Computer.FileSystem.WriteAllText(saveFileDialog1.FileName, TextBox_Log_Serial.Text, True)
        Else
            MessageBox.Show("El log está vacío. No hay información para guardar")
        End If
    End Sub

    Private Sub Button_Abrir_Simular_Click(sender As Object, e As EventArgs) Handles Button_Abrir_Simular.Click
        'Declaración de Variables


        If (Me.Button_Abrir_Simular.Text.ToString() = "Simular") Then
            simulando = True
            Me.Button_Abrir_Simular.Text = "Parar"
            Me.Button_Recargar.Enabled = False
            Me.Button_LensBad.Enabled = True
            Me.Button_TX.Enabled = True


            'Abrir Puerto serial
            If (Microsoft.VisualBasic.Len(Me.cmbBox_PuertoSerie.SelectedItem) > 0 Or Microsoft.VisualBasic.Len(Me.cmbBox_PuertoSerie.Text) > 0) Then
                TextBox_Log_Serial.AppendText("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "] " + "PUERTO COM ABIERTO" + vbCrLf)
                abrirPuertoSerie(cmbBox_PuertoSerie.Text)

                '************* Buffer stuff
                Try
                    comPuertoSerie.DiscardInBuffer()
                    System.Threading.Thread.Sleep(10)
                    comPuertoSerie.DiscardInBuffer()
                    Timer_Leer_COM.Enabled = True
                    TextBox_Log_Serial.AppendText("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "] " + "INICIA SIMULACIÓN..." + vbCrLf)
                    cmbBox_PuertoSerie.Enabled = False
                Catch ex As Exception

                End Try
            Else
                MsgBox("Favor seleccione un puerto serial")
                Exit Sub
            End If

        Else
            simulando = False
            Me.Button_Abrir_Simular.Text = "Simular"
            Me.Button_Recargar.Enabled = True
            Me.Button_LensBad.Enabled = False
            Me.Button_TX.Enabled = False

            '************* Buffer stuff
            Try
                comPuertoSerie.DiscardInBuffer()
                System.Threading.Thread.Sleep(10)
                comPuertoSerie.DiscardInBuffer()

                'Deshabilitar el proceso de lectura del puerto COM
                Timer_Leer_COM.Enabled = False
                cmbBox_PuertoSerie.Enabled = True
                TextBox_Log_Serial.AppendText("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "] " + "SIMULACIÓN FINALIZADA..." + vbCrLf)
            Catch ex As Exception

            End Try
        End If

    End Sub


    Private Sub TrackBar_Sensitivity_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar_Sensitivity.ValueChanged
        If simulando = True Then
            If Me.Radio_ContinuosMode.Checked = True Then
                bufferTX = "R " + Me.TrackBar_Sensitivity.Value.ToString()
                Try
                    comPuertoSerie.Write(bufferTX + vbCrLf)
                Catch ex As Exception

                End Try
                TextBox_Log_Serial.AppendText("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "]>> " + bufferTX + vbCrLf)
            End If
        End If
    End Sub

    Private Sub Button_LensBad_Click(sender As Object, e As EventArgs) Handles Button_LensBad.Click
        If simulando = True Then
            bufferTX = "LensBad"
            Try
                comPuertoSerie.Write(bufferTX + vbCrLf)
            Catch ex As Exception

            End Try
            TextBox_Log_Serial.AppendText("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "]>> " + bufferTX + vbCrLf)
        End If
    End Sub

    Private Sub Button_TX_Click(sender As Object, e As EventArgs) Handles Button_TX.Click
        If simulando = True Then
            If Me.Radio_Reset.Checked = True Then
                bufferTX = "Reset N"
            ElseIf Me.Radio_Firmware.Checked = True Then
                bufferTX = "SW 1.000 2020.06.05"
            ElseIf Me.Radio_Emitters.Checked = True Then
                bufferTX = "Emitters 9 10, Emtotal 19"
            ElseIf Me.Radio_DIPSwitch.Checked = True Then
                bufferTX = "DIP " + dipSW1_txt + dipSW2_txt + dipSW3_txt + dipSW4_txt
            ElseIf Me.Radio_PwrDays.Checked = True Then
                bufferTX = "PwrDays 13"
            ElseIf Me.Radio_EmSat.Checked = True Then
                bufferTX = "EmSat"
            End If
            Try
                comPuertoSerie.Write(bufferTX + vbCrLf)
            Catch ex As Exception

            End Try
            TextBox_Log_Serial.AppendText("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "]>> " + bufferTX + vbCrLf)
        End If
    End Sub

    Private Sub DIP_Switch1_CheckedChanged(sender As Object, e As EventArgs) Handles DIP_Switch1.CheckedChanged
        If Me.DIP_Switch1.Checked = True Then
            dipSW1_txt = "1"
        Else
            dipSW1_txt = "0"
        End If
    End Sub

    Private Sub DIP_Switch2_CheckedChanged(sender As Object, e As EventArgs) Handles DIP_Switch2.CheckedChanged
        If Me.DIP_Switch2.Checked = True Then
            dipSW2_txt = "1"
        Else
            dipSW2_txt = "0"
        End If
    End Sub

    Private Sub DIP_Switch3_CheckedChanged(sender As Object, e As EventArgs) Handles DIP_Switch3.CheckedChanged
        If Me.DIP_Switch3.Checked = True Then
            dipSW3_txt = "1"
        Else
            dipSW3_txt = "0"
        End If
    End Sub

    Private Sub DIP_Switch4_CheckedChanged(sender As Object, e As EventArgs) Handles DIP_Switch4.CheckedChanged
        If Me.DIP_Switch4.Checked = True Then
            dipSW4_txt = "1"
        Else
            dipSW4_txt = "0"
        End If
    End Sub

    Private Sub Radio_PollingMode_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_PollingMode.CheckedChanged
        If simulando = True Then
            If Me.Radio_PollingMode.Checked = True Then
                'Habilitar el proceso de lectura del puerto COM
                TextBox_Log_Serial.AppendText("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "]>> Cambio a modo Consulta" + vbCrLf + vbCrLf)

            Else
                TextBox_Log_Serial.AppendText("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "]>> Cambio a modo Continuo" + vbCrLf + vbCrLf)
            End If
        End If
    End Sub

    Private Sub Timer_Leer_COM_Tick(sender As Object, e As EventArgs) Handles Timer_Leer_COM.Tick
        Dim p_bufferTX As String

        Try
            BufferRX = comPuertoSerie.ReadExisting()
        Catch ex As Exception

        End Try


        If ((BufferRX.Length >= 1) And (BufferRX.Length <= 3)) Then
            TextBox_Log_Serial.AppendText("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "]<< " + BufferRX + vbCrLf)
            Dim comandoRX As String = Strings.Left(BufferRX, 1)

            If (((comandoRX = "R") Or (comandoRX = "r")) And (Me.Radio_PollingMode.Checked = True)) Then
                p_bufferTX = "R " + Me.TrackBar_Sensitivity.Value.ToString()
                Try
                    comPuertoSerie.Write(p_bufferTX + vbCrLf)
                Catch ex As Exception

                End Try
                TextBox_Log_Serial.AppendText("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "]>> " + p_bufferTX + vbCrLf)


            ElseIf ((comandoRX = "K") Or (comandoRX = "k")) Then
                p_bufferTX = "Device Restarts"
                Try
                    comPuertoSerie.Write(p_bufferTX + vbCrLf)
                Catch ex As Exception

                End Try
                TextBox_Log_Serial.AppendText("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "]>> " + p_bufferTX)

            ElseIf ((comandoRX = "P") Or (comandoRX = "p")) Then
                p_bufferTX = "p"
                Try
                    comPuertoSerie.Write(p_bufferTX + vbCrLf)
                Catch ex As Exception
                End Try
                TextBox_Log_Serial.AppendText("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "]>> " + p_bufferTX + vbCrLf)
                Me.Radio_PollingMode.Checked = True

            ElseIf ((comandoRX = "C") Or (comandoRX = "c")) Then
                p_bufferTX = "c"
                Try
                    comPuertoSerie.Write(p_bufferTX + vbCrLf)
                Catch ex As Exception

                End Try
                TextBox_Log_Serial.AppendText("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "]>> " + p_bufferTX + vbCrLf)
                Me.Radio_ContinuosMode.Checked = True
            End If
        ElseIf BufferRX.Length >= 4 Then
            TextBox_Log_Serial.AppendText("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "]<< " + BufferRX + vbCrLf)
            TextBox_Log_Serial.AppendText("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "]>> ERROR de Emulador - Comando no soportado" + vbCrLf)
        Else

        End If
    End Sub
End Class
