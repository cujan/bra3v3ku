<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ziadostOvodicakReportForm
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
        Me.prihlaskaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.eAutoskolaDBDataSet = New e_autoskola.eAutoskolaDBDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.prihlaskaTableAdapter = New e_autoskola.eAutoskolaDBDataSetTableAdapters.prihlaskaTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.prihlaskaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eAutoskolaDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'prihlaskaBindingSource
        '
        Me.prihlaskaBindingSource.DataMember = "prihlaska"
        Me.prihlaskaBindingSource.DataSource = Me.eAutoskolaDBDataSet
        '
        'eAutoskolaDBDataSet
        '
        Me.eAutoskolaDBDataSet.DataSetName = "eAutoskolaDBDataSet"
        Me.eAutoskolaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "ziadostOvodicak"
        ReportDataSource1.Value = Me.prihlaskaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "e_autoskola.ziadostOvodicakReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 30)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(934, 670)
        Me.ReportViewer1.TabIndex = 0
        '
        'prihlaskaTableAdapter
        '
        Me.prihlaskaTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(229, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Zobraziť strany 2 až 4"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ziadostOvodicakReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 700)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ziadostOvodicakReportForm"
        Me.Text = "Žiadosť o vodičské oprávnenie - Report"
        CType(Me.prihlaskaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eAutoskolaDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents prihlaskaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents eAutoskolaDBDataSet As e_autoskola.eAutoskolaDBDataSet
    Friend WithEvents prihlaskaTableAdapter As e_autoskola.eAutoskolaDBDataSetTableAdapters.prihlaskaTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
