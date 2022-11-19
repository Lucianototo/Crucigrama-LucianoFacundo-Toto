Public Class Form1
    Dim auto As String = "AUTO"
    Dim tren As String = "TREN"
    Dim avion As String = "AVION"
    Dim barco As String = "BARCO"
    Dim acertoAuto, acertoTren, acertoAvion, acertoBarco As Boolean


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If auto = TextBox1.Text + TextBox9.Text + TextBox10.Text + TextBox11.Text Then
            CheckBox1.Checked = True
            TextBox1.Enabled = False
            TextBox9.Enabled = False
            TextBox10.Enabled = False
            TextBox11.Enabled = False
            acertoAuto = True
        Else
            CheckBox1.Checked = False
        End If

        If tren = TextBox6.Text + TextBox7.Text + TextBox8.Text + TextBox5.Text Then
            CheckBox2.Checked = True
            TextBox6.Enabled = False
            TextBox7.Enabled = False
            TextBox8.Enabled = False
            TextBox5.Enabled = False
            acertoTren = True
        Else
            CheckBox2.Checked = False
        End If
        If avion = TextBox1.Text + TextBox2.Text + TextBox3.Text + TextBox4.Text + TextBox5.Text Then
            CheckBox3.Checked = True
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False
            acertoAvion = True
        Else
            CheckBox3.Checked = False
        End If
        If barco = TextBox15.Text + TextBox14.Text + TextBox13.Text + TextBox12.Text + TextBox11.Text Then
            CheckBox4.Checked = True
            TextBox15.Enabled = False
            TextBox14.Enabled = False
            TextBox13.Enabled = False
            TextBox12.Enabled = False
            TextBox11.Enabled = False
            acertoBarco = True
        Else
            CheckBox4.Checked = False
        End If

        If acertoAuto And acertoTren And acertoAvion And acertoBarco Then
            MsgBox("Ganaste!", MsgBoxStyle.OkOnly, "Bien hecho!")
            Me.Close()
        End If
    End Sub
End Class
