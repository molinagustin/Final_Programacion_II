Imports CapaPresentacionPersonas
Imports CapaPresentacionObrasSociales
Imports CapaPresentacionLocalidades
Imports CapaPresentacionUsuarios
Public Class frmVistaPrincipal
#Region "Campos"
    'Uso un enum para facilitar la lectura de privilegios
    Public Enum TipoPrivi
        Administrador = 1
        Usuario = 2
        Invitado = 4
    End Enum

    'Creo el campo para guardar el privilegio del usuario
    Private _PrivilegioUsuario As Integer
    Private _TipoPrivilegio As New TipoPrivi

    'Guardo el id del usuario para usarlo en sus movimientos por el programa
    Public _IdUsuActual As Integer
#End Region

#Region "Propiedades"
    Public Property PrivilegioUsuario As Integer
        Set(value As Integer)
            _PrivilegioUsuario = value
        End Set
        Get
            Return _PrivilegioUsuario
        End Get
    End Property

    Public Property TipoPrivilegio As TipoPrivi
        Set(value As TipoPrivi)
            _TipoPrivilegio = value
        End Set
        Get
            Return _TipoPrivilegio
        End Get
    End Property

    Public Property IdUsuActual As Integer
        Get
            Return _IdUsuActual
        End Get
        Set(value As Integer)
            _IdUsuActual = value
        End Set
    End Property
#End Region

