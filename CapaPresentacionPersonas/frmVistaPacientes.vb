Imports entPaciente
Public Class frmVistaPacientes
#Region "Campos"
    'Query para la consulta a la BD
    Dim query As String = "SELECT * FROM Pacientes INNER JOIN ObrasSociales ON Pacientes.ObraSocial = ObrasSociales.IdObraSocial  WHERE Pacientes.Activo = 1"

    Private _IdPac As Integer
    Private _IdLocalidadPac As Integer
    Private _NombrePac As String 'Para las Historias Clinicas y Turnos
    Private _IdOSPac As Integer

    'Usuario actual
    Private _IdUsuAct As Integer

    'Creo un Binding Source para guardar los datos de la consulta SQL
    Dim dataBin As New BindingSource
#End Region

#Region "Propiedades"
    Public Property IdPac As Integer
        Get
            Return _IdPac
        End Get
        Set(value As Integer)
            _IdPac = value
        End Set
    End Property

    Public Property IdUsuAct As Integer
        Get
            Return _IdUsuAct
        End Get
        Set(value As Integer)
            _IdUsuAct = value
        End Set
    End Property

    Public Property IdLocalidadPac As Integer
        Get
            Return _IdLocalidadPac
        End Get
        Set(value As Integer)
            _IdLocalidadPac = value
        End Set
    End Property

    Public Property NombrePac As String
        Get
            Return _NombrePac
        End Get
        Set(value As String)
            _NombrePac = value
        End Set
    End Property

    Public Property IdOSPac As Integer
        Get
            Return _IdOSPac
        End Get
        Set(value As Integer)
            _IdOSPac = value
        End Set
    End Property
#End Region

#Region "Eventos"
    Private Sub frmVistaPacientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Cambio el titulo segun el formulario
            lblVistaPacientes.Text = Text

            'Cambio el tamaño de la fuente del encabezado de las columnas
            dgvListadoPacientes.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 15, FontStyle.Bold)

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

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'Creo un objeto nuevo
        Dim nuevoPac As New frmPersona

        'Le asigno las propiedades y lo muestro como objeto de dialogo
        With nuevoPac
            .Text = "ALTA DE HISTORIA CLINICA"
            .TipoFormulario = frmPersona.TipoFormu.NPaciente
            .IdUsuAct = IdUsuAct
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                'Actualizo el DGV
                ActualizarDGV()
            End If
        End With
    End Sub

    'Evento que se lanza al realizar doble click sobre una celda o fila del DGV
    Private Sub dgvListadoPacientes_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListadoPacientes.CellMouseDoubleClick
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Asigno el Id del paciente seleccionado (el cual se encuentra en la primer columna)
            IdPac = dgvListadoPacientes.Rows(e.RowIndex).Cells(0).Value
            'Asigno el id de la localidad del paciente para mostrarla en modificaciones
            IdLocalidadPac = dgvListadoPacientes.Rows(e.RowIndex).Cells(8).Value
            'Asigno el id de la OS del paciente
            IdOSPac = dgvListadoPacientes.Rows(e.RowIndex).Cells(6).Value

            'Creo un objeto nuevo
            Dim nuevoPac As New frmPersona

            'Le asigno las propiedades y lo muestro como dialogo
            With nuevoPac
                .Text = "CONSULTA DE HISTORIA CLINICA"
                .TipoFormulario = frmPersona.TipoFormu.CPaciente
                .IdUsuAct = IdUsuAct
                .IdPaciente = IdPac
                .IdLoca = IdLocalidadPac
                .IdObraSoc = IdOSPac
                .ShowDialog()
                If .DialogResult = DialogResult.OK Then
                    'Actualizo el DGV
                    ActualizarDGV()
                End If
            End With
        End If
    End Sub

    'Evento que se lanza al terminarse el enlace de datos
    Private Sub dgvListadoPacientes_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvListadoPacientes.DataBindingComplete
        'Limpio la seleccion actual
        dgvListadoPacientes.ClearSelection()
    End Sub

    'Evento que se lanza al entrar el mouse a una celda
    Private Sub dgvListadoPacientes_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoPacientes.CellMouseEnter
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Cambio el back color de la fila
            dgvListadoPacientes.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Aqua
        End If
    End Sub

    'Evento que se lanza al salir el mouse de una celda
    Private Sub dgvListadoPacientes_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoPacientes.CellMouseLeave
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Cambio el back color de la fila
            dgvListadoPacientes.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
        End If
    End Sub

    'Evento cuando se cambia el contenido del TXT
    Private Sub txtBuscador_TextChanged(sender As Object, e As EventArgs) Handles txtBuscador.TextChanged
        'Realizo un filtro en el contenido del dataBin y es lo que mostrara en pantalla sobre el DGV
        dataBin.Filter = "NombreCompleto LIKE '%" & txtBuscador.Text & "%' OR NumeroDocumento LIKE '" & txtBuscador.Text & "%'"
    End Sub
#End Region

#Region "Metodos"
    ''' <summary>
    ''' Metodo que sirve para consultar la base de datos y llenar el DGV con los registros encontrados
    ''' </summary>
    Public Sub ActualizarDGV()
        'Creo nuevos objetos y vuelvo a llenar una tabla para mostrar el registro que fue agregado
        Dim pacientes As New ePaciente
        Dim tablaPac As New DataTable
        'Lleno la tabla
        pacientes.obtenerRegistros(tablaPac, query)

        'Guardo la tabla en el BindingSource
        dataBin.DataSource = tablaPac

        'Se la asigno al DGV asi lo actualizo
        dgvListadoPacientes.DataSource = dataBin
        'Ordeno el DGV por nombre
        dgvListadoPacientes.Sort(dgvListadoPacientes.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        'Limpio la seleccion actual
        dgvListadoPacientes.ClearSelection()
    End Sub
#End Region
End Class