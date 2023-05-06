Imports Twilio
Imports Twilio.Rest.Api.V2010.Account
Imports Twilio.Types

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TwilioClient.Init(sid.Text, token.Text)
        Dim Tel = New PhoneNumber(phone.Text)
        Dim mensaje = MessageResource.Create(
            Tel, from:=New PhoneNumber(from.Text),
            body:="El codigo es: 34123")

        verificacion.Show()

    End Sub
End Class