#Region "Eventos"
    Private Sub frmVistaPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Segun el privilegio del usuario seran los menus a mostrar
        If PrivilegioUsuario = TipoPrivi.Administrador Then
            'Ninguna restriccion
        ElseIf PrivilegioUsuario = TipoPrivi.Usuario Then
            'Usuarios
            USUARIOSToolStripMenuItem.Enabled = False
        ElseIf PrivilegioUsuario = TipoPrivi.Invitado Then
            USUARIOSToolStripMenuItem.Enabled = False
            'Historias Clinicas
            NUEVAToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        'Cierro el programa y todas sus instancias ocultas (como el Login).
        End
    End Sub

    'PACIENTES (HISTORAIS CLINICAS)
    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click
        'Si el formulario no esta abierto ingresa al IF
        If Not AbrirFormularioHijo("CONSULTA DE HISTORIAS CLINICAS") Then
            'Creo un nuevo objeto para usarlo
            Dim nuevoHijo As New frmVistaPacientes
            'Le paso el usuario actual
            nuevoHijo.IdUsuAct = IdUsuActual
            'Creo el nuevo formulario
            CrearFormularioHijo(nuevoHijo, "CONSULTA DE HISTORIAS CLINICAS")
        End If
    End Sub

    'PROFESIONALES
    Private Sub CONSULTAToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CONSULTAToolStripMenuItem1.Click
        'Si el formulario no esta abierto ingresa al IF
        If Not AbrirFormularioHijo("CONSULTA DE PROFESIONALES") Then
            'Creo un nuevo objeto para usarlo
            Dim nuevoHijo As New frmVistaProfesionales
            'Le paso el usuario actual
            nuevoHijo.IdUsuAct = IdUsuActual
            'Creo el nuevo formulario
            CrearFormularioHijo(nuevoHijo, "CONSULTA DE PROFESIONALES")
        End If
    End Sub

    'TURNOS
    Private Sub CONSULTAToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles CONSULTAToolStripMenuItem4.Click
        'Si el formulario no esta abierto ingresa al IF
        If Not AbrirFormularioHijo("GESTION DE TURNOS") Then
            'Creo un nuevo objeto para usarlo
            Dim nuevoHijo As New frmTurnos
            'Le paso el usuario actual
            nuevoHijo.IdUsuAct = IdUsuActual
            'Creo el nuevo formulario
            CrearFormularioHijo(nuevoHijo, "GESTION DE TURNOS")
        End If
    End Sub

    'CONSULTA DE VISITAS
    Private Sub CONSULTAToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles CONSULTAToolStripMenuItem7.Click
        'Si el formulario no esta abierto ingresa al IF
        If Not AbrirFormularioHijo("CONSULTA DE VISITAS") Then
            'Creo un nuevo objeto para usarlo
            Dim nuevoHijo As New frmDetalleMaestroPacientes
            'Le paso el usuario actual
            nuevoHijo.IdUsuAct = IdUsuActual
            'Creo el nuevo formulario
            CrearFormularioHijo(nuevoHijo, "CONSULTA DE VISITAS")
        End If
    End Sub

    'NUEVA VISITA
    Private Sub NUEVAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NUEVAToolStripMenuItem.Click
        'Si el formulario no esta abierto ingresa al IF
        If Not AbrirFormularioHijo("NUEVA VISITA") Then
            'Creo un nuevo objeto para usarlo
            Dim nuevoHijo As New frmHistoriasClinicas
            'Indico de que tipo sera el formulario
            nuevoHijo.TipoFormulario = frmHistoriasClinicas.TipoFormu.Nuevo
            'Le paso el usuario actual
            nuevoHijo.IdUsuAct = IdUsuActual
            'Creo el nuevo formulario
            CrearFormularioHijo(nuevoHijo, "NUEVA VISITA")
        End If
    End Sub

    'OBRAS SOCIALES
    Private Sub CONSULTAToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles CONSULTAToolStripMenuItem8.Click
        'Si el formulario no esta abierto ingresa al IF
        If Not AbrirFormularioHijo("CONSULTA DE OBRAS SOCIALES") Then
            'Creo un nuevo objeto para usarlo
            Dim nuevoHijo As New frmVistaOS
            'Le paso el usuario actual
            nuevoHijo.IdUsuAct = IdUsuActual
            'Creo el nuevo formulario
            CrearFormularioHijo(nuevoHijo, "CONSULTA DE OBRAS SOCIALES")
        End If
    End Sub

    'LOCALIDADES
    Private Sub CONSULTAToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CONSULTAToolStripMenuItem3.Click
        'Si el formulario no esta abierto ingresa al IF
        If Not AbrirFormularioHijo("CONSULTA DE LOCALIDADES") Then
            'Creo un nuevo objeto para usarlo
            Dim nuevoHijo As New frmVistaLocalidades
            'Le paso el usuario actual
            nuevoHijo.IdUsuAct = IdUsuActual
            'Creo el nuevo formulario
            CrearFormularioHijo(nuevoHijo, "CONSULTA DE LOCALIDADES")
        End If
    End Sub

    'USUARIOS
    Private Sub CONSULTAToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CONSULTAToolStripMenuItem2.Click
        'Si el formulario no esta abierto ingresa al IF
        If Not AbrirFormularioHijo("CONSULTA DE USUARIOS") Then
            'Creo un nuevo objeto para usarlo
            Dim nuevoHijo As New frmVistaUsuarios
            'Le paso el usuario actual
            nuevoHijo.IdUsuAct = IdUsuActual
            'Creo el nuevo formulario
            CrearFormularioHijo(nuevoHijo, "CONSULTA DE USUARIOS")
        End If
    End Sub

    'REACTIVAR PACIENTES
    Private Sub PACIENTESToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PACIENTESToolStripMenuItem1.Click
        'Creo un nuevo objeto de reactivacion
        Dim dialogo As New frmReactivacionPac
        dialogo.IdUsuAct = IdUsuActual
        'Lo muestro
        Reactivacion(dialogo)
    End Sub

    'REACTIVAR PROFESIONALES
    Private Sub PROFESIONALESToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PROFESIONALESToolStripMenuItem1.Click
        'Creo un nuevo objeto de reactivacion
        Dim dialogo As New frmReactivacionProf
        dialogo.IdUsuAct = IdUsuActual
        'Lo muestro
        Reactivacion(dialogo)
    End Sub

    'REACTIVAR OBRAS SOCIALES
    Private Sub OBRASSOCIALESToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OBRASSOCIALESToolStripMenuItem1.Click
        'Creo un nuevo objeto de reactivacion
        Dim dialogo As New frmReactivacionOS
        dialogo.IdUsuAct = IdUsuActual
        'Lo muestro
        Reactivacion(dialogo)
    End Sub

    'REACTIVAR USUARIOS
    Private Sub USUARIOSToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles USUARIOSToolStripMenuItem1.Click
        'Creo un nuevo objeto de reactivacion
        Dim dialogo As New frmReactivacionUsu
        'Lo muestro
        Reactivacion(dialogo)
    End Sub

    'Evento para redimensionar la imagen del formulario segun varie el tamaño del mismo
    Private Sub frmVistaPrincipal_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'Al control que contiene la imagen, le cambio el tamaño segun cambie el tamaño del formulario
        pbxImagenConsultorio.Height = Size.Height
        pbxImagenConsultorio.Width = Size.Width - 15 'Le aplico un pequeño factor de correccion
    End Sub

    'Cuando se activa un hijo de este formulario
    Private Sub frmVistaPrincipal_MdiChildActivate(sender As Object, e As EventArgs) Handles Me.MdiChildActivate
        'Oculto la imagen
        pbxImagenConsultorio.Visible = False
    End Sub

    'Cuando el foco vuelve al formulario
    Private Sub frmVistaPrincipal_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        'Vuelvo a mostrar la imagen
        pbxImagenConsultorio.Visible = True
    End Sub

    'Evento que deshabilita la posibilidad de cerrar el programa desde el menu del formulario asi no quedan subprocesos en ejecucion
    Private Sub frmVistaPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Si la razon por la que se esta cerrando el formulario es porque el usuario hizo click en el menu del formulario o con ALT+F4 o desde la barra de tareas, cancela dicha interaccion
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
        End If
    End Sub
