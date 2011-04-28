Public Class studentDetail

    Private Sub studentDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EAutoskolaDBDataSet.studentPrehlad' table. You can move, or remove it, as needed.
        Dim id As Integer = studentPrehlad.Label2.Text
        Me.StudentPrehladTableAdapter.FillBy_id(Me.EAutoskolaDBDataSet.studentPrehlad, id)

    End Sub
End Class