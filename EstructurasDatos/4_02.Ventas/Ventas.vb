Imports System
'4.2. Crear un proyecto llamado �Ventas� y un m�dulo que cuenta con tres vectores cargados
'program�ticamente referente a productos: el primero tiene el c�digo, el segundo el nombre y
'el tercero el precio unitario.
'* Repetitivamente se ingresa un c�digo de producto y el programa muestra su descripci�n
'y precio, si el c�digo no existe mostrar un mensaje de Error.
'* luego el usuario ingresa la cantidad con lo que el programa responde calculando el total
'de venta por ese producto y el total general (acumulado los productos anteriores).
'* Se repite el proceso hasta que el c�digo sea cero.
Module Ventas
    '*Incompleto
    Sub Main(args As String())
        Dim codigo = New Integer() {1, 2, 3}
        Dim nombre = New String() {"papa", "manzana", "uva"}
        Dim precio = New Single() {2.6, 1.2, 4.5}
        Dim numero As Integer
        numero = productoBuscar(codigo)
        Console.WriteLine("El producto es: " & nombre(numero - 1))
        Console.WriteLine("El precio es: " & precio(numero - 1))

    End Sub
    Function productoBuscar(codigo() As Integer)

        Do Until False
            Dim valor As UShort = ingresoValor()
            For x = 0 To codigo.Length - 1
                If valor = codigo(x) Then
                    Return valor
                End If
            Next
            Return False


        Loop

    End Function

    Function ingresoValor() As UShort
        Console.WriteLine("Ingrese un valor : ")
        Return Console.ReadLine
    End Function

End Module
