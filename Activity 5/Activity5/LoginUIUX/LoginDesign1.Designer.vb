<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginDesign1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button1)
        Me.Guna2GroupBox1.Controls.Add(Me.password)
        Me.Guna2GroupBox1.Controls.Add(Me.username)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(373, 521)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.LoginUIUX.My.Resources.Resource1.logo
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(367, 200)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 3
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 6
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.DisabledState.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(46, 387)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(280, 45)
        Me.Guna2Button1.TabIndex = 2
        Me.Guna2Button1.Text = "LOGIN"
        '
        'password
        '
        Me.password.AutoRoundedCorners = True
        Me.password.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.password.BorderRadius = 22
        Me.password.BorderThickness = 2
        Me.password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password.DefaultText = ""
        Me.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password.DisabledState.Parent = Me.password
        Me.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password.FocusedState.Parent = Me.password
        Me.password.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password.HoverState.Parent = Me.password
        Me.password.Location = New System.Drawing.Point(46, 287)
        Me.password.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.password.PlaceholderText = "Password"
        Me.password.SelectedText = ""
        Me.password.ShadowDecoration.Parent = Me.password
        Me.password.Size = New System.Drawing.Size(280, 47)
        Me.password.TabIndex = 1
        '
        'username
        '
        Me.username.AutoRoundedCorners = True
        Me.username.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.username.BorderRadius = 22
        Me.username.BorderThickness = 2
        Me.username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.username.DefaultText = ""
        Me.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.username.DisabledState.Parent = Me.username
        Me.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.username.FocusedState.Parent = Me.username
        Me.username.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.username.HoverState.Parent = Me.username
        Me.username.Location = New System.Drawing.Point(46, 205)
        Me.username.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.username.Name = "username"
        Me.username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.username.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.username.PlaceholderText = "Username"
        Me.username.SelectedText = ""
        Me.username.ShadowDecoration.Parent = Me.username
        Me.username.Size = New System.Drawing.Size(280, 47)
        Me.username.TabIndex = 0
        '
        'LoginDesign1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(400, 545)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginDesign1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Guna2GroupBox1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
