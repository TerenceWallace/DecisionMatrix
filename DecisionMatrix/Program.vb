Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading.Tasks
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DecisionTree.Entities
Imports DecisionTree.Places

Namespace DecisionTree

	''' <summary>
	''' This is an example of creating a Decision Matrix.  The steps are loosely defined as follows.
	''' Step 1: List options (i.e. Places <see cref="Places"/>)
	''' Step 2: Determine important attributes (i.e. Needs <see cref="Needs"/>) 
	''' Step 3: Assign relative weights to each attribute (ex: an 8 would be twice as important as a 4)
	''' Step 4: Assign objective 0-100 scores for each attribute across options (best To Do this On an attribute-by-attribute basis)
	''' Step 5: Options with the higest scores should be considered as valid choice
	''' </summary>
	Class Program

		Private Shared rnd As New DotNetRandom

		Shared Sub Main(ByVal args As String())
			Dim pressedKey As ConsoleKeyInfo

			Do
				DisplayChoices()
				pressedKey = Console.ReadKey(True)
				Select Case pressedKey.Key
					Case ConsoleKey.Escape
					Case ConsoleKey.NumPad1, ConsoleKey.D1
						Console.Clear()
						Test()
					Case Else
						Continue Do
				End Select

			Loop While pressedKey.Key <> ConsoleKey.Escape

		End Sub

		Private Shared Sub DisplayChoices()
			Console.Clear()
			Console.WriteLine("Please choose by pressing the key for the desired selection.")
			Console.WriteLine("1    Test")
			Console.WriteLine("Esc  Quit")
			Console.Write("Selection: ")
		End Sub

		Private Shared Sub Test()
			Dim John As Character = BuildCharacter()
			John.Evaluate()

			Dim TotalValues As Double = John.Physical.Value + John.Esteem.Value + John.Safety.Value + John.Growth.Value + John.Social.Value

			Dim PhysicalWeight As Double = John.Physical.Value / TotalValues
			Dim EsteemWeight As Double = John.Esteem.Value / TotalValues
			Dim FinancialWeight As Double = John.Safety.Value / TotalValues
			Dim GrowthWeight As Double = John.Growth.Value / TotalValues
			Dim SocialWeight As Double = John.Social.Value / TotalValues

			' Create Character choices
			Dim lst As List(Of Place) = BuildPlaces()

			' Calculate needs influenced by what the Character values
			For Each item As Place In lst
				Dim Name As String = item.Name

				Dim PhysicalValue As Double = item.Features.Physical
				Dim EsteemValue As Double = item.Features.Esteem
				Dim FinancialValue As Double = item.Features.Safety
				Dim GrowthValue As Double = item.Features.Growth
				Dim SocialValue As Double = item.Features.Social

				item.Features.Value = (PhysicalValue * PhysicalWeight) + (EsteemValue * EsteemWeight) +
				    (FinancialValue * FinancialWeight) + (GrowthValue * GrowthWeight) + (SocialValue * SocialWeight)

				'' Console.WriteLine($"{Name} calculated value is: {item.Features.Value}")
			Next item

			' Sort values
			Dim DecisionList = From p In lst
						    Order By p.Features.Value Descending

			Console.WriteLine(Environment.NewLine)
			Console.WriteLine("======[VALUES]=======")
			For Each item As Place In DecisionList
				Dim Name As String = item.Name
				Console.WriteLine($"{Name} value is: {item.Features.Value}")
			Next item

			Console.WriteLine($"Decision is: {DecisionList(0).Name}")

			Console.ReadLine()
		End Sub

		Private Shared Function BuildPlaces() As List(Of Place)
			Dim Places As New List(Of Place)

			Places.Add(New Bank)
			Places.Add(New Food)
			Places.Add(New Goldmine)
			Places.Add(New Home)
			Places.Add(New Market)
			Places.Add(New Nightclub)
			Places.Add(New Saloon)
			Places.Add(New School)

			Return Places
		End Function

		Private Shared Function BuildCharacter() As Character

			' Test a Character using this tree
			' Create Character using object initializer
			Dim john As New Character With {
			 .Name = "Farmer John",
			 .Vicinity = PlaceType.Home,
			 .Assets = rnd.Next(0, 5),
			 .Cash = rnd.Next(0, 5),
			 .Thirst = rnd.Next(0, 5),
			 .Fatigue = False,
			 .Knowledge = rnd.Next(0, 5),
			 .Ability = rnd.Next(0, 5),
			 .Preference = FeatureTypes.Work
					   }

			Return john
		End Function
	End Class
End Namespace
