Imports System.Net

Public Class Frm1

    Dim strAPIKey As String
    Dim strEMail As String
    Dim url As String "https://api.cloudflare.com/client/v4/"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles buttSaveLogin.Click
        strAPIKey = txtAPIKey.Text
        strEMail = txtEmail.Text
    End Sub

    Private Sub buttFetch_Click(sender As Object, e As EventArgs) Handles buttFetch.Click
        Dim request As HttpWebRequest = HttpWebRequest.Create(url + "/zones")
        request.ContentType = "application/json"
        request.Headers.Add("X-Auth-Email:" + strEMail,)

    End Sub
End Class
