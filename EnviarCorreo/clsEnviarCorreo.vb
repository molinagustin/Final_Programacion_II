'Libreria que contiene clases para facilitar el envio de correos electronicos
Imports System.Net.Mail
'Libreria con clases para configurar el envio del correo
Imports System.Net
Imports entTurnos
Imports entPaciente
Imports entProfesionales
Public Class clsEnviarCorreo
#Region "Declaraciones"
    'Objetos necesarios para configurar el correo y su envio
    Private correo As New MailMessage
    Private envio As New SmtpClient

    'Para la cantidad de correo enviados
    Dim cant As Integer = 0
#End Region

#Region "Metodos"
    ''' <summary>
    ''' Metodo que permite enviar correos electronicos a los pacientes con turnos asignados y que poseen un correo electronico valido
    ''' </summary>
    Public Sub enviarCorreo()
        Try
            'Verifico si se ha enviado un correo en el dia
            Dim consultaCorreos As New eEnviarCorreo
            consultaCorreos.obtenerRegistro(Today.Date)

            'Si no hay un ID en base a la consulta realizada anteriormente, quiere decir que no se han enviados los correos del dia de hoy, por lo tanto entro al comparador
            If Not consultaCorreos.IdCorreo > 0 Then
                'Obtengo los turnos del dia siguiente
                Dim turnos As New eTurnos
                Dim tablaTurnos As New DataTable
                turnos.ObtenerTurnos(tablaTurnos, Today.Date.AddDays(1))

                'Creo un objeto para la consulta de datos del paciente
                Dim paciente As New ePaciente

                'Recorro las filas de la tabla de turnos
                For Each filaTabla As DataRow In tablaTurnos.Rows

                    'Solo recorro la fila del paciente
                    If filaTabla("Paciente") Then
                        'En cada paciente de cada turno, consulto sus datos en busca de su correo electronico
                        paciente.obtenerRegistro(filaTabla("Paciente"), "Pacientes", "IdPaciente")

                        'Si posee un correo electronico, entro en el comparador
                        If paciente.CorreoElectronico IsNot "" Then
                            'Busco el nombre del profesional con el que tiene turno
                            Dim profesional As New eProfesional
                            profesional.obtenerRegistro(filaTabla("Profesional"), "Profesionales", "IdProfesional")

                            'Configuro las propiedades del correo
                            With correo
                                'Limpio el destiantario
                                .To.Clear()
                                'Blanqueamos el BODY (cuerpo del mensaje) y luego le escribimos el mensaje
                                .Body = ""
                                .Body = "RECUERDE QUE SU TURNO EN EL CONSULTORIO ES EL DIA " & filaTabla("Fecha") & " A LAS " & filaTabla("HoraTurno") & " CON " & profesional.NombreCompleto.ToUpper & ". SALUDOS Y BUEN DIA"
                                'Blanqueamos tambien el asunto
                                .Subject = ""
                                .Subject = "TURNO CONSULTORIO"
                                .IsBodyHtml = True
                                'Agrego el destinatario
                                .To.Add(paciente.CorreoElectronico)
                                'Indico de que correo se envia
                                .From = New MailAddress("molinagustin1@gmail.com")
                            End With

                            'Configuro las propiedades del envio
                            With envio
                                'Las credenciales del correo del que se envia el mensaje
                                .Credentials = New NetworkCredential("molinagustin1@gmail.com", "rnbxgnhwdlifwmry") 'Contraseña de aplicacion
                                'Datos del servicio de envio de correos de GMAIL (NO MODIFICAR EN LO POSIBLE)
                                .Host = "smtp.gmail.com"
                                .Port = "587"
                                .EnableSsl = True
                                'Procedo a enviar el correo
                                .Send(correo)
                            End With

                            'Sumo 1 correo enviado
                            cant += 1

                        End If
                    End If
                Next

                'Guardo los correos enviados
                Dim correosEnviados As New eEnviarCorreo
                correosEnviados.Cantidad = cant
                correosEnviados.Fecha = Today.Date
                'Procedo a realizar el alta en la BD
                correosEnviados.insertarRegistro(correosEnviados)

                MsgBox("Se enviaron " & cant & " correos")

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Enviar Correo")
        End Try
    End Sub
#End Region
End Class
