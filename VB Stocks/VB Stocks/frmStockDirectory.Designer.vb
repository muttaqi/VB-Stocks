<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockDirectory
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
        Me.txtStockDirectory = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtStockDirectory
        '
        Me.txtStockDirectory.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtStockDirectory.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockDirectory.ForeColor = System.Drawing.Color.Lime
        Me.txtStockDirectory.Location = New System.Drawing.Point(12, 12)
        Me.txtStockDirectory.Multiline = True
        Me.txtStockDirectory.Name = "txtStockDirectory"
        Me.txtStockDirectory.ReadOnly = True
        Me.txtStockDirectory.Size = New System.Drawing.Size(771, 425)
        Me.txtStockDirectory.TabIndex = 0
        '
        'frmStockDirectory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(795, 453)
        Me.Controls.Add(Me.txtStockDirectory)
        Me.ForeColor = System.Drawing.Color.Lime
        Me.Name = "frmStockDirectory"
        Me.Text = "Stock Directory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtStockDirectory As System.Windows.Forms.TextBox
End Class
