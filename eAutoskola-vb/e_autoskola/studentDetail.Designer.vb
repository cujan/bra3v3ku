﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentDetail
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
        Dim IdLabel As System.Windows.Forms.Label
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentDetail))
        Me.EAutoskolaDBDataSet = New e_autoskola.eAutoskolaDBDataSet()
        Me.StudentPrehladBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentPrehladTableAdapter = New e_autoskola.eAutoskolaDBDataSetTableAdapters.studentPrehladTableAdapter()
        Me.TableAdapterManager = New e_autoskola.eAutoskolaDBDataSetTableAdapters.TableAdapterManager()
        Me.StudentPrehladBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.StudentPrehladBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
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
        CType(Me.StudentPrehladBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentPrehladBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StudentPrehladBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(148, 62)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'TitulPredLabel
        '
        TitulPredLabel.AutoSize = True
        TitulPredLabel.Location = New System.Drawing.Point(148, 88)
        TitulPredLabel.Name = "TitulPredLabel"
        TitulPredLabel.Size = New System.Drawing.Size(51, 13)
        TitulPredLabel.TabIndex = 3
        TitulPredLabel.Text = "titul Pred:"
        '
        'PriezviskoLabel
        '
        PriezviskoLabel.AutoSize = True
        PriezviskoLabel.Location = New System.Drawing.Point(148, 114)
        PriezviskoLabel.Name = "PriezviskoLabel"
        PriezviskoLabel.Size = New System.Drawing.Size(57, 13)
        PriezviskoLabel.TabIndex = 5
        PriezviskoLabel.Text = "priezvisko:"
        '
        'RodnePriezviskoLabel
        '
        RodnePriezviskoLabel.AutoSize = True
        RodnePriezviskoLabel.Location = New System.Drawing.Point(148, 140)
        RodnePriezviskoLabel.Name = "RodnePriezviskoLabel"
        RodnePriezviskoLabel.Size = New System.Drawing.Size(88, 13)
        RodnePriezviskoLabel.TabIndex = 7
        RodnePriezviskoLabel.Text = "rodne Priezvisko:"
        '
        'MenoLabel
        '
        MenoLabel.AutoSize = True
        MenoLabel.Location = New System.Drawing.Point(148, 166)
        MenoLabel.Name = "MenoLabel"
        MenoLabel.Size = New System.Drawing.Size(36, 13)
        MenoLabel.TabIndex = 9
        MenoLabel.Text = "meno:"
        '
        'TitulZaLabel
        '
        TitulZaLabel.AutoSize = True
        TitulZaLabel.Location = New System.Drawing.Point(148, 192)
        TitulZaLabel.Name = "TitulZaLabel"
        TitulZaLabel.Size = New System.Drawing.Size(42, 13)
        TitulZaLabel.TabIndex = 11
        TitulZaLabel.Text = "titul Za:"
        '
        'DatumNarodeniaLabel
        '
        DatumNarodeniaLabel.AutoSize = True
        DatumNarodeniaLabel.Location = New System.Drawing.Point(148, 218)
        DatumNarodeniaLabel.Name = "DatumNarodeniaLabel"
        DatumNarodeniaLabel.Size = New System.Drawing.Size(91, 13)
        DatumNarodeniaLabel.TabIndex = 13
        DatumNarodeniaLabel.Text = "datum Narodenia:"
        '
        'RodneCisloLabel
        '
        RodneCisloLabel.AutoSize = True
        RodneCisloLabel.Location = New System.Drawing.Point(148, 244)
        RodneCisloLabel.Name = "RodneCisloLabel"
        RodneCisloLabel.Size = New System.Drawing.Size(62, 13)
        RodneCisloLabel.TabIndex = 15
        RodneCisloLabel.Text = "rodne Cislo:"
        '
        'MiestoNarodeniaLabel
        '
        MiestoNarodeniaLabel.AutoSize = True
        MiestoNarodeniaLabel.Location = New System.Drawing.Point(148, 270)
        MiestoNarodeniaLabel.Name = "MiestoNarodeniaLabel"
        MiestoNarodeniaLabel.Size = New System.Drawing.Size(92, 13)
        MiestoNarodeniaLabel.TabIndex = 17
        MiestoNarodeniaLabel.Text = "miesto Narodenia:"
        '
        'UlicaLabel
        '
        UlicaLabel.AutoSize = True
        UlicaLabel.Location = New System.Drawing.Point(148, 296)
        UlicaLabel.Name = "UlicaLabel"
        UlicaLabel.Size = New System.Drawing.Size(32, 13)
        UlicaLabel.TabIndex = 19
        UlicaLabel.Text = "ulica:"
        '
        'UlicaCisloLabel
        '
        UlicaCisloLabel.AutoSize = True
        UlicaCisloLabel.Location = New System.Drawing.Point(148, 322)
        UlicaCisloLabel.Name = "UlicaCisloLabel"
        UlicaCisloLabel.Size = New System.Drawing.Size(57, 13)
        UlicaCisloLabel.TabIndex = 21
        UlicaCisloLabel.Text = "ulica Cislo:"
        '
        'MestoLabel
        '
        MestoLabel.AutoSize = True
        MestoLabel.Location = New System.Drawing.Point(148, 348)
        MestoLabel.Name = "MestoLabel"
        MestoLabel.Size = New System.Drawing.Size(38, 13)
        MestoLabel.TabIndex = 23
        MestoLabel.Text = "mesto:"
        '
        'PscLabel
        '
        PscLabel.AutoSize = True
        PscLabel.Location = New System.Drawing.Point(148, 374)
        PscLabel.Name = "PscLabel"
        PscLabel.Size = New System.Drawing.Size(27, 13)
        PscLabel.TabIndex = 25
        PscLabel.Text = "psc:"
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Location = New System.Drawing.Point(148, 400)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(42, 13)
        TelefonLabel.TabIndex = 27
        TelefonLabel.Text = "telefon:"
        '
        'MobilLabel
        '
        MobilLabel.AutoSize = True
        MobilLabel.Location = New System.Drawing.Point(148, 426)
        MobilLabel.Name = "MobilLabel"
        MobilLabel.Size = New System.Drawing.Size(34, 13)
        MobilLabel.TabIndex = 29
        MobilLabel.Text = "mobil:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(148, 452)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 31
        EmailLabel.Text = "email:"
        '
        'CisloOpLabel
        '
        CisloOpLabel.AutoSize = True
        CisloOpLabel.Location = New System.Drawing.Point(148, 478)
        CisloOpLabel.Name = "CisloOpLabel"
        CisloOpLabel.Size = New System.Drawing.Size(48, 13)
        CisloOpLabel.TabIndex = 33
        CisloOpLabel.Text = "cislo Op:"
        '
        'CisloVpLabel
        '
        CisloVpLabel.AutoSize = True
        CisloVpLabel.Location = New System.Drawing.Point(148, 504)
        CisloVpLabel.Name = "CisloVpLabel"
        CisloVpLabel.Size = New System.Drawing.Size(47, 13)
        CisloVpLabel.TabIndex = 35
        CisloVpLabel.Text = "cislo Vp:"
        '
        'EAutoskolaDBDataSet
        '
        Me.EAutoskolaDBDataSet.DataSetName = "eAutoskolaDBDataSet"
        Me.EAutoskolaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentPrehladBindingSource
        '
        Me.StudentPrehladBindingSource.DataMember = "studentPrehlad"
        Me.StudentPrehladBindingSource.DataSource = Me.EAutoskolaDBDataSet
        '
        'StudentPrehladTableAdapter
        '
        Me.StudentPrehladTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.automobilTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ciselnikSkupinaTableAdapter = Nothing
        Me.TableAdapterManager.clenKurzuTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.dodanePotvrdeniaTableAdapter = Nothing
        Me.TableAdapterManager.instruktorTableAdapter = Nothing
        Me.TableAdapterManager.kurzTableAdapter = Nothing
        Me.TableAdapterManager.osobaTableAdapter = Nothing
        Me.TableAdapterManager.platbaTableAdapter = Nothing
        Me.TableAdapterManager.studentSkupinaUchadzacTableAdapter = Nothing
        Me.TableAdapterManager.studentSkupinaVlastnikTableAdapter = Nothing
        Me.TableAdapterManager.studentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = e_autoskola.eAutoskolaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vseobecneUdajeTableAdapter = Nothing
        '
        'StudentPrehladBindingNavigator
        '
        Me.StudentPrehladBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StudentPrehladBindingNavigator.BindingSource = Me.StudentPrehladBindingSource
        Me.StudentPrehladBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StudentPrehladBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StudentPrehladBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StudentPrehladBindingNavigatorSaveItem})
        Me.StudentPrehladBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StudentPrehladBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StudentPrehladBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StudentPrehladBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StudentPrehladBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StudentPrehladBindingNavigator.Name = "StudentPrehladBindingNavigator"
        Me.StudentPrehladBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StudentPrehladBindingNavigator.Size = New System.Drawing.Size(933, 25)
        Me.StudentPrehladBindingNavigator.TabIndex = 0
        Me.StudentPrehladBindingNavigator.Text = "BindingNavigator1"
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
        'StudentPrehladBindingNavigatorSaveItem
        '
        Me.StudentPrehladBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StudentPrehladBindingNavigatorSaveItem.Enabled = False
        Me.StudentPrehladBindingNavigatorSaveItem.Image = CType(resources.GetObject("StudentPrehladBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StudentPrehladBindingNavigatorSaveItem.Name = "StudentPrehladBindingNavigatorSaveItem"
        Me.StudentPrehladBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.StudentPrehladBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentPrehladBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(246, 59)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'TitulPredTextBox
        '
        Me.TitulPredTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentPrehladBindingSource, "titulPred", True))
        Me.TitulPredTextBox.Location = New System.Drawing.Point(246, 85)
        Me.TitulPredTextBox.Name = "TitulPredTextBox"
        Me.TitulPredTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TitulPredTextBox.TabIndex = 4
        '
        'PriezviskoTextBox
        '
        Me.PriezviskoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentPrehladBindingSource, "priezvisko", True))
        Me.PriezviskoTextBox.Location = New System.Drawing.Point(246, 111)
        Me.PriezviskoTextBox.Name = "PriezviskoTextBox"
        Me.PriezviskoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PriezviskoTextBox.TabIndex = 6
        '
        'RodnePriezviskoTextBox
        '
        Me.RodnePriezviskoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentPrehladBindingSource, "rodnePriezvisko", True))
        Me.RodnePriezviskoTextBox.Location = New System.Drawing.Point(246, 137)
        Me.RodnePriezviskoTextBox.Name = "RodnePriezviskoTextBox"
        Me.RodnePriezviskoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RodnePriezviskoTextBox.TabIndex = 8
        '
        'MenoTextBox
        '
        Me.MenoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentPrehladBindingSource, "meno", True))
        Me.MenoTextBox.Location = New System.Drawing.Point(246, 163)
        Me.MenoTextBox.Name = "MenoTextBox"
        Me.MenoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MenoTextBox.TabIndex = 10
        '
        'TitulZaTextBox
        '
        Me.TitulZaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentPrehladBindingSource, "titulZa", True))
        Me.TitulZaTextBox.Location = New System.Drawing.Point(246, 189)
        Me.TitulZaTextBox.Name = "TitulZaTextBox"
        Me.TitulZaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TitulZaTextBox.TabIndex = 12
        '
        'DatumNarodeniaTextBox
        '
        Me.DatumNarodeniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentPrehladBindingSource, "datumNarodenia", True))
        Me.DatumNarodeniaTextBox.Location = New System.Drawing.Point(246, 215)
        Me.DatumNarodeniaTextBox.Name = "DatumNarodeniaTextBox"
        Me.DatumNarodeniaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DatumNarodeniaTextBox.TabIndex = 14
        '
        'RodneCisloTextBox
        '
        Me.RodneCisloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentPrehladBindingSource, "rodneCislo", True))
        Me.RodneCisloTextBox.Location = New System.Drawing.Point(246, 241)
        Me.RodneCisloTextBox.Name = "RodneCisloTextBox"
        Me.RodneCisloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RodneCisloTextBox.TabIndex = 16
        '
        'MiestoNarodeniaTextBox
        '
        Me.MiestoNarodeniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentPrehladBindingSource, "miestoNarodenia", True))
        Me.MiestoNarodeniaTextBox.Location = New System.Drawing.Point(246, 267)
        Me.MiestoNarodeniaTextBox.Name = "MiestoNarodeniaTextBox"
        Me.MiestoNarodeniaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MiestoNarodeniaTextBox.TabIndex = 18
        '
        'UlicaTextBox
        '
        Me.UlicaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentPrehladBindingSource, "ulica", True))
        Me.UlicaTextBox.Location = New System.Drawing.Point(246, 293)
        Me.UlicaTextBox.Name = "UlicaTextBox"
        Me.UlicaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UlicaTextBox.TabIndex = 20
        '
        'UlicaCisloTextBox
        '
        Me.UlicaCisloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentPrehladBindingSource, "ulicaCislo", True))
        Me.UlicaCisloTextBox.Location = New System.Drawing.Point(246, 319)
        Me.UlicaCisloTextBox.Name = "UlicaCisloTextBox"
        Me.UlicaCisloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UlicaCisloTextBox.TabIndex = 22
        '
        'MestoTextBox
        '
        Me.MestoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentPrehladBindingSource, "mesto", True))
        Me.MestoTextBox.Location = New System.Drawing.Point(246, 345)
        Me.MestoTextBox.Name = "MestoTextBox"
        Me.MestoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MestoTextBox.TabIndex = 24
        '
        'PscTextBox
        '
        Me.PscTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentPrehladBindingSource, "psc", True))
        Me.PscTextBox.Location = New System.Drawing.Point(246, 371)
        Me.PscTextBox.Name = "PscTextBox"
        Me.PscTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PscTextBox.TabIndex = 26
        '
        'TelefonTextBox
        '
        Me.TelefonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentPrehladBindingSource, "telefon", True))
        Me.TelefonTextBox.Location = New System.Drawing.Point(246, 397)
        Me.TelefonTextBox.Name = "TelefonTextBox"
        Me.TelefonTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonTextBox.TabIndex = 28
        '
        'MobilTextBox
        '
        Me.MobilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentPrehladBindingSource, "mobil", True))
        Me.MobilTextBox.Location = New System.Drawing.Point(246, 423)
        Me.MobilTextBox.Name = "MobilTextBox"
        Me.MobilTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MobilTextBox.TabIndex = 30
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentPrehladBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(246, 449)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 32
        '
        'CisloOpTextBox
        '
        Me.CisloOpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentPrehladBindingSource, "cisloOp", True))
        Me.CisloOpTextBox.Location = New System.Drawing.Point(246, 475)
        Me.CisloOpTextBox.Name = "CisloOpTextBox"
        Me.CisloOpTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CisloOpTextBox.TabIndex = 34
        '
        'CisloVpTextBox
        '
        Me.CisloVpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentPrehladBindingSource, "cisloVp", True))
        Me.CisloVpTextBox.Location = New System.Drawing.Point(246, 501)
        Me.CisloVpTextBox.Name = "CisloVpTextBox"
        Me.CisloVpTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CisloVpTextBox.TabIndex = 36
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(468, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Prihlaska"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(480, 148)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 23)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Ziadost o vodicak"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'studentDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 541)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
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
        Me.Controls.Add(Me.StudentPrehladBindingNavigator)
        Me.Name = "studentDetail"
        Me.Text = "studentDetail"
        CType(Me.EAutoskolaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentPrehladBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentPrehladBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudentPrehladBindingNavigator.ResumeLayout(False)
        Me.StudentPrehladBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EAutoskolaDBDataSet As e_autoskola.eAutoskolaDBDataSet
    Friend WithEvents StudentPrehladBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentPrehladTableAdapter As e_autoskola.eAutoskolaDBDataSetTableAdapters.studentPrehladTableAdapter
    Friend WithEvents TableAdapterManager As e_autoskola.eAutoskolaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentPrehladBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents StudentPrehladBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class