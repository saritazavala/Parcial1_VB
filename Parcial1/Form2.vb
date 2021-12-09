'Universidad de San Carlos de Guatemala
'Escuela de Vacaciones Diciembre 2021
'TAREA PARCIAL 1 - Programación de Computadoras 2
'Miguel Bedoya

Imports System.Math
Public Class Form2


    Private Sub Btn_Rslt_Click(sender As Object, e As EventArgs) Handles Btn_Rslt.Click
        Dim total = Form1.contador
        Dim descuento As Double
        Dim cantidad_descontada1 As Double = ((Form1.contador * 10) / 100)
        Dim cantidad_final = total - cantidad_descontada1
        '  -----
        Dim cantidad_descontada2 As Double = ((Form1.contador * 6) / 100)
        Dim cantidad_final2 = total - cantidad_descontada2
        Debug.Print(total)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class