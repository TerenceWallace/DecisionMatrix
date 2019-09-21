

Imports DecisionTree.Entities

Namespace DecisionTree.Places

	''' <summary>
	''' This class represents a Place <see cref="Place"/> that exists to satisfy distinctive and unique need(s).
	''' </summary>
	Public Class Food
		Inherits Place

		Public Overrides Property Name As String = "Food"

		Public Overrides Property Type As PlaceType = PlaceType.Food

		Public Sub New()
			Features = New Feature With {.Name = Name, .Safety = 5, .Social = 1,
				.Esteem = 0, .Physical = 100, .Growth = 15.5}

		End Sub

	End Class
End Namespace