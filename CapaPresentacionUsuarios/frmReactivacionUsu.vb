Imports entUsuario
Public Class frmReactivacionUsu
#Region "Campos"
    'Id de la seleccion
    Private _IdReact As Integer = -1
#End Region

#Region "Propiedades"
    Public Property IdReact As Integer
        Get
            Return _IdReact
        End Get
        Set(value As Integer)
            _IdReact = value
        End Set
    End Property
#End Region

#Region "Eventos"
    Private Sub frmReactivacionUsu_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Muestro los registros actuales en el DGV
            ActualizarDGV()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, Text)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'Cierro el formulario
        Close()
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        'Compruebo que se haya seleccionado un registro
        Try
            If IdReact > -1 Then
                'Creo un nuevo objeto y le asigno el resultado del MessageBox creado
                Dim resultado As DialogResult = MessageBox.Show("¿Seguro desea reactivar el registro seleccionado?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                'Si se confirma la accion, se da de alta el registro
                If resultado = DialogResult.Yes Then
                    'Creo 2 objetos iguales con el mismo id del que se quiere dar de alta y le asigno los mismos valores que ya tiene, pero le cambio a uno la propiedad Activo que sera lo que se modificara 
                    Dim usu As New eUsuario
                    Dim usuAlta As New eUsuario
                    usu.obtenerRegistro(IdReact)
                    usuAlta.obtenerRegistro(IdReact)

                    'Vuelvo a dar de alta el registro
                    usuAlta.Activo = 1

                    'Llamo a la funcion que me permite actualizar registros y guardo el resultado si fue actualizado con exito
                    Dim registro As Integer = usu.actualizarRegistro(usuAlta)

                    If registro = 1 Then
                        'Vuelvo a colocar el Id en -1 para que tenga q seleccionar de nuevo un registro
                        IdReact = -1
                        'Actualizo el DGV
                        ActualizarDGV()
                        MsgBox("REACTIVACION REALIZADA CON EXITO", MsgBoxStyle.Information, "REACTIVACIONES")
                    Else
                        Throw New Exception("No se pudo realizar la reactivacion")
                    End If
                End If
            Else
                Throw New Exception("Debe seleccionar un registro para reactivarlo")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Reactivacion")
        End Try
    End Sub

    'Evento que se lanza al hacer click en una celda del DGV
    Private Sub dgvListadoUsu_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListadoUsu.CellMouseClick
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Asigno el Id del registro a reactivar seleccionado (el cual se encuentra en la primer columna)
            IdReact = dgvListadoUsu.Rows(e.RowIndex).Cells(0).Value
        End If
    End Sub

    'Evento que se lanza al terminarse el enlace de datos
    Private Sub dgvListadoUsu_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvListadoUsu.DataBindingComplete
        'Limpio la seleccion actual
        dgvListadoUsu.ClearSelection()
    End Sub

    'Evento que se lanza al entrar el mouse a una celda
    Private Sub dgvListadoUsu_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoUsu.CellMouseEnter
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Cambio el back color de la fila
            dgvListadoUsu.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Aqua
        End If
    End Sub

    'Evento que se lanza al salir el mouse de una celda
    Private Sub dgvListadoUsu_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoUsu.CellMouseLeave
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Cambio el back color de la fila
            dgvListadoUsu.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
        End If
    End Sub
#End Region

#Region "Metodos"
    ''' <summary>
    ''' Metodo que sirve para consultar la base de datos y llenar el DGV con los registros encontrados
    ''' </summary>
    Public Sub ActualizarDGV()
        'Creo nuevos objetos y vuelvo a llenar una tabla para mostrar el registro que fue agregado
        Dim usuarios As New eUsuario
        Dim tabla As New DataTable

        'Lleno la tabla
        usuarios.obtenerRegistrosBaja(tabla, "Usuarios")

        'Se la asigno al DGV asi lo actualizo
        dgvListadoUsu.DataSource = tabla
        'Ordeno el DGV por nombre
        dgvListadoUsu.Sort(dgvListadoUsu.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        'Limpio la seleccion actual
        dgvListadoUsu.ClearSelection()
    End Sub
#End Region
End Class