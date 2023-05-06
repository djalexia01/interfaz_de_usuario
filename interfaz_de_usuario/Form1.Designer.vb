<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.sid = New System.Windows.Forms.TextBox()
        Me.token = New System.Windows.Forms.TextBox()
        Me.from = New System.Windows.Forms.TextBox()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sid
        '
        Me.sid.Location = New System.Drawing.Point(241, 218)
        Me.sid.Name = "sid"
        Me.sid.Size = New System.Drawing.Size(190, 20)
        Me.sid.TabIndex = 0
        Me.sid.Text = "AC97905d6b36f6544304e13480e025c39d"
        Me.sid.Visible = False
        '
        'token
        '
        Me.token.Location = New System.Drawing.Point(241, 276)
        Me.token.Name = "token"
        Me.token.Size = New System.Drawing.Size(190, 20)
        Me.token.TabIndex = 1
        Me.token.Text = "d0c8a5268da9dd7206aa746fe21cca40"
        Me.token.Visible = False
        '
        'from
        '
        Me.from.Location = New System.Drawing.Point(241, 324)
        Me.from.Name = "from"
        Me.from.Size = New System.Drawing.Size(190, 20)
        Me.from.TabIndex = 2
        Me.from.Text = "+13184963466"
        Me.from.Visible = False
        '
        'phone
        '
        Me.phone.Location = New System.Drawing.Point(241, 368)
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
        Me.Panel1.Location = New System.Drawing.Point(5, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(670, 182)
        Me.Panel1.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(241, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(274, 394)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 49)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(678, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.from)
        Me.Controls.Add(Me.token)
        Me.Controls.Add(Me.sid)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
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
End Class
