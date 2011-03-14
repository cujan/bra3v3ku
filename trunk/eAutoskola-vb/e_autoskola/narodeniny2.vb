Public Class narodeniny2

    Private Sub narodeniny2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Narodeniny_DataSet.clenovia' table. You can move, or remove it, as needed.
        Me.ClenoviaTableAdapter.Fill(Me.Narodeniny_DataSet.clenovia)


    End Sub
End Class