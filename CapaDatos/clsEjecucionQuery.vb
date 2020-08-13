Imports System.Reflection 'Esta libreria me otorga clases para poder consultar objetos y sus propiedades
Imports System.Data.SqlClient
Imports UtilidadesSQL
Public Class clsEjecucionQuery
#Region "Metodos"
    ''' <summary>
    ''' Metodo que permite obtener un registro de una tabla de la base de datos
    ''' </summary>
    ''' <param name="objetoConDatos">El objeto que se llenara con los valores de las propiedades correspondientes del registro</param>
    ''' <param name="querySql">La query armada dirigida a la tabla y el registro correspondiente</param>
    ''' <remarks></remarks>
    Public Sub obtenerRegistro(ByRef objetoConDatos As Object, querySql As String)
        'Creo un objeto que sera el que contenga el String de la conexion a realizar
        Dim conexionSql As New clsConectorSql

        'El using me permite crear objetos y utilizarlos pero cuando se terminan de usar se liberan de memoria
        Using conexionSql.conector
            'Creo un objeto del tipo TYPE para obtener el tipo del objeto pasado por parametro
            Dim objetoEntidad As Type = objetoConDatos.GetType

            'Creo un bojeto para guardar las propiedades del objeto pasado por parametro
            Dim propiedadEntidad() As PropertyInfo = objetoEntidad.GetProperties

            'Creo el comando para guardar la query, la conexion y luego ejecutar la consulta
            Dim comando As SqlCommand = New SqlCommand(querySql, conexionSql.conector)

            Try
                'Si la conexion con la base de datos esta cerrada, la abro
                If conexionSql.conector.State = ConnectionState.Closed Then
                    conexionSql.conector.Open()
                End If

                'El data reader se llena con elementos de la base de datos pero solo se puede leer secuencialmente hacia adelante, es decir no se pueder ir volviendo a otros campos.
                Dim lectorDatos As SqlDataReader = comando.ExecuteReader 'El ExecuteReader envia la consulta a una Base de datos y crea un datareader, asiq le guardo ese datareader dentro del otro.

                'Un campo para guardar el nombre de las propiedades recorridas
                Dim campoNombre As String

                'Mientras el lector de datos se pueda leer , hacer un for anidado para recorrer el nombre de las propiedades del objeto pasado por el metodo, e ir comparando el nombre con las columnas que trae el datareader
                While lectorDatos.Read
                    For campo As Int16 = 0 To propiedadEntidad.Length - 1
                        campoNombre = propiedadEntidad(campo).Name

                        'Ahora recorremos el datareader, el FieldCount es igual al Lenght
                        For columnaDR As Int16 = 0 To lectorDatos.FieldCount - 1
                            If campoNombre = lectorDatos.GetName(columnaDR) Then
                                'A la propiedad que tenga  el nombre correspondiente (campo) le vamos a asignar el valor de dicha propiedad al objeto que habiamos pasado en el metodo, y desde donde se pasan los valores, sera del DataReader y la columna que se emparejo correctamente
                                propiedadEntidad(campo).SetValue(objetoConDatos, lectorDatos.GetValue(columnaDR))
                            End If
                        Next
                    Next
                End While

            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Ejecucion Query")

                'El finally se ejecuta siempre haya habido una excepcion o no
            Finally
                'Si la conexion continua abierta, la cierro
                If conexionSql.conector.State = ConnectionState.Open Then
                    conexionSql.conector.Close()
                End If
            End Try
            'Al finalizar el Using se libera de memoria los objetos creados aca dentro
        End Using
        'Al finalizar el sub, el objeto pasado por referencia ahora estara lleno de las propiedades y valores correspondientes de la entidad enviada
    End Sub

    ''' <summary>
    ''' Metodo que llenara un DataTable de los datos que obtenga de la base de datos segun la query pasada por parametro
    ''' </summary>
    ''' <param name="tablaDatos">La tabla a llenar con los datos</param>
    ''' <param name="query">La query armada para realizar la consulta</param>
    ''' <remarks></remarks>
    Public Sub obtenerRegistros(ByRef tablaDatos As DataTable, query As String)
        'Creo un objeto que sera el que contenga el String de la conexion a realizar
        Dim conexionSql As New clsConectorSql

        'El using me permite crear objetos y utilizarlos pero cuando se terminan de usar se liberan de memoria
        Using conexionSql.conector
            'Creo un bojeto del tipo adaptador de datos de sql que realice la ejecucion de la query
            Dim adaptador As SqlDataAdapter = New SqlDataAdapter(query, conexionSql.conector.ConnectionString)

            'Genero un bloque try para llenar la tabla de datos
            Try
                'Si la conexion con la base de datos esta cerrada, la abro
                If conexionSql.conector.State = ConnectionState.Closed Then
                    conexionSql.conector.Open()
                End If

                'Llamo al metodo FILL que me llena un DataTable
                adaptador.Fill(tablaDatos)

                'Si surge un error del tipo SQL lanzo un mensaje con el error
            Catch er As SqlException
                MsgBox("Error: " & er.Message, MsgBoxStyle.Critical, "Ejecucion Query")

                'Si surge un error menos especifico lanzo un mensaje con el error
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Ejecucion Query")

                'El finally se ejecuta siempre haya habido una excepcion o no
            Finally
                'Si la conexion continua abierta, la cierro
                If conexionSql.conector.State = ConnectionState.Open Then
                    conexionSql.conector.Close()
                End If
            End Try
        End Using
    End Sub
#End Region

#Region "Funciones"
    ''' <summary>
    ''' Funcion que permite ejecutar la query desde un comando SQL
    ''' </summary>
    ''' <param name="Comando">Objeto comando del tipo SqlCommand con la query a ejecutar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Actualizar(ByVal Comando As SqlCommand) As Int16
        'Creo un objeto de la clase conectorSqlServer que me permitira llamar al conector y asignarle el string correspondiente a la direccion de la conexion a realizar
        Dim conexion As New clsConectorSql
        Dim registros As New Int16

        'Al objeto pasado como parametro le asigno el string de conexion correspondiente que se encuentra en la clase clsConectorSql
        Comando.Connection = conexion.conector

        Comando.Connection.Open()
        'Ejecuto la consulta con el ExecuteNonQuery y me devolvera la cantidad de filas afectadas que las guardo para mostrarlas luego
        Try
            registros = Comando.ExecuteNonQuery()
        Catch eq As SqlException
            MsgBox("Error: " & eq.Message, MsgBoxStyle.Critical, "Ejecucion Query")

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Ejecucion Query")
        End Try

        Comando.Connection.Close()
        Return registros
    End Function
#End Region
End Class
