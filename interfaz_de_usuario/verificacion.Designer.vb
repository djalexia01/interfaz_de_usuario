<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class verificacion
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.regresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(66, 97)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(195, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(66, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 53)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "VALIDACION DE CUENTA"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'regresar
        '
        Me.regresar.BackColor = System.Drawing.Color.Gray
        Me.regresar.Location = New System.Drawing.Point(83, 317)
        Me.regresar.Name = "regresar"
        Me.regresar.Size = New System.Drawing.Size(128, 23)
        Me.regresar.TabIndex = 2
        Me.regresar.Text = "REGRESAR A INICIO"
        Me.regresar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(136, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "LIMPIAR"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Location = New System.Drawing.Point(115, 184)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Location = New System.Drawing.Point(105, 138)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 6
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(136, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "mostrar contraseña"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.interfaz_de_usuario.My.Resources.Resources.x_ray_1704855_12801
        Me.PictureBox1.Location = New System.Drawing.Point(-7, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(351, 454)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(68, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "INGRESAR CODIGO DE VALIDACION"
        '
        'verificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(337, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.regresar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "verificacion"
        Me.Text = "verificacion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents regresar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
