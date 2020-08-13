<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTurnos
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTurnos))
        Me.lblTurnos = New System.Windows.Forms.Label()
        Me.dgvTurnos = New System.Windows.Forms.DataGridView()
        Me.IdTurno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraTurno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPaciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Paciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpFechaTurno = New System.Windows.Forms.DateTimePicker()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBuscarProfes = New System.Windows.Forms.Button()
        Me.btnFechaSig = New System.Windows.Forms.Button()
        Me.btnFechaAct = New System.Windows.Forms.Button()
        Me.btnFechaAnt = New System.Windows.Forms.Button()
        Me.btnBorrarTurno = New System.Windows.Forms.Button()
        CType(Me.dgvTurnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTurnos
        '
        Me.lblTurnos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTurnos.BackColor = System.Drawing.Color.Transparent
        Me.lblTurnos.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurnos.Location = New System.Drawing.Point(12, 9)
        Me.lblTurnos.MinimumSize = New System.Drawing.Size(300, 33)
        Me.lblTurnos.Name = "lblTurnos"
        Me.lblTurnos.Size = New System.Drawing.Size(1121, 33)
        Me.lblTurnos.TabIndex = 0
        Me.lblTurnos.Text = "GESTION DE TURNOS"
        Me.lblTurnos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvTurnos
        '
        Me.dgvTurnos.AllowUserToAddRows = False
        Me.dgvTurnos.AllowUserToDeleteRows = False
        Me.dgvTurnos.AllowUserToResizeColumns = False
        Me.dgvTurnos.AllowUserToResizeRows = False
        Me.dgvTurnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTurnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTurnos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTurnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTurnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTurnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdTurno, Me.HoraTurno, Me.IdPaciente, Me.Paciente})
        Me.dgvTurnos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvTurnos.Location = New System.Drawing.Point(12, 211)
        Me.dgvTurnos.MinimumSize = New System.Drawing.Size(897, 468)
        Me.dgvTurnos.MultiSelect = False
        Me.dgvTurnos.Name = "dgvTurnos"
        Me.dgvTurnos.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 10.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTurnos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTurnos.RowHeadersVisible = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold)
        Me.dgvTurnos.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTurnos.Size = New System.Drawing.Size(897, 468)
        Me.dgvTurnos.TabIndex = 1
        '
        'IdTurno
        '
        Me.IdTurno.HeaderText = "IdTurno"
        Me.IdTurno.Name = "IdTurno"
        Me.IdTurno.ReadOnly = True
        Me.IdTurno.Visible = False
        Me.IdTurno.Width = 76
        '
        'HoraTurno
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.HoraTurno.DefaultCellStyle = DataGridViewCellStyle2
        Me.HoraTurno.HeaderText = "HORA TURNO"
        Me.HoraTurno.MinimumWidth = 120
        Me.HoraTurno.Name = "HoraTurno"
        Me.HoraTurno.ReadOnly = True
        Me.HoraTurno.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.HoraTurno.Width = 120
        '
        'IdPaciente
        '
        Me.IdPaciente.HeaderText = "IdPaciente"
        Me.IdPaciente.Name = "IdPaciente"
        Me.IdPaciente.ReadOnly = True
        Me.IdPaciente.Visible = False
        Me.IdPaciente.Width = 93
        '
        'Paciente
        '
        Me.Paciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Paciente.DefaultCellStyle = DataGridViewCellStyle3
        Me.Paciente.HeaderText = "PACIENTE"
        Me.Paciente.Name = "Paciente"
        Me.Paciente.ReadOnly = True
        Me.Paciente.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'dtpFechaTurno
        '
        Me.dtpFechaTurno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFechaTurno.CalendarFont = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaTurno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpFechaTurno.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.dtpFechaTurno.Location = New System.Drawing.Point(630, 120)
        Me.dtpFechaTurno.Name = "dtpFechaTurno"
        Me.dtpFechaTurno.Size = New System.Drawing.Size(279, 27)
        Me.dtpFechaTurno.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnSalir.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.back
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(973, 640)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(116, 39)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "    SALIR"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnBuscarProfes
        '
        Me.btnBuscarProfes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarProfes.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscarProfes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarProfes.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnBuscarProfes.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.users2
        Me.btnBuscarProfes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarProfes.Location = New System.Drawing.Point(959, 554)
        Me.btnBuscarProfes.Name = "btnBuscarProfes"
        Me.btnBuscarProfes.Size = New System.Drawing.Size(148, 47)
        Me.btnBuscarProfes.TabIndex = 12
        Me.btnBuscarProfes.Text = "SELECCIONAR PROFESIONAL"
        Me.btnBuscarProfes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscarProfes.UseVisualStyleBackColor = False
        '
        'btnFechaSig
        '
        Me.btnFechaSig.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFechaSig.BackColor = System.Drawing.Color.Transparent
        Me.btnFechaSig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechaSig.Image = Global.CapaPresentacionPersonas.My.Resources.Resources._next
        Me.btnFechaSig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFechaSig.Location = New System.Drawing.Point(796, 155)
        Me.btnFechaSig.Name = "btnFechaSig"
        Me.btnFechaSig.Size = New System.Drawing.Size(44, 43)
        Me.btnFechaSig.TabIndex = 11
        Me.btnFechaSig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechaSig.UseVisualStyleBackColor = False
        '
        'btnFechaAct
        '
        Me.btnFechaAct.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFechaAct.BackColor = System.Drawing.Color.Transparent
        Me.btnFechaAct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechaAct.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.reload
        Me.btnFechaAct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFechaAct.Location = New System.Drawing.Point(746, 155)
        Me.btnFechaAct.Name = "btnFechaAct"
        Me.btnFechaAct.Size = New System.Drawing.Size(44, 43)
        Me.btnFechaAct.TabIndex = 10
        Me.btnFechaAct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechaAct.UseVisualStyleBackColor = False
        '
        'btnFechaAnt
        '
        Me.btnFechaAnt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFechaAnt.BackColor = System.Drawing.Color.Transparent
        Me.btnFechaAnt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFechaAnt.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.previous
        Me.btnFechaAnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFechaAnt.Location = New System.Drawing.Point(696, 155)
        Me.btnFechaAnt.Name = "btnFechaAnt"
        Me.btnFechaAnt.Size = New System.Drawing.Size(44, 43)
        Me.btnFechaAnt.TabIndex = 9
        Me.btnFechaAnt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechaAnt.UseVisualStyleBackColor = False
        '
        'btnBorrarTurno
        '
        Me.btnBorrarTurno.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBorrarTurno.BackColor = System.Drawing.Color.Transparent
        Me.btnBorrarTurno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrarTurno.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnBorrarTurno.Image = Global.CapaPresentacionPersonas.My.Resources.Resources.remove
        Me.btnBorrarTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrarTurno.Location = New System.Drawing.Point(959, 477)
        Me.btnBorrarTurno.Name = "btnBorrarTurno"
        Me.btnBorrarTurno.Size = New System.Drawing.Size(148, 47)
        Me.btnBorrarTurno.TabIndex = 6
        Me.btnBorrarTurno.Text = "  BORRAR TURNO"
        Me.btnBorrarTurno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBorrarTurno.UseVisualStyleBackColor = False
        '
        'frmTurnos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(1145, 719)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBuscarProfes)
        Me.Controls.Add(Me.btnFechaSig)
        Me.Controls.Add(Me.btnFechaAct)
        Me.Controls.Add(Me.btnFechaAnt)
        Me.Controls.Add(Me.btnBorrarTurno)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dtpFechaTurno)
        Me.Controls.Add(Me.dgvTurnos)
        Me.Controls.Add(Me.lblTurnos)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1161, 735)
        Me.Name = "frmTurnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TURNOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvTurnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTurnos As Label
    Friend WithEvents dgvTurnos As DataGridView
    Friend WithEvents dtpFechaTurno As DateTimePicker
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnBorrarTurno As Button
    Friend WithEvents btnFechaAnt As Button
    Friend WithEvents btnFechaAct As Button
    Friend WithEvents btnFechaSig As Button
    Friend WithEvents btnBuscarProfes As Button
    Friend WithEvents IdTurno As DataGridViewTextBoxColumn
    Friend WithEvents HoraTurno As DataGridViewTextBoxColumn
    Friend WithEvents IdPaciente As DataGridViewTextBoxColumn
    Friend WithEvents Paciente As DataGridViewTextBoxColumn
End Class
