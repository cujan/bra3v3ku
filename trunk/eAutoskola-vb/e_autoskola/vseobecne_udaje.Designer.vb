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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vseobecne_udaje))
        Dim IdLabel As System.Windows.Forms.Label
        Dim NazovOrganizacieLabel As System.Windows.Forms.Label
        Dim UlicaLabel As System.Windows.Forms.Label
        Dim UlicaCisloLabel As System.Windows.Forms.Label
        Dim MestoLabel As System.Windows.Forms.Label
        Dim PscLabel As System.Windows.Forms.Label
        Dim IcoLabel As System.Windows.Forms.Label
        Dim DicLabel As System.Windows.Forms.Label
        Dim TelefonLabel As System.Windows.Forms.Label
        Dim MobilLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim WwwLabel As System.Windows.Forms.Label
        Me.Vseobecne_udajeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Vseobecne_udajeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.upravButton = New System.Windows.Forms.Button()
        Me.ulozButton = New System.Windows.Forms.Button()
        Me.koniecButton = New System.Windows.Forms.Button()
        Me.VseobecneUdajeDataset = New e_autoskola.vseobecneUdajeDataset()
        Me.VseobecneUdajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VseobecneUdajeTableAdapter = New e_autoskola.vseobecneUdajeDatasetTableAdapters.vseobecneUdajeTableAdapter()
        Me.TableAdapterManager = New e_autoskola.vseobecneUdajeDatasetTableAdapters.TableAdapterManager()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.NazovOrganizacieTextBox = New System.Windows.Forms.TextBox()
        Me.UlicaTextBox = New System.Windows.Forms.TextBox()
        Me.UlicaCisloTextBox = New System.Windows.Forms.TextBox()
        Me.MestoTextBox = New System.Windows.Forms.TextBox()
        Me.PscTextBox = New System.Windows.Forms.TextBox()
        Me.IcoTextBox = New System.Windows.Forms.TextBox()
        Me.DicTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonTextBox = New System.Windows.Forms.TextBox()
        Me.MobilTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.WwwTextBox = New System.Windows.Forms.TextBox()
        IdLabel = New System.Windows.Forms.Label()
        NazovOrganizacieLabel = New System.Windows.Forms.Label()
        UlicaLabel = New System.Windows.Forms.Label()
        UlicaCisloLabel = New System.Windows.Forms.Label()
        MestoLabel = New System.Windows.Forms.Label()
        PscLabel = New System.Windows.Forms.Label()
        IcoLabel = New System.Windows.Forms.Label()
        DicLabel = New System.Windows.Forms.Label()
        TelefonLabel = New System.Windows.Forms.Label()
        MobilLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        WwwLabel = New System.Windows.Forms.Label()
        CType(Me.Vseobecne_udajeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Vseobecne_udajeBindingNavigator.SuspendLayout()
        CType(Me.VseobecneUdajeDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VseobecneUdajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Vseobecne_udajeBindingNavigator
        '
        Me.Vseobecne_udajeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
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
        'VseobecneUdajeDataset
        '
        Me.VseobecneUdajeDataset.DataSetName = "vseobecneUdajeDataset"
        Me.VseobecneUdajeDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VseobecneUdajeBindingSource
        '
        Me.VseobecneUdajeBindingSource.DataMember = "vseobecneUdaje"
        Me.VseobecneUdajeBindingSource.DataSource = Me.VseobecneUdajeDataset
        '
        'VseobecneUdajeTableAdapter
        '
        Me.VseobecneUdajeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = e_autoskola.vseobecneUdajeDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vseobecneUdajeTableAdapter = Me.VseobecneUdajeTableAdapter
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(444, 100)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 25
        IdLabel.Text = "ID"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VseobecneUdajeBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(470, 97)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 26
        '
        'NazovOrganizacieLabel
        '
        NazovOrganizacieLabel.AutoSize = True
        NazovOrganizacieLabel.Location = New System.Drawing.Point(80, 98)
        NazovOrganizacieLabel.Name = "NazovOrganizacieLabel"
        NazovOrganizacieLabel.Size = New System.Drawing.Size(95, 13)
        NazovOrganizacieLabel.TabIndex = 27
        NazovOrganizacieLabel.Text = "Názov organizácie"
        '
        'NazovOrganizacieTextBox
        '
        Me.NazovOrganizacieTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VseobecneUdajeBindingSource, "nazovOrganizacie", True))
        Me.NazovOrganizacieTextBox.Location = New System.Drawing.Point(184, 95)
        Me.NazovOrganizacieTextBox.Name = "NazovOrganizacieTextBox"
        Me.NazovOrganizacieTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NazovOrganizacieTextBox.TabIndex = 28
        '
        'UlicaLabel
        '
        UlicaLabel.AutoSize = True
        UlicaLabel.Location = New System.Drawing.Point(144, 125)
        UlicaLabel.Name = "UlicaLabel"
        UlicaLabel.Size = New System.Drawing.Size(31, 13)
        UlicaLabel.TabIndex = 29
        UlicaLabel.Text = "Ulica"
        '
        'UlicaTextBox
        '
        Me.UlicaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VseobecneUdajeBindingSource, "ulica", True))
        Me.UlicaTextBox.Location = New System.Drawing.Point(184, 122)
        Me.UlicaTextBox.Name = "UlicaTextBox"
        Me.UlicaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UlicaTextBox.TabIndex = 30
        '
        'UlicaCisloLabel
        '
        UlicaCisloLabel.AutoSize = True
        UlicaCisloLabel.Location = New System.Drawing.Point(303, 125)
        UlicaCisloLabel.Name = "UlicaCisloLabel"
        UlicaCisloLabel.Size = New System.Drawing.Size(31, 13)
        UlicaCisloLabel.TabIndex = 31
        UlicaCisloLabel.Text = "Číslo"
        '
        'UlicaCisloTextBox
        '
        Me.UlicaCisloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VseobecneUdajeBindingSource, "ulicaCislo", True))
        Me.UlicaCisloTextBox.Location = New System.Drawing.Point(343, 122)
        Me.UlicaCisloTextBox.Name = "UlicaCisloTextBox"
        Me.UlicaCisloTextBox.Size = New System.Drawing.Size(47, 20)
        Me.UlicaCisloTextBox.TabIndex = 32
        '
        'MestoLabel
        '
        MestoLabel.AutoSize = True
        MestoLabel.Location = New System.Drawing.Point(139, 151)
        MestoLabel.Name = "MestoLabel"
        MestoLabel.Size = New System.Drawing.Size(36, 13)
        MestoLabel.TabIndex = 33
        MestoLabel.Text = "Mesto"
        '
        'MestoTextBox
        '
        Me.MestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VseobecneUdajeBindingSource, "mesto", True))
        Me.MestoTextBox.Location = New System.Drawing.Point(184, 148)
        Me.MestoTextBox.Name = "MestoTextBox"
        Me.MestoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MestoTextBox.TabIndex = 34
        '
        'PscLabel
        '
        PscLabel.AutoSize = True
        PscLabel.Location = New System.Drawing.Point(306, 151)
        PscLabel.Name = "PscLabel"
        PscLabel.Size = New System.Drawing.Size(28, 13)
        PscLabel.TabIndex = 35
        PscLabel.Text = "PSČ"
        '
        'PscTextBox
        '
        Me.PscTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VseobecneUdajeBindingSource, "psc", True))
        Me.PscTextBox.Location = New System.Drawing.Point(343, 148)
        Me.PscTextBox.Name = "PscTextBox"
        Me.PscTextBox.Size = New System.Drawing.Size(47, 20)
        Me.PscTextBox.TabIndex = 36
        '
        'IcoLabel
        '
        IcoLabel.AutoSize = True
        IcoLabel.Location = New System.Drawing.Point(440, 125)
        IcoLabel.Name = "IcoLabel"
        IcoLabel.Size = New System.Drawing.Size(25, 13)
        IcoLabel.TabIndex = 37
        IcoLabel.Text = "IČO"
        '
        'IcoTextBox
        '
        Me.IcoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VseobecneUdajeBindingSource, "ico", True))
        Me.IcoTextBox.Location = New System.Drawing.Point(470, 122)
        Me.IcoTextBox.Name = "IcoTextBox"
        Me.IcoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IcoTextBox.TabIndex = 38
        '
        'DicLabel
        '
        DicLabel.AutoSize = True
        DicLabel.Location = New System.Drawing.Point(440, 151)
        DicLabel.Name = "DicLabel"
        DicLabel.Size = New System.Drawing.Size(25, 13)
        DicLabel.TabIndex = 39
        DicLabel.Text = "DIČ"
        '
        'DicTextBox
        '
        Me.DicTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VseobecneUdajeBindingSource, "dic", True))
        Me.DicTextBox.Location = New System.Drawing.Point(470, 148)
        Me.DicTextBox.Name = "DicTextBox"
        Me.DicTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DicTextBox.TabIndex = 40
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Location = New System.Drawing.Point(132, 198)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(43, 13)
        TelefonLabel.TabIndex = 41
        TelefonLabel.Text = "Telefón"
        '
        'TelefonTextBox
        '
        Me.TelefonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VseobecneUdajeBindingSource, "telefon", True))
        Me.TelefonTextBox.Location = New System.Drawing.Point(184, 195)
        Me.TelefonTextBox.Name = "TelefonTextBox"
        Me.TelefonTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonTextBox.TabIndex = 42
        '
        'MobilLabel
        '
        MobilLabel.AutoSize = True
        MobilLabel.Location = New System.Drawing.Point(143, 224)
        MobilLabel.Name = "MobilLabel"
        MobilLabel.Size = New System.Drawing.Size(32, 13)
        MobilLabel.TabIndex = 43
        MobilLabel.Text = "Mobil"
        '
        'MobilTextBox
        '
        Me.MobilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VseobecneUdajeBindingSource, "mobil", True))
        Me.MobilTextBox.Location = New System.Drawing.Point(184, 221)
        Me.MobilTextBox.Name = "MobilTextBox"
        Me.MobilTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MobilTextBox.TabIndex = 44
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(426, 198)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(32, 13)
        EmailLabel.TabIndex = 45
        EmailLabel.Text = "Email"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VseobecneUdajeBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(470, 195)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 46
        '
        'WwwLabel
        '
        WwwLabel.AutoSize = True
        WwwLabel.Location = New System.Drawing.Point(418, 224)
        WwwLabel.Name = "WwwLabel"
        WwwLabel.Size = New System.Drawing.Size(40, 13)
        WwwLabel.TabIndex = 47
        WwwLabel.Text = "WWW"
        '
        'WwwTextBox
        '
        Me.WwwTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VseobecneUdajeBindingSource, "www", True))
        Me.WwwTextBox.Location = New System.Drawing.Point(470, 221)
        Me.WwwTextBox.Name = "WwwTextBox"
        Me.WwwTextBox.Size = New System.Drawing.Size(100, 20)
        Me.WwwTextBox.TabIndex = 48
        '
        'vseobecne_udaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(768, 471)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(NazovOrganizacieLabel)
        Me.Controls.Add(Me.NazovOrganizacieTextBox)
        Me.Controls.Add(UlicaLabel)
        Me.Controls.Add(Me.UlicaTextBox)
        Me.Controls.Add(UlicaCisloLabel)
        Me.Controls.Add(Me.UlicaCisloTextBox)
        Me.Controls.Add(MestoLabel)
        Me.Controls.Add(Me.MestoTextBox)
        Me.Controls.Add(PscLabel)
        Me.Controls.Add(Me.PscTextBox)
        Me.Controls.Add(IcoLabel)
        Me.Controls.Add(Me.IcoTextBox)
        Me.Controls.Add(DicLabel)
        Me.Controls.Add(Me.DicTextBox)
        Me.Controls.Add(TelefonLabel)
        Me.Controls.Add(Me.TelefonTextBox)
        Me.Controls.Add(MobilLabel)
        Me.Controls.Add(Me.MobilTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(WwwLabel)
        Me.Controls.Add(Me.WwwTextBox)
        Me.Controls.Add(Me.koniecButton)
        Me.Controls.Add(Me.ulozButton)
        Me.Controls.Add(Me.upravButton)
        Me.Controls.Add(Me.Vseobecne_udajeBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "vseobecne_udaje"
        Me.Text = "vseobecne_udaje"
        CType(Me.Vseobecne_udajeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Vseobecne_udajeBindingNavigator.ResumeLayout(False)
        Me.Vseobecne_udajeBindingNavigator.PerformLayout()
        CType(Me.VseobecneUdajeDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VseobecneUdajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


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
    Friend WithEvents upravButton As System.Windows.Forms.Button
    Friend WithEvents ulozButton As System.Windows.Forms.Button
    Friend WithEvents koniecButton As System.Windows.Forms.Button
    Friend WithEvents VseobecneUdajeDataset As e_autoskola.vseobecneUdajeDataset
    Friend WithEvents VseobecneUdajeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VseobecneUdajeTableAdapter As e_autoskola.vseobecneUdajeDatasetTableAdapters.vseobecneUdajeTableAdapter
    Friend WithEvents TableAdapterManager As e_autoskola.vseobecneUdajeDatasetTableAdapters.TableAdapterManager
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NazovOrganizacieTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UlicaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UlicaCisloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MestoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PscTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IcoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DicTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MobilTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WwwTextBox As System.Windows.Forms.TextBox
End Class
