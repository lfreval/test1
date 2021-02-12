Option Strict On
Option Explicit On

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

        Console.ReadKey()

        Logs.Instance()
    End Sub


End Module
