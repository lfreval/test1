''' <summary>
''' un trajet est constitué d'un départ et d'une arrivée
''' il contient également la distance entre les deux
''' </summary>
Public Class Trajet
    Private _départ As String
    Private _arrivée As String
    Private _distance As Distance

    ''' <summary>
    ''' constructeur d'un trajet
    ''' </summary>
    ''' <param name="départ">la ville de départ</param>
    ''' <param name="arrivée">la ville d'arrivée</param>
    ''' <param name="distance">la distance entre les deux villes</param>
    Sub New(départ As String, arrivée As String, distance As Integer)
        _départ = départ
        _arrivée = arrivée
        _distance = New Distance(distance)
        Decompte.Instance.Plus()
    End Sub

    Protected Overrides Sub Finalize()
        Decompte.Instance.Moins()
    End Sub

    Public Sub Saisir()
        _départ = InputBox(My.Resources.Départ, "départ")
        _arrivée = InputBox(My.Resources.Arrivée, "arrivée")
    End Sub

    Public Overrides Function ToString() As String
        Return _départ & " => " & _arrivée & " " & _distance & "."
    End Function
End Class
