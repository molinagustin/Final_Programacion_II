<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVistaUsuarios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVistaUsuarios))
        Me.dgvListadoUsuarios = New System.Windows.Forms.DataGridView()
        Me.IdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HashContrasenia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaltContrasenia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Privilegios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPrivilegio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaUltimaModificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPrivilegio1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUsuario1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaUltimaModificacion1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblVistaUsuarios = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        CType(Me.dgvListadoUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListadoUsuarios
        '
        Me.dgvListadoUsuarios.AllowUserToAddRows = False
        Me.dgvListadoUsuarios.AllowUserToDeleteRows = False
        Me.dgvListadoUsuarios.AllowUserToResizeColumns = False
        Me.dgvListadoUsuarios.AllowUserToResizeRows = False
        Me.dgvListadoUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListadoUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListadoUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdUsuario, Me.Nombre, Me.Usuario, Me.HashContrasenia, Me.SaltContrasenia, Me.Privilegios, Me.IdPrivilegio, Me.Activo, Me.FechaUltimaModificacion, Me.IdPrivilegio1, Me.IdUsuario1, Me.FechaUltimaModificacion1})
        Me.dgvListadoUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvListadoUsuarios.Location = New System.Drawing.Point(12, 211)
        Me.dgvListadoUsuarios.MultiSelect = False
        Me.dgvListadoUsuarios.Name = "dgvListadoUsuarios"
        Me.dgvListadoUsuarios.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvListadoUsuarios.RowHeadersVisible = False
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.dgvListadoUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvListadoUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoUsuarios.Size = New System.Drawing.Size(961, 473)
        Me.dgvListadoUsuarios.TabIndex = 0
        '
        'IdUsuario
        '
        Me.IdUsuario.DataPropertyName = "IdUsuario"
        Me.IdUsuario.HeaderText = "IdUsuario"
        Me.IdUsuario.Name = "IdUsuario"
        Me.IdUsuario.ReadOnly = True
        Me.IdUsuario.Visible = False
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "NOMBRE PERSONA"
        Me.Nombre.MinimumWidth = 220
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Usuario
        '
        Me.Usuario.DataPropertyName = "Usuario"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Usuario.DefaultCellStyle = DataGridViewCellStyle2
        Me.Usuario.HeaderText = "NOMBRE DE USUARIO"
        Me.Usuario.MinimumWidth = 200
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        Me.Usuario.Width = 300
        '
        'HashContrasenia
        '
        Me.HashContrasenia.DataPropertyName = "HashContrasenia"
        Me.HashContrasenia.HeaderText = "HASH"
        Me.HashContrasenia.MinimumWidth = 100
        Me.HashContrasenia.Name = "HashContrasenia"
        Me.HashContrasenia.ReadOnly = True
        Me.HashContrasenia.Visible = False
        '
        'SaltContrasenia
        '
        Me.SaltContrasenia.DataPropertyName = "SaltContrasenia"
        Me.SaltContrasenia.HeaderText = "SALT"
        Me.SaltContrasenia.MinimumWidth = 120
        Me.SaltContrasenia.Name = "SaltContrasenia"
        Me.SaltContrasenia.ReadOnly = True
        Me.SaltContrasenia.Visible = False
        Me.SaltContrasenia.Width = 120
        '
        'Privilegios
        '
        Me.Privilegios.DataPropertyName = "Privilegios"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Privilegios.DefaultCellStyle = DataGridViewCellStyle3
        Me.Privilegios.HeaderText = "PRIVILEGIOS"
        Me.Privilegios.MinimumWidth = 180
        Me.Privilegios.Name = "Privilegios"
        Me.Privilegios.ReadOnly = True
        Me.Privilegios.Width = 180
        '
        'IdPrivilegio
        '
        Me.IdPrivilegio.DataPropertyName = "IdPrivilegio"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.IdPrivilegio.DefaultCellStyle = DataGridViewCellStyle4
        Me.IdPrivilegio.HeaderText = "IdPrivilegioUsuarios"
        Me.IdPrivilegio.MinimumWidth = 150
        Me.IdPrivilegio.Name = "IdPrivilegio"
        Me.IdPrivilegio.ReadOnly = True
        Me.IdPrivilegio.Visible = False
        Me.IdPrivilegio.Width = 150
        '
        'Activo
        '
        Me.Activo.DataPropertyName = "Activo"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Activo.DefaultCellStyle = DataGridViewCellStyle5
        Me.Activo.HeaderText = "ACTIVO"
        Me.Activo.MinimumWidth = 100
        Me.Activo.Name = "Activo"
        Me.Activo.ReadOnly = True
        '
        'FechaUltimaModificacion
        '
        Me.FechaUltimaModificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FechaUltimaModificacion.DataPropertyName = "FechaUltimaModificacion"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FechaUltimaModificacion.DefaultCellStyle = DataGridViewCellStyle6
        Me.FechaUltimaModificacion.HeaderText = "FECHA ULTIMA MODIFICACION"
        Me.FechaUltimaModificacion.MinimumWidth = 130
        Me.FechaUltimaModificacion.Name = "FechaUltimaModificacion"
        Me.FechaUltimaModificacion.ReadOnly = True
        '
        'IdPrivilegio1
        '
        Me.IdPrivilegio1.DataPropertyName = "IdPrivilegio1"
        Me.IdPrivilegio1.HeaderText = "IdPrivilegioPrivilegios"
        Me.IdPrivilegio1.Name = "IdPrivilegio1"
        Me.IdPrivilegio1.ReadOnly = True
        Me.IdPrivilegio1.Visible = False
        '
        'IdUsuario1
        '
        Me.IdUsuario1.DataPropertyName = "IdUsuario1"
        Me.IdUsuario1.HeaderText = "IdUsuarioPrivilegios"
        Me.IdUsuario1.Name = "IdUsuario1"
        Me.IdUsuario1.ReadOnly = True
        Me.IdUsuario1.Visible = False
        '
        'FechaUltimaModificacion1
        '
        Me.FechaUltimaModificacion1.DataPropertyName = "FechaUltimaModificacion1"
        Me.FechaUltimaModificacion1.HeaderText = "FechaUltimaModificacionPrivilegios"
        Me.FechaUltimaModificacion1.Name = "FechaUltimaModificacion1"
        Me.FechaUltimaModificacion1.ReadOnly = True
        Me.FechaUltimaModificacion1.Visible = False
        '
        'lblVistaUsuarios
        '
        Me.lblVistaUsuarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVistaUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.lblVistaUsuarios.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVistaUsuarios.Location = New System.Drawing.Point(12, 9)
        Me.lblVistaUsuarios.Name = "lblVistaUsuarios"
        Me.lblVistaUsuarios.Size = New System.Drawing.Size(1121, 33)
        Me.lblVistaUsuarios.TabIndex = 1
        Me.lblVistaUsuarios.Text = "VISTA DE USUARIOS"
        Me.lblVistaUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnSalir.Image = Global.CapaPresentacionUsuarios.My.Resources.Resources.back
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(1004, 645)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(116, 39)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "    SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnAgregar.Image = Global.CapaPresentacionUsuarios.My.Resources.Resources.user_add
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(994, 562)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(139, 47)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "     AGREGAR NUEVO"
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'frmVistaUsuarios
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(1145, 719)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.lblVistaUsuarios)
        Me.Controls.Add(Me.dgvListadoUsuarios)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1161, 735)
        Me.Name = "frmVistaUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA USUARIOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvListadoUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvListadoUsuarios As DataGridView
    Friend WithEvents lblVistaUsuarios As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents IdUsuario As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents HashContrasenia As DataGridViewTextBoxColumn
    Friend WithEvents SaltContrasenia As DataGridViewTextBoxColumn
    Friend WithEvents Privilegios As DataGridViewTextBoxColumn
    Friend WithEvents IdPrivilegio As DataGridViewTextBoxColumn
    Friend WithEvents Activo As DataGridViewTextBoxColumn
    Friend WithEvents FechaUltimaModificacion As DataGridViewTextBoxColumn
    Friend WithEvents IdPrivilegio1 As DataGridViewTextBoxColumn
    Friend WithEvents IdUsuario1 As DataGridViewTextBoxColumn
    Friend WithEvents FechaUltimaModificacion1 As DataGridViewTextBoxColumn
End Class
