<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetirement
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
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.lblDeposit = New System.Windows.Forms.Label()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.pbrAccount = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'btnDeposit
        '
        Me.btnDeposit.BackColor = System.Drawing.Color.Black
        Me.btnDeposit.Location = New System.Drawing.Point(273, 111)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(163, 25)
        Me.btnDeposit.TabIndex = 0
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = False
        '
        'lblDeposit
        '
        Me.lblDeposit.AutoSize = True
        Me.lblDeposit.Location = New System.Drawing.Point(14, 114)
        Me.lblDeposit.Name = "lblDeposit"
        Me.lblDeposit.Size = New System.Drawing.Size(119, 14)
        Me.lblDeposit.TabIndex = 1
        Me.lblDeposit.Text = "Deposit Amount: "
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(124, 111)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(142, 20)
        Me.txtDeposit.TabIndex = 2
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.Location = New System.Drawing.Point(14, 30)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(126, 14)
        Me.lblAccount.TabIndex = 3
        Me.lblAccount.Text = "Current Account: "
        '
        'pbrAccount
        '
        Me.pbrAccount.Location = New System.Drawing.Point(17, 61)
        Me.pbrAccount.Name = "pbrAccount"
        Me.pbrAccount.Size = New System.Drawing.Size(419, 25)
        Me.pbrAccount.TabIndex = 4
        '
        'frmRetirement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(450, 216)
        Me.Controls.Add(Me.pbrAccount)
        Me.Controls.Add(Me.lblAccount)
        Me.Controls.Add(Me.txtDeposit)
        Me.Controls.Add(Me.lblDeposit)
        Me.Controls.Add(Me.btnDeposit)
        Me.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Lime
        Me.Name = "frmRetirement"
        Me.Text = "Retirement Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDeposit As System.Windows.Forms.Button
    Friend WithEvents lblDeposit As System.Windows.Forms.Label
    Friend WithEvents txtDeposit As System.Windows.Forms.TextBox
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents pbrAccount As System.Windows.Forms.ProgressBar
End Class
