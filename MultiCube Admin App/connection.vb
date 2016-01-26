'********************************************************
'*  Class: connection.vb                                *
'*  Author: Beiron John                                 *
'*  Date:   26/01/16                                    *
'*                                                      *
'*  Change Control:                                     *
'*  Date    |   By          |   Description             *
'*  ----------------------------------------------------*
'*                                                      *
'*                                                      *
'********************************************************

'Imports
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

'-------------------------------
Public Class connection
    'Declarations
    Dim connectionString = getConnectionString()
    Dim MySqlConnection As New MySqlConnection(connectionString)
    Dim MySqlCommand = MySqlConnection.CreateCommand()
    Dim MySqlReader As MySqlDataReader


    '----------------
    ' Functions
    Public Function getConnectionString()
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("c:\temp\adminapp.txt")
        Dim Connsetting As String = fileReader.ReadLine()
        Return Connsetting
    End Function

    Public Function openConn()
        Try
            If connectionEstablished = False Then
                MySqlConnection.Open()
                connectionEstablished = True
            End If
        Catch ex As Exception
            connectionEstablished = False
            sqlConnectionError = ex.Message.ToString
        End Try
        Return connectionEstablished
    End Function

    Public Function isConnOpen()
        Return connectionEstablished
    End Function

    Public Function testConnection()
        Dim retval As String = ""
        openConn()
        If connectionEstablished = True Then
            Dim lCmd As New MySqlCommand
            With lCmd
                .CommandText = "SELECT * FROM users"
                .Connection = MySqlConnection
                .CommandType = CommandType.Text
                Dim lDR As MySqlDataReader = .ExecuteReader
                Dim rowcount As Integer = 0
                While lDR.Read
                    retval = lDR.Item("ID")
                    rowcount = rowcount + 1
                End While
                lDR.Close()
            End With
        End If
        Return retval
    End Function

End Class


