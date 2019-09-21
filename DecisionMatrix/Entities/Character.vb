Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DecisionTree.Needs

Namespace DecisionTree.Entities

	''' <summary>
	'''  This class represents a non-player character (NPC).
	'''  It is a character in a game which that is not controlled by a player. 
	''' </summary>
	Public Class Character

		Friend ReadOnly Property Physical As Physical = New Physical
		Friend ReadOnly Property Esteem As Esteem = New Esteem
		Friend ReadOnly Property Safety As Safety = New Safety
		Friend ReadOnly Property Growth As Growth = New Growth
		Friend ReadOnly Property Social As Social = New Social

		Public Property Name() As String
		Public Property Vicinity() As PlaceType
		Public Property Cash() As Double
		Public Property Assets() As Double
		Public Property Thirst() As Double
		Public Property Fatigue() As Boolean

		Public Property Knowledge As Double

		Public Property Ability As Double

		Public Property Preference As FeatureTypes

		Public Sub New()
		End Sub

		Public Sub Evaluate()
			_Physical.Evaluate(Me)
			_Esteem.Evaluate(Me)
			_Safety.Evaluate(Me)
			_Growth.Evaluate(Me)
			_Social.Evaluate(Me)
		End Sub


	End Class

End Namespace
