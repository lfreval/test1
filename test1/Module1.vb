Option Strict On
Option Explicit On

''' <summary>
''' le programme principal
''' </summary>

Module Module1

    Sub Main()
        For Each argument As String In My.Application.CommandLineArgs
            If argument = "--help" Or argument = "-h" Or argument = "/?" Then
                Aide()
                Environment.Exit(0)
            End If
        Next

        Dim dep As String = Saisir(My.Resources.Départ, "String").ToString()
        Dim arr As String = Saisir(My.Resources.Arrivée, "String").ToString()
        Dim dist As Integer = CInt(Saisir("distance ?", "Integer"))

        Dim monTrajet As New Trajet(dep, arr, dist)
        Console.WriteLine(monTrajet)

        Console.ReadKey()
    End Sub


End Module
