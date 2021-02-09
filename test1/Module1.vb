Option Strict On
Option Explicit On

Module Module1

    Sub Main()
        ' Console.WriteLine("Hello World" + "(from Visual Basic Net)" + " sdfksdfsmdlfksmldfksmldfsmldkfjlsdkfjlsdkjf")
        ' MsgBox("VB est partout")

        Dim maClio As New Voiture()
        Console.WriteLine(maClio.lesRoues)
        Console.ReadKey()
    End Sub

End Module
