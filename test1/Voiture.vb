''' <summary>
''' classe voiture
''' </summary>
Public Class Voiture
    Inherits Véhicule

    Private _roues As String = "4 x 195/55R16"

    Public Overrides Function ToString() As String
        Return _roues & MyBase.ToString()
    End Function

    Public Property lesRoues As String
        Get
            Return _roues
        End Get
        Set(value As String)
            _roues = value
        End Set
    End Property
End Class
