

Imports DecisionTree.Entities

Namespace DecisionTree.Places

	''' <summary>
	''' This class represents a Place <see cref="Place"/> that exists to satisfy very distinctive and unique need(s).
	''' </summary>
	Public Class Home
		Inherits Place

		Public Overrides Property Name As String = "Home"

		Public Overrides Property Type As PlaceType = PlaceType.Home

		Public Sub New()
			Features = New Feature With {.Name = Name, .Safety = 7, .Social = 1,
				.Esteem = 43, .Physical = 100, .Growth = 25}

		End Sub

	End Class
End Namespace