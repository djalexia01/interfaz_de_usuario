Imports System.Windows

Public Class verificacion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "34123" Then
            TextBox1.Text = ""





        Else
            MsgBox("el codigo de verificacion es incorrecto")
            TextBox1.Text = ""


        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Visible = Visible

    End Sub

End Class