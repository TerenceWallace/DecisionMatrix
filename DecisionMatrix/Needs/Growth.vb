
Imports DecisionTree.Framework
Imports DecisionTree.Entities

Namespace DecisionTree.Needs

	''' <summary>
	''' This class represents realizing personal potential, self-fulfillment, 
	''' seeking personal growth and peak experiences. 
	''' A desire “to become everything one is capable of becoming”
	''' </summary>
	Friend NotInheritable Class Growth
		Inherits NeedQuery

		Private Shared rnd As New DotNetRandom

		Friend Sub New()
			Title = "Growth"
			Test = AddressOf GetResult

			Positive = New NeedResult With {.Result = PositiveValue()}
			Negative = New NeedResult With {.Result = NegativeValue()}

		End Sub

		Private Function GetResult(ByVal e As Character) As Boolean
			Return e.Knowledge <= 3 Or e.Ability <= 1
		End Function

		Private Function PositiveValue() As Double
			Return rnd.Next(1, 5)
		End Function

		Private Function NegativeValue() As Double
			Return rnd.Next(0.1, 2)
		End Function
	End Class

End Namespace
