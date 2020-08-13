<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionOS
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblObraSocial = New System.Windows.Forms.Label()
        Me.lblSigla = New System.Windows.Forms.Label()
        Me.lblNombreOS = New System.Windows.Forms.Label()
        Me.txtSigla = New System.Windows.Forms.TextBox()
        Me.txtNombreOS = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnAceptar.Image = Global.CapaPresentacionObrasSociales.My.Resources.Resources.ok
        Me.btnAceptar.Location = New System.Drawing.Point(177, 327)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(121, 47)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnCancelar.Image = Global.CapaPresentacionObrasSociales.My.Resources.Resources.stop_error
        Me.btnCancelar.Location = New System.Drawing.Point(379, 327)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(121, 47)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblObraSocial
        '
        Me.lblObraSocial.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObraSocial.Location = New System.Drawing.Point(12, 9)
        Me.lblObraSocial.MaximumSize = New System.Drawing.Size(666, 33)
        Me.lblObraSocial.MinimumSize = New System.Drawing.Size(666, 33)
        Me.lblObraSocial.Name = "lblObraSocial"
        Me.lblObraSocial.Size = New System.Drawing.Size(666, 33)
        Me.lblObraSocial.TabIndex = 2
        Me.lblObraSocial.Text = "OBRA SOCIAL"
        Me.lblObraSocial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSigla
        '
        Me.lblSigla.AutoSize = True
        Me.lblSigla.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblSigla.Location = New System.Drawing.Point(134, 137)
        Me.lblSigla.Name = "lblSigla"
        Me.lblSigla.Size = New System.Drawing.Size(139, 19)
        Me.lblSigla.TabIndex = 3
        Me.lblSigla.Text = "SIGLA OBRA SOCIAL"
        '
        'lblNombreOS
        '
        Me.lblNombreOS.AutoSize = True
        Me.lblNombreOS.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.lblNombreOS.Location = New System.Drawing.Point(134, 205)
        Me.lblNombreOS.Name = "lblNombreOS"
        Me.lblNombreOS.Size = New System.Drawing.Size(162, 19)
        Me.lblNombreOS.TabIndex = 4
        Me.lblNombreOS.Text = "NOMBRE OBRA SOCIAL"
        '
        'txtSigla
        '
        Me.txtSigla.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtSigla.Location = New System.Drawing.Point(302, 134)
        Me.txtSigla.Name = "txtSigla"
        Me.txtSigla.Size = New System.Drawing.Size(90, 27)
        Me.txtSigla.TabIndex = 1
        '
        'txtNombreOS
        '
        Me.txtNombreOS.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.txtNombreOS.Location = New System.Drawing.Point(302, 202)
        Me.txtNombreOS.Name = "txtNombreOS"
        Me.txtNombreOS.Size = New System.Drawing.Size(263, 27)
        Me.txtNombreOS.TabIndex = 2
        '
        'btnModificar
        '
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnModificar.Image = Global.CapaPresentacionObrasSociales.My.Resources.Resources.edit2
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(539, 274)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(139, 47)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.Text = "MODIFICAR REGISTRO"
        Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBaja.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.btnBaja.Image = Global.CapaPresentacionObrasSociales.My.Resources.Resources.remove
        Me.btnBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBaja.Location = New System.Drawing.Point(539, 327)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(139, 47)
        Me.btnBaja.TabIndex = 4
        Me.btnBaja.Text = "BAJA REGISTRO"
        Me.btnBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'frmGestionOS
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(690, 458)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.txtNombreOS)
        Me.Controls.Add(Me.txtSigla)
        Me.Controls.Add(Me.lblNombreOS)
        Me.Controls.Add(Me.lblSigla)
        Me.Controls.Add(Me.lblObraSocial)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximumSize = New System.Drawing.Size(706, 497)
        Me.MinimumSize = New System.Drawing.Size(706, 497)
        Me.Name = "frmGestionOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OBRAS SOCIALES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblObraSocial As Label
    Friend WithEvents lblSigla As Label
    Friend WithEvents lblNombreOS As Label
    Friend WithEvents txtSigla As TextBox
    Friend WithEvents txtNombreOS As TextBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnBaja As Button
End Class
