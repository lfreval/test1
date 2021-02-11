Module Outils
    Sub Aide()
        Console.WriteLine("voici l'aide :)")
    End Sub

    Function Saisir(nom As String, type As String) As Object
        Dim valeur As String = InputBox("saisie" & nom & " : ")
        If type.Equals("String") Then
            Return valeur
        ElseIf type.Equals("Integer") And IsNumeric(valeur) Then
            Return CInt(valeur)
        Else
            Return Nothing
        End If
    End Function
End Module
