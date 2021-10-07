
Module OOPExample

    Sub Main()
        'Constructor
        Dim scruffy As New Dog
        Dim pepe As New Chihuahua



        'Console.WriteLine(scruffy.Move())
        'Console.WriteLine(scruffy.skinType())
        'Console.WriteLine(scruffy.Speak())

        'Console.WriteLine(pepe.Move())
        'pepe.skinType = "A hairless little rat!"
        'Console.WriteLine(pepe.skinType())
        'Console.WriteLine(pepe.Speak())
        'Console.WriteLine(scruffy.skinType())

        Dim jim As New Animal
        Console.WriteLine(jim.Move)
        Console.WriteLine(jim.Speak)

        Dim bob As New Bird
        Console.WriteLine(bob.Move)
        Console.WriteLine(bob.Speak)

        Dim polly As New Parrot
        Console.WriteLine(polly.Move)
        Console.WriteLine(polly.speak)

        'Dim sly As New Fox
        'Console.WriteLine("What does the fox say?")
        'Console.WriteLine(sly.Speak)
        Console.Read()
    End Sub

    Class Animal
        'fields
        Private _skinType As String
        Public Overridable Property skinType As String
            Get
                Return _skinType
            End Get
            Set(ByVal value As String)
                _skinType = value
            End Set
        End Property

        'Methods
        Public Function Move() As String
            Return "Animals move... Well not sponges..."
        End Function

        Public Function Speak() As String
            Return "Animals make sounds... Well not sponges..."
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

    Class Fox
        Inherits Dog
        Public Shadows Function Speak() As String
            Return "Ring-ding-ding-ding-dingeringeding!" & vbNewLine _
                   & "Gering-ding - ding - ding - dingeringeding!" & vbNewLine _
                   & "Gering-ding - ding - ding - dingeringeding!"
        End Function

    End Class

    Class Chihuahua
        Inherits Dog
        Public Shadows Function Speak() As String
            Return "yip! yip! yip! yip! yip! yip! yip!"
        End Function
    End Class


End Module
