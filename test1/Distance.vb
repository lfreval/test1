Public Class Distance
    Private _d As Integer
    Private _unité As String = "km"

    Sub New(valeur As Integer)
        _d = valeur
    End Sub

    Public Overrides Function ToString() As String
        Return "(" & _d & " " & _unité & ")"
    End Function
End Class
