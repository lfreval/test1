''' <summary>
''' un trajet est constitué d'un départ et d'une arrivée
''' il contient également la distance entre les deux
''' </summary>
Public Class Trajet
    Private _départ As String
    Private _arrivée As String
    Private _distance As Distance

    Public Sub Saisir()
        _départ = InputBox(My.Resources.Départ, "départ")
        _arrivée = InputBox(My.Resources.Arrivée, "arrivée")
    End Sub
End Class
