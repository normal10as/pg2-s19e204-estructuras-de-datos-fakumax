Imports System
'4.2. Crear un proyecto llamado “Ventas” y un módulo que cuenta con tres vectores cargados
'programáticamente referente a productos: el primero tiene el código, el segundo el nombre y
'el tercero el precio unitario.
'* Repetitivamente se ingresa un código de producto y el programa muestra su descripción
'y precio, si el código no existe mostrar un mensaje de Error.
'* luego el usuario ingresa la cantidad con lo que el programa responde calculando el total
'de venta por ese producto y el total general (acumulado los productos anteriores).
'* Se repite el proceso hasta que el código sea cero.
Module Ventas
    Sub Main(args As String())
        productoBuscar()

    End Sub
    Sub productoBuscar()
        Dim codigo = New Integer() {1, 2, 3}
        Dim nombre = New String() {"papa", "manzana", "uva"}
        Dim precio = New Single() {2.6, 1.2, 4.5}
        Dim buscar As UShort
        Console.WriteLine("Ingrese un valor : ")
        buscar = Console.ReadLine
        Do While True
            For x = 0 To codigo.GetUpperBound(0)
                If buscar = codigo(x) Then
                    Console.WriteLine("{0} - {1}     - {2} ", codigo(x), nombre(x), precio(x))
                End If
            Next


        Loop

    End Sub

End Module
