<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registracia_aplikacie
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
        Me.components = New System.ComponentModel.Container
        Dim Reg_cisloLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registracia_aplikacie))
        Me.Spz_vseobecne_udaje = New e_autoskola.spz_vseobecne_udaje
        Me.Vseobecne_udajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vseobecne_udajeTableAdapter = New e_autoskola.spz_vseobecne_udajeTableAdapters.vseobecne_udajeTableAdapter
        Me.TableAdapterManager = New e_autoskola.spz_vseobecne_udajeTableAdapters.TableAdapterManager
        Me.Vseobecne_udajeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Vseobecne_udajeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.infoText = New System.Windows.Forms.Label
        Me.ica_label = New System.Windows.Forms.Label
        Me.registruj = New System.Windows.Forms.Button
        Me.zavriet = New System.Windows.Forms.Button
        Me.reg_cislo = New System.Windows.Forms.TextBox
        Me.ica = New System.Windows.Forms.TextBox
        Me.kontakt = New System.Windows.Forms.Button
        Reg_cisloLabel = New System.Windows.Forms.Label
        CType(Me.Spz_vseobecne_udaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vseobecne_udajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vseobecne_udajeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Vseobecne_udajeBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Reg_cisloLabel
        '
        Reg_cisloLabel.AutoSize = True
        Reg_cisloLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Reg_cisloLabel.Location = New System.Drawing.Point(356, 206)
        Reg_cisloLabel.Name = "Reg_cisloLabel"
        Reg_cisloLabel.Size = New System.Drawing.Size(111, 13)
        Reg_cisloLabel.TabIndex = 1
        Reg_cisloLabel.Text = "Registračné číslo:"
        '
        'Spz_vseobecne_udaje
        '
        Me.Spz_vseobecne_udaje.DataSetName = "spz_vseobecne_udaje"
        Me.Spz_vseobecne_udaje.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vseobecne_udajeBindingSource
        '
        Me.Vseobecne_udajeBindingSource.DataMember = "vseobecne_udaje"
        Me.Vseobecne_udajeBindingSource.DataSource = Me.Spz_vseobecne_udaje
        '
        'Vseobecne_udajeTableAdapter
        '
        Me.Vseobecne_udajeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = e_autoskola.spz_vseobecne_udajeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vseobecne_udajeTableAdapter = Me.Vseobecne_udajeTableAdapter
        '
        'Vseobecne_udajeBindingNavigator
        '
        Me.Vseobecne_udajeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Vseobecne_udajeBindingNavigator.BindingSource = Me.Vseobecne_udajeBindingSource
        Me.Vseobecne_udajeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Vseobecne_udajeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Vseobecne_udajeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Vseobecne_udajeBindingNavigatorSaveItem})
        Me.Vseobecne_udajeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Vseobecne_udajeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Vseobecne_udajeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Vseobecne_udajeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Vseobecne_udajeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Vseobecne_udajeBindingNavigator.Name = "Vseobecne_udajeBindingNavigator"
        Me.Vseobecne_udajeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Vseobecne_udajeBindingNavigator.Size = New System.Drawing.Size(627, 25)
        Me.Vseobecne_udajeBindingNavigator.TabIndex = 0
        Me.Vseobecne_udajeBindingNavigator.Text = "BindingNavigator1"
        Me.Vseobecne_udajeBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Vseobecne_udajeBindingNavigatorSaveItem
        '
        Me.Vseobecne_udajeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Vseobecne_udajeBindingNavigatorSaveItem.Image = CType(resources.GetObject("Vseobecne_udajeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Vseobecne_udajeBindingNavigatorSaveItem.Name = "Vseobecne_udajeBindingNavigatorSaveItem"
        Me.Vseobecne_udajeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Vseobecne_udajeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'infoText
        '
        Me.infoText.Location = New System.Drawing.Point(293, 115)
        Me.infoText.Name = "infoText"
        Me.infoText.Size = New System.Drawing.Size(438, 64)
        Me.infoText.TabIndex = 3
        Me.infoText.Text = resources.GetString("infoText.Text")
        Me.infoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ica_label
        '
        Me.ica_label.AutoSize = True
        Me.ica_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ica_label.ForeColor = System.Drawing.Color.DarkRed
        Me.ica_label.Location = New System.Drawing.Point(263, 183)
        Me.ica_label.Name = "ica_label"
        Me.ica_label.Size = New System.Drawing.Size(204, 13)
        Me.ica_label.TabIndex = 4
        Me.ica_label.Text = "Identifikačné číslo aplikácie (IČA):"
        '
        'registruj
        '
        Me.registruj.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.registruj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registruj.Location = New System.Drawing.Point(308, 244)
        Me.registruj.Name = "registruj"
        Me.registruj.Size = New System.Drawing.Size(171, 23)
        Me.registruj.TabIndex = 6
        Me.registruj.Text = "REGISTRUJ"
        Me.registruj.UseVisualStyleBackColor = False
        '
        'zavriet
        '
        Me.zavriet.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.zavriet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zavriet.Location = New System.Drawing.Point(645, 244)
        Me.zavriet.Name = "zavriet"
        Me.zavriet.Size = New System.Drawing.Size(86, 23)
        Me.zavriet.TabIndex = 7
        Me.zavriet.Text = "Zavrieť kartu"
        Me.zavriet.UseVisualStyleBackColor = False
        '
        'reg_cislo
        '
        Me.reg_cislo.Location = New System.Drawing.Point(476, 203)
        Me.reg_cislo.Name = "reg_cislo"
        Me.reg_cislo.Size = New System.Drawing.Size(210, 20)
        Me.reg_cislo.TabIndex = 8
        '
        'ica
        '
        Me.ica.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ica.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ica.ForeColor = System.Drawing.Color.DarkRed
        Me.ica.Location = New System.Drawing.Point(476, 183)
        Me.ica.Name = "ica"
        Me.ica.ReadOnly = True
        Me.ica.Size = New System.Drawing.Size(210, 13)
        Me.ica.TabIndex = 9
        '
        'kontakt
        '
        Me.kontakt.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.kontakt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.kontakt.Location = New System.Drawing.Point(485, 244)
        Me.kontakt.Name = "kontakt"
        Me.kontakt.Size = New System.Drawing.Size(154, 23)
        Me.kontakt.TabIndex = 10
        Me.kontakt.Text = "Kontakt - tvorcovia aplikacie"
        Me.kontakt.UseVisualStyleBackColor = False
        '
        'registracia_aplikacie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(950, 290)
        Me.Controls.Add(Me.kontakt)
        Me.Controls.Add(Me.ica)
        Me.Controls.Add(Me.reg_cislo)
        Me.Controls.Add(Me.zavriet)
        Me.Controls.Add(Me.registruj)
        Me.Controls.Add(Me.ica_label)
        Me.Controls.Add(Me.infoText)
        Me.Controls.Add(Reg_cisloLabel)
        Me.Controls.Add(Me.Vseobecne_udajeBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "registracia_aplikacie"
        Me.Text = "registracia_aplikacie"
        CType(Me.Spz_vseobecne_udaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vseobecne_udajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vseobecne_udajeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Vseobecne_udajeBindingNavigator.ResumeLayout(False)
        Me.Vseobecne_udajeBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Spz_vseobecne_udaje As e_autoskola.spz_vseobecne_udaje
    Friend WithEvents Vseobecne_udajeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vseobecne_udajeTableAdapter As e_autoskola.spz_vseobecne_udajeTableAdapters.vseobecne_udajeTableAdapter
    Friend WithEvents TableAdapterManager As e_autoskola.spz_vseobecne_udajeTableAdapters.TableAdapterManager
    Friend WithEvents Vseobecne_udajeBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Vseobecne_udajeBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents infoText As System.Windows.Forms.Label
    Friend WithEvents ica_label As System.Windows.Forms.Label
    Friend WithEvents registruj As System.Windows.Forms.Button
    Friend WithEvents zavriet As System.Windows.Forms.Button
    Friend WithEvents reg_cislo As System.Windows.Forms.TextBox
    Friend WithEvents ica As System.Windows.Forms.TextBox
    Friend WithEvents kontakt As System.Windows.Forms.Button
End Class
