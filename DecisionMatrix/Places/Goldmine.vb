

Imports DecisionTree.Entities

Namespace DecisionTree.Places

	''' <summary>
	''' This class represents a Place <see cref="Place"/> that exists to satisfy distinctive and unique need(s).
	''' </summary>
	Public Class Goldmine
		Inherits Place

		Public Overrides Property Name As String = "Goldmine"

		Public Overrides Property Type As PlaceType = PlaceType.Goldmine

		Public Sub New()
			Features = New Feature With {.Name = Name, .Safety = 100, .Social = 11,
				.Esteem = 70, .Physical = 0, .Growth = 9}

		End Sub

	End Class
End Namespace