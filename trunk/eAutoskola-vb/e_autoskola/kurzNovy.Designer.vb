<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kurzNovy
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
        Dim ZaciatokDatumLabel As System.Windows.Forms.Label
        Dim DenVykonavaniaLabel As System.Windows.Forms.Label
        Dim HodinaVykonavaniaLabel As System.Windows.Forms.Label
        Dim SkupinyLabel As System.Windows.Forms.Label
        Dim IdInstruktorLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(kurzNovy))
        Me.ZaciatokDatumDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DenVykonavaniaTextBox = New System.Windows.Forms.TextBox()
        Me.HodinaVykonavaniaTextBox = New System.Windows.Forms.TextBox()
        Me.SkupinyTextBox = New System.Windows.Forms.TextBox()
        Me.IdInstruktorTextBox = New System.Windows.Forms.TextBox()
        Me.vlozKurz = New System.Windows.Forms.Button()
        Me.EAutoskolaDBDataSet = New e_autoskola.eAutoskolaDBDataSet()
        Me.KurzBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KurzTableAdapter = New e_autoskola.eAutoskolaDBDataSetTableAdapters.kurzTableAdapter()
        Me.TableAdapterManager = New e_autoskola.eAutoskolaDBDataSetTableAdapters.TableAdapterManager()
        Me.KurzBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.KurzBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.KurzDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ZaciatokDatumLabel = New System.Windows.Forms.Label()
        DenVykonavaniaLabel = New System.Windows.Forms.Label()
        HodinaVykonavaniaLabel = New System.Windows.Forms.Label()
        SkupinyLabel = New System.Windows.Forms.Label()
        IdInstruktorLabel = New System.Windows.Forms.Label()
        CType(Me.EAutoskolaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KurzBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KurzBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KurzBindingNavigator.SuspendLayout()
        CType(Me.KurzDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ZaciatokDatumLabel
        '
        ZaciatokDatumLabel.AutoSize = True
        ZaciatokDatumLabel.Location = New System.Drawing.Point(117, 95)
        ZaciatokDatumLabel.Name = "ZaciatokDatumLabel"
        ZaciatokDatumLabel.Size = New System.Drawing.Size(84, 13)
        ZaciatokDatumLabel.TabIndex = 3
        ZaciatokDatumLabel.Text = "zaciatok Datum:"
        '
        'ZaciatokDatumDateTimePicker
        '
        Me.ZaciatokDatumDateTimePicker.Location = New System.Drawing.Point(230, 91)
        Me.ZaciatokDatumDateTimePicker.Name = "ZaciatokDatumDateTimePicker"
        Me.ZaciatokDatumDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.ZaciatokDatumDateTimePicker.TabIndex = 4
        '
        'DenVykonavaniaLabel
        '
        DenVykonavaniaLabel.AutoSize = True
        DenVykonavaniaLabel.Location = New System.Drawing.Point(117, 120)
        DenVykonavaniaLabel.Name = "DenVykonavaniaLabel"
        DenVykonavaniaLabel.Size = New System.Drawing.Size(93, 13)
        DenVykonavaniaLabel.TabIndex = 5
        DenVykonavaniaLabel.Text = "den Vykonavania:"
        '
        'DenVykonavaniaTextBox
        '
        Me.DenVykonavaniaTextBox.Location = New System.Drawing.Point(230, 117)
        Me.DenVykonavaniaTextBox.Name = "DenVykonavaniaTextBox"
        Me.DenVykonavaniaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DenVykonavaniaTextBox.TabIndex = 6
        '
        'HodinaVykonavaniaLabel
        '
        HodinaVykonavaniaLabel.AutoSize = True
        HodinaVykonavaniaLabel.Location = New System.Drawing.Point(117, 146)
        HodinaVykonavaniaLabel.Name = "HodinaVykonavaniaLabel"
        HodinaVykonavaniaLabel.Size = New System.Drawing.Size(107, 13)
        HodinaVykonavaniaLabel.TabIndex = 7
        HodinaVykonavaniaLabel.Text = "hodina Vykonavania:"
        '
        'HodinaVykonavaniaTextBox
        '
        Me.HodinaVykonavaniaTextBox.Location = New System.Drawing.Point(230, 143)
        Me.HodinaVykonavaniaTextBox.Name = "HodinaVykonavaniaTextBox"
        Me.HodinaVykonavaniaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.HodinaVykonavaniaTextBox.TabIndex = 8
        '
        'SkupinyLabel
        '
        SkupinyLabel.AutoSize = True
        SkupinyLabel.Location = New System.Drawing.Point(117, 172)
        SkupinyLabel.Name = "SkupinyLabel"
        SkupinyLabel.Size = New System.Drawing.Size(46, 13)
        SkupinyLabel.TabIndex = 9
        SkupinyLabel.Text = "skupiny:"
        '
        'SkupinyTextBox
        '
        Me.SkupinyTextBox.Location = New System.Drawing.Point(230, 169)
        Me.SkupinyTextBox.Name = "SkupinyTextBox"
        Me.SkupinyTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SkupinyTextBox.TabIndex = 10
        '
        'IdInstruktorLabel
        '
        IdInstruktorLabel.AutoSize = True
        IdInstruktorLabel.Location = New System.Drawing.Point(117, 198)
        IdInstruktorLabel.Name = "IdInstruktorLabel"
        IdInstruktorLabel.Size = New System.Drawing.Size(65, 13)
        IdInstruktorLabel.TabIndex = 11
        IdInstruktorLabel.Text = "id Instruktor:"
        '
        'IdInstruktorTextBox
        '
        Me.IdInstruktorTextBox.Location = New System.Drawing.Point(230, 195)
        Me.IdInstruktorTextBox.Name = "IdInstruktorTextBox"
        Me.IdInstruktorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdInstruktorTextBox.TabIndex = 12
        '
        'vlozKurz
        '
        Me.vlozKurz.Location = New System.Drawing.Point(120, 221)
        Me.vlozKurz.Name = "vlozKurz"
        Me.vlozKurz.Size = New System.Drawing.Size(157, 23)
        Me.vlozKurz.TabIndex = 13
        Me.vlozKurz.Text = "Vlož nový kurz"
        Me.vlozKurz.UseVisualStyleBackColor = True
        '
        'EAutoskolaDBDataSet
        '
        Me.EAutoskolaDBDataSet.DataSetName = "eAutoskolaDBDataSet"
        Me.EAutoskolaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KurzBindingSource
        '
        Me.KurzBindingSource.DataMember = "kurz"
        Me.KurzBindingSource.DataSource = Me.EAutoskolaDBDataSet
        '
        'KurzTableAdapter
        '
        Me.KurzTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.automobilTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cislenikSkupinaTableAdapter = Nothing
        Me.TableAdapterManager.clenKurzuTableAdapter = Nothing
        Me.TableAdapterManager.dodanePotvrdeniaTableAdapter = Nothing
        Me.TableAdapterManager.instruktorTableAdapter = Nothing
        Me.TableAdapterManager.kurzTableAdapter = Me.KurzTableAdapter
        Me.TableAdapterManager.osobaTableAdapter = Nothing
        Me.TableAdapterManager.platbaTableAdapter = Nothing
        Me.TableAdapterManager.studentSkupinaUchadzacTableAdapter = Nothing
        Me.TableAdapterManager.studentSkupinaVlastnikTableAdapter = Nothing
        Me.TableAdapterManager.studentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = e_autoskola.eAutoskolaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vseobecneUdajeTableAdapter = Nothing
        '
        'KurzBindingNavigator
        '
        Me.KurzBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.KurzBindingNavigator.BindingSource = Me.KurzBindingSource
        Me.KurzBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.KurzBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.KurzBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.KurzBindingNavigatorSaveItem})
        Me.KurzBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.KurzBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.KurzBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.KurzBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.KurzBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.KurzBindingNavigator.Name = "KurzBindingNavigator"
        Me.KurzBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.KurzBindingNavigator.Size = New System.Drawing.Size(888, 25)
        Me.KurzBindingNavigator.TabIndex = 14
        Me.KurzBindingNavigator.Text = "BindingNavigator1"
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
        'KurzBindingNavigatorSaveItem
        '
        Me.KurzBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.KurzBindingNavigatorSaveItem.Image = CType(resources.GetObject("KurzBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.KurzBindingNavigatorSaveItem.Name = "KurzBindingNavigatorSaveItem"
        Me.KurzBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.KurzBindingNavigatorSaveItem.Text = "Save Data"
        '
        'KurzDataGridView
        '
        Me.KurzDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KurzDataGridView.AutoGenerateColumns = False
        Me.KurzDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KurzDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.KurzDataGridView.DataSource = Me.KurzBindingSource
        Me.KurzDataGridView.Location = New System.Drawing.Point(12, 319)
        Me.KurzDataGridView.Name = "KurzDataGridView"
        Me.KurzDataGridView.Size = New System.Drawing.Size(864, 248)
        Me.KurzDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "zaciatokDatum"
        Me.DataGridViewTextBoxColumn2.HeaderText = "zaciatokDatum"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "denVykonavania"
        Me.DataGridViewTextBoxColumn3.HeaderText = "denVykonavania"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "hodinaVykonavania"
        Me.DataGridViewTextBoxColumn4.HeaderText = "hodinaVykonavania"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "skupiny"
        Me.DataGridViewTextBoxColumn5.HeaderText = "skupiny"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "idInstruktor"
        Me.DataGridViewTextBoxColumn6.HeaderText = "idInstruktor"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'kurzNovy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 579)
        Me.Controls.Add(Me.KurzDataGridView)
        Me.Controls.Add(Me.KurzBindingNavigator)
        Me.Controls.Add(Me.vlozKurz)
        Me.Controls.Add(ZaciatokDatumLabel)
        Me.Controls.Add(Me.ZaciatokDatumDateTimePicker)
        Me.Controls.Add(DenVykonavaniaLabel)
        Me.Controls.Add(Me.DenVykonavaniaTextBox)
        Me.Controls.Add(HodinaVykonavaniaLabel)
        Me.Controls.Add(Me.HodinaVykonavaniaTextBox)
        Me.Controls.Add(SkupinyLabel)
        Me.Controls.Add(Me.SkupinyTextBox)
        Me.Controls.Add(IdInstruktorLabel)
        Me.Controls.Add(Me.IdInstruktorTextBox)
        Me.Name = "kurzNovy"
        Me.Text = "kurzNovy"
        CType(Me.EAutoskolaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KurzBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KurzBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KurzBindingNavigator.ResumeLayout(False)
        Me.KurzBindingNavigator.PerformLayout()
        CType(Me.KurzDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ZaciatokDatumDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DenVykonavaniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HodinaVykonavaniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SkupinyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdInstruktorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents vlozKurz As System.Windows.Forms.Button
    Friend WithEvents EAutoskolaDBDataSet As e_autoskola.eAutoskolaDBDataSet
    Friend WithEvents KurzBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KurzTableAdapter As e_autoskola.eAutoskolaDBDataSetTableAdapters.kurzTableAdapter
    Friend WithEvents TableAdapterManager As e_autoskola.eAutoskolaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents KurzBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents KurzBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents KurzDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
