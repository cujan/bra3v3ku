<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vseobecne_udaje
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
        Dim Nazov_organizacieLabel As System.Windows.Forms.Label
        Dim IcoLabel As System.Windows.Forms.Label
        Dim DicLabel As System.Windows.Forms.Label
        Dim UlicaLabel As System.Windows.Forms.Label
        Dim MestoLabel As System.Windows.Forms.Label
        Dim PscLabel As System.Windows.Forms.Label
        Dim TelefonLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim WebLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vseobecne_udaje))
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
        Me.Nazov_organizacieTextBox = New System.Windows.Forms.TextBox
        Me.IcoTextBox = New System.Windows.Forms.TextBox
        Me.DicTextBox = New System.Windows.Forms.TextBox
        Me.UlicaTextBox = New System.Windows.Forms.TextBox
        Me.MestoTextBox = New System.Windows.Forms.TextBox
        Me.PscTextBox = New System.Windows.Forms.TextBox
        Me.TelefonTextBox = New System.Windows.Forms.TextBox
        Me.FaxTextBox = New System.Windows.Forms.TextBox
        Me.EmailTextBox = New System.Windows.Forms.TextBox
        Me.WebTextBox = New System.Windows.Forms.TextBox
        Me.upravButton = New System.Windows.Forms.Button
        Me.ulozButton = New System.Windows.Forms.Button
        Me.koniecButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Nazov_organizacieLabel = New System.Windows.Forms.Label
        IcoLabel = New System.Windows.Forms.Label
        DicLabel = New System.Windows.Forms.Label
        UlicaLabel = New System.Windows.Forms.Label
        MestoLabel = New System.Windows.Forms.Label
        PscLabel = New System.Windows.Forms.Label
        TelefonLabel = New System.Windows.Forms.Label
        FaxLabel = New System.Windows.Forms.Label
        EmailLabel = New System.Windows.Forms.Label
        WebLabel = New System.Windows.Forms.Label
        CType(Me.Spz_vseobecne_udaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vseobecne_udajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vseobecne_udajeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Vseobecne_udajeBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Nazov_organizacieLabel
        '
        Nazov_organizacieLabel.AutoSize = True
        Nazov_organizacieLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nazov_organizacieLabel.Location = New System.Drawing.Point(205, 93)
        Nazov_organizacieLabel.Name = "Nazov_organizacieLabel"
        Nazov_organizacieLabel.Size = New System.Drawing.Size(112, 13)
        Nazov_organizacieLabel.TabIndex = 3
        Nazov_organizacieLabel.Text = "Názov organizácie"
        '
        'IcoLabel
        '
        IcoLabel.AutoSize = True
        IcoLabel.Location = New System.Drawing.Point(292, 119)
        IcoLabel.Name = "IcoLabel"
        IcoLabel.Size = New System.Drawing.Size(25, 13)
        IcoLabel.TabIndex = 5
        IcoLabel.Text = "IČO"
        '
        'DicLabel
        '
        DicLabel.AutoSize = True
        DicLabel.Location = New System.Drawing.Point(292, 145)
        DicLabel.Name = "DicLabel"
        DicLabel.Size = New System.Drawing.Size(25, 13)
        DicLabel.TabIndex = 7
        DicLabel.Text = "DIČ"
        '
        'UlicaLabel
        '
        UlicaLabel.AutoSize = True
        UlicaLabel.Location = New System.Drawing.Point(187, 203)
        UlicaLabel.Name = "UlicaLabel"
        UlicaLabel.Size = New System.Drawing.Size(31, 13)
        UlicaLabel.TabIndex = 9
        UlicaLabel.Text = "Ulica"
        '
        'MestoLabel
        '
        MestoLabel.AutoSize = True
        MestoLabel.Location = New System.Drawing.Point(181, 232)
        MestoLabel.Name = "MestoLabel"
        MestoLabel.Size = New System.Drawing.Size(36, 13)
        MestoLabel.TabIndex = 11
        MestoLabel.Text = "Mesto"
        '
        'PscLabel
        '
        PscLabel.AutoSize = True
        PscLabel.Location = New System.Drawing.Point(190, 258)
        PscLabel.Name = "PscLabel"
        PscLabel.Size = New System.Drawing.Size(28, 13)
        PscLabel.TabIndex = 13
        PscLabel.Text = "PSČ"
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Location = New System.Drawing.Point(427, 206)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(43, 13)
        TelefonLabel.TabIndex = 15
        TelefonLabel.Text = "Telefón"
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Location = New System.Drawing.Point(445, 232)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(24, 13)
        FaxLabel.TabIndex = 17
        FaxLabel.Text = "Fax"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(438, 258)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(32, 13)
        EmailLabel.TabIndex = 19
        EmailLabel.Text = "Email"
        AddHandler EmailLabel.Click, AddressOf Me.EmailLabel_Click
        '
        'WebLabel
        '
        WebLabel.AutoSize = True
        WebLabel.Location = New System.Drawing.Point(405, 284)
        WebLabel.Name = "WebLabel"
        WebLabel.Size = New System.Drawing.Size(65, 13)
        WebLabel.TabIndex = 21
        WebLabel.Text = "Webstránka"
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
        Me.Vseobecne_udajeBindingNavigator.Size = New System.Drawing.Size(768, 25)
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
        'Nazov_organizacieTextBox
        '
        Me.Nazov_organizacieTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vseobecne_udajeBindingSource, "nazov_organizacie", True))
        Me.Nazov_organizacieTextBox.Location = New System.Drawing.Point(323, 90)
        Me.Nazov_organizacieTextBox.Name = "Nazov_organizacieTextBox"
        Me.Nazov_organizacieTextBox.ReadOnly = True
        Me.Nazov_organizacieTextBox.Size = New System.Drawing.Size(267, 20)
        Me.Nazov_organizacieTextBox.TabIndex = 4
        '
        'IcoTextBox
        '
        Me.IcoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vseobecne_udajeBindingSource, "ico", True))
        Me.IcoTextBox.Location = New System.Drawing.Point(323, 116)
        Me.IcoTextBox.Name = "IcoTextBox"
        Me.IcoTextBox.ReadOnly = True
        Me.IcoTextBox.Size = New System.Drawing.Size(78, 20)
        Me.IcoTextBox.TabIndex = 6
        '
        'DicTextBox
        '
        Me.DicTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vseobecne_udajeBindingSource, "dic", True))
        Me.DicTextBox.Location = New System.Drawing.Point(323, 142)
        Me.DicTextBox.Name = "DicTextBox"
        Me.DicTextBox.ReadOnly = True
        Me.DicTextBox.Size = New System.Drawing.Size(78, 20)
        Me.DicTextBox.TabIndex = 8
        '
        'UlicaTextBox
        '
        Me.UlicaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vseobecne_udajeBindingSource, "ulica", True))
        Me.UlicaTextBox.Location = New System.Drawing.Point(224, 203)
        Me.UlicaTextBox.Name = "UlicaTextBox"
        Me.UlicaTextBox.ReadOnly = True
        Me.UlicaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UlicaTextBox.TabIndex = 10
        '
        'MestoTextBox
        '
        Me.MestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vseobecne_udajeBindingSource, "mesto", True))
        Me.MestoTextBox.Location = New System.Drawing.Point(224, 229)
        Me.MestoTextBox.Name = "MestoTextBox"
        Me.MestoTextBox.ReadOnly = True
        Me.MestoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MestoTextBox.TabIndex = 12
        '
        'PscTextBox
        '
        Me.PscTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vseobecne_udajeBindingSource, "psc", True))
        Me.PscTextBox.Location = New System.Drawing.Point(224, 255)
        Me.PscTextBox.Name = "PscTextBox"
        Me.PscTextBox.ReadOnly = True
        Me.PscTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PscTextBox.TabIndex = 14
        '
        'TelefonTextBox
        '
        Me.TelefonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vseobecne_udajeBindingSource, "telefon", True))
        Me.TelefonTextBox.Location = New System.Drawing.Point(476, 203)
        Me.TelefonTextBox.Name = "TelefonTextBox"
        Me.TelefonTextBox.ReadOnly = True
        Me.TelefonTextBox.Size = New System.Drawing.Size(114, 20)
        Me.TelefonTextBox.TabIndex = 16
        '
        'FaxTextBox
        '
        Me.FaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vseobecne_udajeBindingSource, "fax", True))
        Me.FaxTextBox.Location = New System.Drawing.Point(476, 229)
        Me.FaxTextBox.Name = "FaxTextBox"
        Me.FaxTextBox.ReadOnly = True
        Me.FaxTextBox.Size = New System.Drawing.Size(114, 20)
        Me.FaxTextBox.TabIndex = 18
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vseobecne_udajeBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(476, 255)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.ReadOnly = True
        Me.EmailTextBox.Size = New System.Drawing.Size(114, 20)
        Me.EmailTextBox.TabIndex = 20
        '
        'WebTextBox
        '
        Me.WebTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vseobecne_udajeBindingSource, "web", True))
        Me.WebTextBox.Location = New System.Drawing.Point(476, 281)
        Me.WebTextBox.Name = "WebTextBox"
        Me.WebTextBox.ReadOnly = True
        Me.WebTextBox.Size = New System.Drawing.Size(114, 20)
        Me.WebTextBox.TabIndex = 22
        '
        'upravButton
        '
        Me.upravButton.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.upravButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.upravButton.Location = New System.Drawing.Point(218, 23)
        Me.upravButton.Name = "upravButton"
        Me.upravButton.Size = New System.Drawing.Size(75, 23)
        Me.upravButton.TabIndex = 23
        Me.upravButton.Text = "Upraviť"
        Me.upravButton.UseVisualStyleBackColor = False
        '
        'ulozButton
        '
        Me.ulozButton.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ulozButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ulozButton.Location = New System.Drawing.Point(299, 23)
        Me.ulozButton.Name = "ulozButton"
        Me.ulozButton.Size = New System.Drawing.Size(75, 23)
        Me.ulozButton.TabIndex = 24
        Me.ulozButton.Text = "Uložiť"
        Me.ulozButton.UseVisualStyleBackColor = False
        Me.ulozButton.Visible = False
        '
        'koniecButton
        '
        Me.koniecButton.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.koniecButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.koniecButton.Location = New System.Drawing.Point(380, 23)
        Me.koniecButton.Name = "koniecButton"
        Me.koniecButton.Size = New System.Drawing.Size(90, 23)
        Me.koniecButton.TabIndex = 25
        Me.koniecButton.Text = "Zavrieť kartu"
        Me.koniecButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 17)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Adresa organizácie"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(408, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Kontakt"
        '
        'vseobecne_udaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(768, 428)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.koniecButton)
        Me.Controls.Add(Me.ulozButton)
        Me.Controls.Add(Me.upravButton)
        Me.Controls.Add(Nazov_organizacieLabel)
        Me.Controls.Add(Me.Nazov_organizacieTextBox)
        Me.Controls.Add(IcoLabel)
        Me.Controls.Add(Me.IcoTextBox)
        Me.Controls.Add(DicLabel)
        Me.Controls.Add(Me.DicTextBox)
        Me.Controls.Add(UlicaLabel)
        Me.Controls.Add(Me.UlicaTextBox)
        Me.Controls.Add(MestoLabel)
        Me.Controls.Add(Me.MestoTextBox)
        Me.Controls.Add(PscLabel)
        Me.Controls.Add(Me.PscTextBox)
        Me.Controls.Add(TelefonLabel)
        Me.Controls.Add(Me.TelefonTextBox)
        Me.Controls.Add(FaxLabel)
        Me.Controls.Add(Me.FaxTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(WebLabel)
        Me.Controls.Add(Me.WebTextBox)
        Me.Controls.Add(Me.Vseobecne_udajeBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "vseobecne_udaje"
        Me.Text = "vseobecne_udaje"
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
    Friend WithEvents Nazov_organizacieTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IcoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DicTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UlicaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MestoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PscTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WebTextBox As System.Windows.Forms.TextBox
    Friend WithEvents upravButton As System.Windows.Forms.Button
    Friend WithEvents ulozButton As System.Windows.Forms.Button
    Friend WithEvents koniecButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
