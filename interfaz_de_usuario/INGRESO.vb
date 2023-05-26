Imports System.Data.SqlClient
Public Class INGRESO

    Dim conexion As New SqlConnection
    Dim comando As New SqlCommand
    Private Sub INGRESO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection("Server=localhost\SQLEXPRESS;database=LOGIN; integrated security=true")


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conexion.Open()

        Dim consulta As String = "select * from REGISTRO where usuario= '" & TextBox1.Text & "' and contraseña= '" & TextBox2.Text & "'"
        comando = New SqlCommand(consulta, conexion)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        If lector.HasRows Then
            BIENVENIDA.ShowDialog()
        Else
            MessageBox.Show("Este Usuario no Existe Datos incorrectos")
        End If
        conexion.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
    End Sub
End Class