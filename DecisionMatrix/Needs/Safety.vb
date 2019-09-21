
Imports DecisionTree.Framework
Imports DecisionTree.Entities

Namespace DecisionTree.Needs

	''' <summary>
	''' This class represents the needs for security and safety. 
	''' People want control and order in their lives.  Therefore, finding a job, 
	''' obtaining health insurance and health care, contributing money to a savings account, 
	''' and moving into a safer neighborhood are all examples of actions motivated by the security and safety need.
	''' </summary>
	Friend NotInheritable Class Safety
		Inherits NeedQuery

		Private Shared rnd As New DotNetRandom

		Friend Sub New()
			Title = "Safety"
			Test = AddressOf GetResult

			Positive = New NeedResult With {.Result = PositiveValue()}
			Negative = New NeedResult With {.Result = NegativeValue()}

		End Sub

		Private Function GetResult(ByVal e As Character) As Boolean
			If e.Assets <= 2 Or e.Cash <= 1 Then Return True ' Gathering more resources is important

			Return False
		End Function

		Private Function PositiveValue() As Double
			Return rnd.Next(14, 20)
		End Function

		Private Function NegativeValue() As Double
			Return rnd.Next(0.1, 2)
		End Function
	End Class

End Namespace
