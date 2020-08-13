Imports entTurnos
Imports entPaciente
Imports entProfesionales
Public Class frmTurnos
#Region "Campos"
    'Creo una estructura de datos, que me permite mantener una serie de variables con valores estaticos para usar al momento de llenar el DGV para crear las filas de los horarios
    Structure Horarios
        Public mHoraInicio As Date
        Public mHoraFin As Date
        Public tHoraInicio As Date
        Public tHoraFin As Date
        'Variable que sirve para realizar los bucles al momento de mostrar los horarios
        Public Intervalo As Int16
    End Structure

    'Dejo un objeto asignado pero no instanciado
    Public horasTurnos As Horarios

    'Id para tener que seleccionar un registro al asignar o borrar un turno
    Private _filaNum As Integer = -1

    'Usuario actual
    Private _IdUsuAct As Integer

    'Paciente y Profesional seleccionado
    Private _IdPacTur As Integer = -1
    Private _IdProfTur As Integer = -1
    'Guado tambien el nombre para no hacer consultas a una entidad distinta de turnos
    Private _NombreProfTur As String

    'Guardo el Id del Turno
    Private _IdTur As Integer = -1

    'Guardo el color de celda de un turno asignado
    Dim colorCelda As Boolean = False
#End Region

#Region "Propiedades"
    Public Property filaNum As Integer
        Get
            Return _filaNum
        End Get
        Set(value As Integer)
            _filaNum = value
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

    Public Property IdPacTur As Integer
        Get
            Return _IdPacTur
        End Get
        Set(value As Integer)
            _IdPacTur = value
        End Set
    End Property

    Public Property IdProfTur As Integer
        Get
            Return _IdProfTur
        End Get
        Set(value As Integer)
            _IdProfTur = value
        End Set
    End Property

    Public Property NombreProfTur As String
        Get
            Return _NombreProfTur
        End Get
        Set(value As String)
            _NombreProfTur = value
        End Set
    End Property

    Public Property IdTur As Integer
        Get
            Return _IdTur
        End Get
        Set(value As Integer)
            _IdTur = value
        End Set
    End Property
#End Region

