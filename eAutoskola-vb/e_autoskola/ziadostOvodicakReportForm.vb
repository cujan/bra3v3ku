Public Class ziadostOvodicakReportForm

    Private Sub ziadostOvodicakReportForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'eAutoskolaDBDataSet.prihlaska' table. You can move, or remove it, as needed.
        Me.prihlaskaTableAdapter.Fill(Me.eAutoskolaDBDataSet.prihlaska, hlavna_aplikacia.idStudent)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class