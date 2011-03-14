<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class varovanie1
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
        Me.varovanie_text = New System.Windows.Forms.Label
        Me.ukoncit_button = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'varovanie_text
        '
        Me.varovanie_text.Location = New System.Drawing.Point(12, 9)
        Me.varovanie_text.Name = "varovanie_text"
        Me.varovanie_text.Size = New System.Drawing.Size(387, 55)
        Me.varovanie_text.TabIndex = 0
        Me.varovanie_text.Text = "Pri štarte aplikacie nastala chyba. Aplikácia je poškodená, alebo bola prenesená " & _
            "na iný počítač bez inštalácie. Prosím preinštalujte danú aplikáciu, alebo kontak" & _
            "tujte dodávateľa."
        Me.varovanie_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ukoncit_button
        '
        Me.ukoncit_button.Location = New System.Drawing.Point(155, 67)
        Me.ukoncit_button.Name = "ukoncit_button"
        Me.ukoncit_button.Size = New System.Drawing.Size(90, 27)
        Me.ukoncit_button.TabIndex = 1
        Me.ukoncit_button.Text = "Ukončiť"
        Me.ukoncit_button.UseVisualStyleBackColor = True
        '
        'varovanie1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 111)
        Me.Controls.Add(Me.ukoncit_button)
        Me.Controls.Add(Me.varovanie_text)
        Me.Name = "varovanie1"
        Me.Text = "Varovanie"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents varovanie_text As System.Windows.Forms.Label
    Friend WithEvents ukoncit_button As System.Windows.Forms.Button
End Class
