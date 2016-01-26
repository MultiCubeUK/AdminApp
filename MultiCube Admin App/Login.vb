'********************************************************
'*  Class: Login.vb                                     *
'*  Author: Beiron John                                 *
'*  Date:   25/01/16                                    *
'*                                                      *
'*  Change Control:                                     *
'*  Date    |   By          |   Description             *
'*  ----------------------------------------------------*
'*                                                      *
'*  Todo:                                               *
'*   + login script                                     *
'*   + password encryption                              *
'*                                                      *
'********************************************************

'   Imports

'   Class
Public Class Login
    ' Variables


    Dim SQLConnection As New connection()
    ' Methods
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Common.setupForm(Me, "Login")
        GroupBox1.Enabled = False
        displayTextBoxHeader()
        establishDatabseConnection()
        If connectionEstablished Then
            GroupBox1.Enabled = True
        End If
    End Sub

    Private Sub displayTextBoxHeader()
        Dim statusHeader As String
        statusHeader = "MULTICUBE UK - ADMIN APP" & vbCrLf
        statusHeader &= "========================" & vbCrLf & vbCrLf

        statusTB.Text = statusHeader
    End Sub

    Private Sub establishDatabseConnection()

        statusTB.Text &= "Attempting to connect to database..." & vbCrLf
        ' statusTB.Text &= "<<DEBUG>>Connection String = " & SQLConnection.getConnectionString() & vbCrLf
        statusTB.Text &= "Connection to database established..." & vbTab
        connectionEstablished = SQLConnection.openConn()
        If connectionEstablished = True Then
            statusTB.Text &= "Sucessful" & vbCrLf
        Else
            statusTB.Text &= "Failed" & vbCrLf
            statusTB.Text &= "Error:" & vbCrLf
            statusTB.Text &= sqlConnectionError
        End If

    End Sub

    Private Sub CloseBTN_Click(sender As Object, e As EventArgs) Handles CloseBTN.Click
        Application.Exit()
    End Sub

    Private Sub LoginBTN_Click(sender As Object, e As EventArgs) Handles LoginBTN.Click
        ' If usernameTB.Text = "" And PassTB.Text = "" Then
        'Dim test As String = SQLConnection.testConnection()
        'statusTB.Text &= "Test statement returns - " & test & vbCrLf
        'End If
    End Sub
End Class
