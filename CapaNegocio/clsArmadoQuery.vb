Imports System.Reflection 'Esta libreria me otorga clases para poder consultar objetos y sus propiedades
Imports System.Data.SqlClient 'Esta libreria me permite obtener clases para acceder a la base de datos SQL Server de Windows
Public Class clsArmadoQuery
#Region "Funciones"
    'Creo una funcion que sera la encargada de armar una query para la INSERCION de datos
    ''' <summary>
    ''' Funcion para insertar un nuevo registro en la base de datos
    ''' </summary>
    ''' <param name="objetoConDatos">El objeto que contiene las propiedades y valores a insertar</param>
    ''' <param name="tabla">El nombre de la tabla donde se insertara el registro</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function insertarNuevoRegistro(ByRef objetoConDatos As Object, tabla As String) As SqlCommand
        'Creo el objeto comando que contendra los campos y valores a insertar, dentro de la query
        Dim comando As New SqlCommand

        'Creo un variable para guardar los nombres
        Dim nombrePropiedad As String

        'Creo el objeto que contiene la primer parte de la query
        Dim querySql As String = "INSERT INTO " & tabla & "(" 'String para la consulta de insercion
        Dim querySql2 As String = "VALUES (" 'String con los valores de insercion

        'Declaro un objeto del tipo TYPE que contiene la informacion de los tipos de objetos y al objeto pasado como parametro le digo que obtenga el tipo de dicho objeto. Esto me sirve porque si quisiera saber las propiedades de un objeto tipo OBJECT, este por defecto trae mas propiedades que le objeto en si asique me mostraria propiedades que no son necesarias.
        Dim tipoObjeto As Type = objetoConDatos.GetType

        'Objeto que me permite guardar la informacion de las propiedades de un objeto
        Dim propiedadesObjeto() As PropertyInfo
        'Obtengo informacion de las propiedades de un objeto y se guardan como array
        propiedadesObjeto = tipoObjeto.GetProperties

        'Hacemos un bucle for para recorrer el arreglo y completar las consultas. Le colocamos -1 porque el arreglo comienza en 0 y sino se pasara y dara error.
        'Empezamos desde el campo 1 porque el campo 0 seria el Id del objeto y es autoincremental
        For campo As Int16 = 1 To propiedadesObjeto.Length - 1
            'En la variable vamos guardando el nombre de cada propiedad encontrada
            nombrePropiedad = propiedadesObjeto(campo).Name

            'Declaro un objeto al cual le voy a asignar el valor para usarlo luego en el armado de la query
            Dim valorObjeto As Object = propiedadesObjeto(campo).GetValue(objetoConDatos)

            If campo < propiedadesObjeto.Length - 1 Then
                'Segun el tipo de dato que tenga el campo sera como se formatee la consulta para que se guarde correctamente
                Select Case (propiedadesObjeto(campo).PropertyType)
                    Case GetType(Int16), GetType(Short) 'Es lo mismo que el SHORT
                        'Le agrego a la query los @ en las propiedades para que tome el valor desde el comando la query, ademas le agrego una "," al final para poder colocar el otro valor
                        querySql += nombrePropiedad & ", "
                        querySql2 += "@" & nombrePropiedad & ", "
                        'Le agrego un parametro al comando que se llamara igual a la propiedad y le digo de que propiedad sera en la base de datos
                        comando.Parameters.Add("@" & nombrePropiedad, SqlDbType.SmallInt)
                        'Le asigno el valor al parametro que agregue al comando desde el objeto pasado como parametro al principio
                        comando.Parameters("@" & nombrePropiedad).Value = valorObjeto
                    Case GetType(Int32), GetType(Integer) 'Es lo mismo que el INTEGER
                        querySql += nombrePropiedad & ", "
                        querySql2 += "@" & nombrePropiedad & ", "
                        comando.Parameters.Add("@" & nombrePropiedad, SqlDbType.Int)
                        comando.Parameters("@" & nombrePropiedad).Value = valorObjeto
                    Case GetType(Int64), GetType(Long) 'Es lo mismo que el LONG
                        querySql += nombrePropiedad & ", "
                        querySql2 += "@" & nombrePropiedad & ", "
                        comando.Parameters.Add("@" & nombrePropiedad, SqlDbType.BigInt)
                        comando.Parameters("@" & nombrePropiedad).Value = valorObjeto
                    Case GetType(String)
                        querySql += nombrePropiedad & ", "
                        querySql2 += "@" & nombrePropiedad & ", "
                        comando.Parameters.Add("@" & nombrePropiedad, SqlDbType.VarChar)
                        comando.Parameters("@" & nombrePropiedad).Value = valorObjeto
                    Case GetType(Double) 'Es lo mismo que float en SQLserver
                        querySql += nombrePropiedad & ", "
                        querySql2 += "@" & nombrePropiedad & ", "
                        comando.Parameters.Add("@" & nombrePropiedad, SqlDbType.Float)
                        comando.Parameters("@" & nombrePropiedad).Value = valorObjeto
                    Case GetType(Date)
                        querySql += nombrePropiedad & ", "
                        querySql2 += "@" & nombrePropiedad & ", "
                        comando.Parameters.Add("@" & nombrePropiedad, SqlDbType.Date)
                        comando.Parameters("@" & nombrePropiedad).Value = valorObjeto
                    Case GetType(DateTime)
                        querySql += nombrePropiedad & ", "
                        querySql2 += "@" & nombrePropiedad & ", "
                        comando.Parameters.Add("@" & nombrePropiedad, SqlDbType.DateTime)
                        comando.Parameters("@" & nombrePropiedad).Value = valorObjeto
                    Case GetType(Decimal)
                        querySql += nombrePropiedad & ", "
                        querySql2 += "@" & nombrePropiedad & ", "
                        comando.Parameters.Add("@" & nombrePropiedad, SqlDbType.Decimal)
                        comando.Parameters("@" & nombrePropiedad).Value = valorObjeto
                    Case GetType(Char)
                        querySql += nombrePropiedad & ", "
                        querySql2 += "@" & nombrePropiedad & ", "
                        comando.Parameters.Add("@" & nombrePropiedad, SqlDbType.Char)
                        comando.Parameters("@" & nombrePropiedad).Value = valorObjeto
                End Select

                'Entra al comparador cuando llegue al final de las propiedades
            ElseIf campo = propiedadesObjeto.Length - 1 Then
                'Le agrego la clausula ACTIVO en 1 para que se muestre en pantalla
                'querySql += "Activo, "
                'querySql2 += "@Activo, "
                'comando.Parameters.Add("@Activo", SqlDbType.Int)
                'comando.Parameters("@Activo").Value = 1

                'Le agrego al final la fecha de modificacion y la hora
                querySql += "FechaUltimaModificacion)"
                querySql2 += "@FechaUltimaModificacion)"
                comando.Parameters.Add("@FechaUltimaModificacion", SqlDbType.DateTime)
                comando.Parameters("@FechaUltimaModificacion").Value = Now
            End If
        Next

        'Al comando le decimos que el texto que llevara sera el de la query completa que realizamos
        querySql += querySql2
        comando.CommandText = querySql
        Return comando
    End Function

    'Creo una funcion que sirve para comparar objetos y determinar cuales propiedades se tienen que actualizar
    ''' <summary>
    ''' Funcion para actualizar un objeto de la base de datos
    ''' </summary>
    ''' <param name="objetoOriginal">El objeto que contiene los datos originales</param>
    ''' <param name="objetoActualizar">El objeto con datos actualizados</param>
    ''' <param name="tabla">El nombre de la tabla donde se actualizara el registro</param>
    ''' <param name="campoId">El nombre de la columna de la clave principal</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function actualizarRegistro(objetoOriginal As Object, objetoActualizar As Object, tabla As String, campoId As String) As SqlCommand
        'Creo un objeto comando para trasladar la query a la capa de datos con los datos a cambiar formateados y que sean ejecutados desde alli
        Dim comando As New SqlCommand

        'Creo el objeto que contendra la query
        Dim queryActualizar As String = "UPDATE " & tabla & " SET "

        'Creo un objeto que contendra el nombre de la propiedad a consultar
        Dim nombrePropiedad As String

        'Creo 2 objetos que seran los que determinaran el tipo de objeto que esta siendo pasado como parametro
        Dim tipoObjetoOriginal As Type = objetoOriginal.GetType
        Dim tipoObjetoActualizar As Type = objetoActualizar.GetType

        'Si los objetos no son iguales, envio un mensaje de error y salgo de la funcion
        If Not tipoObjetoOriginal = tipoObjetoActualizar Then
            'Lanzo una excepcion a ser capturada por el bloque TRY del objeto que inicia la funcion
            Throw New Exception("Error: Los objetos no son iguales")
            'MsgBox("Error: Los objetos no son iguales", MsgBoxStyle.Critical)
            Exit Function
        End If

        'Creo 2 objetos para guardar las propiedades de estos, los cuales seran una coleccion (similar a un array pero con mas funcionalidades)
        Dim propiedadesObjetoOriginal() As PropertyInfo = tipoObjetoOriginal.GetProperties
        Dim propiedadesObjetoActualizar() As PropertyInfo = tipoObjetoActualizar.GetProperties

        'Creo un objeto en el que voy a guardar el numero de ID para usarlo luego en la clausula WHERE
        Dim numeroId As Integer = 0

        'Con un bucle FOR recorro las propiedades en busca de las que no tengan los mismos valores, puesto que esas seran las que se actualizaran
        For campo As Int16 = 0 To propiedadesObjetoOriginal.Length - 1
            'Guardamos el nombre de la propiedad consultada para pasarla como parametro
            nombrePropiedad = propiedadesObjetoOriginal(campo).Name

            'Verificamos que cuando el nombre del campo sea igual al nombre del campo ID pasado, se compararan los valores de ambos objetos y si son iguales (los ID) se continua iterando, sino se cancela toda la operacion
            If propiedadesObjetoOriginal(campo).Name = campoId Then
                If propiedadesObjetoOriginal(campo).GetValue(objetoOriginal) = propiedadesObjetoActualizar(campo).GetValue(objetoActualizar) Then
                    numeroId = propiedadesObjetoOriginal(campo).GetValue(objetoOriginal)
                Else
                    'Lanzo una excepcion a ser capturada por el bloque TRY del objeto que inicia la funcion
                    Throw New Exception("Error: El numero de ID entre los objetos es distinto")
                    'MsgBox("Error: El numero de ID entre los objetos es distinto", MsgBoxStyle.Critical)
                    Exit Function
                End If
            End If

            'Declaro 2 objetos nuevos donde guardo el valor actual de cada uno para compararlo luego
            Dim valorOriginal As Object = propiedadesObjetoOriginal(campo).GetValue(objetoOriginal)
            Dim valorActual As Object = propiedadesObjetoActualizar(campo).GetValue(objetoActualizar)

            'Comparamos si los valores en las propiedades de ambos objetos no son iguales, quiere decir que fue cambiado y es el que va a ser actualizado, por lo tanto lo usamos en la query
            If Not valorOriginal = valorActual Then
                'Segun el tipo de dato que tenga el campo sera como se formatee la consulta para que se guarde correctamente
                Select Case (propiedadesObjetoActualizar(campo).PropertyType) 'Podria escribirse como "SELECT CASE (valorActual.GetType())"
                    Case GetType(Int16), GetType(Short) 'Es lo mismo que el SHORT
                        'Le agrego a la query los @ en las propiedades para que tome el valor desde el comando la query, ademas le agrego una "," al final para poder colocar el otro valor si lo hubiera
                        queryActualizar += nombrePropiedad & " = @" & nombrePropiedad & ", "
                        'Le agrego un parametro al comando y le digo de que propiedad sera en la base de datos
                        comando.Parameters.Add("@" & nombrePropiedad, SqlDbType.SmallInt)
                        'Le asigno el valor al parametro que agregue al comando
                        comando.Parameters("@" & nombrePropiedad).Value = valorActual
                    Case GetType(Int32), GetType(Integer) 'Es lo mismo que el INTEGER
                        queryActualizar += nombrePropiedad & " = @" & nombrePropiedad & ", "
                        comando.Parameters.Add("@" & nombrePropiedad, SqlDbType.Int)
                        comando.Parameters("@" & nombrePropiedad).Value = valorActual
                    Case GetType(Int64), GetType(Long) 'Es lo mismo que el LONG
                        queryActualizar += nombrePropiedad & " = @" & nombrePropiedad & ", "
                        comando.Parameters.Add("@" & nombrePropiedad, SqlDbType.BigInt)
                        comando.Parameters("@" & nombrePropiedad).Value = valorActual
                    Case GetType(String)
                        queryActualizar += nombrePropiedad & " = @" & nombrePropiedad & ", "
                        comando.Parameters.Add("@" & nombrePropiedad, SqlDbType.VarChar)
                        comando.Parameters("@" & nombrePropiedad).Value = valorActual
                    Case GetType(Double) 'Es lo mismo que float en SQLserver
                        queryActualizar += nombrePropiedad & " = @" & nombrePropiedad & ", "
                        comando.Parameters.Add("@" & nombrePropiedad, SqlDbType.Float)
                        comando.Parameters("@" & nombrePropiedad).Value = valorActual
                    Case GetType(Date)
                        queryActualizar += nombrePropiedad & " = @" & nombrePropiedad & ", "
                        comando.Parameters.Add("@" & nombrePropiedad, SqlDbType.Float)
                        comando.Parameters("@" & nombrePropiedad).Value = valorActual
                    Case GetType(DateTime)
                        queryActualizar += nombrePropiedad & " = @" & nombrePropiedad & ", "
                        comando.Parameters.Add("@" & nombrePropiedad, SqlDbType.DateTime)
                        comando.Parameters("@" & nombrePropiedad).Value = valorActual
                    Case GetType(Decimal)
                        queryActualizar += nombrePropiedad & " = @" & nombrePropiedad & ", "
                        comando.Parameters.Add("@" & nombrePropiedad, SqlDbType.Decimal)
                        comando.Parameters("@" & nombrePropiedad).Value = valorActual
                    Case GetType(Char)
                        queryActualizar += nombrePropiedad & " = @" & nombrePropiedad & ", "
                        comando.Parameters.Add("@" & nombrePropiedad, SqlDbType.Char)
                        comando.Parameters("@" & nombrePropiedad).Value = valorActual
                End Select
            End If

            'Entra al comparador cuando llega al ultimo recorrido del FOR
            If campo = propiedadesObjetoOriginal.Length - 1 Then
                'Le agrego al final la fecha y la hora de modificacion
                queryActualizar += "FechaUltimaModificacion = @FechaUltimaModificacion"
                comando.Parameters.Add("@FechaUltimaModificacion", SqlDbType.DateTime)
                comando.Parameters("@FechaUltimaModificacion").Value = Now

                'En la query con todos los valores, le asignamos la clausula correspondiente que en este caso sera el ID de la fila a actualizar
                queryActualizar += " WHERE " & tabla & "." & campoId & " = @" & campoId & ";"

                'Le agregamos un parametro que sera con el mismo nombre que el campo ID y le decimos que es del tipo INT en SQLServer
                comando.Parameters.Add("@" & campoId, SqlDbType.Int)

                'Le asignamos al parametro anterior el valor correspondiente al ID que obtuvimos anteriormente
                comando.Parameters("@" & campoId).Value = numeroId
            End If
        Next

        'Al comando le decimos que el texto que llevara sera el de la query completa que realizamos
        comando.CommandText = queryActualizar
        Return comando
    End Function

    'Creo la funcion que me permita realizar la consulta de los registros cargados
    ''' <summary>
    ''' Funcion que permite consultar un registro de una tabla
    ''' </summary>
    ''' <param name="tabla">El nombre de la tabla a consultar</param>
    ''' <param name="campoId">El nombre del campo de la clave principal o ID de la tabla</param>
    ''' <param name="numeroId">El numero de ID del registro a consultar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function consultaRegistro(tabla As String, campoId As String, numeroId As Integer) As String
        'Creo un objeto comando para trasladar la query a la capa de datos y que sea ejecutada desde alli
        Dim query As String = "SELECT * FROM " & tabla & " WHERE " & campoId & " = " & numeroId & ";"
        Return query
    End Function

    ''' <summary>
    ''' Funcion que permite consultar todos los registros de una tabla
    ''' </summary>
    ''' <param name="tabla">El nombre de la tabla a consultar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function consultarRegistros(tabla As String) As String
        'Armo la query generica con la tabla pasada
        Dim query As String = "SELECT * FROM " & tabla
        Return query
    End Function

    ''' <summary>
    ''' Funcion que trae todos los registros activos de una tabla de la base de datos
    ''' </summary>
    ''' <param name="tabla">Nombre de la tabla a consultar</param>
    ''' <returns></returns>
    Public Function consultarRegistrosActivos(tabla As String) As String
        'Armo la query generica con la tabla pasada y que solo se muestren los registros activos
        Dim query As String = "SELECT * FROM " & tabla & " WHERE Activo = 1;"
        Return query
    End Function

    ''' <summary>
    ''' Funcion que trae todos los registros no activos de una tabla de la base de datos
    ''' </summary>
    ''' <param name="tabla">Nombre de la tabla a consultar</param>
    ''' <returns></returns>
    Public Function consultarRegistrosBaja(tabla As String) As String
        'Armo la query generica con la tabla pasada y que solo se muestren los registros no activos
        Dim query As String = "SELECT * FROM " & tabla & " WHERE Activo = 0;"
        Return query
    End Function

    ''' <summary>
    ''' Funcion me trae todos los registros asociados a un ID foraneo de la misma tabla
    ''' </summary>
    ''' <param name="tabla">El nombre de la tabla principal</param>
    ''' <param name="tablaForanea">El nombre de la columna con el ID foraneo</param>
    ''' <param name="numeroIdForaneo">El numero de ID del registro asociado a la tabla principal</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function consultarRegistrosCompleto(tabla As String, tablaForanea As String, numeroIdForaneo As Integer) As String
        'Creo un objeto comando para trasladar la query a la capa de datos y que sea ejecutada desde alli
        Dim query As String = "SELECT * FROM " & tabla & " WHERE " & tablaForanea & " = " & numeroIdForaneo & ";"
        Return query
    End Function
#End Region
End Class
