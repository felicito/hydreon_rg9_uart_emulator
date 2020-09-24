<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button_Abrir_Simular = New System.Windows.Forms.Button()
        Me.Button_Recargar = New System.Windows.Forms.Button()
        Me.cmbBox_PuertoSerie = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button_Exportar = New System.Windows.Forms.Button()
        Me.Button_Copiar = New System.Windows.Forms.Button()
        Me.Button_Limpiar = New System.Windows.Forms.Button()
        Me.TextBox_Log_Serial = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Radio_ContinuosMode = New System.Windows.Forms.RadioButton()
        Me.Radio_PollingMode = New System.Windows.Forms.RadioButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TrackBar_Sensitivity = New System.Windows.Forms.TrackBar()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DIP_Switch4 = New System.Windows.Forms.CheckBox()
        Me.DIP_Switch3 = New System.Windows.Forms.CheckBox()
        Me.DIP_Switch2 = New System.Windows.Forms.CheckBox()
        Me.DIP_Switch1 = New System.Windows.Forms.CheckBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button_LensBad = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Button_TX = New System.Windows.Forms.Button()
        Me.Radio_EmSat = New System.Windows.Forms.RadioButton()
        Me.Radio_PwrDays = New System.Windows.Forms.RadioButton()
        Me.Radio_DIPSwitch = New System.Windows.Forms.RadioButton()
        Me.Radio_Emitters = New System.Windows.Forms.RadioButton()
        Me.Radio_Firmware = New System.Windows.Forms.RadioButton()
        Me.Radio_Reset = New System.Windows.Forms.RadioButton()
        Me.comPuertoSerie = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer_Leer_COM = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.TrackBar_Sensitivity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button_Abrir_Simular)
        Me.GroupBox1.Controls.Add(Me.Button_Recargar)
        Me.GroupBox1.Controls.Add(Me.cmbBox_PuertoSerie)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(96, 189)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "UART"
        '
        'ComboBox1
        '
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"115200"})
        Me.ComboBox1.Location = New System.Drawing.Point(9, 94)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(75, 21)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.Text = "115200"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Baudrate"
        '
        'Button_Abrir_Simular
        '
        Me.Button_Abrir_Simular.Location = New System.Drawing.Point(9, 158)
        Me.Button_Abrir_Simular.Name = "Button_Abrir_Simular"
        Me.Button_Abrir_Simular.Size = New System.Drawing.Size(78, 23)
        Me.Button_Abrir_Simular.TabIndex = 3
        Me.Button_Abrir_Simular.Text = "Simular"
        Me.Button_Abrir_Simular.UseVisualStyleBackColor = True
        '
        'Button_Recargar
        '
        Me.Button_Recargar.BackColor = System.Drawing.Color.Transparent
        Me.Button_Recargar.Location = New System.Drawing.Point(9, 129)
        Me.Button_Recargar.Name = "Button_Recargar"
        Me.Button_Recargar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Recargar.TabIndex = 2
        Me.Button_Recargar.Text = "Recargar"
        Me.Button_Recargar.UseVisualStyleBackColor = False
        '
        'cmbBox_PuertoSerie
        '
        Me.cmbBox_PuertoSerie.FormattingEnabled = True
        Me.cmbBox_PuertoSerie.Location = New System.Drawing.Point(9, 43)
        Me.cmbBox_PuertoSerie.Name = "cmbBox_PuertoSerie"
        Me.cmbBox_PuertoSerie.Size = New System.Drawing.Size(75, 21)
        Me.cmbBox_PuertoSerie.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Puerto COM"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button_Exportar)
        Me.GroupBox5.Controls.Add(Me.Button_Copiar)
        Me.GroupBox5.Controls.Add(Me.Button_Limpiar)
        Me.GroupBox5.Controls.Add(Me.TextBox_Log_Serial)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 207)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(376, 233)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Salida"
        '
        'Button_Exportar
        '
        Me.Button_Exportar.Location = New System.Drawing.Point(301, 204)
        Me.Button_Exportar.Name = "Button_Exportar"
        Me.Button_Exportar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Exportar.TabIndex = 3
        Me.Button_Exportar.Text = "Exportar"
        Me.Button_Exportar.UseVisualStyleBackColor = True
        '
        'Button_Copiar
        '
        Me.Button_Copiar.Location = New System.Drawing.Point(216, 204)
        Me.Button_Copiar.Name = "Button_Copiar"
        Me.Button_Copiar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Copiar.TabIndex = 2
        Me.Button_Copiar.Text = "Copiar"
        Me.Button_Copiar.UseVisualStyleBackColor = True
        '
        'Button_Limpiar
        '
        Me.Button_Limpiar.Location = New System.Drawing.Point(6, 204)
        Me.Button_Limpiar.Name = "Button_Limpiar"
        Me.Button_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Limpiar.TabIndex = 1
        Me.Button_Limpiar.Text = "Limpiar"
        Me.Button_Limpiar.UseVisualStyleBackColor = True
        '
        'TextBox_Log_Serial
        '
        Me.TextBox_Log_Serial.BackColor = System.Drawing.Color.Black
        Me.TextBox_Log_Serial.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Log_Serial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox_Log_Serial.Location = New System.Drawing.Point(6, 19)
        Me.TextBox_Log_Serial.Multiline = True
        Me.TextBox_Log_Serial.Name = "TextBox_Log_Serial"
        Me.TextBox_Log_Serial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_Log_Serial.Size = New System.Drawing.Size(364, 179)
        Me.TextBox_Log_Serial.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(120, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(268, 189)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.Radio_ContinuosMode)
        Me.TabPage1.Controls.Add(Me.Radio_PollingMode)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(260, 163)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Modo"
        '
        'Radio_ContinuosMode
        '
        Me.Radio_ContinuosMode.AutoSize = True
        Me.Radio_ContinuosMode.Checked = True
        Me.Radio_ContinuosMode.Location = New System.Drawing.Point(8, 21)
        Me.Radio_ContinuosMode.Name = "Radio_ContinuosMode"
        Me.Radio_ContinuosMode.Size = New System.Drawing.Size(67, 17)
        Me.Radio_ContinuosMode.TabIndex = 1
        Me.Radio_ContinuosMode.TabStop = True
        Me.Radio_ContinuosMode.Text = "Continuo"
        Me.Radio_ContinuosMode.UseVisualStyleBackColor = True
        '
        'Radio_PollingMode
        '
        Me.Radio_PollingMode.AutoSize = True
        Me.Radio_PollingMode.Location = New System.Drawing.Point(6, 44)
        Me.Radio_PollingMode.Name = "Radio_PollingMode"
        Me.Radio_PollingMode.Size = New System.Drawing.Size(66, 17)
        Me.Radio_PollingMode.TabIndex = 0
        Me.Radio_PollingMode.Text = "Consulta"
        Me.Radio_PollingMode.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.TrackBar_Sensitivity)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(260, 163)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Intensidad"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(53, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "R7 - Lluvia intensa"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(53, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "R6 - Lluvia pesada"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(53, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(168, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "R5 - Lluvia medianamente pesada"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(53, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "R4 - Lluvia media"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "R3 - Lluvia medianamente ligera"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "R2 - Lluvia muy ligera"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "R1 - Gotas de lluvia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "R0 - Sin lluvia"
        '
        'TrackBar_Sensitivity
        '
        Me.TrackBar_Sensitivity.LargeChange = 1
        Me.TrackBar_Sensitivity.Location = New System.Drawing.Point(21, 6)
        Me.TrackBar_Sensitivity.Maximum = 7
        Me.TrackBar_Sensitivity.Name = "TrackBar_Sensitivity"
        Me.TrackBar_Sensitivity.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar_Sensitivity.Size = New System.Drawing.Size(45, 154)
        Me.TrackBar_Sensitivity.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.DIP_Switch4)
        Me.TabPage3.Controls.Add(Me.DIP_Switch3)
        Me.TabPage3.Controls.Add(Me.DIP_Switch2)
        Me.TabPage3.Controls.Add(Me.DIP_Switch1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(260, 163)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "DIP Switch"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Estabilidad:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Sensibilidad:"
        '
        'DIP_Switch4
        '
        Me.DIP_Switch4.AutoSize = True
        Me.DIP_Switch4.Location = New System.Drawing.Point(29, 118)
        Me.DIP_Switch4.Name = "DIP_Switch4"
        Me.DIP_Switch4.Size = New System.Drawing.Size(88, 17)
        Me.DIP_Switch4.TabIndex = 3
        Me.DIP_Switch4.Text = "DIP Switch 4"
        Me.DIP_Switch4.UseVisualStyleBackColor = True
        '
        'DIP_Switch3
        '
        Me.DIP_Switch3.AutoSize = True
        Me.DIP_Switch3.Location = New System.Drawing.Point(29, 94)
        Me.DIP_Switch3.Name = "DIP_Switch3"
        Me.DIP_Switch3.Size = New System.Drawing.Size(88, 17)
        Me.DIP_Switch3.TabIndex = 2
        Me.DIP_Switch3.Text = "DIP Switch 3"
        Me.DIP_Switch3.UseVisualStyleBackColor = True
        '
        'DIP_Switch2
        '
        Me.DIP_Switch2.AutoSize = True
        Me.DIP_Switch2.Location = New System.Drawing.Point(29, 51)
        Me.DIP_Switch2.Name = "DIP_Switch2"
        Me.DIP_Switch2.Size = New System.Drawing.Size(88, 17)
        Me.DIP_Switch2.TabIndex = 1
        Me.DIP_Switch2.Text = "DIP Switch 2"
        Me.DIP_Switch2.UseVisualStyleBackColor = True
        '
        'DIP_Switch1
        '
        Me.DIP_Switch1.AutoSize = True
        Me.DIP_Switch1.Location = New System.Drawing.Point(29, 27)
        Me.DIP_Switch1.Name = "DIP_Switch1"
        Me.DIP_Switch1.Size = New System.Drawing.Size(88, 17)
        Me.DIP_Switch1.TabIndex = 0
        Me.DIP_Switch1.Text = "DIP Switch 1"
        Me.DIP_Switch1.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.Controls.Add(Me.Button_LensBad)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(260, 163)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Lente"
        '
        'Button_LensBad
        '
        Me.Button_LensBad.Location = New System.Drawing.Point(78, 19)
        Me.Button_LensBad.Name = "Button_LensBad"
        Me.Button_LensBad.Size = New System.Drawing.Size(114, 23)
        Me.Button_LensBad.TabIndex = 0
        Me.Button_LensBad.Text = "Lente Dañado"
        Me.Button_LensBad.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.White
        Me.TabPage5.Controls.Add(Me.Button_TX)
        Me.TabPage5.Controls.Add(Me.Radio_EmSat)
        Me.TabPage5.Controls.Add(Me.Radio_PwrDays)
        Me.TabPage5.Controls.Add(Me.Radio_DIPSwitch)
        Me.TabPage5.Controls.Add(Me.Radio_Emitters)
        Me.TabPage5.Controls.Add(Me.Radio_Firmware)
        Me.TabPage5.Controls.Add(Me.Radio_Reset)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(260, 163)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Otros"
        '
        'Button_TX
        '
        Me.Button_TX.Enabled = False
        Me.Button_TX.Location = New System.Drawing.Point(18, 12)
        Me.Button_TX.Name = "Button_TX"
        Me.Button_TX.Size = New System.Drawing.Size(75, 23)
        Me.Button_TX.TabIndex = 6
        Me.Button_TX.Text = "Transmitir"
        Me.Button_TX.UseVisualStyleBackColor = True
        '
        'Radio_EmSat
        '
        Me.Radio_EmSat.AutoSize = True
        Me.Radio_EmSat.Location = New System.Drawing.Point(107, 134)
        Me.Radio_EmSat.Name = "Radio_EmSat"
        Me.Radio_EmSat.Size = New System.Drawing.Size(102, 17)
        Me.Radio_EmSat.TabIndex = 5
        Me.Radio_EmSat.Text = "Emisor Saturado"
        Me.Radio_EmSat.UseVisualStyleBackColor = True
        '
        'Radio_PwrDays
        '
        Me.Radio_PwrDays.AutoSize = True
        Me.Radio_PwrDays.Location = New System.Drawing.Point(107, 110)
        Me.Radio_PwrDays.Name = "Radio_PwrDays"
        Me.Radio_PwrDays.Size = New System.Drawing.Size(102, 17)
        Me.Radio_PwrDays.TabIndex = 4
        Me.Radio_PwrDays.Text = "Días alimentado"
        Me.Radio_PwrDays.UseVisualStyleBackColor = True
        '
        'Radio_DIPSwitch
        '
        Me.Radio_DIPSwitch.AutoSize = True
        Me.Radio_DIPSwitch.Location = New System.Drawing.Point(107, 86)
        Me.Radio_DIPSwitch.Name = "Radio_DIPSwitch"
        Me.Radio_DIPSwitch.Size = New System.Drawing.Size(64, 17)
        Me.Radio_DIPSwitch.TabIndex = 3
        Me.Radio_DIPSwitch.Text = "DIP SW"
        Me.Radio_DIPSwitch.UseVisualStyleBackColor = True
        '
        'Radio_Emitters
        '
        Me.Radio_Emitters.AutoSize = True
        Me.Radio_Emitters.Location = New System.Drawing.Point(107, 62)
        Me.Radio_Emitters.Name = "Radio_Emitters"
        Me.Radio_Emitters.Size = New System.Drawing.Size(99, 17)
        Me.Radio_Emitters.TabIndex = 2
        Me.Radio_Emitters.Text = "Emisores 9 y 10"
        Me.Radio_Emitters.UseVisualStyleBackColor = True
        '
        'Radio_Firmware
        '
        Me.Radio_Firmware.AutoSize = True
        Me.Radio_Firmware.Location = New System.Drawing.Point(107, 38)
        Me.Radio_Firmware.Name = "Radio_Firmware"
        Me.Radio_Firmware.Size = New System.Drawing.Size(120, 17)
        Me.Radio_Firmware.TabIndex = 1
        Me.Radio_Firmware.Text = "Version de Firmware"
        Me.Radio_Firmware.UseVisualStyleBackColor = True
        '
        'Radio_Reset
        '
        Me.Radio_Reset.AutoSize = True
        Me.Radio_Reset.Checked = True
        Me.Radio_Reset.Location = New System.Drawing.Point(107, 14)
        Me.Radio_Reset.Name = "Radio_Reset"
        Me.Radio_Reset.Size = New System.Drawing.Size(89, 17)
        Me.Radio_Reset.TabIndex = 0
        Me.Radio_Reset.TabStop = True
        Me.Radio_Reset.Text = "Reset Normal"
        Me.Radio_Reset.UseVisualStyleBackColor = True
        '
        'Timer_Leer_COM
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(403, 452)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "HYDREON RG-9 UART Emulator"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.TrackBar_Sensitivity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button_Abrir_Simular As Button
    Friend WithEvents Button_Recargar As Button
    Friend WithEvents cmbBox_PuertoSerie As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button_Exportar As Button
    Friend WithEvents Button_Copiar As Button
    Friend WithEvents Button_Limpiar As Button
    Friend WithEvents TextBox_Log_Serial As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Radio_ContinuosMode As RadioButton
    Friend WithEvents Radio_PollingMode As RadioButton
    Friend WithEvents comPuertoSerie As IO.Ports.SerialPort
    Friend WithEvents Timer_Leer_COM As Timer
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TrackBar_Sensitivity As TrackBar
    Friend WithEvents Label11 As Label
    Friend WithEvents DIP_Switch4 As CheckBox
    Friend WithEvents DIP_Switch3 As CheckBox
    Friend WithEvents DIP_Switch2 As CheckBox
    Friend WithEvents DIP_Switch1 As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button_LensBad As Button
    Friend WithEvents Button_TX As Button
    Friend WithEvents Radio_EmSat As RadioButton
    Friend WithEvents Radio_PwrDays As RadioButton
    Friend WithEvents Radio_DIPSwitch As RadioButton
    Friend WithEvents Radio_Emitters As RadioButton
    Friend WithEvents Radio_Firmware As RadioButton
    Friend WithEvents Radio_Reset As RadioButton
End Class
