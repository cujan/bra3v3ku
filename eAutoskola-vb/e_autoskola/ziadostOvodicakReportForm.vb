Public Class ziadostOvodicakReportForm

    Private Sub ziadostOvodicakReportForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'eAutoskolaDBDataSet.prihlaska' table. You can move, or remove it, as needed.
        Me.prihlaskaTableAdapter.Fill(Me.eAutoskolaDBDataSet.prihlaska, hlavna_aplikacia.idStudent)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim file As String
        '' Cesta k stranam 2 az 4 z ziadosti o vodicak
        file = CurDir() & "\Report2.pdf"
        'MsgBox(file)
        Process.Start(file)
    End Sub
End Class