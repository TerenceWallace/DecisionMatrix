Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DecisionTree.Entities

Namespace DecisionTree.Framework

	''' <summary>
	''' The class represents the final result of a Query <see cref="NeedQuery"/>
	''' </summary>
	Public Class NeedResult
		Inherits Need

		Public Property Result() As Double

		Public Overrides Function Evaluate(ByVal Character As Character) As Double
			Console.WriteLine($"  - Importance Rank: {Result}" & Environment.NewLine)
			Return Result
		End Function
	End Class
End Namespace
