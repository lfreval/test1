Public Class Distance
    Private _d As Integer
    Private _unité As String = "km"

    Sub New(valeur As Integer)
        _d = valeur
        Decompte.Instance.Plus()
    End Sub

    Protected Overrides Sub Finalize()
        Decompte.Instance.Moins()
    End Sub


    Public Overrides Function ToString() As String
        Return "(" & _d & " " & _unité & ")"
    End Function

    Public Shared Operator &(c1 As String, d1 As Distance) As String
        Return c1 & d1.ToString()
    End Operator

    Public Shared Operator &(d1 As Distance, c1 As String) As String
        Return d1.ToString() & c1
    End Operator
End Class
