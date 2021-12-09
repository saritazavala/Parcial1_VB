<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.RB_LavExt = New System.Windows.Forms.RadioButton()
        Me.RB_LavBasic = New System.Windows.Forms.RadioButton()
        Me.RB_LavCompl = New System.Windows.Forms.RadioButton()
        Me.RB_LavMotor = New System.Windows.Forms.RadioButton()
        Me.RD_LimpChz = New System.Windows.Forms.RadioButton()
        Me.RB_Pulido = New System.Windows.Forms.RadioButton()
        Me.RB_Encerado = New System.Windows.Forms.RadioButton()
        Me.RB_Exterior = New System.Windows.Forms.RadioButton()
        Me.RB_TapBasic = New System.Windows.Forms.RadioButton()
        Me.RB_TapFull = New System.Windows.Forms.RadioButton()
        Me.RB_LavLlanta = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Btn_Calcular = New System.Windows.Forms.Button()
        Me.Btn_Limpiar = New System.Windows.Forms.Button()
        Me.Btn_Salir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ServDisp = New System.Windows.Forms.GroupBox()
        Me.ChBox_ServEsp = New System.Windows.Forms.CheckBox()
        Me.ChBox_ServBasc = New System.Windows.Forms.CheckBox()
        Me.ChBox_DCW = New System.Windows.Forms.CheckBox()
        Me.ServBasic = New System.Windows.Forms.GroupBox()
        Me.ServEsp = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.ServDisp.SuspendLayout()
        Me.ServBasic.SuspendLayout()
        Me.ServEsp.SuspendLayout()
        Me.SuspendLayout()
        '
        'RB_LavExt
        '
        Me.RB_LavExt.AutoSize = True
        Me.RB_LavExt.Location = New System.Drawing.Point(16, 30)
        Me.RB_LavExt.Name = "RB_LavExt"
        Me.RB_LavExt.Size = New System.Drawing.Size(133, 64)
        Me.RB_LavExt.TabIndex = 8
        Me.RB_LavExt.TabStop = True
        Me.RB_LavExt.Text = "Lavado Exterior" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " (Q110.50)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RB_LavExt.UseVisualStyleBackColor = True
        '
        'RB_LavBasic
        '
        Me.RB_LavBasic.AutoSize = True
        Me.RB_LavBasic.Location = New System.Drawing.Point(16, 80)
        Me.RB_LavBasic.Name = "RB_LavBasic"
        Me.RB_LavBasic.Size = New System.Drawing.Size(125, 44)
        Me.RB_LavBasic.TabIndex = 9
        Me.RB_LavBasic.TabStop = True
        Me.RB_LavBasic.Text = "Lavado Basico" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Q125.50)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RB_LavBasic.UseVisualStyleBackColor = True
        '
        'RB_LavCompl
        '
        Me.RB_LavCompl.AutoSize = True
        Me.RB_LavCompl.Location = New System.Drawing.Point(177, 30)
        Me.RB_LavCompl.Name = "RB_LavCompl"
        Me.RB_LavCompl.Size = New System.Drawing.Size(148, 44)
        Me.RB_LavCompl.TabIndex = 10
        Me.RB_LavCompl.TabStop = True
        Me.RB_LavCompl.Text = "Lavado Completo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Q185.50)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RB_LavCompl.UseVisualStyleBackColor = True
        '
        'RB_LavMotor
        '
        Me.RB_LavMotor.AutoSize = True
        Me.RB_LavMotor.Location = New System.Drawing.Point(177, 80)
        Me.RB_LavMotor.Name = "RB_LavMotor"
        Me.RB_LavMotor.Size = New System.Drawing.Size(144, 44)
        Me.RB_LavMotor.TabIndex = 11
        Me.RB_LavMotor.TabStop = True
        Me.RB_LavMotor.Text = "Lavado de Motor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Q165.50)"
        Me.RB_LavMotor.UseVisualStyleBackColor = True
        '
        'RD_LimpChz
        '
        Me.RD_LimpChz.AutoSize = True
        Me.RD_LimpChz.Location = New System.Drawing.Point(62, 130)
        Me.RD_LimpChz.Name = "RD_LimpChz"
        Me.RD_LimpChz.Size = New System.Drawing.Size(216, 24)
        Me.RD_LimpChz.TabIndex = 12
        Me.RD_LimpChz.TabStop = True
        Me.RD_LimpChz.Text = "Limpieza de Chasis (Q95.50)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RD_LimpChz.UseVisualStyleBackColor = True
        '
        'RB_Pulido
        '
        Me.RB_Pulido.AutoSize = True
        Me.RB_Pulido.Location = New System.Drawing.Point(4, 28)
        Me.RB_Pulido.Name = "RB_Pulido"
        Me.RB_Pulido.Size = New System.Drawing.Size(132, 24)
        Me.RB_Pulido.TabIndex = 14
        Me.RB_Pulido.TabStop = True
        Me.RB_Pulido.Text = "Pulido (Q90.00)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RB_Pulido.UseVisualStyleBackColor = True
        '
        'RB_Encerado
        '
        Me.RB_Encerado.AutoSize = True
        Me.RB_Encerado.Location = New System.Drawing.Point(4, 58)
        Me.RB_Encerado.Name = "RB_Encerado"
        Me.RB_Encerado.Size = New System.Drawing.Size(152, 24)
        Me.RB_Encerado.TabIndex = 15
        Me.RB_Encerado.TabStop = True
        Me.RB_Encerado.Text = "Encerado (Q90.00)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RB_Encerado.UseVisualStyleBackColor = True
        '
        'RB_Exterior
        '
        Me.RB_Exterior.AutoSize = True
        Me.RB_Exterior.Location = New System.Drawing.Point(4, 88)
        Me.RB_Exterior.Name = "RB_Exterior"
        Me.RB_Exterior.Size = New System.Drawing.Size(141, 24)
        Me.RB_Exterior.TabIndex = 16
        Me.RB_Exterior.TabStop = True
        Me.RB_Exterior.Text = "Exterior (Q90.00)"
        Me.RB_Exterior.UseVisualStyleBackColor = True
        '
        'RB_TapBasic
        '
        Me.RB_TapBasic.AutoSize = True
        Me.RB_TapBasic.Location = New System.Drawing.Point(162, 88)
        Me.RB_TapBasic.Name = "RB_TapBasic"
        Me.RB_TapBasic.Size = New System.Drawing.Size(197, 24)
        Me.RB_TapBasic.TabIndex = 17
        Me.RB_TapBasic.TabStop = True
        Me.RB_TapBasic.Text = "Tapizado Basico (Q85.00)"
        Me.RB_TapBasic.UseVisualStyleBackColor = True
        '
        'RB_TapFull
        '
        Me.RB_TapFull.AutoSize = True
        Me.RB_TapFull.Location = New System.Drawing.Point(162, 28)
        Me.RB_TapFull.Name = "RB_TapFull"
        Me.RB_TapFull.Size = New System.Drawing.Size(185, 24)
        Me.RB_TapFull.TabIndex = 18
        Me.RB_TapFull.TabStop = True
        Me.RB_TapFull.Text = "Tapizado Full (Q105.00)"
        Me.RB_TapFull.UseVisualStyleBackColor = True
        '
        'RB_LavLlanta
        '
        Me.RB_LavLlanta.AutoSize = True
        Me.RB_LavLlanta.Location = New System.Drawing.Point(162, 58)
        Me.RB_LavLlanta.Name = "RB_LavLlanta"
        Me.RB_LavLlanta.Size = New System.Drawing.Size(191, 24)
        Me.RB_LavLlanta.TabIndex = 19
        Me.RB_LavLlanta.TabStop = True
        Me.RB_LavLlanta.Text = "Lavado Llantas (Q135.00"
        Me.RB_LavLlanta.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(500, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "DATOS DE CLIENTE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(404, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(404, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "NIT"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(474, 253)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(222, 27)
        Me.TextBox1.TabIndex = 23
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(473, 293)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(222, 27)
        Me.TextBox2.TabIndex = 24
        '
        'Btn_Calcular
        '
        Me.Btn_Calcular.Location = New System.Drawing.Point(20, 53)
        Me.Btn_Calcular.Name = "Btn_Calcular"
        Me.Btn_Calcular.Size = New System.Drawing.Size(128, 28)
        Me.Btn_Calcular.TabIndex = 26
        Me.Btn_Calcular.Text = "Calcular"
        Me.Btn_Calcular.UseVisualStyleBackColor = True
        '
        'Btn_Limpiar
        '
        Me.Btn_Limpiar.Location = New System.Drawing.Point(171, 53)
        Me.Btn_Limpiar.Name = "Btn_Limpiar"
        Me.Btn_Limpiar.Size = New System.Drawing.Size(128, 28)
        Me.Btn_Limpiar.TabIndex = 27
        Me.Btn_Limpiar.Text = "Limpiar"
        Me.Btn_Limpiar.UseVisualStyleBackColor = True
        '
        'Btn_Salir
        '
        Me.Btn_Salir.Location = New System.Drawing.Point(323, 51)
        Me.Btn_Salir.Name = "Btn_Salir"
        Me.Btn_Salir.Size = New System.Drawing.Size(128, 30)
        Me.Btn_Salir.TabIndex = 28
        Me.Btn_Salir.Text = "Salir"
        Me.Btn_Salir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_Salir)
        Me.GroupBox1.Controls.Add(Me.Btn_Limpiar)
        Me.GroupBox1.Controls.Add(Me.Btn_Calcular)
        Me.GroupBox1.Location = New System.Drawing.Point(113, 359)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(470, 101)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ACCIONES"
        '
        'ServDisp
        '
        Me.ServDisp.Controls.Add(Me.ChBox_ServEsp)
        Me.ServDisp.Controls.Add(Me.ChBox_ServBasc)
        Me.ServDisp.Controls.Add(Me.ChBox_DCW)
        Me.ServDisp.Location = New System.Drawing.Point(33, 20)
        Me.ServDisp.Name = "ServDisp"
        Me.ServDisp.Size = New System.Drawing.Size(263, 144)
        Me.ServDisp.TabIndex = 30
        Me.ServDisp.TabStop = False
        Me.ServDisp.Text = "SERVICIOS DISPONIBLES"
        '
        'ChBox_ServEsp
        '
        Me.ChBox_ServEsp.AutoSize = True
        Me.ChBox_ServEsp.Location = New System.Drawing.Point(6, 96)
        Me.ChBox_ServEsp.Name = "ChBox_ServEsp"
        Me.ChBox_ServEsp.Size = New System.Drawing.Size(161, 24)
        Me.ChBox_ServEsp.TabIndex = 9
        Me.ChBox_ServEsp.Text = "Servicios Especiales"
        Me.ChBox_ServEsp.UseVisualStyleBackColor = True
        '
        'ChBox_ServBasc
        '
        Me.ChBox_ServBasc.AutoSize = True
        Me.ChBox_ServBasc.Location = New System.Drawing.Point(6, 66)
        Me.ChBox_ServBasc.Name = "ChBox_ServBasc"
        Me.ChBox_ServBasc.Size = New System.Drawing.Size(142, 24)
        Me.ChBox_ServBasc.TabIndex = 8
        Me.ChBox_ServBasc.Text = "Servicios Basicos"
        Me.ChBox_ServBasc.UseVisualStyleBackColor = True
        '
        'ChBox_DCW
        '
        Me.ChBox_DCW.AutoSize = True
        Me.ChBox_DCW.Location = New System.Drawing.Point(6, 36)
        Me.ChBox_DCW.Name = "ChBox_DCW"
        Me.ChBox_DCW.Size = New System.Drawing.Size(199, 24)
        Me.ChBox_DCW.TabIndex = 7
        Me.ChBox_DCW.Text = "Delivery Car Wash (Q100)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ChBox_DCW.UseVisualStyleBackColor = True
        '
        'ServBasic
        '
        Me.ServBasic.Controls.Add(Me.RD_LimpChz)
        Me.ServBasic.Controls.Add(Me.RB_LavMotor)
        Me.ServBasic.Controls.Add(Me.RB_LavBasic)
        Me.ServBasic.Controls.Add(Me.RB_LavExt)
        Me.ServBasic.Controls.Add(Me.RB_LavCompl)
        Me.ServBasic.Enabled = False
        Me.ServBasic.Location = New System.Drawing.Point(359, 20)
        Me.ServBasic.Name = "ServBasic"
        Me.ServBasic.Size = New System.Drawing.Size(355, 168)
        Me.ServBasic.TabIndex = 31
        Me.ServBasic.TabStop = False
        Me.ServBasic.Text = "SERVICIOS BASICOS"
        '
        'ServEsp
        '
        Me.ServEsp.Controls.Add(Me.RB_LavLlanta)
        Me.ServEsp.Controls.Add(Me.RB_TapFull)
        Me.ServEsp.Controls.Add(Me.RB_TapBasic)
        Me.ServEsp.Controls.Add(Me.RB_Exterior)
        Me.ServEsp.Controls.Add(Me.RB_Encerado)
        Me.ServEsp.Controls.Add(Me.RB_Pulido)
        Me.ServEsp.Enabled = False
        Me.ServEsp.Location = New System.Drawing.Point(12, 194)
        Me.ServEsp.Name = "ServEsp"
        Me.ServEsp.Size = New System.Drawing.Size(365, 154)
        Me.ServEsp.TabIndex = 32
        Me.ServEsp.TabStop = False
        Me.ServEsp.Text = "SERVICIOS ESPECIALES"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 526)
        Me.Controls.Add(Me.ServEsp)
        Me.Controls.Add(Me.ServBasic)
        Me.Controls.Add(Me.ServDisp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form1"
        Me.Text = "ACCIONES"
        Me.GroupBox1.ResumeLayout(False)
        Me.ServDisp.ResumeLayout(False)
        Me.ServDisp.PerformLayout()
        Me.ServBasic.ResumeLayout(False)
        Me.ServBasic.PerformLayout()
        Me.ServEsp.ResumeLayout(False)
        Me.ServEsp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RB_LavExt As RadioButton
    Friend WithEvents RB_LavBasic As RadioButton
    Friend WithEvents RB_LavCompl As RadioButton
    Friend WithEvents RB_LavMotor As RadioButton
    Friend WithEvents RD_LimpChz As RadioButton
    Friend WithEvents RB_Pulido As RadioButton
    Friend WithEvents RB_Encerado As RadioButton
    Friend WithEvents RB_Exterior As RadioButton
    Friend WithEvents RB_TapBasic As RadioButton
    Friend WithEvents RB_TapFull As RadioButton
    Friend WithEvents RB_LavLlanta As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Btn_Calcular As Button
    Friend WithEvents Btn_Limpiar As Button
    Friend WithEvents Btn_Salir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ServDisp As GroupBox
    Friend WithEvents ServBasic As GroupBox
    Friend WithEvents ServEsp As GroupBox
    Friend WithEvents ChBox_ServEsp As CheckBox
    Friend WithEvents ChBox_ServBasc As CheckBox
    Friend WithEvents ChBox_DCW As CheckBox
End Class
