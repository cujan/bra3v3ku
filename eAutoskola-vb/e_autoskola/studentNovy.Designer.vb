<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentNovy
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
        Dim TitulPredLabel As System.Windows.Forms.Label
        Dim PriezviskoLabel As System.Windows.Forms.Label
        Dim RodnePriezviskoLabel As System.Windows.Forms.Label
        Dim MenoLabel As System.Windows.Forms.Label
        Dim TitulZaLabel As System.Windows.Forms.Label
        Dim DatumNarodeniaLabel As System.Windows.Forms.Label
        Dim RodneCisloLabel As System.Windows.Forms.Label
        Dim MiestoNarodeniaLabel As System.Windows.Forms.Label
        Dim UlicaLabel As System.Windows.Forms.Label
        Dim UlicaCisloLabel As System.Windows.Forms.Label
        Dim MestoLabel As System.Windows.Forms.Label
        Dim PscLabel As System.Windows.Forms.Label
        Dim TelefonLabel As System.Windows.Forms.Label
        Dim MobilLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim CisloOpLabel As System.Windows.Forms.Label
        Dim CisloVpLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentNovy))
        Me.TitulPredTextBox = New System.Windows.Forms.TextBox()
        Me.PriezviskoTextBox = New System.Windows.Forms.TextBox()
        Me.RodnePriezviskoTextBox = New System.Windows.Forms.TextBox()
        Me.MenoTextBox = New System.Windows.Forms.TextBox()
        Me.TitulZaTextBox = New System.Windows.Forms.TextBox()
        Me.DatumNarodeniaTextBox = New System.Windows.Forms.TextBox()
        Me.RodneCisloTextBox = New System.Windows.Forms.TextBox()
        Me.MiestoNarodeniaTextBox = New System.Windows.Forms.TextBox()
        Me.UlicaTextBox = New System.Windows.Forms.TextBox()
        Me.UlicaCisloTextBox = New System.Windows.Forms.TextBox()
        Me.MestoTextBox = New System.Windows.Forms.TextBox()
        Me.PscTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonTextBox = New System.Windows.Forms.TextBox()
        Me.MobilTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.CisloOpTextBox = New System.Windows.Forms.TextBox()
        Me.CisloVpTextBox = New System.Windows.Forms.TextBox()
        Me.vlozStudenta = New System.Windows.Forms.Button()
        Me.EAutoskolaDBDataSet = New e_autoskola.eAutoskolaDBDataSet()
        Me.OsobaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OsobaTableAdapter = New e_autoskola.eAutoskolaDBDataSetTableAdapters.osobaTableAdapter()
        Me.TableAdapterManager = New e_autoskola.eAutoskolaDBDataSetTableAdapters.TableAdapterManager()
        Me.OsobaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.OsobaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.OsobaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New e_autoskola.eAutoskolaDBDataSetTableAdapters.studentTableAdapter()
        Me.StudentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        TitulPredLabel = New System.Windows.Forms.Label()
        PriezviskoLabel = New System.Windows.Forms.Label()
        RodnePriezviskoLabel = New System.Windows.Forms.Label()
        MenoLabel = New System.Windows.Forms.Label()
        TitulZaLabel = New System.Windows.Forms.Label()
        DatumNarodeniaLabel = New System.Windows.Forms.Label()
        RodneCisloLabel = New System.Windows.Forms.Label()
        MiestoNarodeniaLabel = New System.Windows.Forms.Label()
        UlicaLabel = New System.Windows.Forms.Label()
        UlicaCisloLabel = New System.Windows.Forms.Label()
        MestoLabel = New System.Windows.Forms.Label()
        PscLabel = New System.Windows.Forms.Label()
        TelefonLabel = New System.Windows.Forms.Label()
        MobilLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CisloOpLabel = New System.Windows.Forms.Label()
        CisloVpLabel = New System.Windows.Forms.Label()
        CType(Me.EAutoskolaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OsobaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OsobaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OsobaBindingNavigator.SuspendLayout()
        CType(Me.OsobaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitulPredLabel
        '
        TitulPredLabel.AutoSize = True
        TitulPredLabel.Location = New System.Drawing.Point(102, 34)
        TitulPredLabel.Name = "TitulPredLabel"
        TitulPredLabel.Size = New System.Drawing.Size(51, 13)
        TitulPredLabel.TabIndex = 3
        TitulPredLabel.Text = "titul Pred:"
        '
        'PriezviskoLabel
        '
        PriezviskoLabel.AutoSize = True
        PriezviskoLabel.Location = New System.Drawing.Point(102, 60)
        PriezviskoLabel.Name = "PriezviskoLabel"
        PriezviskoLabel.Size = New System.Drawing.Size(57, 13)
        PriezviskoLabel.TabIndex = 5
        PriezviskoLabel.Text = "priezvisko:"
        '
        'RodnePriezviskoLabel
        '
        RodnePriezviskoLabel.AutoSize = True
        RodnePriezviskoLabel.Location = New System.Drawing.Point(102, 86)
        RodnePriezviskoLabel.Name = "RodnePriezviskoLabel"
        RodnePriezviskoLabel.Size = New System.Drawing.Size(88, 13)
        RodnePriezviskoLabel.TabIndex = 7
        RodnePriezviskoLabel.Text = "rodne Priezvisko:"
        '
        'MenoLabel
        '
        MenoLabel.AutoSize = True
        MenoLabel.Location = New System.Drawing.Point(102, 112)
        MenoLabel.Name = "MenoLabel"
        MenoLabel.Size = New System.Drawing.Size(36, 13)
        MenoLabel.TabIndex = 9
        MenoLabel.Text = "meno:"
        '
        'TitulZaLabel
        '
        TitulZaLabel.AutoSize = True
        TitulZaLabel.Location = New System.Drawing.Point(102, 138)
        TitulZaLabel.Name = "TitulZaLabel"
        TitulZaLabel.Size = New System.Drawing.Size(42, 13)
        TitulZaLabel.TabIndex = 11
        TitulZaLabel.Text = "titul Za:"
        '
        'DatumNarodeniaLabel
        '
        DatumNarodeniaLabel.AutoSize = True
        DatumNarodeniaLabel.Location = New System.Drawing.Point(102, 164)
        DatumNarodeniaLabel.Name = "DatumNarodeniaLabel"
        DatumNarodeniaLabel.Size = New System.Drawing.Size(91, 13)
        DatumNarodeniaLabel.TabIndex = 13
        DatumNarodeniaLabel.Text = "datum Narodenia:"
        '
        'RodneCisloLabel
        '
        RodneCisloLabel.AutoSize = True
        RodneCisloLabel.Location = New System.Drawing.Point(102, 190)
        RodneCisloLabel.Name = "RodneCisloLabel"
        RodneCisloLabel.Size = New System.Drawing.Size(62, 13)
        RodneCisloLabel.TabIndex = 15
        RodneCisloLabel.Text = "rodne Cislo:"
        '
        'MiestoNarodeniaLabel
        '
        MiestoNarodeniaLabel.AutoSize = True
        MiestoNarodeniaLabel.Location = New System.Drawing.Point(102, 216)
        MiestoNarodeniaLabel.Name = "MiestoNarodeniaLabel"
        MiestoNarodeniaLabel.Size = New System.Drawing.Size(92, 13)
        MiestoNarodeniaLabel.TabIndex = 17
        MiestoNarodeniaLabel.Text = "miesto Narodenia:"
        '
        'UlicaLabel
        '
        UlicaLabel.AutoSize = True
        UlicaLabel.Location = New System.Drawing.Point(102, 242)
        UlicaLabel.Name = "UlicaLabel"
        UlicaLabel.Size = New System.Drawing.Size(32, 13)
        UlicaLabel.TabIndex = 19
        UlicaLabel.Text = "ulica:"
        '
        'UlicaCisloLabel
        '
        UlicaCisloLabel.AutoSize = True
        UlicaCisloLabel.Location = New System.Drawing.Point(102, 268)
        UlicaCisloLabel.Name = "UlicaCisloLabel"
        UlicaCisloLabel.Size = New System.Drawing.Size(57, 13)
        UlicaCisloLabel.TabIndex = 21
        UlicaCisloLabel.Text = "ulica Cislo:"
        '
        'MestoLabel
        '
        MestoLabel.AutoSize = True
        MestoLabel.Location = New System.Drawing.Point(102, 294)
        MestoLabel.Name = "MestoLabel"
        MestoLabel.Size = New System.Drawing.Size(38, 13)
        MestoLabel.TabIndex = 23
        MestoLabel.Text = "mesto:"
        '
        'PscLabel
        '
        PscLabel.AutoSize = True
        PscLabel.Location = New System.Drawing.Point(102, 320)
        PscLabel.Name = "PscLabel"
        PscLabel.Size = New System.Drawing.Size(27, 13)
        PscLabel.TabIndex = 25
        PscLabel.Text = "psc:"
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Location = New System.Drawing.Point(102, 346)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(42, 13)
        TelefonLabel.TabIndex = 27
        TelefonLabel.Text = "telefon:"
        '
        'MobilLabel
        '
        MobilLabel.AutoSize = True
        MobilLabel.Location = New System.Drawing.Point(102, 372)
        MobilLabel.Name = "MobilLabel"
        MobilLabel.Size = New System.Drawing.Size(34, 13)
        MobilLabel.TabIndex = 29
        MobilLabel.Text = "mobil:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(102, 398)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 31
        EmailLabel.Text = "email:"
        '
        'CisloOpLabel
        '
        CisloOpLabel.AutoSize = True
        CisloOpLabel.Location = New System.Drawing.Point(102, 424)
        CisloOpLabel.Name = "CisloOpLabel"
        CisloOpLabel.Size = New System.Drawing.Size(48, 13)
        CisloOpLabel.TabIndex = 33
        CisloOpLabel.Text = "cislo Op:"
        '
        'CisloVpLabel
        '
        CisloVpLabel.AutoSize = True
        CisloVpLabel.Location = New System.Drawing.Point(102, 450)
        CisloVpLabel.Name = "CisloVpLabel"
        CisloVpLabel.Size = New System.Drawing.Size(47, 13)
        CisloVpLabel.TabIndex = 35
        CisloVpLabel.Text = "cislo Vp:"
        '
        'TitulPredTextBox
        '
        Me.TitulPredTextBox.Location = New System.Drawing.Point(200, 31)
        Me.TitulPredTextBox.Name = "TitulPredTextBox"
        Me.TitulPredTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TitulPredTextBox.TabIndex = 4
        '
        'PriezviskoTextBox
        '
        Me.PriezviskoTextBox.Location = New System.Drawing.Point(200, 57)
        Me.PriezviskoTextBox.Name = "PriezviskoTextBox"
        Me.PriezviskoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PriezviskoTextBox.TabIndex = 6
        '
        'RodnePriezviskoTextBox
        '
        Me.RodnePriezviskoTextBox.Location = New System.Drawing.Point(200, 83)
        Me.RodnePriezviskoTextBox.Name = "RodnePriezviskoTextBox"
        Me.RodnePriezviskoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RodnePriezviskoTextBox.TabIndex = 8
        '
        'MenoTextBox
        '
        Me.MenoTextBox.Location = New System.Drawing.Point(200, 109)
        Me.MenoTextBox.Name = "MenoTextBox"
        Me.MenoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MenoTextBox.TabIndex = 10
        '
        'TitulZaTextBox
        '
        Me.TitulZaTextBox.Location = New System.Drawing.Point(200, 135)
        Me.TitulZaTextBox.Name = "TitulZaTextBox"
        Me.TitulZaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TitulZaTextBox.TabIndex = 12
        '
        'DatumNarodeniaTextBox
        '
        Me.DatumNarodeniaTextBox.Location = New System.Drawing.Point(200, 161)
        Me.DatumNarodeniaTextBox.Name = "DatumNarodeniaTextBox"
        Me.DatumNarodeniaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DatumNarodeniaTextBox.TabIndex = 14
        '
        'RodneCisloTextBox
        '
        Me.RodneCisloTextBox.Location = New System.Drawing.Point(200, 187)
        Me.RodneCisloTextBox.Name = "RodneCisloTextBox"
        Me.RodneCisloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RodneCisloTextBox.TabIndex = 16
        '
        'MiestoNarodeniaTextBox
        '
        Me.MiestoNarodeniaTextBox.Location = New System.Drawing.Point(200, 213)
        Me.MiestoNarodeniaTextBox.Name = "MiestoNarodeniaTextBox"
        Me.MiestoNarodeniaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MiestoNarodeniaTextBox.TabIndex = 18
        '
        'UlicaTextBox
        '
        Me.UlicaTextBox.Location = New System.Drawing.Point(200, 239)
        Me.UlicaTextBox.Name = "UlicaTextBox"
        Me.UlicaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UlicaTextBox.TabIndex = 20
        '
        'UlicaCisloTextBox
        '
        Me.UlicaCisloTextBox.Location = New System.Drawing.Point(200, 265)
        Me.UlicaCisloTextBox.Name = "UlicaCisloTextBox"
        Me.UlicaCisloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UlicaCisloTextBox.TabIndex = 22
        '
        'MestoTextBox
        '
        Me.MestoTextBox.Location = New System.Drawing.Point(200, 291)
        Me.MestoTextBox.Name = "MestoTextBox"
        Me.MestoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MestoTextBox.TabIndex = 24
        '
        'PscTextBox
        '
        Me.PscTextBox.Location = New System.Drawing.Point(200, 317)
        Me.PscTextBox.Name = "PscTextBox"
        Me.PscTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PscTextBox.TabIndex = 26
        '
        'TelefonTextBox
        '
        Me.TelefonTextBox.Location = New System.Drawing.Point(200, 343)
        Me.TelefonTextBox.Name = "TelefonTextBox"
        Me.TelefonTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonTextBox.TabIndex = 28
        '
        'MobilTextBox
        '
        Me.MobilTextBox.Location = New System.Drawing.Point(200, 369)
        Me.MobilTextBox.Name = "MobilTextBox"
        Me.MobilTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MobilTextBox.TabIndex = 30
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(200, 395)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 32
        '
        'CisloOpTextBox
        '
        Me.CisloOpTextBox.Location = New System.Drawing.Point(200, 421)
        Me.CisloOpTextBox.Name = "CisloOpTextBox"
        Me.CisloOpTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CisloOpTextBox.TabIndex = 34
        '
        'CisloVpTextBox
        '
        Me.CisloVpTextBox.Location = New System.Drawing.Point(200, 447)
        Me.CisloVpTextBox.Name = "CisloVpTextBox"
        Me.CisloVpTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CisloVpTextBox.TabIndex = 36
        '
        'vlozStudenta
        '
        Me.vlozStudenta.Location = New System.Drawing.Point(334, 60)
        Me.vlozStudenta.Name = "vlozStudenta"
        Me.vlozStudenta.Size = New System.Drawing.Size(285, 23)
        Me.vlozStudenta.TabIndex = 37
        Me.vlozStudenta.Text = "Vlož nového študenta"
        Me.vlozStudenta.UseVisualStyleBackColor = True
        '
        'EAutoskolaDBDataSet
        '
        Me.EAutoskolaDBDataSet.DataSetName = "eAutoskolaDBDataSet"
        Me.EAutoskolaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OsobaBindingSource
        '
        Me.OsobaBindingSource.DataMember = "osoba"
        Me.OsobaBindingSource.DataSource = Me.EAutoskolaDBDataSet
        '
        'OsobaTableAdapter
        '
        Me.OsobaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.automobilTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cislenikSkupinaTableAdapter = Nothing
        Me.TableAdapterManager.clenKurzuTableAdapter = Nothing
        Me.TableAdapterManager.dodanePotvrdeniaTableAdapter = Nothing
        Me.TableAdapterManager.instruktorTableAdapter = Nothing
        Me.TableAdapterManager.kurzTableAdapter = Nothing
        Me.TableAdapterManager.osobaTableAdapter = Me.OsobaTableAdapter
        Me.TableAdapterManager.platbaTableAdapter = Nothing
        Me.TableAdapterManager.studentSkupinaUchadzacTableAdapter = Nothing
        Me.TableAdapterManager.studentSkupinaVlastnikTableAdapter = Nothing
        Me.TableAdapterManager.studentTableAdapter = Me.StudentTableAdapter
        Me.TableAdapterManager.UpdateOrder = e_autoskola.eAutoskolaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vseobecneUdajeTableAdapter = Nothing
        '
        'OsobaBindingNavigator
        '
        Me.OsobaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OsobaBindingNavigator.BindingSource = Me.OsobaBindingSource
        Me.OsobaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OsobaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OsobaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.OsobaBindingNavigatorSaveItem})
        Me.OsobaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OsobaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OsobaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OsobaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OsobaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OsobaBindingNavigator.Name = "OsobaBindingNavigator"
        Me.OsobaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OsobaBindingNavigator.Size = New System.Drawing.Size(728, 25)
        Me.OsobaBindingNavigator.TabIndex = 38
        Me.OsobaBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 13)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'OsobaBindingNavigatorSaveItem
        '
        Me.OsobaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OsobaBindingNavigatorSaveItem.Image = CType(resources.GetObject("OsobaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OsobaBindingNavigatorSaveItem.Name = "OsobaBindingNavigatorSaveItem"
        Me.OsobaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.OsobaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'OsobaDataGridView
        '
        Me.OsobaDataGridView.AutoGenerateColumns = False
        Me.OsobaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OsobaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.OsobaDataGridView.DataSource = Me.OsobaBindingSource
        Me.OsobaDataGridView.Location = New System.Drawing.Point(12, 501)
        Me.OsobaDataGridView.Name = "OsobaDataGridView"
        Me.OsobaDataGridView.Size = New System.Drawing.Size(670, 170)
        Me.OsobaDataGridView.TabIndex = 38
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "titulPred"
        Me.DataGridViewTextBoxColumn2.HeaderText = "titulPred"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "priezvisko"
        Me.DataGridViewTextBoxColumn3.HeaderText = "priezvisko"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "rodnePriezvisko"
        Me.DataGridViewTextBoxColumn4.HeaderText = "rodnePriezvisko"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "meno"
        Me.DataGridViewTextBoxColumn5.HeaderText = "meno"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "titulZa"
        Me.DataGridViewTextBoxColumn6.HeaderText = "titulZa"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "datumNarodenia"
        Me.DataGridViewTextBoxColumn7.HeaderText = "datumNarodenia"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "rodneCislo"
        Me.DataGridViewTextBoxColumn8.HeaderText = "rodneCislo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "miestoNarodenia"
        Me.DataGridViewTextBoxColumn9.HeaderText = "miestoNarodenia"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ulica"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ulica"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ulicaCislo"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ulicaCislo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "mesto"
        Me.DataGridViewTextBoxColumn12.HeaderText = "mesto"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "psc"
        Me.DataGridViewTextBoxColumn13.HeaderText = "psc"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "telefon"
        Me.DataGridViewTextBoxColumn14.HeaderText = "telefon"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "mobil"
        Me.DataGridViewTextBoxColumn15.HeaderText = "mobil"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn16.HeaderText = "email"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "cisloOp"
        Me.DataGridViewTextBoxColumn17.HeaderText = "cisloOp"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "cisloVp"
        Me.DataGridViewTextBoxColumn18.HeaderText = "cisloVp"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 482)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Tabulka osoba"
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "student"
        Me.StudentBindingSource.DataSource = Me.EAutoskolaDBDataSet
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'StudentDataGridView
        '
        Me.StudentDataGridView.AutoGenerateColumns = False
        Me.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn19})
        Me.StudentDataGridView.DataSource = Me.StudentBindingSource
        Me.StudentDataGridView.Location = New System.Drawing.Point(26, 691)
        Me.StudentDataGridView.Name = "StudentDataGridView"
        Me.StudentDataGridView.Size = New System.Drawing.Size(656, 220)
        Me.StudentDataGridView.TabIndex = 39
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn19.HeaderText = "id"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 672)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Tabulka student"
        '
        'studentNovy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 948)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StudentDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OsobaDataGridView)
        Me.Controls.Add(Me.OsobaBindingNavigator)
        Me.Controls.Add(Me.vlozStudenta)
        Me.Controls.Add(TitulPredLabel)
        Me.Controls.Add(Me.TitulPredTextBox)
        Me.Controls.Add(PriezviskoLabel)
        Me.Controls.Add(Me.PriezviskoTextBox)
        Me.Controls.Add(RodnePriezviskoLabel)
        Me.Controls.Add(Me.RodnePriezviskoTextBox)
        Me.Controls.Add(MenoLabel)
        Me.Controls.Add(Me.MenoTextBox)
        Me.Controls.Add(TitulZaLabel)
        Me.Controls.Add(Me.TitulZaTextBox)
        Me.Controls.Add(DatumNarodeniaLabel)
        Me.Controls.Add(Me.DatumNarodeniaTextBox)
        Me.Controls.Add(RodneCisloLabel)
        Me.Controls.Add(Me.RodneCisloTextBox)
        Me.Controls.Add(MiestoNarodeniaLabel)
        Me.Controls.Add(Me.MiestoNarodeniaTextBox)
        Me.Controls.Add(UlicaLabel)
        Me.Controls.Add(Me.UlicaTextBox)
        Me.Controls.Add(UlicaCisloLabel)
        Me.Controls.Add(Me.UlicaCisloTextBox)
        Me.Controls.Add(MestoLabel)
        Me.Controls.Add(Me.MestoTextBox)
        Me.Controls.Add(PscLabel)
        Me.Controls.Add(Me.PscTextBox)
        Me.Controls.Add(TelefonLabel)
        Me.Controls.Add(Me.TelefonTextBox)
        Me.Controls.Add(MobilLabel)
        Me.Controls.Add(Me.MobilTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(CisloOpLabel)
        Me.Controls.Add(Me.CisloOpTextBox)
        Me.Controls.Add(CisloVpLabel)
        Me.Controls.Add(Me.CisloVpTextBox)
        Me.Name = "studentNovy"
        Me.Text = "Študent - nový"
        CType(Me.EAutoskolaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OsobaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OsobaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OsobaBindingNavigator.ResumeLayout(False)
        Me.OsobaBindingNavigator.PerformLayout()
        CType(Me.OsobaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitulPredTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriezviskoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RodnePriezviskoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitulZaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DatumNarodeniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RodneCisloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MiestoNarodeniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UlicaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UlicaCisloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MestoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PscTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MobilTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CisloOpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CisloVpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents vlozStudenta As System.Windows.Forms.Button
    Friend WithEvents EAutoskolaDBDataSet As e_autoskola.eAutoskolaDBDataSet
    Friend WithEvents OsobaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OsobaTableAdapter As e_autoskola.eAutoskolaDBDataSetTableAdapters.osobaTableAdapter
    Friend WithEvents TableAdapterManager As e_autoskola.eAutoskolaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OsobaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents OsobaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents OsobaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentTableAdapter As e_autoskola.eAutoskolaDBDataSetTableAdapters.studentTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
