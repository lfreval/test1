Option Strict On
Option Explicit On

''' <summary>
''' le programme principal
''' </summary>

Module Module1

    Sub Main()
        Dim maClio As New Voiture()
        ' maClio.lesRoues = "3 x 165/77R12"
        Console.WriteLine(maClio)

        Dim monTrajet As New Trajet()

        Console.ReadKey()
    End Sub

End Module
