Imports CapaPresentacionLocalidades
Imports CapaPresentacionObrasSociales
Imports entPaciente
Imports entProfesionales
Imports entAntecedente
Imports entGrupoSanguineo
'Libreria para acceder a las clases de las expresiones regulares
Imports System.Text.RegularExpressions
Imports entTipoDocumento
Imports entObraSocial
Imports entLocalidad
Public Class frmPersona
#Region "Campos"
    'Declaro un nuevo objeto (sin instanciar) con eventos, de esa forma puedo utilizar los eventos declarados y heredados desde la interfaz iPersona y sus posteriores
    Dim WithEvents paciente As New ePaciente
    'Declaro un objeto con eventos para usarlo en las modificaciones
    Dim WithEvents pacienteActual As New ePaciente

    'Enumeracion para los distintos formularios
    Public Enum TipoFormu
        NPaciente
        CPaciente
        NProfesional
        CProfesional
    End Enum

    'Enumeracion para las distintas especialidades del lugar
    Public Enum Especialidades
        Alergología
        Anestesiología
        Cardiología
        Gastroenterología
        Endocrinología
        Geriatría
        Hematología
        Infectología
        Medicina_del_Deporte
        Medicina_del_Trabajo
        Medicina_Familiar
        Neumología
        Neurología
        Nutriología
        Oncologia_Medica
        Pediatría
        Psiquiatría
        Reumatología
        Toxicología
    End Enum

    'Enumeracion para el genero
    Public Enum Generos
        Masculino
        Femenino
        Otro
        No_Declara
    End Enum

    'Para guardar el tipo de formulario, el id del paciente y el profesional
    Private _TipoFormulario As TipoFormu
    Private _Especialidad As Especialidades
    Private _Genero As Generos
    Private _IdPaciente As Integer
    Private _IdProfesional As Integer
    'Para guardar el Id y nombre de la localidad
    Private _IdLoca As Integer = -1 'Para obligar a que seleccione una localidad
    Private _NombreLoca As String

    'Para guardar el Id y nombre del a Obra Social
    Private _IdObraSoc As Integer = -1 'Para obligar a que seleccione una OS
    Private _NombreObraS As String

    'Usuario actual
    Private _IdUsuAct As Integer

    'Para guardar los datos del paciente original cuando se trate de modificaciones
    Dim _PacienteOriginal As New ePaciente
    'Para guardar los datos del profesional original cuando se trate de modificaciones
    Dim _ProfesionalOriginal As New eProfesional

    'Para guardar los datos de los antecedentes originales en las modificaciones
    Dim _AntecedenteOriginal As New eAntecedente

    'Para la validacion por medio de expresiones regulares
    Dim MailRegex As String = "^[a-zA-Z0-9\._-]+@(hotmail|gmail|outlook|yahoo)[\.][a-zA-Z]{3}$"
    'Dim Regex2 As String = "/^[\w\d\.]+@(hotmail|gmail|outlook|yahoo)[\.][\w]{3}$/" NO FUNCIONA CORRECTAMENTE
    '".": Hace referencia a cualquier caracter (pueden ser muchos entre medio)
    '"^": Para indicar donde inicia el texto a comparar (usualmente se lo toma como inicio)
    '"$": Para indicar donde termina el texto a comparar (usualmente se lo toma como fin)
    '"+": Los caracteres anteriores se pueden repetir 1 o mas veces
    '"\.": Para considerar el caracter punto (.)
    '"{2,4}": Que se puede ser de 2 a 4 de longitud
    '"w": Para referirnos a cualquier carácter de la A a la Z, incluyendo dígitos y guiones bajos
    '"d" Para referirnos a numeros del 0-9
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

    Public Property IdPaciente As Integer
        Get
            Return _IdPaciente
        End Get
        Set(value As Integer)
            _IdPaciente = value
        End Set
    End Property

    Public Property IdProfesional As Integer
        Get
            Return _IdProfesional
        End Get
        Set(value As Integer)
            _IdProfesional = value
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

    Public Property Especialidad As Especialidades
        Get
            Return _Especialidad
        End Get
        Set(value As Especialidades)
            _Especialidad = value
        End Set
    End Property

    Public Property Genero As Generos
        Get
            Return _Genero
        End Get
        Set(value As Generos)
            _Genero = value
        End Set
    End Property

    Public Property IdLoca As Integer
        Get
            Return _IdLoca
        End Get
        Set(value As Integer)
            _IdLoca = value
        End Set
    End Property

    Public Property NombreLoca As String
        Get
            Return _NombreLoca
        End Get
        Set(value As String)
            _NombreLoca = value
        End Set
    End Property

    Public Property IdObraSoc As Integer
        Get
            Return _IdObraSoc
        End Get
        Set(value As Integer)
            _IdObraSoc = value
        End Set
    End Property

    Public Property NombreObraS As String
        Get
            Return _NombreObraS
        End Get
        Set(value As String)
            _NombreObraS = value
        End Set
    End Property
