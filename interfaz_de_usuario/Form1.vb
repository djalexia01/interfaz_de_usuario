Imports Twilio
Imports Twilio.Rest.Api.V2010.Account
Imports Twilio.Types
Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class Form1
    Private conexion As SqlConnection
    Private ds As DataSet
    Private da As SqlDataAdapter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resultado As Integer
        da.InsertCommand.Parameters("@usuario").Value = Me.text1.Text
        da.InsertCommand.Parameters("@contraseña").Value = Me.text2.Text
        conexion.Open()
        resultado = da.InsertCommand.ExecuteNonQuery
        conexion.Close()
        MessageBox.Show("registrando enviando mensaje:" & resultado)

        TwilioClient.Init(sid.Text, token.Text)
        Dim Tel = New PhoneNumber(phone.Text)
        Dim mensaje = MessageResource.Create(
            Tel, from:=New PhoneNumber(from.Text),
            body:="El codigo es: 34123")
        verificacion.Show()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection
        conexion.ConnectionString = "Server=localhost\SQLEXPRESS;database=LOGIN;integrated security=true;"
        da = New SqlDataAdapter
        Dim cm As New SqlCommand(" insert into REGISTRO(usuario,contraseña) values (@usuario,@contraseña)", conexion)
        da.InsertCommand = cm
        da.InsertCommand.Parameters.Add(New SqlParameter("@usuario", SqlDbType.VarChar))
        da.InsertCommand.Parameters.Add(New SqlParameter("@contraseña", SqlDbType.Int))
        Dim consulta As New SqlCommand("Select * from REGISTRO", conexion)
        da.SelectCommand = consulta
        ds = New DataSet()
        Me.Datos()

    End Sub
    Private Sub Datos()
        ds.Clear()
        conexion.Open()
        da.Fill(ds, "REGISTRO")
        conexion.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        INGRESO.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            text2.UseSystemPasswordChar = False
        Else
            text2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        text1.Clear()
        text2.Clear()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class