'********************************************************
'*  Class: Login.vb                                     *
'*  Author: Beiron John                                 *
'*  Date:   25/01/16                                    *
'*                                                      *
'*  Change Control:                                     *
'*  Date    |   By          |   Description             *
'*  ----------------------------------------------------*
'*                                                      *
'*                                                      *
'*                                                      *
'*                                                      *
'********************************************************

'   Imports

'   Class
Public Module Common
    ' Variables
    '===========
    'SQL
    '---
    Public connectionEstablished As Boolean = False
    Public sqlConnectionError As String

    ' Methods
    '=========
    Public Sub setupForm(ByRef frm As Form, ByVal formTitle As String)
        'set background
        frm.BackgroundImage = Global.MultiCube_Admin_App.My.Resources.Resources.bg2016
        'set title
        frm.Text = "MCUK - Admin App - " & formTitle
        If formTitle = "Login" Then
            'remove the title bar
            frm.ControlBox = False

        End If
    End Sub
End Module
