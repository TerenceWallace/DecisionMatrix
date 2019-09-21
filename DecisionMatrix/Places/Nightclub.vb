

Imports DecisionTree.Entities

Namespace DecisionTree.Places

	''' <summary>
	''' This class represents a Place <see cref="Place"/> that exists to satisfy very distinctive and unique need(s).
	''' </summary>
	Public Class Nightclub
		Inherits Place

		Public Overrides Property Name As String = "Nightclub"

		Public Overrides Property Type As PlaceType = PlaceType.Nightclub

		Public Sub New()
			Features = New Feature With {.Name = Name, .Safety = 0, .Social = 100,
				.Esteem = 3, .Physical = 0, .Growth = 0}

		End Sub

	End Class
End Namespace