#End Region

#Region "Eventos"
    Private Sub frmPersona_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Traigo los tipo de documento de la base de datos
            Dim tipoDoc As New eTipoDocumento
            Dim tablaTipoDoc As New DataTable

            'Lleno la tabla de los tipo de documentos
            tipoDoc.ObtenerTiposDocumentos(tablaTipoDoc)

            'Al combo box le asigno la fuente de datos y cuales datos mostrara (DisplayMember) y cuales tomara como referencia ante consultas (ValueMember)
            With cboTipoDoc
                .DataSource = tablaTipoDoc
                .DisplayMember = "Sigla"
                .ValueMember = "IdTiposDocumentos"
            End With

            'Al cboGenero le asigno la enumeracion apropiada. Obtengo los valores en un array de la enumeracion creada
            With cboGenero
                .DataSource = [Enum].GetValues(GetType(Generos))
            End With

            'Al cboEspecialidad le asgino la enumeracion anterior. Obtengo los valores en un array de la enumeracion creada
            With cboEspecialidad
                .DataSource = [Enum].GetValues(GetType(Especialidades))
            End With

            'En un alta de paciente
            If TipoFormulario = TipoFormu.NPaciente Then
                'Cambio el titulo segun el formulario
                lblGestionPersona.Text = "NUEVA HISTORIA CLINICA"

                'Deshabilito los controles apropiados
                lblEspecialidad.Visible = False
                cboEspecialidad.Visible = False
                btnModificar.Visible = False
                btnBaja.Visible = False

                'Cambio la imagen y el nombre del boton
                btnCancelar.Text = "CANCELAR"
                btnCancelar.Image = My.Resources.stop_error

                'Oculto la pestaña de Otros Datos
                tbpAnt.Parent = Nothing

                'En la consulta de un paciente
            ElseIf TipoFormulario = TipoFormu.CPaciente Then
                'Cambio el nombre del label
                lblGestionPersona.Text = "HISTORIA CLINICA"

                'Deshabilito los controles apropiados
                lblEspecialidad.Visible = False
                cboEspecialidad.Visible = False
                cboEspecialidad.Enabled = False

                'Obtengo los datos de la localidad del paciente
                Dim locali As New eLocalidad
                locali.obtenerRegistro(IdLoca)

                'Obtengo los datos de la obra social del paciente
                Dim os As New eObraSocial
                os.obtenerRegistro(IdObraSoc)

                'Obtengo los datos del paciente a modificar
                _PacienteOriginal.obtenerRegistro(IdPaciente, "Pacientes", "IdPaciente")
                'Se lo asigno a los controles adecuados
                txtNombreCompleto.Text = _PacienteOriginal.NombreCompleto
                txtDireccion.Text = _PacienteOriginal.Direccion
                cboTipoDoc.SelectedValue = _PacienteOriginal.TipoDocumento
                txtNumDoc.Text = _PacienteOriginal.NumeroDocumento
                cboGenero.SelectedIndex = EnlazarEnumValor(_PacienteOriginal.Genero)
                txtLocalidad.Text = locali.Localidad
                txtObraSocial.Text = os.Sigla
                txtNumOS.Text = _PacienteOriginal.NumObraSoc
                dtpFechaNac.Value = _PacienteOriginal.FechaNacimiento
                txtNumTelefono.Text = _PacienteOriginal.NumTelefono
                txtCorreoEle.Text = _PacienteOriginal.CorreoElectronico

                'Dejo de solo lectura los controles que voy a mostrar
                habilitarControles(True, False)

                'Traigo los datos de los antecedentes
                'Comienzo con el CBO de los grupos sanguineos
                Dim grupo As New eGrupoSanguineo
                Dim tablaGrupo As New DataTable
                'Guardo en la tabla los grupos de la base de datos
                grupo.obtenerRegistros(tablaGrupo)

                'Se la asigno al CBO
                With cboGrupoSanguineo
                    .DataSource = tablaGrupo
                    .DisplayMember = "Grupo"
                    .ValueMember = "IdGrupo"
                End With

                'Obtengo los antecedentes guardados en la base de datos
                _AntecedenteOriginal.obtenerRegistro(IdPaciente)

                rtbPatolog.Text = _AntecedenteOriginal.Patologicos
                rtbNoPato.Text = _AntecedenteOriginal.NoPatologicos
                rtbHered.Text = _AntecedenteOriginal.Hereditarios
                cboGrupoSanguineo.SelectedValue = _AntecedenteOriginal.GrupoSanguineo

                'En un alta de profesional
            ElseIf TipoFormulario = TipoFormu.NProfesional Then
                'Cambio el titulo segun el formulario
                lblGestionPersona.Text = "NUEVO PROFESIONAL"

                'Deshabilito los controles apropiados
                lblObraSoc.Visible = False
                txtObraSocial.Visible = False
                btnBuscarOS.Visible = False
                lblNumOS.Visible = False
                txtNumOS.Visible = False
                lblFechaNac.Visible = False
                dtpFechaNac.Visible = False
                lblNumTelef.Visible = False
                txtNumTelefono.Visible = False
                lblCorreo.Visible = False
                txtCorreoEle.Visible = False
                btnModificar.Visible = False
                btnBaja.Visible = False

                'Cambio la imagen y el nombre del boton
                btnCancelar.Text = "CANCELAR"
                btnCancelar.Image = My.Resources.stop_error

                'Oculto la pestaña de Otros Datos
                tbpAnt.Parent = Nothing
                'Cambio el nombre de la pestaña
                tbpHC.Text = "PROFESIONAL"

                'En la consulta de un profesional
            ElseIf TipoFormulario = TipoFormu.CProfesional Then
                'Cambio el nombre del label
                lblGestionPersona.Text = "CONSULTA DE PROFESIONAL"

                'Deshabilito los controles apropiados
                lblObraSoc.Visible = False
                txtObraSocial.Visible = False
                btnBuscarOS.Visible = False
                btnBuscarOS.Enabled = False
                lblNumOS.Visible = False
                txtNumOS.Visible = False
                txtNumOS.Enabled = False
                lblFechaNac.Visible = False
                dtpFechaNac.Visible = False
                dtpFechaNac.Enabled = False
                lblNumTelef.Visible = False
                txtNumTelefono.Visible = False
                txtNumTelefono.Enabled = False
                lblCorreo.Visible = False
                txtCorreoEle.Visible = False
                txtCorreoEle.Enabled = False

                'Obtengo los datos de la localidad del profesional
                Dim locali As New eLocalidad
                locali.obtenerRegistro(IdLoca)

                'Obtengo los datos del profesional a modificar
                _ProfesionalOriginal.obtenerRegistro(IdProfesional, "Profesionales", "IdProfesional")
                'Se lo asigno a los controles adecuados
                txtNombreCompleto.Text = _ProfesionalOriginal.NombreCompleto
                txtDireccion.Text = _ProfesionalOriginal.Direccion
                cboTipoDoc.SelectedValue = _ProfesionalOriginal.TipoDocumento
                txtNumDoc.Text = _ProfesionalOriginal.NumeroDocumento
                cboGenero.SelectedIndex = EnlazarEnumValor(_ProfesionalOriginal.Genero)
                txtLocalidad.Text = locali.Localidad
                cboEspecialidad.SelectedIndex = EnlazarEnumValor(_ProfesionalOriginal.Especialidad)

                'Dejo de solo lectura los controles que voy a mostrar
                habilitarControles(True, False)

                'Oculto la pestaña de Otros Datos
                tbpAnt.Parent = Nothing
                'Cambio el nombre de la pestaña
                tbpHC.Text = "PROFESIONAL"
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
            'Si el formulario es de alta de Paciente
            If TipoFormulario = TipoFormu.NPaciente Then

                'Le asigno el contenido de los controles
                With paciente
                    .NombreCompleto = txtNombreCompleto.Text
                    .Direccion = txtDireccion.Text
                    .TipoDocumento = cboTipoDoc.SelectedValue
                    .NumeroDocumento = txtNumDoc.Text
                    'Segun el item que se selecciono en en cbo, obtengo el nombre del mismo y lo guardo en la propiedad
                    .Genero = [Enum].GetName(GetType(Generos), cboGenero.SelectedItem)
                    .Localidad = IdLoca
                    .ObraSocial = IdObraSoc
                    .NumObraSoc = txtNumOS.Text
                    .FechaNacimiento = dtpFechaNac.Value.Date
                    .NumTelefono = txtNumTelefono.Text
                    .CorreoElectronico = txtCorreoEle.Text
                    .Activo = 1
                    .IdUsuario = IdUsuAct
                End With

                'Llamo al metodo para agregar el registro y le paso el objeto con los datos
                paciente.insertarRegistro(paciente, "Pacientes")

            ElseIf TipoFormulario = TipoFormu.CPaciente Then
                'Obtengo los datos del paciente a modificar
                pacienteActual.obtenerRegistro(IdPaciente, "Pacientes", "IdPaciente")

                'Reemplazo los valores que fueron modificados en dicho paciente
                With pacienteActual
                    .NombreCompleto = txtNombreCompleto.Text
                    .Direccion = txtDireccion.Text
                    .TipoDocumento = cboTipoDoc.SelectedValue
                    .NumeroDocumento = txtNumDoc.Text
                    'Segun el item que se selecciono en en cbo, obtengo el nombre del mismo y lo guardo en la propiedad
                    .Genero = [Enum].GetName(GetType(Generos), cboGenero.SelectedItem)
                    .Localidad = IdLoca
                    .ObraSocial = IdObraSoc
                    .NumObraSoc = txtNumOS.Text
                    .FechaNacimiento = dtpFechaNac.Value.Date
                    .NumTelefono = txtNumTelefono.Text
                    .CorreoElectronico = txtCorreoEle.Text
                    .IdUsuario = IdUsuAct
                End With

                'Compruebo si se ha llenado con algun dato los campos de texto o el cbo de la pestaña Antecedentes, en ese caso, creo un nuevo registro de los antecedentes de la persona
                If Not rtbPatolog.Text.Trim() = "" Or Not rtbNoPato.Text.Trim() = "" Or Not rtbHered.Text.Trim() = "" Or cboGrupoSanguineo.SelectedValue > 0 Then
                    'Compruebo que haya un antecedente creado en base a su ID que debera ser mayor a 0 en ese caso
                    If _AntecedenteOriginal.IdAntecedente > 0 Then
                        'Si hay uno creado, procedo a modificarlo
                        Dim antecedenteActual As New eAntecedente
                        'Obtengo los datos de la base de datos
                        antecedenteActual.obtenerRegistro(IdPaciente)

                        'Le asigno el contenido de los controles asi modifica lo necesario
                        With antecedenteActual
                            .Patologicos = rtbPatolog.Text
                            .NoPatologicos = rtbNoPato.Text
                            .Hereditarios = rtbHered.Text
                            .GrupoSanguineo = cboGrupoSanguineo.SelectedValue
                        End With

                        'Creo un objeto para comprobar si los registros del antecedente fueron modificados
                        Dim registroAnt As Integer = _AntecedenteOriginal.actualizarRegistro(antecedenteActual)

                        'Compruebo que el registro haya sido actualizado
                        If Not registroAnt = 1 Then
                            Throw New Exception("El antecedente no pudo ser actualizado")
                        End If

                        'Si no hay ninguno creado, procedo a crearlo
                    Else
                        'Creo un nuevo objeto del tipo antecedentes
                        Dim nuevoAntecedente As New eAntecedente

                        'Le asigno el contenido de los controles
                        With nuevoAntecedente
                            .IdPaciente = IdPaciente
                            .Patologicos = rtbPatolog.Text
                            .NoPatologicos = rtbNoPato.Text
                            .Hereditarios = rtbHered.Text
                            .GrupoSanguineo = cboGrupoSanguineo.SelectedValue
                        End With

                        'Llamo al metodo para agregar el registro y le paso el objeto con los datos
                        nuevoAntecedente.insertarRegistro(nuevoAntecedente)
                    End If
                End If

                'Creo un objeto para comprobar si los registros del paciente fueron modificados (dara mayor a 0 si fue modificado). Llamo a la funcion desde el objeto viejo porque es necesario que sea tomado como parametro implicito tambien (esta dentro de la funcion) asi ésta podra comparar ambos objetos y sus valores.
                Dim registro As Integer = _PacienteOriginal.actualizarRegistro(pacienteActual, "Pacientes", "IdPaciente")

                'Compruebo que el registro fue guardado
                If registro = 1 Then
                    MsgBox("El registro fue actualizado correctamente", MsgBoxStyle.Information, "Historias Clinicas")
                Else
                    Throw New Exception("El registro no pudo ser actualizado")
                End If

                'Si el formulario es de alta de Profesional
            ElseIf TipoFormulario = TipoFormu.NProfesional Then
                'Creo un objeto del tipo eProfesional
                Dim profesional As New eProfesional

                'Le asigno el contenido de los controles
                With profesional
                    .NombreCompleto = txtNombreCompleto.Text
                    .Direccion = txtDireccion.Text
                    .TipoDocumento = cboTipoDoc.SelectedValue
                    .NumeroDocumento = txtNumDoc.Text
                    'Segun el item que se selecciono en en cbo, obtengo el nombre del mismo y lo guardo en la propiedad
                    .Genero = [Enum].GetName(GetType(Generos), cboGenero.SelectedItem)
                    .Localidad = IdLoca
                    .Especialidad = [Enum].GetName(GetType(Especialidades), cboEspecialidad.SelectedItem)
                    .Activo = 1
                    .IdUsuario = IdUsuAct
                End With

                'Llamo al metodo para agregar el registro y le paso el objeto con los datos
                profesional.insertarRegistro(profesional, "Profesionales")

                'Si el formulario es para modificar un Profesional
            ElseIf TipoFormulario = TipoFormu.CProfesional Then
                'Creo un objeto del tipo eProfesional
                Dim profesionalActual As New eProfesional

                'Le asigno los valores de la base de datos
                profesionalActual.obtenerRegistro(IdProfesional, "Profesionales", "IdProfesional")

                'Reemplazo los valores que fueron modificados en dicho profesional
                With profesionalActual
                    .NombreCompleto = txtNombreCompleto.Text
                    .Direccion = txtDireccion.Text
                    .TipoDocumento = cboTipoDoc.SelectedValue
                    .NumeroDocumento = txtNumDoc.Text
                    'Segun el item que se selecciono en en cbo, obtengo el nombre del mismo y lo guardo en la propiedad
                    .Genero = [Enum].GetName(GetType(Generos), cboGenero.SelectedItem)
                    .Localidad = IdLoca
                    .Especialidad = [Enum].GetName(GetType(Especialidades), cboEspecialidad.SelectedItem)
                    .IdUsuario = IdUsuAct
                End With

                'Creo un objeto para comprobar si los registros fueron modificados (dara mayor a 0 si fue modificado). Llamo a la funcion desde el objeto viejo porque es necesario que sea tomado como parametro implicito tambien (esta dentro de la funcion) asi ésta podra comparar ambos objetos y sus valores.
                Dim registro As Integer = _ProfesionalOriginal.actualizarRegistro(profesionalActual, "Profesionales", "IdProfesional")

                'Compruebo que el registro fue guardado
                If registro = 1 Then
                    MsgBox("El registro fue actualizado correctamente", MsgBoxStyle.Information, "Profesionales")
                Else
                    Throw New Exception("El registro no pudo ser actualizado")
                End If
            End If

            'Confirmo el formulario
            DialogResult = DialogResult.OK

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
            'Cambio el nombre del boton y su imagen
            btnCancelar.Text = "CANCELAR"
            btnCancelar.Image = My.Resources.stop_error

            If TipoFormulario = TipoFormu.CPaciente Then
                Text = "MODIFICACION DE HISTORIA CLINICA"
                lblGestionPersona.Text = "MODIFICAR HISTORIA CLINICA"

            ElseIf TipoFormulario = TipoFormu.CProfesional Then
                Text = "MODIFICACION DE PROFESIONAL"
                lblGestionPersona.Text = "MODIFICAR PROFESIONAL"
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Text)
        End Try
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        Try
            'Creo un nuevo objeto y le asigno el resultado del MessageBox creado
            Dim resultado As DialogResult = MessageBox.Show("¿Seguro desea dar de baja el registro actual?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            'Si se confirma la accion, se da de baja el registro
            If resultado = DialogResult.Yes Then
                'Compruebo el tipo de formulario
                If TipoFormulario = TipoFormu.CPaciente Then
                    'Creo 2 objetos iguales con el mismo id del que se quiere dar de baja y le asigno los mismos valores que ya tiene, pero le cambio a uno la propiedad Activo que sera lo que se modificara para darse de baja
                    Dim paciente As New ePaciente
                    Dim pacienteBaja As New ePaciente
                    paciente.obtenerRegistro(IdPaciente, "Pacientes", "IdPaciente")
                    pacienteBaja.obtenerRegistro(IdPaciente, "Pacientes", "IdPaciente")

                    'Guardo el usuario actual y pongo activo en 0 para ocultarlo (darlo de baja)
                    pacienteBaja.IdUsuario = IdUsuAct
                    pacienteBaja.Activo = 0

                    'Llamo a la funcion que me permite actualizar registros y guardo el resultado si fue actualizado con exito
                    Dim registro As Integer = paciente.actualizarRegistro(pacienteBaja, "Pacientes", "IdPaciente")

                    If registro = 1 Then
                        'Muestro un mensaje
                        MsgBox("BAJA REALIZADA CON EXITO", MsgBoxStyle.Information, "HISTORIA CLINICA")
                        'Confirmo el dialogo  
                        DialogResult = DialogResult.OK
                    Else
                        Throw New Exception("No se pudo realizar la baja")
                    End If

                ElseIf TipoFormulario = TipoFormu.CProfesional Then
                    'Creo 2 objetos iguales con el mismo id del que se quiere dar de baja y le asigno los mismos valores que ya tiene, pero le cambio a uno la propiedad Activo que sera lo que se modificara para darse de baja
                    Dim profesional As New eProfesional
                    Dim profesionalBaja As New eProfesional
                    profesional.obtenerRegistro(IdProfesional, "Profesionales", "IdProfesional")
                    profesionalBaja.obtenerRegistro(IdProfesional, "Profesionales", "IdProfesional")

                    'Guardo el usuario actual y pongo activo en 0 para ocultarlo (darlo de baja)
                    profesionalBaja.IdUsuario = IdUsuAct
                    profesionalBaja.Activo = 0

                    'Llamo a la funcion que me permite actualizar registros y guardo el resultado si fue actualizado con exito
                    Dim registro As Integer = profesional.actualizarRegistro(profesionalBaja, "Profesionales", "IdProfesional")

                    If registro = 1 Then
                        'Muestro un mensaje
                        MsgBox("BAJA REALIZADA CON EXITO", MsgBoxStyle.Information, "PROFESIONALES")
                        'Confirmo el dialogo  
                        DialogResult = DialogResult.OK
                    Else
                        Throw New Exception("No se pudo realizar la baja")
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Text)
        End Try
    End Sub

    Private Sub btnBuscarLocalidad_Click_1(sender As Object, e As EventArgs) Handles btnBuscarLocalidad.Click
        'Creo un nuevo objeto
        Dim local As New frmDialogoLocalidades

        'Lo muestro como dialogo
        With local
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                'Si la seleccion fue correcta, guardo el Id de la localidad y muestro su nombre
                IdLoca = local.IdLocal
                txtLocalidad.Text = local.NombreLoca
            End If
        End With
    End Sub

    Private Sub btnBuscarOS_Click_1(sender As Object, e As EventArgs) Handles btnBuscarOS.Click
        'Creo un nuevo objeto
        Dim obra As New frmDialogoOS

        'Lo muestro como dialogo
        With obra
            .ShowDialog()
            If .DialogResult = DialogResult.OK Then
                'Si la seleccion fue correcta, guardo el Id de la OS y muestro su nombre
                IdObraSoc = obra.IdObra
                txtObraSocial.Text = obra.NombreObraS
            End If
        End With
    End Sub

    'Eventos que se lanzaran al pulsar una tecla en el control apropiado
    Private Sub txtNombreCompleto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreCompleto.KeyPress
        CaracterNumerico(e)
    End Sub
    Private Sub cboTipoDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboTipoDoc.KeyPress
        CaracterNumerico(e)
    End Sub

    Private Sub txtNumDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumDoc.KeyPress
        CaracterNoNumerico(e)
    End Sub

    Private Sub cboGenero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboGenero.KeyPress
        CaracterNumerico(e)
    End Sub

    Private Sub cboEspecialidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboEspecialidad.KeyPress
        CaracterNumerico(e)
    End Sub

    Private Sub txtNumOS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumOS.KeyPress
        CaracterNoNumerico(e)
    End Sub
    Private Sub txtNumTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumTelefono.KeyPress
        CaracterNoNumerico(e)
    End Sub

    'Evento que se lanza al momento de guardar los datos para verificar que el correo sea valido
    Private Sub paciente_ValidarCorreo(correo As String) Handles paciente.ValidarCorreo, pacienteActual.ValidarCorreo
        'Creo un nuevo objeto del tipo Regex (clase de las expresiones regulares) y le asigno el string con la expresion regular creada
        Dim valida As New Regex(MailRegex)

        'Con un comparador, usando la funcion de comparacion de Regex, verifico que lo que contiene el textbox sea valido con la expresion regular asignada anteriormente
        If Not valida.IsMatch(correo) Then
            'Lanzo la alerta del ErrorProvider, le asigno el control al que estara ligado y el texto que contendra
            eprCorreo.SetError(txtCorreoEle, "Direccion de correo electronico no valida")
            Throw New Exception("Direccion de correo electronico no valida")
        Else
            'Si no hubiera error, o se hubiera arreglado el correo erroneo, dejo de mostrar la alerta
            eprCorreo.SetError(txtCorreoEle, String.Empty)
        End If
    End Sub

    'Mostrar una pequeña ayuda sobre los correos electronicos admitidos cuando el mouse pase por el control
    Private Sub txtCorreoEle_MouseHover(sender As Object, e As EventArgs) Handles txtCorreoEle.MouseHover
        'Si el control esta vacio muestra la ayuda
        If txtCorreoEle.Text.Trim() = "" Then
            'Muestro la ayuda, con el mensaje personalizado y le digo en que control quiero que se muestre
            ttpAyudaCorreo.Show("Los correos admitidos son Hotmail, Gmail, Outlook y Yahoo", txtCorreoEle)
        Else
            'Oculto la ayuda
            ttpAyudaCorreo.Hide(txtCorreoEle)
        End If
    End Sub

    'Evento que se lanza al perder el foco del control
    Private Sub txtCorreoEle_LostFocus(sender As Object, e As EventArgs) Handles txtCorreoEle.LostFocus
        Try
            'Le asigno el contenido del control asi lanzo el evento de validacion si fuera necesario
            paciente.CorreoElectronico = txtCorreoEle.Text

            'Si el contenido del control esta vacio, elimino la alerta por si estuviera generada
            If txtCorreoEle.Text.Trim() = "" Then
                eprCorreo.SetError(txtCorreoEle, String.Empty)
            End If

        Catch ex As Exception

        End Try
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
    ''' Metodo que captura un caracter no numerico ingresado y no deja mostrarlo
    ''' </summary>
    ''' <param name="e"></param>
    Public Sub CaracterNoNumerico(e As KeyPressEventArgs)
        'Pregunto si es numerico el valor de la tecla presionada o si corresponde al Codigo ASCII 8 "retroceso ", de ser asi muestro el valor en el control. Caso contrario no dejo que el valor tecleado se muestre
        If IsNumeric(e.KeyChar) Or e.KeyChar = Chr(8) Then
            'El handled me indica que tomara lo que tecleamos y si es false lo dejara pasar, pero si es True lo toma y no me lo muestra
            e.Handled = False
        Else
            e.Handled = True
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

        If TipoFormulario = TipoFormu.CPaciente Then
            'Deshabilito o habilito los controles apropiados
            txtNombreCompleto.ReadOnly = accion1
            txtDireccion.ReadOnly = accion1
            cboTipoDoc.Enabled = accion2
            txtNumDoc.ReadOnly = accion1
            cboGenero.Enabled = accion2
            btnBuscarLocalidad.Enabled = accion2
            btnBuscarOS.Enabled = accion2
            txtNumOS.ReadOnly = accion1
            dtpFechaNac.Enabled = accion2
            txtNumTelefono.ReadOnly = accion1
            txtCorreoEle.ReadOnly = accion1

            'Controles de Antecedentes
            rtbPatolog.ReadOnly = accion1
            rtbNoPato.ReadOnly = accion1
            rtbHered.ReadOnly = accion1
            cboGrupoSanguineo.Enabled = accion2

        ElseIf TipoFormulario = TipoFormu.CProfesional Then
            'Deshabilito o habilito los controles apropiados
            txtNombreCompleto.ReadOnly = accion1
            txtDireccion.ReadOnly = accion1
            cboTipoDoc.Enabled = accion2
            txtNumDoc.ReadOnly = accion1
            cboGenero.Enabled = accion2
            btnBuscarLocalidad.Enabled = accion2
            cboEspecialidad.Enabled = accion2
        End If
    End Sub
#End Region

#Region "Funciones"
    ''' <summary>
    ''' Funcion que permite relacionar los campos de texto traidos de la base de datos con los valores de una enumeracion
    ''' </summary>
    ''' <param name="texto">Texto a comparar con los valores de la enumeracion del formulario</param>
    Public Function EnlazarEnumValor(texto As String) As Integer
        'Guardo todos los valores de las enumeraciones del formularios en Arrays
        Dim valoresGeneros() As Integer = [Enum].GetValues(GetType(Generos))
        Dim valoresEspecialidades() As Integer = [Enum].GetValues(GetType(Especialidades))

        'Hago un bucle for
        For i As Integer = 0 To 100 Step 1

            'Si el texto pasado por parametro se encuentra en el arreglo de valores de la enumeracion
            If texto = [Enum].GetName(GetType(Generos), i) Then
                'Devuelvo el valor de dicho texto en la enumeracion
                Return valoresGeneros(i)

            ElseIf texto = [Enum].GetName(GetType(Especialidades), i) Then
                Return valoresEspecialidades(i)
            End If
        Next

        Return 0
    End Function
#End Region
End Class