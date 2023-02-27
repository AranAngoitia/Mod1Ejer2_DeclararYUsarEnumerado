Imports System

Structure Persona
    Enum SexoPersona As Integer
        Masculino
        Femenino
    End Enum

    Dim _nombre, _primerapellido As String
    Dim _edad As Integer
    Dim _sexopersona As SexoPersona

    'Constructor
    Public Sub New(ByVal nombre As String, ByVal primerapellido As String, ByVal edad As Integer, ByVal sexo As SexoPersona)
        _nombre = nombre
        _primerapellido = primerapellido
        _edad = edad
        _sexopersona = sexo
    End Sub

    Public Overloads Overrides Function ToString() As String
        Return "Nombre completo, edad y sexo de la persona: " + _nombre + " " + _primerapellido + ", " + _edad.ToString() + " años. Sexo: " + _sexopersona.ToString() + "."
    End Function
End Structure

Module Program
    Sub Main(args As String())
        Dim p As Persona = New Persona("Marta", "Abad", 42, Persona.SexoPersona.Femenino)
        Console.WriteLine(p)

        Console.WriteLine("Pulse cualquier tecla para continuar")
        Console.ReadKey(True)
    End Sub
End Module
