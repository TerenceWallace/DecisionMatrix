Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DecisionTree.Entities

Namespace DecisionTree.Framework

	''' <summary>
	''' This represents the base class for all other Needs.
	''' This represents a five-stage model can be divided into deficiency needs and growth needs. 
	''' The first four levels are often referred to as deficiency needs (D-needs), and the top level is known as growth or being needs (B-needs).
	''' Deficiency needs arise and motivates people when they are unmet. 
	''' Also, the motivation To fulfill such needs will become stronger the longer the duration they are denied. 
	''' </summary>
	''' <example>
	''' For example, the longer a person goes without food, the more hungry they will become.
	''' </example>
	Public MustInherit Class Need

		''' <summary>
		''' Denotes the last time the need was met or satisfied
		''' </summary>
		Friend Property LastModified As Long

		Public MustOverride Function Evaluate(ByVal Character As Character) As Double
	End Class
End Namespace
