<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zaloha_databazy
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
        Me.zaloha = New System.Windows.Forms.RadioButton
        Me.obnova = New System.Windows.Forms.RadioButton
        Me.zaloha_label = New System.Windows.Forms.Label
        Me.zalohuj = New System.Windows.Forms.Button
        Me.poznamka = New System.Windows.Forms.Label
        Me.obnova_label = New System.Windows.Forms.Label
        Me.obnova_label2 = New System.Windows.Forms.Label
        Me.obnov = New System.Windows.Forms.Button
        Me.obnov_listbox = New System.Windows.Forms.ListBox
        Me.obnova_nadpis_label = New System.Windows.Forms.Label
        Me.poznamka_obnova = New System.Windows.Forms.Label
        Me.vymaz_zalohu = New System.Windows.Forms.Button
        Me.zavriet_kartu = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'zaloha
        '
        Me.zaloha.AutoSize = True
        Me.zaloha.Checked = True
        Me.zaloha.Location = New System.Drawing.Point(158, 97)
        Me.zaloha.Name = "zaloha"
        Me.zaloha.Size = New System.Drawing.Size(104, 17)
        Me.zaloha.TabIndex = 0
        Me.zaloha.TabStop = True
        Me.zaloha.Text = "Záloha databázy"
        Me.zaloha.UseVisualStyleBackColor = True
        '
        'obnova
        '
        Me.obnova.AutoSize = True
        Me.obnova.Location = New System.Drawing.Point(158, 174)
        Me.obnova.Name = "obnova"
        Me.obnova.Size = New System.Drawing.Size(109, 17)
        Me.obnova.TabIndex = 1
        Me.obnova.Text = "Obnova databázy"
        Me.obnova.UseVisualStyleBackColor = True
        '
        'zaloha_label
        '
        Me.zaloha_label.AutoSize = True
        Me.zaloha_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.zaloha_label.Location = New System.Drawing.Point(212, 117)
        Me.zaloha_label.Name = "zaloha_label"
        Me.zaloha_label.Size = New System.Drawing.Size(333, 13)
        Me.zaloha_label.TabIndex = 2
        Me.zaloha_label.Text = "Zálohu databázy vytvoríte stlačením na tlačítko 'Zálohuj'"
        '
        'zalohuj
        '
        Me.zalohuj.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.zalohuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zalohuj.Location = New System.Drawing.Point(636, 133)
        Me.zalohuj.Name = "zalohuj"
        Me.zalohuj.Size = New System.Drawing.Size(100, 21)
        Me.zalohuj.TabIndex = 3
        Me.zalohuj.Text = "Zálohuj"
        Me.zalohuj.UseVisualStyleBackColor = False
        '
        'poznamka
        '
        Me.poznamka.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.poznamka.ForeColor = System.Drawing.Color.DarkRed
        Me.poznamka.Location = New System.Drawing.Point(299, 148)
        Me.poznamka.Name = "poznamka"
        Me.poznamka.Size = New System.Drawing.Size(331, 22)
        Me.poznamka.TabIndex = 4
        Me.poznamka.Text = "Label1"
        Me.poznamka.Visible = False
        '
        'obnova_label
        '
        Me.obnova_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.obnova_label.Location = New System.Drawing.Point(212, 194)
        Me.obnova_label.Name = "obnova_label"
        Me.obnova_label.Size = New System.Drawing.Size(353, 49)
        Me.obnova_label.TabIndex = 5
        Me.obnova_label.Text = "Obnovu dát zo staršej databázy vykonáte tak, že vyberiete zálohu databázy zo zozn" & _
            "amu záloh databázy a stačíte na tlačítko 'Obnov'. "
        '
        'obnova_label2
        '
        Me.obnova_label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.obnova_label2.ForeColor = System.Drawing.Color.DarkRed
        Me.obnova_label2.Location = New System.Drawing.Point(204, 243)
        Me.obnova_label2.Name = "obnova_label2"
        Me.obnova_label2.Size = New System.Drawing.Size(383, 65)
        Me.obnova_label2.TabIndex = 6
        Me.obnova_label2.Text = "  POZOR! Po obnove staršej databázy budú všetky od vtedy vykonané zmeny stratené." & _
            " Odporúčame pred obnovou spraviť zálohu súčasnej databázy."
        Me.obnova_label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'obnov
        '
        Me.obnov.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.obnov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.obnov.Location = New System.Drawing.Point(636, 314)
        Me.obnov.Name = "obnov"
        Me.obnov.Size = New System.Drawing.Size(100, 23)
        Me.obnov.TabIndex = 7
        Me.obnov.Text = "Obnov"
        Me.obnov.UseVisualStyleBackColor = False
        '
        'obnov_listbox
        '
        Me.obnov_listbox.FormattingEnabled = True
        Me.obnov_listbox.Location = New System.Drawing.Point(636, 213)
        Me.obnov_listbox.Name = "obnov_listbox"
        Me.obnov_listbox.Size = New System.Drawing.Size(246, 95)
        Me.obnov_listbox.TabIndex = 8
        '
        'obnova_nadpis_label
        '
        Me.obnova_nadpis_label.AutoSize = True
        Me.obnova_nadpis_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.obnova_nadpis_label.Location = New System.Drawing.Point(617, 195)
        Me.obnova_nadpis_label.Name = "obnova_nadpis_label"
        Me.obnova_nadpis_label.Size = New System.Drawing.Size(140, 13)
        Me.obnova_nadpis_label.TabIndex = 9
        Me.obnova_nadpis_label.Text = "Zoznam záloh databázy"
        '
        'poznamka_obnova
        '
        Me.poznamka_obnova.AutoSize = True
        Me.poznamka_obnova.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.poznamka_obnova.ForeColor = System.Drawing.Color.DarkRed
        Me.poznamka_obnova.Location = New System.Drawing.Point(670, 350)
        Me.poznamka_obnova.Name = "poznamka_obnova"
        Me.poznamka_obnova.Size = New System.Drawing.Size(45, 13)
        Me.poznamka_obnova.TabIndex = 10
        Me.poznamka_obnova.Text = "Label1"
        Me.poznamka_obnova.Visible = False
        '
        'vymaz_zalohu
        '
        Me.vymaz_zalohu.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.vymaz_zalohu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vymaz_zalohu.Location = New System.Drawing.Point(783, 314)
        Me.vymaz_zalohu.Name = "vymaz_zalohu"
        Me.vymaz_zalohu.Size = New System.Drawing.Size(99, 23)
        Me.vymaz_zalohu.TabIndex = 11
        Me.vymaz_zalohu.Text = "Vymaž zálohu"
        Me.vymaz_zalohu.UseVisualStyleBackColor = False
        '
        'zavriet_kartu
        '
        Me.zavriet_kartu.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.zavriet_kartu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zavriet_kartu.Location = New System.Drawing.Point(316, 12)
        Me.zavriet_kartu.Name = "zavriet_kartu"
        Me.zavriet_kartu.Size = New System.Drawing.Size(420, 24)
        Me.zavriet_kartu.TabIndex = 12
        Me.zavriet_kartu.Text = "Zavrieť kartu"
        Me.zavriet_kartu.UseVisualStyleBackColor = False
        '
        'zaloha_databazy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(954, 614)
        Me.Controls.Add(Me.zavriet_kartu)
        Me.Controls.Add(Me.vymaz_zalohu)
        Me.Controls.Add(Me.poznamka_obnova)
        Me.Controls.Add(Me.obnova_nadpis_label)
        Me.Controls.Add(Me.obnov_listbox)
        Me.Controls.Add(Me.obnov)
        Me.Controls.Add(Me.obnova_label2)
        Me.Controls.Add(Me.obnova_label)
        Me.Controls.Add(Me.poznamka)
        Me.Controls.Add(Me.zalohuj)
        Me.Controls.Add(Me.zaloha_label)
        Me.Controls.Add(Me.obnova)
        Me.Controls.Add(Me.zaloha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "zaloha_databazy"
        Me.Text = "Zalohovanie databazy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents zaloha As System.Windows.Forms.RadioButton
    Friend WithEvents obnova As System.Windows.Forms.RadioButton
    Friend WithEvents zaloha_label As System.Windows.Forms.Label
    Friend WithEvents zalohuj As System.Windows.Forms.Button
    Friend WithEvents poznamka As System.Windows.Forms.Label
    Friend WithEvents obnova_label As System.Windows.Forms.Label
    Friend WithEvents obnova_label2 As System.Windows.Forms.Label
    Friend WithEvents obnov As System.Windows.Forms.Button
    Friend WithEvents obnov_listbox As System.Windows.Forms.ListBox
    Friend WithEvents obnova_nadpis_label As System.Windows.Forms.Label
    Friend WithEvents poznamka_obnova As System.Windows.Forms.Label
    Friend WithEvents vymaz_zalohu As System.Windows.Forms.Button
    Friend WithEvents zavriet_kartu As System.Windows.Forms.Button
End Class
