Imports System
'4.1. Crear un proyecto llamado �Media� y un m�dulo que permita cargar 5 n�meros en un
'arreglo de 5 elementos; calcular la media y luego imprimir cada elemento del arreglo y la
'desviaci�n que tiene respecto a la media. La MEDIA se obtiene la sumatoria de los todos
'elementos del arreglo y se divide por la cantidad de estos. La DESVIACION de cada
'elemento se obtiene rest�ndole al elemento la MEDIA.
Module Media
    Sub Main(args As String())
        calculoElementos()
    End Sub
    Sub calculoElementos()
        Dim valor(4) As Integer
        Dim sumatoria As Integer
        For x = 0 To valor.Length - 1
            Console.Write("Ingrese un valor : ")
            valor(x) = Console.ReadLine
            sumatoria += valor(x)
        Next
        Console.WriteLine("Los elementos contenidos son : ")
        For Each m In valor
            Console.WriteLine("Elemento : {0}  - Desviaci�n : {1}", m, m - (sumatoria / valor.Count))
        Next
    End Sub
End Module
