﻿Imports MySql.Data.MySqlClient
Imports System.IO
Module dbconnection

    Public conn As New MySqlConnection
    Dim result As Boolean
    Public i As Integer

    Public Function dbconn() As Boolean
        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "server=localhost;user=root;password=;database=dbpool"
                result = True
            End If
        Catch ex As Exception
            result = False
            MsgBox("Server Not Connected !", vbExclamation)
        End Try
        Return result
    End Function

End Module
