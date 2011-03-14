<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ciselniky
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
        Me.ciselniky_splitter = New System.Windows.Forms.SplitContainer
        Me.narodnost_button = New System.Windows.Forms.Button
        Me.zavriet_button = New System.Windows.Forms.Button
        Me.titul_za_button = New System.Windows.Forms.Button
        Me.st_prisl_button = New System.Windows.Forms.Button
        Me.tituly_button = New System.Windows.Forms.Button
        Me.ciselniky_splitter.Panel1.SuspendLayout()
        Me.ciselniky_splitter.SuspendLayout()
        Me.SuspendLayout()
        '
        'ciselniky_splitter
        '
        Me.ciselniky_splitter.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ciselniky_splitter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ciselniky_splitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.ciselniky_splitter.Location = New System.Drawing.Point(0, 0)
        Me.ciselniky_splitter.Name = "ciselniky_splitter"
        Me.ciselniky_splitter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'ciselniky_splitter.Panel1
        '
        Me.ciselniky_splitter.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ciselniky_splitter.Panel1.Controls.Add(Me.narodnost_button)
        Me.ciselniky_splitter.Panel1.Controls.Add(Me.zavriet_button)
        Me.ciselniky_splitter.Panel1.Controls.Add(Me.titul_za_button)
        Me.ciselniky_splitter.Panel1.Controls.Add(Me.st_prisl_button)
        Me.ciselniky_splitter.Panel1.Controls.Add(Me.tituly_button)
        '
        'ciselniky_splitter.Panel2
        '
        Me.ciselniky_splitter.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ciselniky_splitter.Size = New System.Drawing.Size(735, 516)
        Me.ciselniky_splitter.SplitterDistance = 53
        Me.ciselniky_splitter.TabIndex = 0
        '
        'narodnost_button
        '
        Me.narodnost_button.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.narodnost_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.narodnost_button.Location = New System.Drawing.Point(479, 12)
        Me.narodnost_button.Name = "narodnost_button"
        Me.narodnost_button.Size = New System.Drawing.Size(75, 23)
        Me.narodnost_button.TabIndex = 4
        Me.narodnost_button.Text = "Národnosť"
        Me.narodnost_button.UseVisualStyleBackColor = False
        '
        'zavriet_button
        '
        Me.zavriet_button.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.zavriet_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zavriet_button.Location = New System.Drawing.Point(560, 12)
        Me.zavriet_button.Name = "zavriet_button"
        Me.zavriet_button.Size = New System.Drawing.Size(82, 23)
        Me.zavriet_button.TabIndex = 3
        Me.zavriet_button.Text = "Zavrieť kartu"
        Me.zavriet_button.UseVisualStyleBackColor = False
        '
        'titul_za_button
        '
        Me.titul_za_button.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.titul_za_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.titul_za_button.Location = New System.Drawing.Point(374, 12)
        Me.titul_za_button.Name = "titul_za_button"
        Me.titul_za_button.Size = New System.Drawing.Size(99, 23)
        Me.titul_za_button.TabIndex = 2
        Me.titul_za_button.Text = "Titul za menom"
        Me.titul_za_button.UseVisualStyleBackColor = False
        '
        'st_prisl_button
        '
        Me.st_prisl_button.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.st_prisl_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.st_prisl_button.Location = New System.Drawing.Point(265, 12)
        Me.st_prisl_button.Name = "st_prisl_button"
        Me.st_prisl_button.Size = New System.Drawing.Size(103, 23)
        Me.st_prisl_button.TabIndex = 1
        Me.st_prisl_button.Text = "Štátna príslušnosť"
        Me.st_prisl_button.UseVisualStyleBackColor = False
        '
        'tituly_button
        '
        Me.tituly_button.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.tituly_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tituly_button.Location = New System.Drawing.Point(184, 12)
        Me.tituly_button.Name = "tituly_button"
        Me.tituly_button.Size = New System.Drawing.Size(75, 23)
        Me.tituly_button.TabIndex = 0
        Me.tituly_button.Text = "Tituly"
        Me.tituly_button.UseVisualStyleBackColor = False
        '
        'ciselniky
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(735, 516)
        Me.Controls.Add(Me.ciselniky_splitter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ciselniky"
        Me.Text = "ciselniky"
        Me.ciselniky_splitter.Panel1.ResumeLayout(False)
        Me.ciselniky_splitter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ciselniky_splitter As System.Windows.Forms.SplitContainer
    Friend WithEvents titul_za_button As System.Windows.Forms.Button
    Friend WithEvents st_prisl_button As System.Windows.Forms.Button
    Friend WithEvents tituly_button As System.Windows.Forms.Button
    Friend WithEvents zavriet_button As System.Windows.Forms.Button
    Friend WithEvents narodnost_button As System.Windows.Forms.Button
End Class
