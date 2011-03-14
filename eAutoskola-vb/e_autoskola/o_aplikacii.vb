Public Class o_aplikacii

    Private Sub o_aplikacii_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)
        Me.verzia.Text = hlavna_aplikacia.versionLabel.Text

    End Sub

    Private Sub zavriet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zavriet.Click
        Me.Close()

    End Sub
End Class