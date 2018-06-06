<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpen))
        Me.btnLog = New System.Windows.Forms.Button()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblInvalid = New System.Windows.Forms.Label()
        Me.txtRegPass = New System.Windows.Forms.TextBox()
        Me.txtRegUser = New System.Windows.Forms.TextBox()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.lblRegInvalid = New System.Windows.Forms.Label()
        Me.txtHighScores = New System.Windows.Forms.TextBox()
        Me.lblHighScores = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnLog
        '
        Me.btnLog.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLog.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLog.ForeColor = System.Drawing.Color.Lime
        Me.btnLog.Location = New System.Drawing.Point(43, 116)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(141, 23)
        Me.btnLog.TabIndex = 1
        Me.btnLog.Text = "Log On"
        Me.btnLog.UseVisualStyleBackColor = False
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtUser.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.Lime
        Me.txtUser.Location = New System.Drawing.Point(43, 27)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(141, 20)
        Me.txtUser.TabIndex = 2
        Me.txtUser.Text = "Username"
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPass.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.Lime
        Me.txtPass.Location = New System.Drawing.Point(43, 63)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(141, 20)
        Me.txtPass.TabIndex = 3
        Me.txtPass.Text = "Password"
        '
        'lblInvalid
        '
        Me.lblInvalid.AutoSize = True
        Me.lblInvalid.Location = New System.Drawing.Point(43, 90)
        Me.lblInvalid.Name = "lblInvalid"
        Me.lblInvalid.Size = New System.Drawing.Size(0, 13)
        Me.lblInvalid.TabIndex = 4
        '
        'txtRegPass
        '
        Me.txtRegPass.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtRegPass.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegPass.ForeColor = System.Drawing.Color.Lime
        Me.txtRegPass.Location = New System.Drawing.Point(43, 221)
        Me.txtRegPass.Name = "txtRegPass"
        Me.txtRegPass.Size = New System.Drawing.Size(141, 20)
        Me.txtRegPass.TabIndex = 7
        Me.txtRegPass.Text = "Password"
        '
        'txtRegUser
        '
        Me.txtRegUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtRegUser.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegUser.ForeColor = System.Drawing.Color.Lime
        Me.txtRegUser.Location = New System.Drawing.Point(43, 183)
        Me.txtRegUser.Name = "txtRegUser"
        Me.txtRegUser.Size = New System.Drawing.Size(141, 20)
        Me.txtRegUser.TabIndex = 6
        Me.txtRegUser.Text = "Username"
        '
        'btnReg
        '
        Me.btnReg.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnReg.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReg.ForeColor = System.Drawing.Color.Lime
        Me.btnReg.Location = New System.Drawing.Point(43, 279)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(141, 23)
        Me.btnReg.TabIndex = 5
        Me.btnReg.Text = "Register"
        Me.btnReg.UseVisualStyleBackColor = False
        '
        'lblRegInvalid
        '
        Me.lblRegInvalid.AutoSize = True
        Me.lblRegInvalid.Location = New System.Drawing.Point(43, 254)
        Me.lblRegInvalid.Name = "lblRegInvalid"
        Me.lblRegInvalid.Size = New System.Drawing.Size(0, 13)
        Me.lblRegInvalid.TabIndex = 8
        '
        'txtHighScores
        '
        Me.txtHighScores.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtHighScores.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHighScores.ForeColor = System.Drawing.Color.Lime
        Me.txtHighScores.Location = New System.Drawing.Point(244, 56)
        Me.txtHighScores.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHighScores.Multiline = True
        Me.txtHighScores.Name = "txtHighScores"
        Me.txtHighScores.Size = New System.Drawing.Size(223, 255)
        Me.txtHighScores.TabIndex = 9
        '
        'lblHighScores
        '
        Me.lblHighScores.AutoSize = True
        Me.lblHighScores.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighScores.Location = New System.Drawing.Point(242, 27)
        Me.lblHighScores.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHighScores.Name = "lblHighScores"
        Me.lblHighScores.Size = New System.Drawing.Size(203, 14)
        Me.lblHighScores.TabIndex = 10
        Me.lblHighScores.Text = "Top Users On Your Computer: "
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Lime
        Me.TextBox1.Location = New System.Drawing.Point(517, 27)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(217, 284)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmOpen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(767, 324)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblHighScores)
        Me.Controls.Add(Me.txtHighScores)
        Me.Controls.Add(Me.lblRegInvalid)
        Me.Controls.Add(Me.txtRegPass)
        Me.Controls.Add(Me.txtRegUser)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.lblInvalid)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.btnLog)
        Me.ForeColor = System.Drawing.Color.Lime
        Me.Name = "frmOpen"
        Me.Text = "VB Stocks Log On Screen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLog As System.Windows.Forms.Button
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblInvalid As System.Windows.Forms.Label
    Friend WithEvents txtRegUser As System.Windows.Forms.TextBox
    Friend WithEvents btnReg As System.Windows.Forms.Button
    Friend WithEvents lblRegInvalid As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtRegPass As System.Windows.Forms.TextBox
    Friend WithEvents txtHighScores As System.Windows.Forms.TextBox
    Friend WithEvents lblHighScores As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
