<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPersona
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPersona))
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.ttpAyudaCorreo = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.eprCorreo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tbcPersona = New System.Windows.Forms.TabControl()
        Me.tbpHC = New System.Windows.Forms.TabPage()
        Me.lblGestionPersona = New System.Windows.Forms.Label()
        Me.btnBuscarOS = New System.Windows.Forms.Button()
        Me.txtObraSocial = New System.Windows.Forms.TextBox()
        Me.txtNumTelefono = New System.Windows.Forms.TextBox()
        Me.lblNumTelef = New System.Windows.Forms.Label()
        Me.txtNumOS = New System.Windows.Forms.TextBox()
        Me.lblNumOS = New System.Windows.Forms.Label()
        Me.lblObraSoc = New System.Windows.Forms.Label()
        Me.cboEspecialidad = New System.Windows.Forms.ComboBox()
        Me.lblEspecialidad = New System.Windows.Forms.Label()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.txtCorreoEle = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.cboGenero = New System.Windows.Forms.ComboBox()
        Me.txtNumDoc = New System.Windows.Forms.TextBox()
        Me.lblNumDoc = New System.Windows.Forms.Label()
        Me.lblTipoDoc = New System.Windows.Forms.Label()
        Me.cboTipoDoc = New System.Windows.Forms.ComboBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.lblNombreCompleto = New System.Windows.Forms.Label()
        Me.btnBuscarLocalidad = New System.Windows.Forms.Button()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.tbpAnt = New System.Windows.Forms.TabPage()
        Me.rtbHered = New System.Windows.Forms.RichTextBox()
        Me.rtbNoPato = New System.Windows.Forms.RichTextBox()
        Me.rtbPatolog = New System.Windows.Forms.RichTextBox()
        Me.cboGrupoSanguineo = New System.Windows.Forms.ComboBox()
        Me.lblGrupoSang = New System.Windows.Forms.Label()
        Me.lblHeredi = New System.Windows.Forms.Label()
        Me.lblNoPatol = New System.Windows.Forms.Label()
        Me.lblPatologicos = New System.Windows.Forms.Label()
        Me.lblAntecedentes = New System.Windows.Forms.Label()
        CType(Me.eprCorreo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcPersona.SuspendLayout()
        Me.tbpHC.SuspendLayout()
        Me.tbpAnt.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnAceptar.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.ok
        Me.btnAceptar.Location = New System.Drawing.Point(351, 626)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(121, 47)
        Me.btnAceptar.TabIndex = 13
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnCancelar.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.back
        Me.btnCancelar.Location = New System.Drawing.Point(523, 626)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(121, 47)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "   SALIR"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'ttpAyudaCorreo
        '
        Me.ttpAyudaCorreo.AutomaticDelay = 0
        Me.ttpAyudaCorreo.AutoPopDelay = 5000
        Me.ttpAyudaCorreo.InitialDelay = 100
        Me.ttpAyudaCorreo.ReshowDelay = 100
        Me.ttpAyudaCorreo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttpAyudaCorreo.ToolTipTitle = "Correos Admitidos"
        '
        'btnModificar
        '
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnModificar.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.edit
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(815, 626)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(139, 47)
        Me.btnModificar.TabIndex = 15
        Me.btnModificar.Text = "MODIFICAR REGISTRO"
        Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBaja.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnBaja.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.user_remove
        Me.btnBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBaja.Location = New System.Drawing.Point(670, 626)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(139, 47)
        Me.btnBaja.TabIndex = 16
        Me.btnBaja.Text = "BAJA REGISTRO"
        Me.btnBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'eprCorreo
        '
        Me.eprCorreo.ContainerControl = Me
        '
        'tbcPersona
        '
        Me.tbcPersona.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbcPersona.Controls.Add(Me.tbpHC)
        Me.tbcPersona.Controls.Add(Me.tbpAnt)
        Me.tbcPersona.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.tbcPersona.Location = New System.Drawing.Point(12, 12)
        Me.tbcPersona.MaximumSize = New System.Drawing.Size(934, 608)
        Me.tbcPersona.MinimumSize = New System.Drawing.Size(934, 608)
        Me.tbcPersona.Name = "tbcPersona"
        Me.tbcPersona.SelectedIndex = 0
        Me.tbcPersona.Size = New System.Drawing.Size(934, 608)
        Me.tbcPersona.TabIndex = 17
        '
        'tbpHC
        '
        Me.tbpHC.BackColor = System.Drawing.Color.Transparent
        Me.tbpHC.Controls.Add(Me.lblGestionPersona)
        Me.tbpHC.Controls.Add(Me.btnBuscarOS)
        Me.tbpHC.Controls.Add(Me.txtObraSocial)
        Me.tbpHC.Controls.Add(Me.txtNumTelefono)
        Me.tbpHC.Controls.Add(Me.lblNumTelef)
        Me.tbpHC.Controls.Add(Me.txtNumOS)
        Me.tbpHC.Controls.Add(Me.lblNumOS)
        Me.tbpHC.Controls.Add(Me.lblObraSoc)
        Me.tbpHC.Controls.Add(Me.cboEspecialidad)
        Me.tbpHC.Controls.Add(Me.lblEspecialidad)
        Me.tbpHC.Controls.Add(Me.dtpFechaNac)
        Me.tbpHC.Controls.Add(Me.lblFechaNac)
        Me.tbpHC.Controls.Add(Me.txtCorreoEle)
        Me.tbpHC.Controls.Add(Me.lblCorreo)
        Me.tbpHC.Controls.Add(Me.lblGenero)
        Me.tbpHC.Controls.Add(Me.cboGenero)
        Me.tbpHC.Controls.Add(Me.txtNumDoc)
        Me.tbpHC.Controls.Add(Me.lblNumDoc)
        Me.tbpHC.Controls.Add(Me.lblTipoDoc)
        Me.tbpHC.Controls.Add(Me.cboTipoDoc)
        Me.tbpHC.Controls.Add(Me.txtDireccion)
        Me.tbpHC.Controls.Add(Me.lblDireccion)
        Me.tbpHC.Controls.Add(Me.txtNombreCompleto)
        Me.tbpHC.Controls.Add(Me.lblNombreCompleto)
        Me.tbpHC.Controls.Add(Me.btnBuscarLocalidad)
        Me.tbpHC.Controls.Add(Me.lblLocalidad)
        Me.tbpHC.Controls.Add(Me.txtLocalidad)
        Me.tbpHC.Location = New System.Drawing.Point(4, 28)
        Me.tbpHC.Name = "tbpHC"
        Me.tbpHC.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpHC.Size = New System.Drawing.Size(926, 576)
        Me.tbpHC.TabIndex = 0
        Me.tbpHC.Text = "Historia Clinica"
        '
        'lblGestionPersona
        '
        Me.lblGestionPersona.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGestionPersona.BackColor = System.Drawing.Color.Transparent
        Me.lblGestionPersona.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGestionPersona.Location = New System.Drawing.Point(3, 3)
        Me.lblGestionPersona.Name = "lblGestionPersona"
        Me.lblGestionPersona.Size = New System.Drawing.Size(920, 42)
        Me.lblGestionPersona.TabIndex = 53
        Me.lblGestionPersona.Text = "HISTORIA CLINICA"
        Me.lblGestionPersona.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBuscarOS
        '
        Me.btnBuscarOS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarOS.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.search
        Me.btnBuscarOS.Location = New System.Drawing.Point(829, 98)
        Me.btnBuscarOS.Name = "btnBuscarOS"
        Me.btnBuscarOS.Size = New System.Drawing.Size(40, 37)
        Me.btnBuscarOS.TabIndex = 37
        Me.btnBuscarOS.UseVisualStyleBackColor = True
        '
        'txtObraSocial
        '
        Me.txtObraSocial.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtObraSocial.Location = New System.Drawing.Point(696, 103)
        Me.txtObraSocial.Name = "txtObraSocial"
        Me.txtObraSocial.ReadOnly = True
        Me.txtObraSocial.Size = New System.Drawing.Size(127, 27)
        Me.txtObraSocial.TabIndex = 52
        '
        'txtNumTelefono
        '
        Me.txtNumTelefono.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtNumTelefono.Location = New System.Drawing.Point(697, 316)
        Me.txtNumTelefono.MaxLength = 20
        Me.txtNumTelefono.Name = "txtNumTelefono"
        Me.txtNumTelefono.Size = New System.Drawing.Size(145, 27)
        Me.txtNumTelefono.TabIndex = 42
        '
        'lblNumTelef
        '
        Me.lblNumTelef.AutoSize = True
        Me.lblNumTelef.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblNumTelef.Location = New System.Drawing.Point(527, 319)
        Me.lblNumTelef.Name = "lblNumTelef"
        Me.lblNumTelef.Size = New System.Drawing.Size(98, 19)
        Me.lblNumTelef.TabIndex = 51
        Me.lblNumTelef.Text = "N° TELEFONO"
        '
        'txtNumOS
        '
        Me.txtNumOS.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtNumOS.Location = New System.Drawing.Point(696, 174)
        Me.txtNumOS.Name = "txtNumOS"
        Me.txtNumOS.Size = New System.Drawing.Size(213, 27)
        Me.txtNumOS.TabIndex = 38
        '
        'lblNumOS
        '
        Me.lblNumOS.AutoSize = True
        Me.lblNumOS.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblNumOS.Location = New System.Drawing.Point(527, 177)
        Me.lblNumOS.Name = "lblNumOS"
        Me.lblNumOS.Size = New System.Drawing.Size(100, 19)
        Me.lblNumOS.TabIndex = 50
        Me.lblNumOS.Text = "NUMERO O.S."
        '
        'lblObraSoc
        '
        Me.lblObraSoc.AutoSize = True
        Me.lblObraSoc.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblObraSoc.Location = New System.Drawing.Point(527, 106)
        Me.lblObraSoc.Name = "lblObraSoc"
        Me.lblObraSoc.Size = New System.Drawing.Size(98, 19)
        Me.lblObraSoc.TabIndex = 49
        Me.lblObraSoc.Text = "OBRA SOCIAL"
        '
        'cboEspecialidad
        '
        Me.cboEspecialidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboEspecialidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEspecialidad.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cboEspecialidad.FormattingEnabled = True
        Me.cboEspecialidad.Location = New System.Drawing.Point(183, 529)
        Me.cboEspecialidad.Name = "cboEspecialidad"
        Me.cboEspecialidad.Size = New System.Drawing.Size(180, 27)
        Me.cboEspecialidad.TabIndex = 36
        '
        'lblEspecialidad
        '
        Me.lblEspecialidad.AutoSize = True
        Me.lblEspecialidad.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblEspecialidad.Location = New System.Drawing.Point(13, 532)
        Me.lblEspecialidad.Name = "lblEspecialidad"
        Me.lblEspecialidad.Size = New System.Drawing.Size(102, 19)
        Me.lblEspecialidad.TabIndex = 47
        Me.lblEspecialidad.Text = "ESPECIALIDAD"
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpFechaNac.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNac.Location = New System.Drawing.Point(696, 242)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(146, 27)
        Me.dtpFechaNac.TabIndex = 41
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblFechaNac.Location = New System.Drawing.Point(527, 248)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(142, 19)
        Me.lblFechaNac.TabIndex = 46
        Me.lblFechaNac.Text = "FECHA NACIMIENTO"
        '
        'txtCorreoEle
        '
        Me.txtCorreoEle.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtCorreoEle.Location = New System.Drawing.Point(697, 387)
        Me.txtCorreoEle.Name = "txtCorreoEle"
        Me.txtCorreoEle.Size = New System.Drawing.Size(212, 27)
        Me.txtCorreoEle.TabIndex = 43
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblCorreo.Location = New System.Drawing.Point(527, 390)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(164, 19)
        Me.lblCorreo.TabIndex = 45
        Me.lblCorreo.Text = "CORREO ELECTRONICO"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblGenero.Location = New System.Drawing.Point(13, 390)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(65, 19)
        Me.lblGenero.TabIndex = 44
        Me.lblGenero.Text = "GENERO"
        '
        'cboGenero
        '
        Me.cboGenero.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cboGenero.FormattingEnabled = True
        Me.cboGenero.Location = New System.Drawing.Point(183, 387)
        Me.cboGenero.Name = "cboGenero"
        Me.cboGenero.Size = New System.Drawing.Size(126, 27)
        Me.cboGenero.TabIndex = 33
        '
        'txtNumDoc
        '
        Me.txtNumDoc.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtNumDoc.Location = New System.Drawing.Point(183, 316)
        Me.txtNumDoc.Name = "txtNumDoc"
        Me.txtNumDoc.Size = New System.Drawing.Size(126, 27)
        Me.txtNumDoc.TabIndex = 31
        '
        'lblNumDoc
        '
        Me.lblNumDoc.AutoSize = True
        Me.lblNumDoc.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblNumDoc.Location = New System.Drawing.Point(13, 319)
        Me.lblNumDoc.Name = "lblNumDoc"
        Me.lblNumDoc.Size = New System.Drawing.Size(164, 19)
        Me.lblNumDoc.TabIndex = 40
        Me.lblNumDoc.Text = "NUMERO DOCUMENTO"
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.AutoSize = True
        Me.lblTipoDoc.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblTipoDoc.Location = New System.Drawing.Point(13, 248)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(134, 19)
        Me.lblTipoDoc.TabIndex = 39
        Me.lblTipoDoc.Text = "TIPO DOCUMENTO"
        '
        'cboTipoDoc
        '
        Me.cboTipoDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboTipoDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoDoc.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cboTipoDoc.FormattingEnabled = True
        Me.cboTipoDoc.Location = New System.Drawing.Point(183, 245)
        Me.cboTipoDoc.Name = "cboTipoDoc"
        Me.cboTipoDoc.Size = New System.Drawing.Size(126, 27)
        Me.cboTipoDoc.TabIndex = 30
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtDireccion.Location = New System.Drawing.Point(183, 174)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(254, 27)
        Me.txtDireccion.TabIndex = 29
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblDireccion.Location = New System.Drawing.Point(13, 177)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(83, 19)
        Me.lblDireccion.TabIndex = 35
        Me.lblDireccion.Text = "DIRECCION"
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtNombreCompleto.Location = New System.Drawing.Point(183, 103)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.Size = New System.Drawing.Size(254, 27)
        Me.txtNombreCompleto.TabIndex = 27
        '
        'lblNombreCompleto
        '
        Me.lblNombreCompleto.AutoSize = True
        Me.lblNombreCompleto.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblNombreCompleto.Location = New System.Drawing.Point(13, 106)
        Me.lblNombreCompleto.Name = "lblNombreCompleto"
        Me.lblNombreCompleto.Size = New System.Drawing.Size(148, 19)
        Me.lblNombreCompleto.TabIndex = 32
        Me.lblNombreCompleto.Text = "NOMBRE COMPLETO"
        '
        'btnBuscarLocalidad
        '
        Me.btnBuscarLocalidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarLocalidad.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.search
        Me.btnBuscarLocalidad.Location = New System.Drawing.Point(427, 453)
        Me.btnBuscarLocalidad.Name = "btnBuscarLocalidad"
        Me.btnBuscarLocalidad.Size = New System.Drawing.Size(40, 37)
        Me.btnBuscarLocalidad.TabIndex = 34
        Me.btnBuscarLocalidad.UseVisualStyleBackColor = True
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblLocalidad.Location = New System.Drawing.Point(13, 461)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(85, 19)
        Me.lblLocalidad.TabIndex = 28
        Me.lblLocalidad.Text = "LOCALIDAD"
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtLocalidad.Location = New System.Drawing.Point(183, 458)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.ReadOnly = True
        Me.txtLocalidad.Size = New System.Drawing.Size(238, 27)
        Me.txtLocalidad.TabIndex = 48
        '
        'tbpAnt
        '
        Me.tbpAnt.BackColor = System.Drawing.Color.Transparent
        Me.tbpAnt.Controls.Add(Me.rtbHered)
        Me.tbpAnt.Controls.Add(Me.rtbNoPato)
        Me.tbpAnt.Controls.Add(Me.rtbPatolog)
        Me.tbpAnt.Controls.Add(Me.cboGrupoSanguineo)
        Me.tbpAnt.Controls.Add(Me.lblGrupoSang)
        Me.tbpAnt.Controls.Add(Me.lblHeredi)
        Me.tbpAnt.Controls.Add(Me.lblNoPatol)
        Me.tbpAnt.Controls.Add(Me.lblPatologicos)
        Me.tbpAnt.Controls.Add(Me.lblAntecedentes)
        Me.tbpAnt.Location = New System.Drawing.Point(4, 28)
        Me.tbpAnt.Name = "tbpAnt"
        Me.tbpAnt.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpAnt.Size = New System.Drawing.Size(926, 576)
        Me.tbpAnt.TabIndex = 1
        Me.tbpAnt.Text = "Otros Datos"
        '
        'rtbHered
        '
        Me.rtbHered.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbHered.BackColor = System.Drawing.Color.White
        Me.rtbHered.Location = New System.Drawing.Point(291, 356)
        Me.rtbHered.Name = "rtbHered"
        Me.rtbHered.Size = New System.Drawing.Size(519, 96)
        Me.rtbHered.TabIndex = 32
        Me.rtbHered.Text = ""
        '
        'rtbNoPato
        '
        Me.rtbNoPato.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbNoPato.BackColor = System.Drawing.Color.White
        Me.rtbNoPato.Location = New System.Drawing.Point(291, 235)
        Me.rtbNoPato.Name = "rtbNoPato"
        Me.rtbNoPato.Size = New System.Drawing.Size(519, 96)
        Me.rtbNoPato.TabIndex = 31
        Me.rtbNoPato.Text = ""
        '
        'rtbPatolog
        '
        Me.rtbPatolog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbPatolog.BackColor = System.Drawing.Color.White
        Me.rtbPatolog.Location = New System.Drawing.Point(291, 114)
        Me.rtbPatolog.Name = "rtbPatolog"
        Me.rtbPatolog.Size = New System.Drawing.Size(519, 96)
        Me.rtbPatolog.TabIndex = 30
        Me.rtbPatolog.Text = ""
        '
        'cboGrupoSanguineo
        '
        Me.cboGrupoSanguineo.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cboGrupoSanguineo.FormattingEnabled = True
        Me.cboGrupoSanguineo.Location = New System.Drawing.Point(291, 478)
        Me.cboGrupoSanguineo.Name = "cboGrupoSanguineo"
        Me.cboGrupoSanguineo.Size = New System.Drawing.Size(126, 27)
        Me.cboGrupoSanguineo.TabIndex = 59
        '
        'lblGrupoSang
        '
        Me.lblGrupoSang.AutoSize = True
        Me.lblGrupoSang.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblGrupoSang.Location = New System.Drawing.Point(138, 480)
        Me.lblGrupoSang.Name = "lblGrupoSang"
        Me.lblGrupoSang.Size = New System.Drawing.Size(140, 19)
        Me.lblGrupoSang.TabIndex = 58
        Me.lblGrupoSang.Text = "GRUPO SANGUINEO"
        '
        'lblHeredi
        '
        Me.lblHeredi.AutoSize = True
        Me.lblHeredi.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblHeredi.Location = New System.Drawing.Point(138, 359)
        Me.lblHeredi.Name = "lblHeredi"
        Me.lblHeredi.Size = New System.Drawing.Size(112, 38)
        Me.lblHeredi.TabIndex = 57
        Me.lblHeredi.Text = "ANTECEDENTES" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "HEREDITARIOS"
        '
        'lblNoPatol
        '
        Me.lblNoPatol.AutoSize = True
        Me.lblNoPatol.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblNoPatol.Location = New System.Drawing.Point(138, 238)
        Me.lblNoPatol.Name = "lblNoPatol"
        Me.lblNoPatol.Size = New System.Drawing.Size(127, 38)
        Me.lblNoPatol.TabIndex = 56
        Me.lblNoPatol.Text = "ANTECEDENTES" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NO PATOLOGICOS"
        '
        'lblPatologicos
        '
        Me.lblPatologicos.AutoSize = True
        Me.lblPatologicos.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblPatologicos.Location = New System.Drawing.Point(138, 117)
        Me.lblPatologicos.Name = "lblPatologicos"
        Me.lblPatologicos.Size = New System.Drawing.Size(112, 38)
        Me.lblPatologicos.TabIndex = 55
        Me.lblPatologicos.Text = "ANTECEDENTES" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PATOLOGICOS"
        '
        'lblAntecedentes
        '
        Me.lblAntecedentes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAntecedentes.BackColor = System.Drawing.Color.Transparent
        Me.lblAntecedentes.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAntecedentes.Location = New System.Drawing.Point(3, 3)
        Me.lblAntecedentes.Name = "lblAntecedentes"
        Me.lblAntecedentes.Size = New System.Drawing.Size(920, 42)
        Me.lblAntecedentes.TabIndex = 54
        Me.lblAntecedentes.Text = "DATOS ADICIONALES"
        Me.lblAntecedentes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPersona
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(968, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbcPersona)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(984, 720)
        Me.MinimumSize = New System.Drawing.Size(984, 720)
        Me.Name = "frmPersona"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HISTORIA CLINICA"
        CType(Me.eprCorreo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcPersona.ResumeLayout(False)
        Me.tbpHC.ResumeLayout(False)
        Me.tbpHC.PerformLayout()
        Me.tbpAnt.ResumeLayout(False)
        Me.tbpAnt.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents ttpAyudaCorreo As ToolTip
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnBaja As Button
    Friend WithEvents eprCorreo As ErrorProvider
    Friend WithEvents tbcPersona As TabControl
    Friend WithEvents tbpHC As TabPage
    Friend WithEvents lblGestionPersona As Label
    Friend WithEvents btnBuscarOS As Button
    Friend WithEvents txtObraSocial As TextBox
    Friend WithEvents txtNumTelefono As TextBox
    Friend WithEvents lblNumTelef As Label
    Friend WithEvents txtNumOS As TextBox
    Friend WithEvents lblNumOS As Label
    Friend WithEvents lblObraSoc As Label
    Friend WithEvents cboEspecialidad As ComboBox
    Friend WithEvents lblEspecialidad As Label
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents lblFechaNac As Label
    Friend WithEvents txtCorreoEle As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblGenero As Label
    Friend WithEvents cboGenero As ComboBox
    Friend WithEvents txtNumDoc As TextBox
    Friend WithEvents lblNumDoc As Label
    Friend WithEvents lblTipoDoc As Label
    Friend WithEvents cboTipoDoc As ComboBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents txtNombreCompleto As TextBox
    Friend WithEvents lblNombreCompleto As Label
    Friend WithEvents btnBuscarLocalidad As Button
    Friend WithEvents lblLocalidad As Label
    Friend WithEvents txtLocalidad As TextBox
    Friend WithEvents tbpAnt As TabPage
    Friend WithEvents lblAntecedentes As Label
    Friend WithEvents rtbPatolog As RichTextBox
    Friend WithEvents cboGrupoSanguineo As ComboBox
    Friend WithEvents lblGrupoSang As Label
    Friend WithEvents lblHeredi As Label
    Friend WithEvents lblNoPatol As Label
    Friend WithEvents lblPatologicos As Label
    Friend WithEvents rtbHered As RichTextBox
    Friend WithEvents rtbNoPato As RichTextBox
End Class
