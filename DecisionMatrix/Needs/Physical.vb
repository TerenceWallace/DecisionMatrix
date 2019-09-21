
Imports DecisionTree.Framework
Imports DecisionTree.Entities

Namespace DecisionTree.Needs

	''' <summary>
	''' These are biological requirements for human survival, e.g. air, food, drink, shelter, clothing, warmth, sex, sleep.
	''' Maslow considered physiological needs the most important.
	''' As all the other needs become secondary until these needs are met.
	''' </summary>
	Friend NotInheritable Class Physical
		Inherits NeedQuery

		Private Shared rnd As New DotNetRandom

		Friend Sub New()
			Title = "Physical"
			Test = AddressOf GetResult

			Positive = New NeedResult With {.Result = PositiveValue()}
			Negative = New NeedResult With {.Result = NegativeValue()}

		End Sub

		Private Function GetResult(ByVal e As Character) As Boolean
			Return (e.Thirst <= 2 OrElse e.Thirst >= 8 Or e.Fatigue)
		End Function

		Private Function PositiveValue() As Double
			Return rnd.Next(20, 25)
		End Function

		Private Function NegativeValue() As Double
			Return rnd.Next(0.1, 2)
		End Function
	End Class

End Namespace
