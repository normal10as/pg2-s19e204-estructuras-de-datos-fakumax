Imports System
'4.1. Crear un proyecto llamado “Media” y un módulo que permita cargar 5 números en un
'arreglo de 5 elementos; calcular la media y luego imprimir cada elemento del arreglo y la
'desviación que tiene respecto a la media. La MEDIA se obtiene la sumatoria de los todos
'elementos del arreglo y se divide por la cantidad de estos. La DESVIACION de cada
'elemento se obtiene restándole al elemento la MEDIA.
Module Media
    Sub Main(args As String())
        Dim sumatoria As Integer
        Dim valor() As Integer = calculoElementos(sumatoria)
        Console.WriteLine(vbCrLf & "La Sumatoria es : " & sumatoria)
        Console.WriteLine("La media es : " & sumatoria / valor.Length)
        elementosDesviacion(valor, sumatoria)
    End Sub

    Function calculoElementos(ByRef sumatoria As Integer) As Integer()
        Dim valor(4) As Integer
        For x = 0 To valor.Length - 1
            Console.Write("Ingrese un valor : ")
            valor(x) = Console.ReadLine
            sumatoria += valor(x)
        Next
        Return valor
    End Function

    Sub elementosDesviacion(valor() As Integer, sumatoria As Integer)
        Console.WriteLine(vbCrLf & "Los elementos son : ")
        For Each elemento In valor
            Console.WriteLine("Elemento : {0},  Desviación : {1}", elemento, elemento - (sumatoria / valor.Count))
        Next
    End Sub
End Module