#Region "Eventos"
    Private Sub frmTurnos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Deshabilito controles apropiados para que el usuario tenga que seleccionar un profesional primero
            Controles(False)

            'Establezco los horarios en que quiero que se puedan asignar turnos
            With horasTurnos
                .mHoraInicio = "#1/1/0001 07:30:00 AM#"
                .mHoraFin = "#1/1/0001 01:00:00 PM#"
                .tHoraInicio = "#1/1/0001 05:00:00 PM#"
                .tHoraFin = "#1/1/0001 09:00:00 PM#"
                .Intervalo = "30"
            End With

            'Muestro los horarios vacios para dar una mejor apareciencia a la vista
            construirHorarios()

            'Cambio el tamaño de la fuente del encabezado de las columnas
            dgvTurnos.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 15, FontStyle.Bold)

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, Text)
        End Try
    End Sub

    'Al hacer click sobre el formulario, se limpia la seleccion del DGV
    Private Sub frmTurnos_Click(sender As Object, e As EventArgs) Handles Me.Click
        'Borro la seleccion
        dgvTurnos.ClearSelection()
        'Reestablezco el numero de fila
        filaNum = -1
    End Sub

    'Cuando se muestra el formulario (luego del evento LOAD que carga todo lo necesario), procede a mostrar el listado de profesionales con el evento CLICK del btnBuscarProfes
    Private Sub frmTurnos_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Muestro inicialmente la busqueda de profesionales para facilitar su uso
        btnBuscarProfes_Click()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'Cierro el formulario
        Close()
    End Sub

    Private Sub btnBorrarTurno_Click(sender As Object, e As EventArgs) Handles btnBorrarTurno.Click
        'Compruebo que se haya seleccionado un registro y que la fecha del turno sea posterior o igual a la fecha actual
        Try
            If filaNum > -1 Then
                If dtpFechaTurno.Value.Date >= Today.Date Then
                    'Compruebo que la fila con el horario este disponible (con la celda del IdPaciente)
                    If dgvTurnos.Rows(filaNum).Cells(2).Value > 0 Then
                        'Creo un nuevo objeto y le asigno el resultado del MessageBox creado
                        Dim resultado As DialogResult = MessageBox.Show("¿Seguro desea dar de baja el turno seleccionado?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                        'Si se confirma la accion, se da de baja el registro
                        If resultado = DialogResult.Yes Then
                            'Creo 2 objetos iguales con el mismo id del que se quiere dar de baja y le asigno los mismos valores que ya tiene, pero le cambio a uno la propiedad Activo que sera lo que se modificara para darse de baja
                            Dim turno As New eTurnos
                            Dim turnoBaja As New eTurnos
                            turno.obtenerRegistro(IdTur)
                            turnoBaja.obtenerRegistro(IdTur)

                            'Guardo el usuario actual y pongo activo en 0 para ocultarlo (darlo de baja)
                            turnoBaja.IdUsuario = IdUsuAct
                            turnoBaja.Activo = 0

                            'Llamo a la funcion que me permite actualizar registros y guardo el resultado si fue actualizado con exito
                            Dim registro As Integer = turno.actualizarRegistro(turnoBaja)

                            If registro = 1 Then
                                'Actualizo el DGV
                                ActualizarDGV()
                                'Reestablezco el id de la fila
                                filaNum = -1
                                MsgBox("BAJA REALIZADA CON EXITO", MsgBoxStyle.Information, "TURNOS")
                            Else
                                Throw New Exception("No se pudo realizar la baja")
                            End If
                        End If
                    Else
                        Throw New Exception("Debe seleccionar un registro con un turno activo")
                    End If
                Else
                    Throw New Exception("No se puede dar de baja turnos pasados")
                End If
            Else
                Throw New Exception("Debe seleccionar un registro para darlo de baja")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Text)
        End Try
    End Sub

    Private Sub btnBuscarProfes_Click() Handles btnBuscarProfes.Click
        'Creo un nuevo objeto y lo muestro como dialogo para buscar al profesional
        Dim profesional As New frmDialogoPro

        With profesional
            .Text = "LISTADO DE PROFESIONALES"
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                'Guardo los datos del profesional seleccionado
                IdProfTur = .IdProfe
                NombreProfTur = .NombreProfe
                'Cambio el nombre del Label
                lblTurnos.Text = "GESTION DE TURNOS DE " & NombreProfTur.ToUpper
                'Muestro los controles deshabilitados
                Controles(True)

                'Actualizo el DGV
                ActualizarDGV()
            End If
        End With
    End Sub

    'Evento para atrasar en 1 dia la fecha
    Private Sub btnFechaAnt_Click(sender As Object, e As EventArgs) Handles btnFechaAnt.Click
        'Por medio de la funcion DateAdd vamos restando de a 1 dia al DTP cuando se lanza el evento
        dtpFechaTurno.Value = DateAdd(DateInterval.Day, -1, dtpFechaTurno.Value)
    End Sub

    'Evento para adelantar en 1 dia la fecha
    Private Sub btnFechaSig_Click(sender As Object, e As EventArgs) Handles btnFechaSig.Click
        'Por medio de la funcion DateAdd vamos agregando de a 1 dia al DTP cuando se lanza el evento
        dtpFechaTurno.Value = DateAdd(DateInterval.Day, 1, dtpFechaTurno.Value)
    End Sub

    'Evento para reestablecer la fecha
    Private Sub btnFechaAct_Click(sender As Object, e As EventArgs) Handles btnFechaAct.Click
        'Reestablecemos la fecha
        dtpFechaTurno.Value = Now
    End Sub

    'Cada vez que cambie la fecha del Date Time Picker
    Private Sub dtpFechaTurno_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaTurno.ValueChanged
        'Actualizo el DGV
        ActualizarDGV()
    End Sub

    'Evento que se lanzara cuando se haga click en una celda del DGV
    Private Sub dgvTurnos_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvTurnos.CellMouseClick
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Guardo el numero de fila que seleccione
            filaNum = e.RowIndex

            'Si hay un turno asignado, guardo el id de dicho turno
            Dim regTurno As Int16 = dgvTurnos.Rows(filaNum).Cells(0).Value

            If regTurno > -1 Then
                IdTur = regTurno
            End If
        End If
    End Sub

    'Evento que se lanzara cuando se haga doble click sobre una celda
    Private Sub dgvTurnos_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvTurnos.CellMouseDoubleClick
        Try
            'Si el DGV tiene mas de una celda entra al comparador
            If e.RowIndex > -1 Then
                'Guardo el numero de fila que seleccione
                filaNum = e.RowIndex

                'Compruebo que se haya seleccionado un profesional
                If IdProfTur > -1 Then
                    'Compruebo que la fecha sea la correcta
                    If dtpFechaTurno.Value.Date >= Today.Date Then
                        'Compruebo que la fila con el horario este disponible (con la celda del IdPaciente)
                        If Not dgvTurnos.Rows(filaNum).Cells(2).Value > 0 Then

                            'Creo un nuevo objeto y lo muestro como dialogo para buscar al paciente
                            Dim paciente As New frmDialogoPac

                            With paciente
                                .Text = "LISTADO DE PACIENTES"
                                .ShowDialog()
                                If .DialogResult = DialogResult.OK Then
                                    'Guardo el ID del paciente seleccionado
                                    IdPacTur = .IdPaci

                                    'Creo un nuevo objeto para guardar los datos del turno
                                    Dim nuevoTurno As New eTurnos

                                    'Guardo los valores
                                    With nuevoTurno
                                        'celda de horario
                                        .HoraTurno = dgvTurnos.Rows(filaNum).Cells(1).Value
                                        .Fecha = dtpFechaTurno.Value.Date
                                        .Paciente = IdPacTur
                                        .Profesional = IdProfTur
                                        .Activo = 1
                                        .IdUsuario = IdUsuAct
                                    End With

                                    'Llamo al metodo para agregar el registro y le paso el objeto con los datos
                                    nuevoTurno.insertarRegistro(nuevoTurno)

                                    'Actualizo el DGV
                                    ActualizarDGV()

                                    'Limpio los controles usados
                                    LimpiarControles()
                                End If
                            End With
                        Else
                            Throw New Exception("El turno ya fue asignado a un Paciente")
                        End If
                    Else
                        Throw New Exception("No se puede dar turnos en dias pasados")
                    End If
                Else
                    Throw New Exception("Debe seleccionar un profesional")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Text)
        End Try
    End Sub

    'Evento que se lanza al terminarse el enlace de datos
    Private Sub dgvTurnos_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvTurnos.DataBindingComplete
        'Limpio la seleccion actual 
        dgvTurnos.ClearSelection()
    End Sub

    'Evento que se lanza cuando el mouse entra en una celda
    Private Sub dgvTurnos_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTurnos.CellMouseEnter
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Si el back color de la celda no es light green entro (quiere decir que es un turno asignado)
            If dgvTurnos.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Aqua Then
                colorCelda = True
            End If
            'Cambio el back color de la fila
            dgvTurnos.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Aquamarine
        End If
    End Sub

    'Evento que se lanza cuando el mouse sale de una celda
    Private Sub dgvTurnos_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTurnos.CellMouseLeave
        'Si el DGV tiene mas de una celda entra al comparador
        If e.RowIndex > -1 Then
            'Si el color de la celda era verde (un turno) vuelvo a colocarselo
            If colorCelda Then
                dgvTurnos.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Aqua
                'Restablezco el booleano
                colorCelda = False
            Else
                'Sino pongo en blanco el back color
                dgvTurnos.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            End If
        End If
    End Sub
