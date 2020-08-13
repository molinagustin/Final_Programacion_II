Imports entUsuario
Imports entPrivilegio
Imports SimpleCrypto
Public Class frmGestionUsuarios
#Region "Campos"
    'Tipos de formularios
    Public Enum TipoFormu
        Nuevo
        Consulta
    End Enum

    Private _TipoFormulario As TipoFormu
    Private _IdUs As Integer

    'Usuario orginal (Para modificaiones)
    Dim _UsuarioOriginal As New eUsuario

    'Usuario actual
    Private _IdUsuAct As Integer
#End Region

#Region "Propiedades"
    Public Property TipoFormulario As TipoFormu
        Get
            Return _TipoFormulario
        End Get
        Set(value As TipoFormu)
            _TipoFormulario = value
        End Set
    End Property

    Public Property IdUs As Integer
        Get
            Return _IdUs
        End Get
        Set(value As Integer)
            _IdUs = value
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
#End Region

#Region "Eventos"
    Private Sub frmGestionUsuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Creo un nuevo objeto para los privilegios
            Dim privilegio As New ePrivilegio
            Dim tablaPriv As New DataTable

            'Lleno la tabla de privilegios (Si o si llenarla al principio)
            privilegio.ObtenerPrivilegios(tablaPriv)

            'Al combo box le asigno la fuente de datos y cuales datos mostrara (DisplayMember) y cuales tomara como referencia ante consultas (ValueMember)
            With cboTipoUsuario
                .DataSource = tablaPriv
                .DisplayMember = "Privilegios"
                .ValueMember = "IdPrivilegio"
            End With

            If TipoFormulario = TipoFormu.Nuevo Then
                'Cambio el titulo segun el formulario
                lblGestionUsuario.Text = "NUEVO USUARIO"

                'Deshabilitos los botones
                btnCambiarContra.Visible = False
                btnCambiarContra.Enabled = False
                btnModificar.Visible = False
                btnBaja.Visible = False

            ElseIf TipoFormulario = TipoFormu.Consulta Then
                'Cambio el titulo segun el formulario
                lblGestionUsuario.Text = "CONSULTA DE USUARIO"

                txtNombreUsuario.ReadOnly = True
                txtContra1.ReadOnly = True
                txtContra2.ReadOnly = True

                'Obtengo los datos del usuario a modificar
                _UsuarioOriginal.obtenerRegistro(IdUs)
                'Se lo asigno a los controles
                txtNombreCompleto.Text = _UsuarioOriginal.Nombre
                txtNombreUsuario.Text = _UsuarioOriginal.Usuario
                cboTipoUsuario.SelectedValue = _UsuarioOriginal.IdPrivilegio

                'Dejo de solo lectura los controles que voy a mostrar
                habilitarControles(True, False)
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, Text)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'Cierro el formulario
        Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            'Si el tipo de formulario es de alta (Nuevo)
            If TipoFormulario = TipoFormu.Nuevo Then
                'Creamos objetos para comparar las contraseñas en los text box
                Dim contrasenia As String = txtContra1.Text.Trim()
                Dim contrasenia2 As String = txtContra2.Text.Trim()

                'Si son iguales las contraseñas procedo
                If contrasenia = contrasenia2 And Not contrasenia = "" And Not contrasenia2 = "" Then
                    'Creo un nuevo objeto para asignar todos los valores que se llenaron en los campos del formulario
                    Dim nuevoUsuario As New eUsuario

                    'Creamos un objeto del tipo PBKDF2 (simple crypto) que contiene funciones para encriptar la contraseña y generar los SALT y HASH
                    Dim cryptoService As New PBKDF2

                    'Generar algoritmo de encriptacion (salt es el algoritmo que mezclado con la contraseña comun creara la nueva contraseña cifrada). El salt queda guardado del objeto cryptoService, por eso tenemos que guardarlo en un objeto para luego poder usarlo y comparar con la contraseña entrante en el login.
                    Dim salt As String = cryptoService.GenerateSalt()

                    'Ahora con el SALT y la contraseña escrita procedemos a Encriptarla (generar lo que se llama HASH contraseña)
                    Dim contraseniaEncriptada As String = cryptoService.Compute(contrasenia)

                    'Guardo los valores en el objeto Usuario creado
                    With nuevoUsuario
                        .Nombre = txtNombreCompleto.Text.Trim()
                        .Usuario = txtNombreUsuario.Text.Trim()
                        .SaltContrasenia = salt
                        .HashContrasenia = contraseniaEncriptada
                        .IdPrivilegio = cboTipoUsuario.SelectedValue
                        .Activo = 1
                    End With

                    nuevoUsuario.insertarUsuario(nuevoUsuario)

                Else
                    Throw New Exception("Las contraseñas deben ser iguales y no estar vacias")
                End If

                'Si el formulario es para modificar un Usuario
            ElseIf TipoFormulario = TipoFormu.Consulta Then
                'Creo un objeto que contendra los datos modificados mas lo que no han sido modificados
                Dim usuarioModificado As New eUsuario

                'Obtengo los valores de la base de datos
                usuarioModificado.obtenerRegistro(IdUs)

                'Ahora le asigno los valores que fueron modificados
                With usuarioModificado
                    .Nombre = txtNombreCompleto.Text
                    .IdPrivilegio = cboTipoUsuario.SelectedValue
                End With

                'Creo un objeto para comprobar si los registros fueron modificados (dara mayor a 0 si fue modificado). Llamo a la funcion desde el objeto viejo porque es necesario que sea tomado como parametro implicito tambien (esta dentro de la funcion) asi ésta podra comparar ambos objetos y sus valores.
                Dim registro As Integer = _UsuarioOriginal.actualizarRegistro(usuarioModificado)

                'Si fue modificado con exito lo muestra por pantalla
                If registro = 1 Then
                    MsgBox("El registro fue actualizado correctamente", MsgBoxStyle.Information, "Usuarios")
                Else
                    Throw New Exception("El registro no pudo ser actualizado")
                End If
            End If

            'Confirmo el formulario
            DialogResult = DialogResult.OK

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, Text)
        End Try
    End Sub

    'Cuando se requiera cambiar la contraseña (porque el usuario la olvido u otra razon)
    Private Sub btnCambiarContra_Click(sender As Object, e As EventArgs) Handles btnCambiarContra.Click
        Try
            'Instancio un nuevo objeto del cambio de contraseñas
            Dim cambio As New frmCambioContrasenia
            'Le asigno las propiedades y lo muestro como dialogo
            With cambio
                .TipoFormulario = frmCambioContrasenia.TipoFormu.CambioAdmin
                .IdUsuario = IdUs
                .ShowDialog()
                If .DialogResult = DialogResult.OK Then
                    'Confirmo el formulario de gestion tambien para evitar problemas en la base de datos debido a que ya llene un objeto con los valores de contraseñas que estaban anteriores al cambio, y con las nuevas contraseñas en el objeto se hace conflicto al momento de actualizar
                    DialogResult = DialogResult.OK
                    MsgBox("La contraseña fue actualizada correctamente", MsgBoxStyle.Information, "USUARIOS")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Text)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            'Habilito los controles apropiados
            habilitarControles(False, True)

            'Deshabilito el boton de baja y modificacion
            btnModificar.Enabled = False
            btnBaja.Enabled = False

            Text = "MODIFICACION DE USUARIO"
            lblGestionUsuario.Text = "MODIFICAR USUARIO"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Text)
        End Try
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        Try
            If Not IdUsuAct = IdUs Then
                'Creo un nuevo objeto y le asigno el resultado del MessageBox creado
                Dim resultado As DialogResult = MessageBox.Show("¿Seguro desea dar de baja el registro actual?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                'Si se confirma la accion, se da de baja el registro
                If resultado = DialogResult.Yes Then
                    'Creo 2 objetos iguales con el mismo id del que se quiere dar de baja y le asigno los mismos valores que ya tiene, pero le cambio a uno la propiedad Activo que sera lo que se modificara para darse de baja
                    Dim usuario As New eUsuario
                    Dim usuarioBaja As New eUsuario
                    usuario.obtenerRegistro(IdUs)
                    usuarioBaja.obtenerRegistro(IdUs)

                    'Pongo su propiedad Activo en 0
                    usuarioBaja.Activo = 0

                    'Llamo a la funcion que me permite actualizar registros y guardo el resultado si fue actualizado con exito
                    Dim registro As Integer = usuario.actualizarRegistro(usuarioBaja)

                    If registro = 1 Then
                        'Muestro un mensaje 
                        MsgBox("BAJA REALIZADA CON EXITO", MsgBoxStyle.Information, "USUARIOS")
                        'Confirmo el dialogo  
                        DialogResult = DialogResult.OK
                    Else
                        Throw New Exception("No se pudo realizar la baja")
                    End If
                End If
            Else
                Throw New Exception("No puede dar de baja el usuario que esta utilizando")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Text)
        End Try
    End Sub

    Private Sub txtNombreCompleto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreCompleto.KeyPress
        CaracterNumerico(e)
    End Sub

    Private Sub txtNombreUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreUsuario.KeyPress
        CaracterNumerico(e)
    End Sub

    Private Sub cboTipoUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboTipoUsuario.KeyPress
        CaracterNumerico(e)
    End Sub
#End Region

#Region "Metodos"
    ''' <summary>
    ''' Metodo que captura un caracter numerico ingresado y no deja mostrarlo
    ''' </summary>
    ''' <param name="e"></param>
    Public Sub CaracterNumerico(e As KeyPressEventArgs)
        'Pregunto si es numerico el valor de la tecla presionada , de ser asi muestro no muestro el valor
        'El handled me indica que tomara lo que tecleamos y si es false lo dejara pasar, pero si es True lo toma y no me lo muestra
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    ''' <summary>
    ''' Metodo que permite habilitar o deshabilitar los controles del formulario
    ''' </summary>
    ''' <param name="accion1">Booleano que determina si los controles apropiados seran de solo lectura</param>
    ''' <param name="accion2">Booleano que determina si los controles apropiados estaran habilitados o no</param>
    Public Sub habilitarControles(accion1 As Boolean, accion2 As Boolean)
        'El boton es general
        btnAceptar.Enabled = accion2
        txtNombreCompleto.ReadOnly = accion1
        cboTipoUsuario.Enabled = accion2
        btnCambiarContra.Enabled = accion2
    End Sub
#End Region
End Class