

Imports DecisionTree.Entities

Namespace DecisionTree.Places

	''' <summary>
	''' This class represents a Place <see cref="Place"/> that exists to satisfy very distinctive and unique need(s).
	''' </summary>
	Public Class School
		Inherits Place

		Public Overrides Property Name As String = "School"

		Public Overrides Property Type As PlaceType = PlaceType.School

		Public Sub New()
			Features = New Feature With {.Name = Name, .Safety = 9, .Social = 35,
				.Esteem = 78, .Physical = 0, .Growth = 100}

		End Sub

	End Class
End Namespace