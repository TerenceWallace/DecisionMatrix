
Namespace DecisionTree.Entities

	''' <summary>
	''' A Feature represents distinctive attributes or aspects of a <see cref="Place"/> Place.
	''' </summary>
	Public Class Feature

		Public Property Name As String = "BaseFeature"
		Public Property Physical As Double = 0.2
		Public Property Esteem As Double = 0.2
		Public Property Safety As Double = 0.2
		Public Property Growth As Double = 0.2
		Public Property Social As Double = 0.2

		Public Type As FeatureTypes = FeatureTypes.None

		Public Property Value As Double = 1
	End Class
End Namespace