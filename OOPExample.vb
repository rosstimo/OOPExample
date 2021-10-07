Imports System.Windows.Forms
Module OOPExample

    Sub Main()
        Dim scruffy As New Dog
        Console.WriteLine(scruffy.Move())
        Console.WriteLine(scruffy.skinType())
        Console.Read()
    End Sub

    Class Animal

        Private _skinType As String
        Public Overridable Property skinType As String
            Get
                Return _skinType
            End Get
            Set(ByVal value As String)
                _skinType = value
            End Set
        End Property

        Public Function Move() As String
            Return ""
        End Function

        Public Function Speak() As String
            Return ""
        End Function

    End Class

    Class Mammal
        Inherits Animal

        'Properties
        Public Overrides Property skinType As String = "Fur"

        'Methods
        Public Shadows Function Move() As String
            Return "Walking on all fours"
        End Function
    End Class

    Class Bird
        Inherits Animal
        'Properties
        Public Overrides Property skinType As String = "Feathers"

        'Methods
        Public Shadows Function Move() As String
            Return "Soaring through the sky..."
        End Function

    End Class

    Class Dog
        Inherits Mammal
        'Properties
        Private _skinType As String

        'Fields

        'Methods
        Sub New()
            Me.skinType = "shiny coat"
        End Sub

        Public Shadows Function Move() As String
            Return "Leaping through the tall grass in the back yard.."
        End Function

        Public Shadows Function Speak() As String
            Return "Woof! Woof"
        End Function

    End Class

    Class Cat
        Inherits Mammal
        Public Shadows Function Move() As String
            Return "Walking across the kitchen table..."
        End Function

        Public Shadows Function speak() As String
            Return "Meow..."
        End Function
    End Class

    Class Parrot
        Inherits Bird

        Sub New()
            Me.skinType = "Green Feathers"
        End Sub

        Public Shadows Function Move() As String
            Return "Ok, who left the window open?"
        End Function

        Public Shadows Function speak() As String
            Return "Pretty Bird...."
        End Function
    End Class

    Class Lion
        Inherits Mammal
        Public Shadows Function speak() As String
            Return "Roar!"
        End Function
    End Class

    Class Duck
        Inherits Bird
        Public Shadows Function Move() As String
            Return "It walks like a duck..."
        End Function
        Public Shadows Function speak() As String
            Return "It quacks like a duck..."
        End Function
    End Class

End Module
