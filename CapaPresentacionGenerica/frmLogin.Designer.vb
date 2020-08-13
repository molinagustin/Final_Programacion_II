<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblContrasenia = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContrasenia = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCambioContra = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.lblImagenUsuario = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(297, 79)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(69, 19)
        Me.lblUsuario.TabIndex = 1
        Me.lblUsuario.Text = "USUARIO"
        '
        'lblContrasenia
        '
        Me.lblContrasenia.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblContrasenia.AutoSize = True
        Me.lblContrasenia.Location = New System.Drawing.Point(297, 132)
        Me.lblContrasenia.Name = "lblContrasenia"
        Me.lblContrasenia.Size = New System.Drawing.Size(99, 19)
        Me.lblContrasenia.TabIndex = 2
        Me.lblContrasenia.Text = "CONTRASEÑA"
        '
        'txtUsuario
        '
        Me.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtUsuario.Location = New System.Drawing.Point(418, 76)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(188, 27)
        Me.txtUsuario.TabIndex = 1
        '
        'txtContrasenia
        '
        Me.txtContrasenia.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtContrasenia.Location = New System.Drawing.Point(418, 132)
        Me.txtContrasenia.Name = "txtContrasenia"
        Me.txtContrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasenia.Size = New System.Drawing.Size(188, 27)
        Me.txtContrasenia.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(527, 205)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(115, 38)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCambioContra
        '
        Me.btnCambioContra.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCambioContra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCambioContra.Location = New System.Drawing.Point(226, 205)
        Me.btnCambioContra.Name = "btnCambioContra"
        Me.btnCambioContra.Size = New System.Drawing.Size(174, 38)
        Me.btnCambioContra.TabIndex = 5
        Me.btnCambioContra.Text = "CAMBIAR CONTRASEÑA"
        Me.btnCambioContra.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngresar.Location = New System.Drawing.Point(406, 205)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(115, 38)
        Me.btnIngresar.TabIndex = 3
        Me.btnIngresar.Text = "INGRESAR"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'lblImagenUsuario
        '
        Me.lblImagenUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblImagenUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblImagenUsuario.Image = Global.CapaPresentacionGenerica.My.Resources.Resources.usuario
        Me.lblImagenUsuario.Location = New System.Drawing.Point(-3, 9)
        Me.lblImagenUsuario.Name = "lblImagenUsuario"
        Me.lblImagenUsuario.Size = New System.Drawing.Size(242, 203)
        Me.lblImagenUsuario.TabIndex = 0
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnIngresar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(669, 255)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCambioContra)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtContrasenia)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblContrasenia)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblImagenUsuario)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(685, 294)
        Me.MinimumSize = New System.Drawing.Size(685, 294)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INICIO SESION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblImagenUsuario As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblContrasenia As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContrasenia As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnCambioContra As Button
End Class
