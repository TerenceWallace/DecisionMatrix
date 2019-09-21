
Namespace DecisionTree.Entities

	''' <summary>
	''' This class is a noun that represents a particular portion of definite space with defined boundaries.
	''' </summary>
	Public MustInherit Class Place

		Public MustOverride Property Name As String

		Public MustOverride Property Type As PlaceType

		Public Property Features As Feature

	End Class
End Namespace