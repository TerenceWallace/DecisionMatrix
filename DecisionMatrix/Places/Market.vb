

Imports DecisionTree.Entities

Namespace DecisionTree.Places

	''' <summary>
	''' This class represents a Place <see cref="Place"/> that exists to satisfy very distinctive and unique need(s).
	''' </summary>
	Public Class Market
		Inherits Place

		Public Overrides Property Name As String = "Market"

		Public Overrides Property Type As PlaceType = PlaceType.Market

		Public Sub New()
			Features = New Feature With {.Name = Name, .Safety = 1, .Social = 80,
				.Esteem = 15, .Physical = 0, .Growth = 8}

		End Sub

	End Class
End Namespace