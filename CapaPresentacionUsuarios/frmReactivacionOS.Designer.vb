<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReactivacionOS
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
        Me.lblReactivar = New System.Windows.Forms.Label()
        Me.dgvListadoOS = New System.Windows.Forms.DataGridView()
        Me.IdObraSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sigla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaUltimaModificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        CType(Me.dgvListadoOS, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblReactivar.Text = "REACTIVAR OBRAS SOCIALES"
        Me.lblReactivar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvListadoOS
        '
        Me.dgvListadoOS.AllowUserToAddRows = False
        Me.dgvListadoOS.AllowUserToDeleteRows = False
        Me.dgvListadoOS.AllowUserToResizeColumns = False
        Me.dgvListadoOS.AllowUserToResizeRows = False
        Me.dgvListadoOS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListadoOS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListadoOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoOS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdObraSocial, Me.Sigla, Me.NombreOS, Me.Activo, Me.IdUsuario, Me.FechaUltimaModificacion})
        Me.dgvListadoOS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvListadoOS.Location = New System.Drawing.Point(12, 88)
        Me.dgvListadoOS.MaximumSize = New System.Drawing.Size(801, 237)
        Me.dgvListadoOS.MinimumSize = New System.Drawing.Size(801, 237)
        Me.dgvListadoOS.MultiSelect = False
        Me.dgvListadoOS.Name = "dgvListadoOS"
        Me.dgvListadoOS.ReadOnly = True
        Me.dgvListadoOS.RowHeadersVisible = False
        Me.dgvListadoOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoOS.Size = New System.Drawing.Size(801, 237)
        Me.dgvListadoOS.TabIndex = 5
        '
        'IdObraSocial
        '
        Me.IdObraSocial.DataPropertyName = "IdObraSocial"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.IdObraSocial.DefaultCellStyle = DataGridViewCellStyle2
        Me.IdObraSocial.HeaderText = "IdObraSocial"
        Me.IdObraSocial.MinimumWidth = 100
        Me.IdObraSocial.Name = "IdObraSocial"
        Me.IdObraSocial.ReadOnly = True
        '
        'Sigla
        '
        Me.Sigla.DataPropertyName = "Sigla"
        Me.Sigla.HeaderText = "Sigla"
        Me.Sigla.MinimumWidth = 100
        Me.Sigla.Name = "Sigla"
        Me.Sigla.ReadOnly = True
        '
        'NombreOS
        '
        Me.NombreOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreOS.DataPropertyName = "NombreOS"
        Me.NombreOS.HeaderText = "NombreOS"
        Me.NombreOS.Name = "NombreOS"
        Me.NombreOS.ReadOnly = True
        '
        'Activo
        '
        Me.Activo.DataPropertyName = "Activo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Activo.DefaultCellStyle = DataGridViewCellStyle3
        Me.Activo.HeaderText = "Activo"
        Me.Activo.MinimumWidth = 100
        Me.Activo.Name = "Activo"
        Me.Activo.ReadOnly = True
        '
        'IdUsuario
        '
        Me.IdUsuario.DataPropertyName = "IdUsuario"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.IdUsuario.DefaultCellStyle = DataGridViewCellStyle4
        Me.IdUsuario.HeaderText = "IdUsuario"
        Me.IdUsuario.MinimumWidth = 100
        Me.IdUsuario.Name = "IdUsuario"
        Me.IdUsuario.ReadOnly = True
        '
        'FechaUltimaModificacion
        '
        Me.FechaUltimaModificacion.DataPropertyName = "FechaUltimaModificacion"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FechaUltimaModificacion.DefaultCellStyle = DataGridViewCellStyle5
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
        Me.btnSalir.Location = New System.Drawing.Point(428, 346)
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
        Me.btnConfirmar.Location = New System.Drawing.Point(235, 346)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(114, 47)
        Me.btnConfirmar.TabIndex = 4
        Me.btnConfirmar.Text = "CONFIRMAR"
        Me.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'frmReactivacionOS
        '
        Me.AcceptButton = Me.btnConfirmar
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(825, 422)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblReactivar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.dgvListadoOS)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(841, 461)
        Me.MinimumSize = New System.Drawing.Size(841, 461)
        Me.Name = "frmReactivacionOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REACTIVACIONES"
        CType(Me.dgvListadoOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblReactivar As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents dgvListadoOS As DataGridView
    Friend WithEvents IdObraSocial As DataGridViewTextBoxColumn
    Friend WithEvents Sigla As DataGridViewTextBoxColumn
    Friend WithEvents NombreOS As DataGridViewTextBoxColumn
    Friend WithEvents Activo As DataGridViewTextBoxColumn
    Friend WithEvents IdUsuario As DataGridViewTextBoxColumn
    Friend WithEvents FechaUltimaModificacion As DataGridViewTextBoxColumn
End Class
