Option Strict On
Option Explicit On
Imports System.Data.SQLite

''' <summary>
''' le programme principal
''' </summary>
Module Module1

    Sub Main()
        ' démarrage du logger
        Logs.Instance()

        For Each argument As String In My.Application.CommandLineArgs
            If argument = "--help" Or argument = "-h" Or argument = "/?" Then
                Aide()
                Environment.Exit(0)
            End If
        Next

        Dim clio As New Voiture()

        Dim dep As String = "Nantes" ' Saisir(My.Resources.Départ, "String").ToString()
        Dim arr As String = "Lille" ' Saisir(My.Resources.Arrivée, "String").ToString()
        Dim dist As Integer = 986 ' CInt(Saisir("distance ?", "Integer"))

        Dim monTrajet As New Trajet(dep, arr, dist)
        Console.WriteLine(monTrajet)

        Dim t2 As New Trajet("Nantes", "Paris", 400)

        GetData()
        Console.ReadKey()

        Logs.Instance()
    End Sub

    Sub GetData()
        Dim database As String = "trajets.db"
        Dim SQLstr As String = "SELECT * FROM trajet WHERE 1"
        Dim connection As String = "Data Source=" & database & ";Version=3"
        Dim SQLConn As New SQLiteConnection
        Dim SQLcmd As New SQLiteCommand
        Dim SQLdr As SQLiteDataReader
        SQLConn.ConnectionString = connection 
        SQLConn.Open() 
        SQLcmd.Connection = SQLConn
        SQLcmd.CommandText = SQLstr
        SQLdr = SQLcmd.ExecuteReader()
        While SQLdr.Read()
            Dim t1 As New Trajet(SQLdr("depart").ToString, SQLdr("arrivee").ToString, CInt(SQLdr("distance").ToString))
            Console.WriteLine(t1)
        End While 
        SQLdr.Close()
        SQLConn.Close()
    End Sub
End Module
