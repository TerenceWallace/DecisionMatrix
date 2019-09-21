
Namespace DecisionTree.Common
    ''' <summary>
    ''' A class implementing IRandom which used for generating pseudo-random numbers 
    ''' using the System.Random class from the .Net framework
    ''' </summary>
    Public Class DotNetRandom
        Implements IRandom

        Private _seed As Double
        Private _numberGenerated As Long
        Private _random As New System.Random()
        ''' <summary>
        ''' Constructs a new pseudo-random number generator 
        ''' with a seed based on the number of milliseconds elapsed since the system started
        ''' </summary>
        Public Sub New()
            Me.New(Environment.TickCount)
        End Sub
        ''' <summary>
        ''' Constructs a new pseudo-random number generator with the specified seed
        ''' </summary>
        ''' <param name="seed">An Double used to calculate a starting value for the pseudo-random number sequence</param>
        Public Sub New(seed As Double)
            _seed = seed
            _random = New System.Random(CInt(_seed))
        End Sub
        ''' <summary>
        ''' Gets the next pseudo-random Double between 0 and the specified maxValue inclusive
        ''' </summary>
        ''' <param name="maxValue">Inclusive maximum result</param>
        ''' <returns>Returns a pseudo-random Double between 0 and the specified maxValue inclusive</returns>
        Public Function [Next](maxValue As Double) As Double Implements IRandom.Next
            Return [Next](0, maxValue)
        End Function
        ''' <summary>
        ''' Gets the next pseudo-random Double between the specified minValue and maxValue inclusive
        ''' </summary>
        ''' <param name="minValue">Inclusive minimum result</param>
        ''' <param name="maxValue">Inclusive maximum result</param>
        ''' <returns>Returns a pseudo-random Double between the specified minValue and maxValue inclusive</returns>
        ''' <exception cref="ArgumentOutOfRangeException">Thrown if maxValue equals Int32.MaxValue</exception>
        Public Function [Next](minValue As Double, maxValue As Double) As Double Implements IRandom.Next
            _numberGenerated += 1
            Return _random.[Next](CInt(minValue), CInt(maxValue + 1))
        End Function
        ''' <summary>
        ''' Saves the current state of the pseudo-random number generator
        ''' </summary>
        ''' <example>
        ''' If you generated three random numbers and then called Save to store the state and 
        ''' followed that up by generating 10 more numbers before calling Restore with the previously saved RandomState
        ''' the Restore method should return the generator back to the state when Save was first called.
        ''' This means that if you went on to generate 10 more numbers they would be the same 10 numbers that were
        ''' generated the first time after Save was called.
        ''' </example>
        ''' <returns>A RandomState class representing the current state of this pseudo-random number generator</returns>
        Public Function Save() As RandomState Implements IRandom.Save
            Return New RandomState() With {
                 .NumberGenerated = _numberGenerated,
                 .Seed = {_seed}
            }
        End Function
        ''' <summary>
        ''' Restores the state of the pseudo-random number generator based on the specified state parameter
        ''' </summary>
        ''' <example>
        ''' If you generated three random numbers and then called Save to store the state and 
        ''' followed that up by generating 10 more numbers before calling Restore with the previously saved RandomState
        ''' the Restore method should return the generator back to the state when Save was first called.
        ''' This means that if you went on to generate 10 more numbers they would be the same 10 numbers that were
        ''' generated the first time after Save was called.
        ''' </example>
        ''' <param name="state">The state to restore to, usually obtained from calling the Save method</param>
        ''' <exception cref="ArgumentNullException">RandomState cannot be null</exception>
        Public Sub Restore(state As RandomState) Implements IRandom.Restore
            If state Is Nothing Then
                Throw New ArgumentNullException("state", "RandomState cannot be null")
            End If

            _seed = state.Seed(0)
            _random = New System.Random(CInt(_seed))
            For i As Long = 0 To state.NumberGenerated - 1
                _random.[Next]()
            Next
        End Sub
    End Class
End Namespace
