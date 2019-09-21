Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DecisionTree.Entities

Namespace DecisionTree.Framework

	''' <summary>
	''' This class is used to determine the value of a Decision Tree matrix.
	''' A decision tree is defined by an initial query that forms the root of the tree. 
	''' A query consists of the name of a test and a function that executes it and can return several possible answers. 
	''' In this implementation, we’ll limit the answer to just true or false. 
	''' For each answer, the node also contains a link to the next query or the final decision for this path through the tree. 
	''' </summary>
	Friend Class NeedQuery
		Inherits Need

		Public Property Title() As String
		Public Property Positive() As Need
		Public Property Negative() As Need
		' Primitive operation to be provided by the user
		Public Property Test() As Func(Of Character, Boolean)

		Public ReadOnly Property Value As Double

		Public Overrides Function Evaluate(ByVal Character As Character) As Double
			' Test a Character using the primitive operation
			Dim res As Boolean = Test()(Character)

			Console.WriteLine($"{Title}? {If(res, "yes", "no")}")
			' Select a branch to follow
			If res Then
				_Value = Positive.Evaluate(Character)
			Else
				_Value = Negative.Evaluate(Character)
			End If

			Return _Value
		End Function
	End Class
End Namespace
