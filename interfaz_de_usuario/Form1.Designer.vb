<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.sid = New System.Windows.Forms.TextBox()
        Me.token = New System.Windows.Forms.TextBox()
        Me.from = New System.Windows.Forms.TextBox()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.text1 = New System.Windows.Forms.TextBox()
        Me.text2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sid
        '
        Me.sid.Location = New System.Drawing.Point(503, 35)
        Me.sid.Name = "sid"
        Me.sid.Size = New System.Drawing.Size(190, 20)
        Me.sid.TabIndex = 0
        Me.sid.Text = "ACf45f0edbc6fb3200cedcf141f6755a2a"
        Me.sid.Visible = False
        '
        'token
        '
        Me.token.Location = New System.Drawing.Point(503, 74)
        Me.token.Name = "token"
        Me.token.Size = New System.Drawing.Size(190, 20)
        Me.token.TabIndex = 1
        Me.token.Text = "64b7df381c915600b5d78bb5e3b43e20"
        Me.token.Visible = False
        '
        'from
        '
        Me.from.Location = New System.Drawing.Point(503, 110)
        Me.from.Name = "from"
        Me.from.Size = New System.Drawing.Size(190, 20)
        Me.from.TabIndex = 2
        Me.from.Text = "+12705889125"
        Me.from.Visible = False
        '
        'phone
        '
        Me.phone.Location = New System.Drawing.Point(503, 146)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(190, 20)
        Me.phone.TabIndex = 3
        Me.phone.Text = "+50258304382"
        Me.phone.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cyan
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.sid)
        Me.Panel1.Controls.Add(Me.token)
        Me.Panel1.Controls.Add(Me.from)
        Me.Panel1.Controls.Add(Me.phone)
        Me.Panel1.Location = New System.Drawing.Point(5, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(731, 182)
        Me.Panel1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(303, 401)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 49)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "REGISTRARSE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'text1
        '
        Me.text1.Location = New System.Drawing.Point(296, 238)
        Me.text1.Name = "text1"
        Me.text1.Size = New System.Drawing.Size(170, 20)
        Me.text1.TabIndex = 6
        '
        'text2
        '
        Me.text2.Location = New System.Drawing.Point(296, 316)
        Me.text2.Name = "text2"
        Me.text2.Size = New System.Drawing.Size(107, 20)
        Me.text2.TabIndex = 7
        Me.text2.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Aquamarine
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 371)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "INICIAR SECION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(472, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "CREAR USUARIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(409, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "CREAR CONTRASEÑA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(317, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "mostrar contraseña"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox1.Location = New System.Drawing.Point(296, 348)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(336, 371)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "LIMPIAR"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(320, 371)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 16
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.interfaz_de_usuario.My.Resources.Resources.png_clipart_password_strength_computer_security_password_policy_managed_security_service_procurement_icon_blue_logo1
        Me.PictureBox3.Location = New System.Drawing.Point(242, 300)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(47, 36)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.interfaz_de_usuario.My.Resources.Resources.transparent_hd_white_male_user_profile_icon_11637133256qticy7lqml
        Me.PictureBox2.Location = New System.Drawing.Point(242, 226)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(276, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(739, 450)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.text2)
        Me.Controls.Add(Me.text1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sid As TextBox
    Friend WithEvents token As TextBox
    Friend WithEvents from As TextBox
    Friend WithEvents phone As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents text1 As TextBox
    Friend WithEvents text2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox2 As CheckBox
End Class
