Imports System
'4.3. Crear un proyecto llamado “Notas” y un módulo que utilice arrays para almacenar las notas
'(entre 0 y 10) de una serie de alumnos.
'1 Primero paso es ingresar la cantidad de alumnos y la cantidad de notas que tiene cada
'uno teniendo en cuenta un máximo aceptado de 40 alumnos y 4 notas por alumno.
'2 Iterativamente ingresar el nombre de un alumno y sus notas. Validar que tenga un
'nombre de al menos 3 caracteres, que no sea repetido y el rango de la nota correcto.
'3 Al completar la iteración informar por cada alumno el nombre, el promedio, si aprobó o
'desaprobó teniendo en cuenta que aprueba con 6 o más.
'4 También informar quien es el mejor alumno (puede haber más de uno).
'5 Implementar procedimientos para resolver las siguientes tareas:
'* Para validar el nombre
'* Para validar la inexistencia de un nombre igual
'* Para validar el rango de la nota
'* Para determinar el promedio
'* Para imprimir si el alumno aprobó o no
'* Para determinar la lista de mejores alumnos
Module Notas
    Sub Main(args As String())
        Dim nombre As String = ""
        Dim alumnos As Integer = cantAlumnos()
        Dim notas As Integer = cantNotas()
        Dim totales = New Object(alumnos, notas) {}
        insertaNombre(nombre, totales, alumnos)
        'For Each alumnos In totales.GetUpperBound
        '    Console.WriteLine(alumnos)
        'Next
        For i = 0 To alumnos
            For j = 0 To notas
                Console.WriteLine("[{0},{1}] = {2}", i, j, totales(i, j))
            Next
        Next
    End Sub

    Function cantAlumnos() As Integer
        Dim alumnos As Integer
        Do
            Console.Write("Ingrese la cantidad de Alumnos(1-40) : ")
            alumnos = Console.ReadLine
        Loop Until alumnos > 0 And alumnos <= 40
        Return alumnos
    End Function
    Function cantNotas() As Integer
        Dim notas As Integer
        Do
            Console.Write("Ingrese la cantidad de Notas(1-4) : ")
            notas = Console.ReadLine
        Loop Until notas > 0 And notas <= 4
        Return notas
    End Function
    Sub validaNombre(ByRef nombre As String)
        Do
            Console.WriteLine("Ingrese nombre del Alumno(mínimo 3 caracteres)")
            nombre = Console.ReadLine
        Loop While nombre.Length < 3
    End Sub
    Sub existeNombre(ByRef nombre As String, totales(,) As Object, alumnos As Integer)

        For indiceAlumnos = 0 To alumnos - 1
            If nombre = totales(indiceAlumnos, 0) Then
                Console.WriteLine("Reingrese otro nombre, ya existe alumno.")
            End If
        Next
    End Sub

    Sub insertaNombre(ByRef nombre As String, totales(,) As Object, alumnos As Integer)

        For indiceAlumnos = 0 To alumnos - 1
            validaNombre(nombre)
            existeNombre(nombre, totales, alumnos)
            totales(indiceAlumnos, 0) = nombre
        Next

    End Sub

    Sub rangoNota()
        Console.WriteLine("asd")
    End Sub
    Sub promedioNota()
        Console.WriteLine("asd")
    End Sub
    Sub resultadoAlumno()
        Console.WriteLine("asd")
    End Sub
    Sub mejorAlumno()
        Console.WriteLine("asd")
    End Sub
End Module
