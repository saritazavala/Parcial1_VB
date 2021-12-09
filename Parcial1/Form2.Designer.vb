<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Btn_Rslt = New System.Windows.Forms.Button()
        Me.TxtB_Final = New System.Windows.Forms.TextBox()
        Me.TxtB_DescTot = New System.Windows.Forms.TextBox()
        Me.TxtB_CantDesc = New System.Windows.Forms.TextBox()
        Me.TxtB_PagoPar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Btn_Rslt)
        Me.GroupBox1.Controls.Add(Me.TxtB_Final)
        Me.GroupBox1.Controls.Add(Me.TxtB_DescTot)
        Me.GroupBox1.Controls.Add(Me.TxtB_CantDesc)
        Me.GroupBox1.Controls.Add(Me.TxtB_PagoPar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(744, 193)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TOTALES"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(148, 147)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 40)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Btn_Rslt
        '
        Me.Btn_Rslt.Location = New System.Drawing.Point(15, 147)
        Me.Btn_Rslt.Name = "Btn_Rslt"
        Me.Btn_Rslt.Size = New System.Drawing.Size(127, 40)
        Me.Btn_Rslt.TabIndex = 8
        Me.Btn_Rslt.Text = "Resultados"
        Me.Btn_Rslt.UseVisualStyleBackColor = True
        '
        'TxtB_Final
        '
        Me.TxtB_Final.Enabled = False
        Me.TxtB_Final.Location = New System.Drawing.Point(534, 88)
        Me.TxtB_Final.Name = "TxtB_Final"
        Me.TxtB_Final.Size = New System.Drawing.Size(189, 34)
        Me.TxtB_Final.TabIndex = 7
        '
        'TxtB_DescTot
        '
        Me.TxtB_DescTot.Enabled = False
        Me.TxtB_DescTot.Location = New System.Drawing.Point(565, 41)
        Me.TxtB_DescTot.Name = "TxtB_DescTot"
        Me.TxtB_DescTot.Size = New System.Drawing.Size(158, 34)
        Me.TxtB_DescTot.TabIndex = 6
        '
        'TxtB_CantDesc
        '
        Me.TxtB_CantDesc.Enabled = False
        Me.TxtB_CantDesc.Location = New System.Drawing.Point(220, 91)
        Me.TxtB_CantDesc.Name = "TxtB_CantDesc"
        Me.TxtB_CantDesc.Size = New System.Drawing.Size(146, 34)
        Me.TxtB_CantDesc.TabIndex = 5
        '
        'TxtB_PagoPar
        '
        Me.TxtB_PagoPar.Enabled = False
        Me.TxtB_PagoPar.Location = New System.Drawing.Point(140, 35)
        Me.TxtB_PagoPar.Name = "TxtB_PagoPar"
        Me.TxtB_PagoPar.Size = New System.Drawing.Size(226, 34)
        Me.TxtB_PagoPar.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(406, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PAGO FINAL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cantidad Descontada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(406, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descuento Total"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pago Parcial"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 275)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtB_PagoPar As TextBox
    Friend WithEvents TxtB_Final As TextBox
    Friend WithEvents TxtB_DescTot As TextBox
    Friend WithEvents TxtB_CantDesc As TextBox
    Friend WithEvents Btn_Rslt As Button
    Friend WithEvents Button1 As Button
End Class
