Imports entProvincia
Imports entLocalidad
Public Class frmGestionLocalidades
#Region "Campos"
    'Enumeracion para los distintos formularios
    Public Enum TipoFormu
        Nueva
        Modificar
    End Enum

    Private _TipoFormulario As TipoFormu
    Private _IdLocali As Integer
    Private _IdProvi As Integer

    'Usuario actual
    Private _IdUsuAct As Integer

    'Localidad original (cuando se modifica)
    Dim _LocalidadOriginal As New eLocalidad
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

    Public Property IdLocali As Integer
        Get
            Return _IdLocali
        End Get
        Set(value As Integer)
            _IdLocali = value
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

    Public Property IdProvi As Integer
        Get
            Return _IdProvi
        End Get
        Set(value As Integer)
            _IdProvi = value
        End Set
    End Property
#End Region

#Region "Eventos"
    Private Sub frmGestionLocalidades_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Creo un objeto de la entidad provincia
            Dim provincias As New eProvincia
            Dim tablaProvincia As New DataTable

            'Lleno la tabla de provincias. Si o si hay que llenarla al principio sino presenta problemas al intentar acceder al cbo en la modificacion
            provincias.ObtenerProvincias(tablaProvincia)

            'Al combo box le asigno la fuente de datos y cuales datos mostrara (DisplayMember) y cuales tomara como referencia ante consultas (ValueMember)
            With cboProvincia
                .DataSource = tablaProvincia
                .DisplayMember = "Nombre"
                .ValueMember = "IdProvincia"
            End With

            'Coloco el cbo por defecto en Mendoza
            cboProvincia.SelectedValue = 12

            If TipoFormulario = TipoFormu.Nueva Then
                'Cambio el titulo segun el formulario
                lblLocalidad.Text = "NUEVA LOCALIDAD"

            ElseIf TipoFormulario = TipoFormu.Modificar Then
                'Cambio el titulo segun el formulario
                lblLocalidad.Text = "MODIFICAR LOCALIDAD"

                'Obtengo los datos de la localidad a modificar
                _LocalidadOriginal.obtenerRegistro(IdLocali)
                'Se los asigno a los controles
                cboProvincia.SelectedValue = _LocalidadOriginal.IdProvincia
                txtNombreLocalidad.Text = _LocalidadOriginal.Localidad
                txtCodigoPostal.Text = _LocalidadOriginal.CP
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
            'Si el tipo de formulario es de alta (nueva)
            If TipoFormulario = TipoFormu.Nueva Then
                'Creo un nuevo objeto y le asigno el contenido de los controles
                Dim nuevaLoc As New eLocalidad
                With nuevaLoc
                    .IdProvincia = cboProvincia.SelectedValue
                    .Localidad = txtNombreLocalidad.Text.Trim()
                    .CP = txtCodigoPostal.Text.Trim()
                    .IdUsuario = IdUsuAct
                End With

                'Llamo al metodo para agregar el registro y le paso el objeto con los datos
                nuevaLoc.insertarRegistro(nuevaLoc)

                'Si el formulario es de modificacion
            ElseIf TipoFormulario = TipoFormu.Modificar Then
                'Creo un objeto que contendra los datos modificados mas lo que no han sido modificados
                Dim localidadModificada As New eLocalidad
                'Le asigno los valores que estan en la base de datos
                localidadModificada.obtenerRegistro(IdLocali)
                'Ahora le asigno los valores que fueron modificados
                With localidadModificada
                    .IdProvincia = cboProvincia.SelectedValue
                    .Localidad = txtNombreLocalidad.Text
                    .CP = txtCodigoPostal.Text
                    .IdUsuario = IdUsuAct
                End With

                'Creo un objeto para comprobar si los registros fueron modificados (dara mayor a 0 si fue modificado). Llamo a la funcion desde el objeto viejo porque es necesario que sea tomado como parametro implicito tambien (esta dentro de la funcion) asi ésta podra comparar ambos objetos y sus valores.
                Dim registro As Integer = _LocalidadOriginal.actualizarRegistro(localidadModificada)
                'Muestro la cantidad de registros modificados
                If registro = 1 Then
                    MsgBox("El registro fue actualizado correctamente", MsgBoxStyle.Information, "Localidades")
                Else
                    Throw New Exception("El registro no pudo ser actualizado")
                End If
            End If

            'Guardo el valor de ID de la provincia seleccionada
            IdProvi = cboProvincia.SelectedValue

            'Confirmo el formulario
            DialogResult = DialogResult.OK

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, Text)
        End Try
    End Sub

    'Evento que se lanza al presionar una tecla
    Private Sub cboProvincia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboProvincia.KeyPress
        CaracterNumerico(e)
    End Sub

    'Evento que se lanza al presionar una tecla
    Private Sub txtNombreLocalidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreLocalidad.KeyPress
        CaracterNumerico(e)
    End Sub

    'Evento que se lanza al presionar una tecla
    Private Sub txtCodigoPostal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoPostal.KeyPress
        CaracterNoNumerico(e)
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

    Public Sub CaracterNoNumerico(e As KeyPressEventArgs)
        'Pregunto si es numerico el valor de la tecla presionada o si corresponde al Codigo ASCII 8 "retroceso ", de ser asi muestro el valor en el control. Caso contrario no dejo que el valor tecleado se muestre
        If IsNumeric(e.KeyChar) Or e.KeyChar = Chr(8) Then
            'El handled me indica que tomara lo que tecleamos y si es false lo dejara pasar, pero si es True lo toma y no me lo muestra
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
#End Region
End Class