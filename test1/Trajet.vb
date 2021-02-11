''' <summary>
''' un trajet est constitué d'un départ et d'une arrivée
''' il contient également la distance entre les deux
''' </summary>
Public Class Trajet
    Private _départ As String
    Private _arrivée As String
    Private _distance As Distance

    Sub New(départ As String, arrivée As String, distance As Integer)
        _départ = départ
        _arrivée = arrivée
        _distance = New Distance(distance)
    End Sub



    Public Sub Saisir()
        _départ = InputBox(My.Resources.Départ, "départ")
        _arrivée = InputBox(My.Resources.Arrivée, "arrivée")
    End Sub

    Public Overrides Function ToString() As String
        Return _départ & " => " & _arrivée & " " & _distance.ToString()
    End Function
End Class
