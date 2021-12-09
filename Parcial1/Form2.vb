Imports System.Math
Public Class Form2
    Public total = Form1.contador
    Public descuento As Double
    Public cantidad_descontada1 As Double = ((Form1.contador * 10) / 100)
    Public cantidad_final = total - cantidad_descontada1
    '  -----
    Public cantidad_descontada2 As Double = ((Form1.contador * 6) / 100)
    Public cantidad_final2 = total - cantidad_descontada2

    Private Sub Btn_Rslt_Click(sender As Object, e As EventArgs) Handles Btn_Rslt.Click
        TxtB_PagoPar.Text = Str(Round(total, 2))

        If (Form1.ChBox_DCW.Checked And Form1.RB_LavMotor.Checked And Form1.RB_TapFull.Checked) Then
            descuento = descuento + 10
            'Etiqueta de descuento
            TxtB_DescTot.Text = Str(Round(descuento, 2)) + "%"
            TxtB_CantDesc.Text = Str(Round(cantidad_descontada1, 2))
            TxtB_Final.Text = Str(Round(cantidad_final, 2))

        ElseIf (Form1.ChBox_DCW.Checked And Form1.RB_LavMotor.Checked) Then
            descuento = descuento + 6
            'Etiqueta de descuento
            TxtB_DescTot.Text = Str(Round(descuento, 2)) + "%"
            TxtB_CantDesc.Text = Str(Round(cantidad_descontada2, 2))
            TxtB_Final.Text = Str(Round(cantidad_final2, 2))

        Else
            TxtB_DescTot.Text = "0%"
            TxtB_CantDesc.Text = "0"
            TxtB_Final.Text = total

        End If














    End Sub
End Class