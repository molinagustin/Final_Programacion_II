Imports CapaPresentacionUsuarios
Imports entUsuario
Imports SimpleCrypto
Public Class frmCambioContrasenia
#Region "Campos"
    'Tipos de formularios
    Public Enum TipoFormu
        CambioLogin
        CambioAdmin
    End Enum

    Private _TipoFormulario As TipoFormu
    Private _IdUsuario As Integer

    'Usuario orginal (Para modificaiones)
    Dim _UsuarioOriginal As New eUsuario
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

    Public Property IdUsuario As Integer
        Get
            Return _IdUsuario
        End Get
        Set(value As Integer)
            _IdUsuario = value
        End Set
    End Property
#End Region

#Region "Eventos"
    Private Sub frmCambioContrasenia_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If TipoFormulario = TipoFormu.CambioLogin Then
                'Muestro todos los controles

            ElseIf TipoFormulario = TipoFormu.CambioAdmin Then
                'Deshabilito los controles apropiados
                lblContraVieja.Visible = False
                lblContraVieja.Enabled = False
                txtContraVieja.Visible = False
                txtContraVieja.Enabled = False
                txtNombreUsuario.ReadOnly = True

                'Obtengo los datos de la base de datos del usuario a modificar
                _UsuarioOriginal.obtenerRegistro(IdUsuario)
                'Se lo asigno solamente al nombre de usuario
                txtNombreUsuario.Text = _UsuarioOriginal.Usuario
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
            'Si el cambio de contraseña proviene del usuario en el login
            If TipoFormulario = TipoFormu.CambioLogin Then
                'Creo dos objetos para el usuario y la contraseña vieja
                Dim usuario As String = txtNombreUsuario.Text.Trim()
                Dim contraVieja As String = txtContraVieja.Text.Trim()

                'Primero compruebo que el usuario y la contraseña vieja no esten vacios y que sean correctos
                If (usuario IsNot "" And contraVieja IsNot "") Then
                    'Creo un objeto usuario y llamo a su metodo para obtener datos del usuario en cuestion, si es que existe, de la base de datos
                    Dim usu As New eUsuario
                    usu.obtenerUsuario(usu, usuario)

                    'Compruebo que el Id del usuario sea valido
                    If (usu.IdUsuario > 0) Then
                        'Creamos un objeto del tipo PBKDF2 (simple crypto) que contiene funciones para encriptar la contraseña y generar los SALT y HASH
                        Dim cryptoService As New PBKDF2

                        'Procedemos a encriptar la contraseña vieja pasada en el formulario
                        Dim contraseniaViejaEncriptada As String = cryptoService.Compute(contraVieja, usu.SaltContrasenia)

                        'Comparamos la contraseña de la BD con la encriptada en el formulario (El metodo usado del CRYPTOSERVICE devuelve un Booleano)
                        If (cryptoService.Compare(usu.HashContrasenia, contraseniaViejaEncriptada)) Then
                            'Creamos objetos para comparar las contraseñas en los text box
                            Dim contrasenia As String = txtContraNueva1.Text.Trim()
                            Dim contrasenia2 As String = txtContraNueva2.Text.Trim()

                            'Las comparamos
                            If contrasenia = contrasenia2 And Not contrasenia = "" And Not contrasenia2 = "" Then
                                'Guardo el Id del usuario
                                Dim idUsuario As Integer = usu.IdUsuario
                                'Obtengo los datos del usuario original para mantener los que no van a ser cambiados
                                Dim _UsuarioOriginal As New eUsuario
                                _UsuarioOriginal.obtenerRegistro(idUsuario)

                                'Creo un objeto que contendra los datos modificados mas lo que no han sido modificados
                                Dim usuarioModificado As New eUsuario

                                'Obtengo los valores de la base de datos
                                usuarioModificado.obtenerRegistro(idUsuario)

                                'Creamos un objeto del tipo PBKDF2 (simple crypto) que contiene funciones para encriptar la contraseña y generar los SALT y HASH
                                Dim cryptoServices As New PBKDF2

                                'Generar algoritmo de encriptacion (salt es el algoritmo que mezclado con la contraseña comun creara la nueva contraseña cifrada). El salt queda guardado del objeto cryptoService, por eso tenemos que guardarlo en un objeto para luego poder usarlo y comparar con la contraseña entrante en el login.
                                Dim salt As String = cryptoServices.GenerateSalt()

                                'Ahora con el SALT y la contraseña escrita procedemos a Encriptarla (generar lo que se llama HASH contraseña)
                                Dim contraseniaEncriptada As String = cryptoServices.Compute(contrasenia)

                                'Guardo los valores en el objeto Usuario modificado creado
                                With usuarioModificado
                                    .SaltContrasenia = salt
                                    .HashContrasenia = contraseniaEncriptada
                                End With

                                'Creo un objeto para comprobar si los registros fueron modificados (dara mayor a 0 si fue modificado). Llamo a la funcion desde el objeto viejo porque es necesario que sea tomado como parametro implicito tambien (esta dentro de la funcion) asi ésta podra comparar ambos objetos y sus valores.
                                Dim registro As Integer = _UsuarioOriginal.actualizarRegistro(usuarioModificado)

                                'Si fue modificado con exito pasa de largo, caso contrario avisa del error
                                If Not registro = 1 Then
                                    Throw New Exception("El contraseña no pudo ser actualizada")
                                End If
                            Else
                                Throw New Exception("Las contraseñas nuevas deben ser iguales y no estar vacias")
                            End If
                        Else
                                Throw New Exception("Contraseña Vieja y/o Usuario invalido")
                        End If
                    Else
                        Throw New Exception("Contraseña Vieja y/o Usuario invalido")
                    End If
                Else
                    Throw New Exception("Campos Incompletos")
                End If

                'Si el cambio de contraseña proviene del administrador
            ElseIf TipoFormulario = TipoFormu.CambioAdmin Then
                'Creamos objetos para comparar las contraseñas en los text box
                Dim contrasenia As String = txtContraNueva1.Text.Trim()
                Dim contrasenia2 As String = txtContraNueva2.Text.Trim()

                'Las comparamos
                If contrasenia = contrasenia2 And Not contrasenia = "" And Not contrasenia2 = "" Then
                    'Creo un objeto que contendra los datos modificados mas lo que no han sido modificados
                    Dim usuarioModificado As New eUsuario

                    'Obtengo los valores de la base de datos
                    usuarioModificado.obtenerRegistro(IdUsuario)

                    'Creamos un objeto del tipo PBKDF2 (simple crypto) que contiene funciones para encriptar la contraseña y generar los SALT y HASH
                    Dim cryptoService As New PBKDF2

                    'Generar algoritmo de encriptacion (salt es el algoritmo que mezclado con la contraseña comun creara la nueva contraseña cifrada). El salt queda guardado del objeto cryptoService, por eso tenemos que guardarlo en un objeto para luego poder usarlo y comparar con la contraseña entrante en el login.
                    Dim salt As String = cryptoService.GenerateSalt()

                    'Ahora con el SALT y la contraseña escrita procedemos a Encriptarla (generar lo que se llama HASH contraseña)
                    Dim contraseniaEncriptada As String = cryptoService.Compute(contrasenia)

                    'Guardo los valores en el objeto Usuario creado
                    With usuarioModificado
                        .SaltContrasenia = salt
                        .HashContrasenia = contraseniaEncriptada
                    End With

                    'Creo un objeto para comprobar si los registros fueron modificados (dara mayor a 0 si fue modificado). Llamo a la funcion desde el objeto viejo porque es necesario que sea tomado como parametro implicito tambien (esta dentro de la funcion) asi ésta podra comparar ambos objetos y sus valores.
                    Dim registro As Integer = _UsuarioOriginal.actualizarRegistro(usuarioModificado)

                    'Si fue modificado con exito pasa de largo, caso contrario avisa del error
                    If Not registro = 1 Then
                        Throw New Exception("El contraseña no pudo ser actualizada")
                    End If
                Else
                    Throw New Exception("Las contraseñas deben ser iguales y no estar vacias")
                End If
            End If

            'Confirmo el formulario
            DialogResult = DialogResult.OK

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, Text)
        End Try
    End Sub

    'Evento que se lanza al pulsar una tecla sobre el textbox
    Private Sub txtNombreUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreUsuario.KeyPress
        CaracterNumerico(e)
    End Sub
#End Region

#Region "Metodos"
    Public Sub CaracterNumerico(e As KeyPressEventArgs)
        'Pregunto si es numerico el valor de la tecla presionada , de ser asi muestro no muestro el valor
        'El handled me indica que tomara lo que tecleamos y si es false lo dejara pasar, pero si es True lo toma y no me lo muestra
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub
#End Region
End Class