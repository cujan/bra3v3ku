<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrihlaskaReportForm
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.eAutoskolaDBDataSet = New e_autoskola.eAutoskolaDBDataSet()
        Me.prihlaskaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.prihlaskaTableAdapter = New e_autoskola.eAutoskolaDBDataSetTableAdapters.prihlaskaTableAdapter()
        CType(Me.eAutoskolaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prihlaskaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "prihlaskaReport"
        ReportDataSource1.Value = Me.prihlaskaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "e_autoskola.prihlaskaReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(28, 26)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(713, 430)
        Me.ReportViewer1.TabIndex = 0
        '
        'eAutoskolaDBDataSet
        '
        Me.eAutoskolaDBDataSet.DataSetName = "eAutoskolaDBDataSet"
        Me.eAutoskolaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'prihlaskaBindingSource
        '
        Me.prihlaskaBindingSource.DataMember = "prihlaska"
        Me.prihlaskaBindingSource.DataSource = Me.eAutoskolaDBDataSet
        '
        'prihlaskaTableAdapter
        '
        Me.prihlaskaTableAdapter.ClearBeforeFill = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 526)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form3"
        Me.Text = "Report - Prihláška"
        CType(Me.eAutoskolaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prihlaskaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents prihlaskaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents eAutoskolaDBDataSet As e_autoskola.eAutoskolaDBDataSet
    Friend WithEvents prihlaskaTableAdapter As e_autoskola.eAutoskolaDBDataSetTableAdapters.prihlaskaTableAdapter
End Class
