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

    End Class

    Class Mammal
        Inherits Animal

        'Properties
        Public Overrides Property skinType As String = "Fur"

    End Class

    Class Bird
        Inherits Animal
        'Properties
        Public Overrides Property skinType As String = "Feathers"

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

        End Sub

        Public Shadows Function Move() As String
            Return "Leaping through the tall grass in the back yard.."
        End Function

    End Class

    Class Cat
        Inherits Mammal
    End Class

    Class Parrot
        Inherits Bird
        Public Shadows Function Move() As String
            Return "Ok, who left the window open?"
        End Function
    End Class

    Class Lion
        Inherits Mammal
    End Class

    Class Duck
        Inherits Bird
    End Class

End Module
