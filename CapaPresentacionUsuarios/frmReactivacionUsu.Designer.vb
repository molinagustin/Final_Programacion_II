<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReactivacionUsu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblReactivar = New System.Windows.Forms.Label()
        Me.dgvListadoUsu = New System.Windows.Forms.DataGridView()
        Me.IdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HashContrasenia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaltContrasenia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPrivilegio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaUltimaModificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        CType(Me.dgvListadoUsu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblReactivar
        '
        Me.lblReactivar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblReactivar.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReactivar.Location = New System.Drawing.Point(12, 9)
        Me.lblReactivar.MaximumSize = New System.Drawing.Size(801, 29)
        Me.lblReactivar.MinimumSize = New System.Drawing.Size(801, 29)
        Me.lblReactivar.Name = "lblReactivar"
        Me.lblReactivar.Size = New System.Drawing.Size(801, 29)
        Me.lblReactivar.TabIndex = 7
        Me.lblReactivar.Text = "REACTIVAR USUARIOS"
        Me.lblReactivar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvListadoUsu
        '
        Me.dgvListadoUsu.AllowUserToAddRows = False
        Me.dgvListadoUsu.AllowUserToDeleteRows = False
        Me.dgvListadoUsu.AllowUserToResizeColumns = False
        Me.dgvListadoUsu.AllowUserToResizeRows = False
        Me.dgvListadoUsu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListadoUsu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListadoUsu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoUsu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoUsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoUsu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdUsuario, Me.Nombre, Me.Usuario, Me.HashContrasenia, Me.SaltContrasenia, Me.IdPrivilegio, Me.Activo, Me.FechaUltimaModificacion})
        Me.dgvListadoUsu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvListadoUsu.Location = New System.Drawing.Point(12, 88)
        Me.dgvListadoUsu.MaximumSize = New System.Drawing.Size(801, 237)
        Me.dgvListadoUsu.MinimumSize = New System.Drawing.Size(801, 237)
        Me.dgvListadoUsu.MultiSelect = False
        Me.dgvListadoUsu.Name = "dgvListadoUsu"
        Me.dgvListadoUsu.ReadOnly = True
        Me.dgvListadoUsu.RowHeadersVisible = False
        Me.dgvListadoUsu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoUsu.Size = New System.Drawing.Size(801, 237)
        Me.dgvListadoUsu.TabIndex = 5
        '
        'IdUsuario
        '
        Me.IdUsuario.DataPropertyName = "IdUsuario"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.IdUsuario.DefaultCellStyle = DataGridViewCellStyle2
        Me.IdUsuario.HeaderText = "IdUsuario"
        Me.IdUsuario.MinimumWidth = 100
        Me.IdUsuario.Name = "IdUsuario"
        Me.IdUsuario.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Visible = False
        '
        'Usuario
        '
        Me.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Usuario.DataPropertyName = "Usuario"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Usuario.DefaultCellStyle = DataGridViewCellStyle3
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.MinimumWidth = 120
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        '
        'HashContrasenia
        '
        Me.HashContrasenia.DataPropertyName = "HashContrasenia"
        Me.HashContrasenia.HeaderText = "HashContrasenia"
        Me.HashContrasenia.Name = "HashContrasenia"
        Me.HashContrasenia.ReadOnly = True
        Me.HashContrasenia.Visible = False
        '
        'SaltContrasenia
        '
        Me.SaltContrasenia.DataPropertyName = "SaltContrasenia"
        Me.SaltContrasenia.HeaderText = "SaltContrasenia"
        Me.SaltContrasenia.Name = "SaltContrasenia"
        Me.SaltContrasenia.ReadOnly = True
        Me.SaltContrasenia.Visible = False
        '
        'IdPrivilegio
        '
        Me.IdPrivilegio.DataPropertyName = "IdPrivilegio"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.IdPrivilegio.DefaultCellStyle = DataGridViewCellStyle4
        Me.IdPrivilegio.HeaderText = "IdPrivilegio"
        Me.IdPrivilegio.MinimumWidth = 120
        Me.IdPrivilegio.Name = "IdPrivilegio"
        Me.IdPrivilegio.ReadOnly = True
        Me.IdPrivilegio.Width = 120
        '
        'Activo
        '
        Me.Activo.DataPropertyName = "Activo"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Activo.DefaultCellStyle = DataGridViewCellStyle5
        Me.Activo.HeaderText = "Activo"
        Me.Activo.MinimumWidth = 100
        Me.Activo.Name = "Activo"
        Me.Activo.ReadOnly = True
        '
        'FechaUltimaModificacion
        '
        Me.FechaUltimaModificacion.DataPropertyName = "FechaUltimaModificacion"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FechaUltimaModificacion.DefaultCellStyle = DataGridViewCellStyle6
        Me.FechaUltimaModificacion.HeaderText = "FechaUltimaModificacion"
        Me.FechaUltimaModificacion.MinimumWidth = 150
        Me.FechaUltimaModificacion.Name = "FechaUltimaModificacion"
        Me.FechaUltimaModificacion.ReadOnly = True
        Me.FechaUltimaModificacion.Width = 150
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = Global.CapaPresentacionUsuarios.My.Resources.Resources.back
        Me.btnSalir.Location = New System.Drawing.Point(434, 349)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(114, 47)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "    SALIR"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirmar.Image = Global.CapaPresentacionUsuarios.My.Resources.Resources.ok
        Me.btnConfirmar.Location = New System.Drawing.Point(241, 349)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(114, 47)
        Me.btnConfirmar.TabIndex = 4
        Me.btnConfirmar.Text = "CONFIRMAR"
        Me.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'frmReactivacionUsu
        '
        Me.AcceptButton = Me.btnConfirmar
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(825, 422)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblReactivar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.dgvListadoUsu)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(841, 461)
        Me.MinimumSize = New System.Drawing.Size(841, 461)
        Me.Name = "frmReactivacionUsu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REACTIVACIONES"
        CType(Me.dgvListadoUsu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblReactivar As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents dgvListadoUsu As DataGridView
    Friend WithEvents IdUsuario As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents HashContrasenia As DataGridViewTextBoxColumn
    Friend WithEvents SaltContrasenia As DataGridViewTextBoxColumn
    Friend WithEvents IdPrivilegio As DataGridViewTextBoxColumn
    Friend WithEvents Activo As DataGridViewTextBoxColumn
    Friend WithEvents FechaUltimaModificacion As DataGridViewTextBoxColumn
End Class
