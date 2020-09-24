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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button_Abrir_Simular = New System.Windows.Forms.Button()
        Me.Button_Recargar = New System.Windows.Forms.Button()
        Me.cmbBox_PuertoSerie = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button_Exportar = New System.Windows.Forms.Button()
        Me.Button_Copiar = New System.Windows.Forms.Button()
        Me.Button_Limpiar = New System.Windows.Forms.Button()
        Me.TextBox_Log_Serial = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabControl1.SuspendLayout()
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
        Me.Button_Recargar.Location = New System.Drawing.Point(9, 129)
        Me.Button_Recargar.Name = "Button_Recargar"
        Me.Button_Recargar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Recargar.TabIndex = 2
        Me.Button_Recargar.Text = "Recargar"
        Me.Button_Recargar.UseVisualStyleBackColor = True
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Baudrate"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(9, 94)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(75, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button_Exportar)
        Me.GroupBox5.Controls.Add(Me.Button_Copiar)
        Me.GroupBox5.Controls.Add(Me.Button_Limpiar)
        Me.GroupBox5.Controls.Add(Me.TextBox_Log_Serial)
        Me.GroupBox5.Location = New System.Drawing.Point(392, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(341, 189)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Salida"
        '
        'Button_Exportar
        '
        Me.Button_Exportar.Location = New System.Drawing.Point(257, 158)
        Me.Button_Exportar.Name = "Button_Exportar"
        Me.Button_Exportar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Exportar.TabIndex = 3
        Me.Button_Exportar.Text = "Exportar"
        Me.Button_Exportar.UseVisualStyleBackColor = True
        '
        'Button_Copiar
        '
        Me.Button_Copiar.Location = New System.Drawing.Point(176, 158)
        Me.Button_Copiar.Name = "Button_Copiar"
        Me.Button_Copiar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Copiar.TabIndex = 2
        Me.Button_Copiar.Text = "Copiar"
        Me.Button_Copiar.UseVisualStyleBackColor = True
        '
        'Button_Limpiar
        '
        Me.Button_Limpiar.Location = New System.Drawing.Point(6, 158)
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
        Me.TextBox_Log_Serial.Size = New System.Drawing.Size(326, 133)
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
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(260, 163)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Modo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(184, 163)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Intensidad"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(184, 163)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "DIP Switch"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(184, 163)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Lente"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(184, 163)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Otros"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 213)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "HYDREON RG-9 UART Emulator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
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
End Class
