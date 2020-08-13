Imports entObraSocial
Public Class frmGestionOS
#Region "Campos"
    'Tipos de formularios
    Public Enum TipoFormu
        Nueva
        Consulta
    End Enum

    Private _TipoFormulario As TipoFormu
    Private _IdObraSoc As Integer

    'Usuario actual
    Private _IdUsuAct As Integer

    'Obra Social original (cuando se modifican)
    Dim _OSOriginal As New eObraSocial
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

    Public Property IdObraSoc As Integer
        Get
            Return _IdObraSoc
        End Get
        Set(value As Integer)
            _IdObraSoc = value
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
    Private Sub frmGestionOS_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If TipoFormulario = TipoFormu.Nueva Then
                'Cambio el titulo segun el formulario
                lblObraSocial.Text = "NUEVA OBRA SOCIAL"

                'Deshabilitos los botones
                btnModificar.Visible = False
                btnBaja.Visible = False

            ElseIf TipoFormulario = TipoFormu.Consulta Then
                'Cambio el titulo segun el formulario
                lblObraSocial.Text = "CONSULTA DE OBRA SOCIAL"

                'Obtengo los datos de la Obra Social a modificar
                _OSOriginal.obtenerRegistro(IdObraSoc)
                'Se lo asigno a los controles
                txtNombreOS.Text = _OSOriginal.NombreOS
                txtSigla.Text = _OSOriginal.Sigla

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
            'Si el tipo de formulario es de alta (Nueva)
            If TipoFormulario = TipoFormu.Nueva Then
                'Creo un nuevo objeto y le asigno el contenido de los controles
                Dim nuevaOS As New eObraSocial
                With nuevaOS
                    .NombreOS = txtNombreOS.Text
                    .Sigla = txtSigla.Text
                    .Activo = 1
                    .IdUsuario = IdUsuAct
                End With

                'Llamo al metodo para agregar el registro y le paso el objeto con los datos
                nuevaOS.insertarRegistro(nuevaOS)

                'Si el formulario es de modificacion
            ElseIf TipoFormulario = TipoFormu.Consulta Then
                'Creo un objeto que contendra los datos modificados mas lo que no han sido modificados
                Dim obraSocialModificada As New eObraSocial
                'Obtengo los valores de la base de datos
                obraSocialModificada.obtenerRegistro(IdObraSoc)
                'Ahora le asigno los valores que fueron modificados
                With obraSocialModificada
                    .NombreOS = txtNombreOS.Text
                    .Sigla = txtSigla.Text
                    .IdUsuario = IdUsuAct
                End With

                'Creo un objeto para comprobar si los registros fueron modificados (dara mayor a 0 si fue modificado). Llamo a la funcion desde el objeto viejo porque es necesario que sea tomado como parametro implicito tambien (esta dentro de la funcion) asi ésta podra comparar ambos objetos y sus valores.
                Dim registro As Integer = _OSOriginal.actualizarRegistro(obraSocialModificada)
                'Muestro la cantidad de registros modificados
                If registro = 1 Then
                    MsgBox("El registro fue actualizado correctamente", MsgBoxStyle.Information, "Obras Sociales")
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

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            'Habilito los controles apropiados
            habilitarControles(False, True)

            'Deshabilito el boton de baja y modificacion
            btnModificar.Enabled = False
            btnBaja.Enabled = False

            Text = "MODIFICACION DE OBRA SOCIAL"
            lblObraSocial.Text = "MODIFICAR OBRA SOCIAL"

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
                'Creo 2 objetos iguales con el mismo id del que se quiere dar de baja y le asigno los mismos valores que ya tiene, pero le cambio a uno la propiedad Activo que sera lo que se modificara para darse de baja
                Dim obraSoc As New eObraSocial
                Dim obraSocBaja As New eObraSocial
                obraSoc.obtenerRegistro(IdObraSoc)
                obraSocBaja.obtenerRegistro(IdObraSoc)

                'Guardo el usuario actual y pongo activo en 0 para ocultarlo (darlo de baja)
                obraSocBaja.IdUsuario = IdUsuAct
                obraSocBaja.Activo = 0

                'Llamo a la funcion que me permite actualizar registros y guardo el resultado si fue actualizado con exito
                Dim registro As Integer = obraSoc.actualizarRegistro(obraSocBaja)

                If registro = 1 Then
                    'Muestro un mensaje
                    MsgBox("BAJA REALIZADA CON EXITO", MsgBoxStyle.Information, "OBRAS SOCIALES")
                    'Confirmo el formulario
                    DialogResult = DialogResult.OK
                Else
                    Throw New Exception("No se pudo realizar la baja")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Text)
        End Try
    End Sub

    'Evento que se lanza al pulsar una tecla
    Private Sub txtSigla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSigla.KeyPress
        CaracterNumerico(e)
    End Sub

    'Evento que se lanza al pulsar una tecla
    Private Sub txtNombreOS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreOS.KeyPress
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

    ''' <summary>
    ''' Metodo que permite habilitar o deshabilitar los controles del formulario
    ''' </summary>
    ''' <param name="accion1">Booleano que determina si los controles apropiados seran de solo lectura</param>
    ''' <param name="accion2">Booleano que determina si los controles apropiados estaran habilitados o no</param>
    Public Sub habilitarControles(accion1 As Boolean, accion2 As Boolean)
        btnAceptar.Enabled = accion2
        txtSigla.ReadOnly = accion1
        txtNombreOS.ReadOnly = accion1
    End Sub
#End Region
End Class