Imports System.Math
Public Class Form2
    Private Sub Btn_Rslt_Click(sender As Object, e As EventArgs) Handles Btn_Rslt.Click
        TxtB_PagoPar.Text = Str(Round(Form1.contador, 2))

        If (Form1.ChBox_DCW.Checked And Form1.RB_LavMotor.Checked And Form1.RB_TapFull.Checked) Then
            Debug.Print("Segundo descuento aplica")

        ElseIf (Form1.ChBox_DCW.Checked And Form1.RB_LavMotor.Checked) Then
            Debug.Print("primero descuento aplica")
        End If





    End Sub
End Class