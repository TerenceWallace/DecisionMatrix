
Imports DecisionTree.Framework
Imports DecisionTree.Entities

Namespace DecisionTree.Needs

	''' <summary>
	''' This class represents the third level of human needs.
	''' Social involves feelings of belongingness. 
	''' The need for interpersonal relationships that motivates behavior
	''' </summary>
	Friend NotInheritable Class Social
		Inherits NeedQuery

		Private Shared rnd As New DotNetRandom

		Friend Sub New()
			Title = "Social"
			Test = AddressOf GetResult

			Positive = New NeedResult With {.Result = PositiveValue()}
			Negative = New NeedResult With {.Result = NegativeValue()}

		End Sub

		Private Function GetResult(ByVal e As Character) As Boolean
			Return e.Cash >= 5 And (Not e.Fatigue And e.Vicinity = PlaceType.Nightclub) Or (Not e.Fatigue And e.Vicinity = PlaceType.Saloon)
		End Function

		Private Function PositiveValue() As Double
			Return rnd.Next(8, 15)
		End Function

		Private Function NegativeValue() As Double
			Return rnd.Next(0.1, 2)
		End Function
	End Class

End Namespace
