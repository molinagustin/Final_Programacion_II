Imports CapaPresentacionUsuarios
Imports entUsuario
Imports SimpleCrypto
Imports EnviarCorreo
Public Class frmLogin
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            Dim usuario As String = txtUsuario.Text.Trim()
            Dim contra As String = txtContrasenia.Text.Trim()

            If (usuario IsNot "" And contra IsNot "") Then
                'Creo un objeto usuario y llamo a su metodo para obtener datos del usuario en cuestion, si es que existe, de la base de datos
                Dim usu As New eUsuario
                usu.obtenerUsuario(usu, usuario)

                'Compruebo que el Id del usuario sea valido
                If (usu.IdUsuario > 0) Then
                    'Creamos un objeto del tipo PBKDF2 (simple crypto) que contiene funciones para encriptar la contraseña y generar los SALT y HASH
                    Dim cryptoService As New PBKDF2
                    'Procedemos a encriptar la contraseña pasada en el LOGIN
                    Dim contraseniaEncriptada As String
                    'Utilizamos la contraseña y el salt obtenido del objeto usuario de la base de datos
                    contraseniaEncriptada = cryptoService.Compute(contra, usu.SaltContrasenia)

                    'Comparamos la contraseña de la BD con la encriptada en el LOGIN (El metodo usado del CRYPTOSERVICE devuelve un Booleano)
                    If (cryptoService.Compare(usu.HashContrasenia, contraseniaEncriptada)) Then
                        'Compruebo que se trate de un usuario activo
                        If usu.Activo = 1 Then
                            'Oculto el login
                            Hide()

                            'Creo un nuevo objeto del tipo EnviarCorreo para usar su metodo y poder enviarle un mensaje a los pacientes que tengan turnos el dia siguiente
                            Dim enviarCorreos As New clsEnviarCorreo
                            enviarCorreos.enviarCorreo()

                            'Creo un objeto del formulario principal y procedo a mostrarlo
                            Dim ingreso As New frmVistaPrincipal
                            With ingreso
                                .PrivilegioUsuario = usu.IdPrivilegio
                                .IdUsuActual = usu.IdUsuario
                                .Text = ingreso.Text & " - " & usu.Nombre
                                .Show()
                            End With
                        Else
                            Throw New Exception("El usuario no se encuentra activo. Contacte con el administrador de sistemas")
                        End If
                    Else
                        Throw New Exception("Contraseña y/o Usuario invalido")
                    End If
                Else
                    Throw New Exception("Contraseña y/o Usuario invalido")
                End If
            Else
                Throw New Exception("Campos Incompletos")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Text)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'Salir del programa y cerrar todos sus subprocesos
        End
    End Sub

    Private Sub btnCambioContra_Click(sender As Object, e As EventArgs) Handles btnCambioContra.Click
        Try
            'Instancio un nuevo objeto del cambio de contraseñas
            Dim cambio As New frmCambioContrasenia
            'Le asigno las propiedades y lo muestro como dialogo
            With cambio
                .TipoFormulario = frmCambioContrasenia.TipoFormu.CambioLogin
                .ShowDialog()
                If .DialogResult = DialogResult.OK Then
                    MsgBox("La contraseña fue actualizada correctamente", MsgBoxStyle.Information, "LOGIN")
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Text)
        End Try
    End Sub
End Class
