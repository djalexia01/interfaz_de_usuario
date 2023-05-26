Imports System.Windows

Public Class verificacion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "34123" Then
            TextBox1.Text = ""
            MsgBox("el codigo de verificacion es correcto")
            TextBox1.Text = ""





        Else
            MsgBox("el codigo de verificacion es incorrecto")
            TextBox1.Text = ""


        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Visible = False

    End Sub

    Private Sub regresar_Click(sender As Object, e As EventArgs) Handles regresar.Click
        Form1.Show()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox1.Clear()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox1.UseSystemPasswordChar = False
        Else
            TextBox1.UseSystemPasswordChar = True
        End If
    End Sub
End Class