Public Class ciselniky

    Private Sub ciselniky_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)
    End Sub

    Private Sub zavriet_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zavriet_button.Click
        Me.Close()

    End Sub

    Private Sub tituly_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tituly_button.Click
    End Sub

    Private Sub st_prisl_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles st_prisl_button.Click


    End Sub

    Private Sub titul_za_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles titul_za_button.Click

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ciselniky_splitter.Panel2.Paint

    End Sub

    Private Sub narodnost_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles narodnost_button.Click

    End Sub
End Class