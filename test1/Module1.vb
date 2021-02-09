Option Strict On
Option Explicit On

''' <summary>
''' le programme principal
''' </summary>

Module Module1
    Sub Aide()
        Console.WriteLine("voici l'aide :)")
    End Sub

    Sub Main()
        For Each argument As String In My.Application.CommandLineArgs
            If argument = "--help" Or argument = "-h" Or argument = "/?" Then
                Aide()
                Environment.Exit(0)
            End If
        Next

        Dim monTrajet As New Trajet(InputBox(My.Resources.Départ, "départ"), InputBox(My.Resources.Arrivée, "arrivée"), InputBox("distance ?", "km"))


        Console.ReadKey()
    End Sub

End Module
