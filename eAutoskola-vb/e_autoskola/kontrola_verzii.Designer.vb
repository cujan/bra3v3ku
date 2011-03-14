<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kontrola_verzii
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(kontrola_verzii))
        Me.verzie_text = New System.Windows.Forms.Label
        Me.microsoft = New System.Windows.Forms.Label
        Me.instaluj = New System.Windows.Forms.Button
        Me.zavriet = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'verzie_text
        '
        Me.verzie_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verzie_text.Location = New System.Drawing.Point(21, 22)
        Me.verzie_text.Name = "verzie_text"
        Me.verzie_text.Size = New System.Drawing.Size(391, 78)
        Me.verzie_text.TabIndex = 0
        Me.verzie_text.Text = resources.GetString("verzie_text.Text")
        '
        'microsoft
        '
        Me.microsoft.AutoSize = True
        Me.microsoft.Cursor = System.Windows.Forms.Cursors.Hand
        Me.microsoft.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.microsoft.ForeColor = System.Drawing.SystemColors.Desktop
        Me.microsoft.Location = New System.Drawing.Point(22, 72)
        Me.microsoft.Name = "microsoft"
        Me.microsoft.Size = New System.Drawing.Size(95, 17)
        Me.microsoft.TabIndex = 1
        Me.microsoft.Text = "microsoft.com"
        '
        'instaluj
        '
        Me.instaluj.Location = New System.Drawing.Point(61, 103)
        Me.instaluj.Name = "instaluj"
        Me.instaluj.Size = New System.Drawing.Size(112, 26)
        Me.instaluj.TabIndex = 2
        Me.instaluj.Text = "Inštaluj"
        Me.instaluj.UseVisualStyleBackColor = True
        '
        'zavriet
        '
        Me.zavriet.Location = New System.Drawing.Point(220, 103)
        Me.zavriet.Name = "zavriet"
        Me.zavriet.Size = New System.Drawing.Size(112, 26)
        Me.zavriet.TabIndex = 3
        Me.zavriet.Text = "Zavrieť"
        Me.zavriet.UseVisualStyleBackColor = True
        '
        'kontrola_verzii
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 142)
        Me.Controls.Add(Me.zavriet)
        Me.Controls.Add(Me.instaluj)
        Me.Controls.Add(Me.microsoft)
        Me.Controls.Add(Me.verzie_text)
        Me.Name = "kontrola_verzii"
        Me.Text = "Varovanie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents verzie_text As System.Windows.Forms.Label
    Friend WithEvents microsoft As System.Windows.Forms.Label
    Friend WithEvents instaluj As System.Windows.Forms.Button
    Friend WithEvents zavriet As System.Windows.Forms.Button
End Class
