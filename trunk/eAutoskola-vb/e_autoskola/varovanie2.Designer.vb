<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class varovanie2
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
        Me.text_varovanie = New System.Windows.Forms.Label
        Me.poznamka = New System.Windows.Forms.Label
        Me.zaregistrovat = New System.Windows.Forms.Button
        Me.zavriet = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'text_varovanie
        '
        Me.text_varovanie.Location = New System.Drawing.Point(71, 9)
        Me.text_varovanie.Name = "text_varovanie"
        Me.text_varovanie.Size = New System.Drawing.Size(353, 46)
        Me.text_varovanie.TabIndex = 0
        Me.text_varovanie.Text = "Aplikácie nebola zaregistrovaná, alebo registračné číslo je chybné. Prosím prejdi" & _
            "te do časti registrácia kliknutím na tlačítko ZAREGISTROVAŤ."
        Me.text_varovanie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'poznamka
        '
        Me.poznamka.AutoSize = True
        Me.poznamka.Location = New System.Drawing.Point(71, 72)
        Me.poznamka.Name = "poznamka"
        Me.poznamka.Size = New System.Drawing.Size(353, 13)
        Me.poznamka.TabIndex = 1
        Me.poznamka.Text = "Poznámka: V neregistrovanej verzii je funkčná iba sekcia tlačové zostavy"
        '
        'zaregistrovat
        '
        Me.zaregistrovat.Location = New System.Drawing.Point(117, 103)
        Me.zaregistrovat.Name = "zaregistrovat"
        Me.zaregistrovat.Size = New System.Drawing.Size(109, 23)
        Me.zaregistrovat.TabIndex = 2
        Me.zaregistrovat.Text = "ZAREGISTROVAŤ"
        Me.zaregistrovat.UseVisualStyleBackColor = True
        '
        'zavriet
        '
        Me.zavriet.Location = New System.Drawing.Point(271, 103)
        Me.zavriet.Name = "zavriet"
        Me.zavriet.Size = New System.Drawing.Size(75, 23)
        Me.zavriet.TabIndex = 3
        Me.zavriet.Text = "Zavrieť"
        Me.zavriet.UseVisualStyleBackColor = True
        '
        'varovanie2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 152)
        Me.Controls.Add(Me.zavriet)
        Me.Controls.Add(Me.zaregistrovat)
        Me.Controls.Add(Me.poznamka)
        Me.Controls.Add(Me.text_varovanie)
        Me.Name = "varovanie2"
        Me.Text = "Varovanie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents text_varovanie As System.Windows.Forms.Label
    Friend WithEvents poznamka As System.Windows.Forms.Label
    Friend WithEvents zaregistrovat As System.Windows.Forms.Button
    Friend WithEvents zavriet As System.Windows.Forms.Button
End Class
