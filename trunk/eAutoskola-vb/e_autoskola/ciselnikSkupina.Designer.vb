<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ciselnikSkupina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ciselnikSkupina))
        Me.EAutoskolaDBDataSet = New e_autoskola.eAutoskolaDBDataSet()
        Me.CislenikSkupinaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CislenikSkupinaTableAdapter = New e_autoskola.eAutoskolaDBDataSetTableAdapters.cislenikSkupinaTableAdapter()
        Me.TableAdapterManager = New e_autoskola.eAutoskolaDBDataSetTableAdapters.TableAdapterManager()
        Me.CislenikSkupinaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CislenikSkupinaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CislenikSkupinaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.EAutoskolaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CislenikSkupinaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CislenikSkupinaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CislenikSkupinaBindingNavigator.SuspendLayout()
        CType(Me.CislenikSkupinaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EAutoskolaDBDataSet
        '
        Me.EAutoskolaDBDataSet.DataSetName = "eAutoskolaDBDataSet"
        Me.EAutoskolaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CislenikSkupinaBindingSource
        '
        Me.CislenikSkupinaBindingSource.DataMember = "cislenikSkupina"
        Me.CislenikSkupinaBindingSource.DataSource = Me.EAutoskolaDBDataSet
        '
        'CislenikSkupinaTableAdapter
        '
        Me.CislenikSkupinaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.automobilTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cislenikSkupinaTableAdapter = Me.CislenikSkupinaTableAdapter
        Me.TableAdapterManager.clenKurzuTableAdapter = Nothing
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
        'CislenikSkupinaBindingNavigator
        '
        Me.CislenikSkupinaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CislenikSkupinaBindingNavigator.BindingSource = Me.CislenikSkupinaBindingSource
        Me.CislenikSkupinaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CislenikSkupinaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CislenikSkupinaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CislenikSkupinaBindingNavigatorSaveItem})
        Me.CislenikSkupinaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CislenikSkupinaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CislenikSkupinaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CislenikSkupinaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CislenikSkupinaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CislenikSkupinaBindingNavigator.Name = "CislenikSkupinaBindingNavigator"
        Me.CislenikSkupinaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CislenikSkupinaBindingNavigator.Size = New System.Drawing.Size(988, 25)
        Me.CislenikSkupinaBindingNavigator.TabIndex = 0
        Me.CislenikSkupinaBindingNavigator.Text = "BindingNavigator1"
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
        'CislenikSkupinaBindingNavigatorSaveItem
        '
        Me.CislenikSkupinaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CislenikSkupinaBindingNavigatorSaveItem.Image = CType(resources.GetObject("CislenikSkupinaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CislenikSkupinaBindingNavigatorSaveItem.Name = "CislenikSkupinaBindingNavigatorSaveItem"
        Me.CislenikSkupinaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.CislenikSkupinaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CislenikSkupinaDataGridView
        '
        Me.CislenikSkupinaDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CislenikSkupinaDataGridView.AutoGenerateColumns = False
        Me.CislenikSkupinaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CislenikSkupinaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1})
        Me.CislenikSkupinaDataGridView.DataSource = Me.CislenikSkupinaBindingSource
        Me.CislenikSkupinaDataGridView.Location = New System.Drawing.Point(12, 38)
        Me.CislenikSkupinaDataGridView.Name = "CislenikSkupinaDataGridView"
        Me.CislenikSkupinaDataGridView.Size = New System.Drawing.Size(889, 425)
        Me.CislenikSkupinaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "skupina"
        Me.DataGridViewTextBoxColumn2.HeaderText = "skupina"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "popis"
        Me.DataGridViewTextBoxColumn3.HeaderText = "popis"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "vlastnikAutoskola"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "vlastnikAutoskola"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'ciselnikSkupina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 512)
        Me.Controls.Add(Me.CislenikSkupinaDataGridView)
        Me.Controls.Add(Me.CislenikSkupinaBindingNavigator)
        Me.Name = "ciselnikSkupina"
        Me.Text = "ciselnikSkupina"
        CType(Me.EAutoskolaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CislenikSkupinaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CislenikSkupinaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CislenikSkupinaBindingNavigator.ResumeLayout(False)
        Me.CislenikSkupinaBindingNavigator.PerformLayout()
        CType(Me.CislenikSkupinaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EAutoskolaDBDataSet As e_autoskola.eAutoskolaDBDataSet
    Friend WithEvents CislenikSkupinaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CislenikSkupinaTableAdapter As e_autoskola.eAutoskolaDBDataSetTableAdapters.cislenikSkupinaTableAdapter
    Friend WithEvents TableAdapterManager As e_autoskola.eAutoskolaDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CislenikSkupinaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CislenikSkupinaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CislenikSkupinaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
