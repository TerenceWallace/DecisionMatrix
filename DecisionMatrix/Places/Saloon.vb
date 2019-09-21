

Imports DecisionTree.Entities

Namespace DecisionTree.Places

	''' <summary>
	''' This class represents a Place <see cref="Place"/> that exists to satisfy very distinctive and unique need(s).
	''' </summary>
	Public Class Saloon
		Inherits Place

		Public Overrides Property Name As String = "Saloon"

		Public Overrides Property Type As PlaceType = PlaceType.Saloon

		Public Sub New()
			Features = New Feature With {.Name = Name, .Safety = 0, .Social = 79,
				.Esteem = 15, .Physical = 12, .Growth = 5}

		End Sub

	End Class
End Namespace