#End Region

#Region "Metodos"
    ''' <summary>
    ''' Metodo que sirve para reestablecer el valor de los controles usados
    ''' </summary>
    Public Sub LimpiarControles()
        IdPacTur = -1
        filaNum = -1
    End Sub

    ''' <summary>
    ''' Metodo que sirve para actualizar el DGV
    ''' </summary>
    Public Sub ActualizarDGV()
        'Procedo a comenzar limpiando todas las filas del DGV por si hubiese algun registro introducido a ser borrado
        dgvTurnos.Rows.Clear()

        'Vuelvo a construir los horarios pero sin datos de pacientes o profesionales de los turnos
        construirHorarios()

        'Creo nuevos objetos y vuelvo a llenar una tabla para mostrar los registros que hubiesen en la base de datos
        Dim turnos As New eTurnos
        Dim tabla As New DataTable

        'Lleno la tabla (le asigno la tabla, el valor de fecha puesto en el date time picker y el Id del profesional seleccionado)
        turnos.ObtenerTurnos(tabla, dtpFechaTurno.Value.Date, IdProfTur)

        'Guardo el numero de fila del DGV
        Dim numFila As Integer = 0

        'Recorro todas las filas activas del DGV
        For Each filaDGV As DataGridViewRow In dgvTurnos.Rows

            'Recorro todas las filas del datatable que llene con los turnos
            For Each filaTabla As DataRow In tabla.Rows

                'Si el contenido de HoraTurno del turno es igual al horario en la fila del DGV, continuo
                If (filaTabla("HoraTurno") = filaDGV.Cells("HoraTurno").Value) Then

                    'Obtengo los datos del paciente
                    Dim pac As New ePaciente
                    pac.obtenerRegistro(filaTabla("Paciente"), "Pacientes", "IdPaciente")

                    'Coloco el Id del Turno
                    dgvTurnos.Rows(numFila).Cells(0).Value = filaTabla("IdTurno")
                    'Coloco el Id del Paciente
                    dgvTurnos.Rows(numFila).Cells(2).Value = pac.IdPaciente
                    'Muestro el nombre del Paciente
                    dgvTurnos.Rows(numFila).Cells(3).Value = pac.NombreCompleto

                    'Cambio el color de la fila para dar un estilo visual de que en ese horario ya hay un turno
                    dgvTurnos.Rows(numFila).DefaultCellStyle.BackColor = Color.Aqua

                    'Salgo del for each de la tabla
                    Exit For
                End If
            Next

            'Sumo una nueva fila
            numFila += 1
        Next

        'Limpio la seleccion actual 
        dgvTurnos.ClearSelection()
    End Sub

    ''' <summary>
    ''' Metodo que sirve para activar o desactivar controles
    ''' </summary>
    ''' <param name="accion">Booleano que correspondera a si un control esta activado o no</param>
    Public Sub Controles(accion As Boolean)
        dtpFechaTurno.Enabled = accion
        btnFechaAnt.Enabled = accion
        btnFechaAct.Enabled = accion
        btnFechaSig.Enabled = accion
        btnBorrarTurno.Enabled = accion
    End Sub

    ''' <summary>
    ''' Metodo que permite mostrar los horarios de turnos en el DGV
    ''' </summary>
    Public Sub construirHorarios()
        'Guardo la hora en que comienzan los turnos del dia
        Dim hora As Date = horasTurnos.mHoraInicio

        'Hago un bucle Do While para construir las filas de los turnos por la mañana
        Do
            'Guardo en numero de fila en que me voy a posicionar
            Dim fila As Int16 = dgvTurnos.Rows().Count

            'Agrego una nueva fila a continuacion de la ultima
            dgvTurnos.Rows.Add()

            'Y en dicha fila, en el valor de celda 1 (la segunda celda) coloco el valor de hora que corresponde (formateo el texto para que sea del tipo de HORARIOS con "HH:mm" (horas y minutos))
            dgvTurnos.Rows(fila).Cells(1).Value = hora.ToString("HH:mm")

            'A la hora que tenia en un principio le sumo los minutos declarados en el Intervalo de la Estructura creada
            hora = hora.AddMinutes(horasTurnos.Intervalo)

            'Se realizara el bucle hasta que la hora sea igual al horarios de fin de turnos por la mañana mas una ultima suma del intervalo declarado (entonces solo representara hasta el horario de fin de turnos)
        Loop Until hora = horasTurnos.mHoraFin.AddMinutes(horasTurnos.Intervalo)

        'Con los turnos de la tarde realizo el mismo procedimiento, solo que la hora sera en la que comienzan los turnos de tarde y llegara hasta el horario de finalizacion de turnos de tarde
        hora = horasTurnos.tHoraInicio
        Do
            Dim fila As Int16 = dgvTurnos.Rows().Count
            dgvTurnos.Rows.Add()
            dgvTurnos.Rows(fila).Cells(1).Value = hora.ToString("HH:mm")
            hora = hora.AddMinutes(horasTurnos.Intervalo)

        Loop Until hora = horasTurnos.tHoraFin.AddMinutes(horasTurnos.Intervalo)
    End Sub
#End Region
End Class