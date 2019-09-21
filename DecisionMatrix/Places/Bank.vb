

Imports DecisionTree.Entities

Namespace DecisionTree.Places

	''' <summary>
	''' This class represents a Place <see cref="Place"/> that exists to satisfy distinctive and unique need(s).
	''' </summary>
	Public Class Bank
		Inherits Place

		Public Overrides Property Name As String = "Bank"

		Public Overrides Property Type As PlaceType = PlaceType.Bank

		Public Sub New()
			Features = New Feature With {.Name = Name, .Safety = 61, .Social = 1,
				.Esteem = 100, .Physical = 0, .Growth = 25}

		End Sub

	End Class
End Namespace