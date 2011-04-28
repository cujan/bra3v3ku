Public Class studentPrehlad

    Private Sub studentPrehlad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EAutoskolaDBDataSet.studentPrehlad' table. You can move, or remove it, as needed.
        Me.StudentPrehladTableAdapter.Fill(Me.EAutoskolaDBDataSet.studentPrehlad)

        Me.StudentPrehladDataGridView.CurrentCell = Nothing
    End Sub

    Private Sub StudentPrehladDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles StudentPrehladDataGridView.CellClick
        Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentPrehladBindingSource, "id", True))
        Label2.Text = Label1.Text
        Label1.DataBindings.Clear()
    End Sub

   
    Private Sub StudentPrehladDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles StudentPrehladDataGridView.CellContentClick

    End Sub

    Private Sub StudentPrehladDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles StudentPrehladDataGridView.CellDoubleClick
        studentDetail.Show()
    End Sub
End Class