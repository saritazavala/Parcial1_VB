'Universidad de San Carlos de Guatemala
'Escuela de Vacaciones Diciembre 2021
'TAREA PARCIAL 1 - Programación de Computadoras 2
'Miguel Bedoya

Public Class Form1
    'Dim nombre_variable as tipo_variable.
    Public contador As Double

    Private Sub ChBox_ServBasc_CheckedChanged(sender As Object, e As EventArgs) Handles ChBox_ServBasc.CheckedChanged
        If (ChBox_ServBasc.Checked
            ) Then
            ServBasic.Enabled = True
            ServBasic.Focus()
        Else
            ServBasic.Enabled = False
        End If
    End Sub

    Private Sub ChBox_ServEsp_CheckedChanged(sender As Object, e As EventArgs) Handles ChBox_ServEsp.CheckedChanged
        If (ChBox_ServEsp.Checked
            ) Then
            ServEsp.Enabled = True
            ServEsp.Focus()
        Else
            ServEsp.Enabled = False
        End If
    End Sub

    Private Sub ChBox_DCW_CheckedChanged(sender As Object, e As EventArgs) Handles ChBox_DCW.CheckedChanged
        If (ChBox_DCW.Checked) Then
            contador += 100
        Else
            contador = contador - 100
        End If
        'Debug.Print(contador)
    End Sub

    Private Sub RB_LavExt_CheckedChanged(sender As Object, e As EventArgs) Handles RB_LavExt.CheckedChanged
        If (RB_LavExt.Checked
            ) Then
            contador = contador + 110.5
        Else
            contador = contador - 110.5
        End If
        'Debug.Print(contador)
    End Sub

    Private Sub RB_LavCompl_CheckedChanged(sender As Object, e As EventArgs) Handles RB_LavCompl.CheckedChanged
        If (RB_LavCompl.Checked) Then
            contador = contador + 185.5
        Else
            contador = contador - 185.5
        End If
        'Debug.Print(contador)
    End Sub

    Private Sub RB_LavBasic_CheckedChanged(sender As Object, e As EventArgs) Handles RB_LavBasic.CheckedChanged
        If (RB_LavBasic.Checked) Then
            contador = contador + 125.5
        Else
            contador = contador - 125.5
        End If
        'Debug.Print(contador)
    End Sub

    Private Sub RB_LavMotor_CheckedChanged(sender As Object, e As EventArgs) Handles RB_LavMotor.CheckedChanged
        If (RB_LavMotor.Checked) Then
            contador = contador + 165.5
        Else
            contador = contador - 165.5
        End If
        ' Debug.Print(contador)
    End Sub

    Private Sub RB_Pulido_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Pulido.CheckedChanged
        If (ServEsp.Enabled) Then
            If (RB_Pulido.Checked) Then
                contador = contador + 90
            Else
                contador = contador - 90
            End If
            ' Debug.Print(contador)

        End If
    End Sub

    Private Sub RB_Encerado_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Encerado.CheckedChanged
        If (ServEsp.Enabled) Then
            If (RB_Encerado.Checked) Then
                contador = contador + 90
            Else
                contador = contador - 90
            End If
            ' Debug.Print(contador)
        End If
    End Sub

    Private Sub RB_Exterior_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Exterior.CheckedChanged
        If (ServEsp.Enabled) Then
            If (RB_Exterior.Checked) Then
                contador = contador + 90
            Else
                contador = contador - 90
            End If
            'Debug.Print(contador)
        End If
    End Sub

    Private Sub RB_TapFull_CheckedChanged(sender As Object, e As EventArgs) Handles RB_TapFull.CheckedChanged
        If (ServEsp.Enabled) Then
            If (RB_TapFull.Checked) Then
                contador = contador + 105
            Else
                contador = contador - 105
            End If
            ' Debug.Print(contador)
        End If

    End Sub

    Private Sub RB_LavLlanta_CheckedChanged(sender As Object, e As EventArgs) Handles RB_LavLlanta.CheckedChanged
        If (ServEsp.Enabled) Then
            If (RB_LavLlanta.Checked) Then
                contador = contador + 135
            Else
                contador = contador - 135
            End If
            ' Debug.Print(contador)
        End If
    End Sub

    Private Sub RB_TapBasic_CheckedChanged(sender As Object, e As EventArgs) Handles RB_TapBasic.CheckedChanged
        If (ServEsp.Enabled) Then
            If (RB_TapBasic.Checked) Then
                contador = contador + 85
            Else
                contador = contador - 85
            End If
            ' Debug.Print(contador)
        End If
    End Sub

    Private Sub RD_LimpChz_CheckedChanged(sender As Object, e As EventArgs) Handles RD_LimpChz.CheckedChanged
        If (RD_LimpChz.Checked) Then
            contador = contador + 95.5
        Else
            contador = contador - 95.5
        End If
        'Debug.Print(contador)
    End Sub

    Private Sub Btn_Calcular_Click(sender As Object, e As EventArgs) Handles Btn_Calcular.Click
        If (TextBox1.Text = "" Or TextBox2.Text = "") Then
            MsgBox("No se han completado los datos del cliente")
            TextBox1.Focus()
            Exit Sub
        End If

        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Btn_Limpiar_Click(sender As Object, e As EventArgs) Handles Btn_Limpiar.Click
        'Limpieza de CheckBox
        ChBox_DCW.Checked = False
        ChBox_ServBasc.Checked = False
        ChBox_ServEsp.Checked = False

        'Limpieza de RadioButtons

        ''' Servicios Especiales
        RB_Pulido.Checked = False
        RB_Encerado.Checked = False
        RB_Exterior.Checked = False
        RB_TapBasic.Checked = False
        RB_TapFull.Checked = False
        RB_LavLlanta.Checked = False

        ''' Servicios Basicos
        RB_LavExt.Checked = False
        RB_LavBasic.Checked = False
        RB_LavCompl.Checked = False
        RB_LavMotor.Checked = False
        RD_LimpChz.Checked = False

        ' CONTADOR A CERO
        contador = 0

    End Sub

    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "salir") = vbYes Then
            'Me.Close()
            End
        End If


    End Sub
End Class