#End Region

#Region "Funciones"
    ''' <summary>
    ''' Funcion que permite detectar si un formulario hijo esta abierto dentro de uno padre
    ''' </summary>
    ''' <param name="NombreFormu">Nombre del formulario hijo</param>
    ''' <returns></returns>
    Function AbrirFormularioHijo(NombreFormu As String) As Boolean
        'Variable que indicara si se encontro algun formulario que cumpla con las condiciones dadas
        Dim bandera As Boolean
        'Objeto que contendra el formulario hijo que se estara analizando
        Dim formu As New Form

        'Preguntamos si existe algun formulario hijo en la coleccion de formularios hijos del frmPrincipal
        If Me.MdiChildren.Count > 0 Then
            'Recorremos todos los formularios hijos del frmPrincipal
            For Each formu In Me.MdiChildren
                'Consultamos si el formulario hijo que se esta analizando cumple con la condicion de igualdad de la propiedad text pasado por parametro
                If formu.Text = NombreFormu Then
                    'Si el formulario hijo cumple con la condicion anterior colocamos en verdadero la variable bandera y salimos del bucle For Each...Next
                    bandera = True
                    Exit For
                End If
            Next
        End If

        'Preguntamos si bandera esta en verdadero (el formulario ya esta abierto)
        If bandera Then
            'Si el formulario ya esta abierto hacemos foco en el.
            formu.Focus()
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "Metodos"
    ''' <summary>
    ''' Metodo que permite crear un nuevo formulario hijo y asignarselo a un formulario padre
    ''' </summary>
    ''' <param name="frmHijo">Formulario a crear</param>
    ''' <param name="NombreFormu">Nombre del formulario hijo</param>
    Sub CrearFormularioHijo(ByRef frmHijo As Form, NombreFormu As String)
        'Si el formulario no se encuentra abierto, Instanciamos un objeto del tipo del formulario que queremos abrir, configuramos sus propiedades y lo abrimos
        With frmHijo
            .MdiParent = Me 'Le decimos que heredara propiedades del padre frmPrincipal
            .Text = NombreFormu
            .Show() 'Con este evento se muestra el formulario
        End With
    End Sub

    ''' <summary>
    ''' Metodo que abre un dialogo con los formularios de reactivacion creados
    ''' </summary>
    ''' <param name="formulario">Tipo de formulario a crear</param>
    Public Sub Reactivacion(ByRef formulario As Form)
        'Muestro el formulario apropiado
        With formulario
            .ShowDialog()
        End With
    End Sub
#End Region
End Class