Imports System.IO.File
Public Class Logs
    Private Shared _fichier As String = "trace.txt"
    Private Shared _instance As Logs = Nothing

    Public Shared Function Instance() As Logs
        If IsNothing(_instance) Then
            _instance = New Logs()
            WriteAllText(_fichier, My.Computer.Clock.LocalTime.ToString & " > Première instance")
        End If
        Return _instance
    End Function

    Public Sub Trace(message As String)
        AppendAllText(_fichier, My.Computer.Clock.LocalTime.ToString & " > " & message & Environment.NewLine)
    End Sub

End Class
