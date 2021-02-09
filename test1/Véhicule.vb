''' <summary>
''' classe véhicule
''' </summary>
Public Class Véhicule
    Private _moteur As String = "V12"
    Private _châssis As String = "GT"
    Private _carrosserie As String = "Rouge"

    Public Overrides Function ToString() As String
        Return "> " & _châssis & " : " & _carrosserie
    End Function
End Class
