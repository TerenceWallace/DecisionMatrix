
Imports DecisionTree.Framework
Imports DecisionTree.Entities

Namespace DecisionTree.Needs

	''' <summary>
	''' The class represents what Maslow classified into two categories: 
	''' (i) esteem for oneself (dignity, achievement, mastery, independence) 
	''' and (ii) the desire for reputation or respect from others (e.g., status, prestige). 
	''' </summary>
	Friend NotInheritable Class Esteem
		Inherits NeedQuery

		Private Shared rnd As New DotNetRandom

		Friend Sub New()
			Title = "Esteem"
			Test = AddressOf GetResult

			Positive = New NeedResult With {.Result = PositiveValue()}
			Negative = New NeedResult With {.Result = NegativeValue()}

		End Sub

		Private Function GetResult(ByVal e As Character) As Boolean
			Return (e.Knowledge <= 5 Or e.Ability <= 6) Or (e.Assets >= 6)
		End Function

		Private Function PositiveValue() As Double
			Return rnd.Next(1, 7)
		End Function

		Private Function NegativeValue() As Double
			Return rnd.Next(0.1, 2)
		End Function
	End Class

End Namespace
