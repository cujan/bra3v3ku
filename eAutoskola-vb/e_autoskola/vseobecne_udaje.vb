Public Class vseobecne_udaje

    Private Sub Vseobecne_udajeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vseobecne_udajeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Vseobecne_udajeBindingSource.EndEdit()


    End Sub

    Private Sub vseobecne_udaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Spz_vseobecne_udaje.vseobecne_udaje' table. You can move, or remove it, as needed.


        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)
    End Sub

    Private Sub upravButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upravButton.Click
        Me.Nazov_organizacieTextBox.ReadOnly = False
        Me.IcoTextBox.ReadOnly = False
        Me.DicTextBox.ReadOnly = False
        Me.UlicaTextBox.ReadOnly = False
        Me.MestoTextBox.ReadOnly = False
        Me.PscTextBox.ReadOnly = False
        Me.TelefonTextBox.ReadOnly = False
        Me.FaxTextBox.ReadOnly = False
        Me.EmailTextBox.ReadOnly = False
        Me.WebTextBox.ReadOnly = False
        Me.ulozButton.Visible = True
        Me.upravButton.Visible = False
    End Sub

    Private Sub ulozButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ulozButton.Click
        Me.Validate()
        Me.Vseobecne_udajeBindingSource.EndEdit()


        Me.upravButton.Visible = True
        Me.ulozButton.Visible = False

        Me.Nazov_organizacieTextBox.ReadOnly = True
        Me.IcoTextBox.ReadOnly = True
        Me.DicTextBox.ReadOnly = True
        Me.UlicaTextBox.ReadOnly = True
        Me.MestoTextBox.ReadOnly = True
        Me.PscTextBox.ReadOnly = True
        Me.TelefonTextBox.ReadOnly = True
        Me.FaxTextBox.ReadOnly = True
        Me.EmailTextBox.ReadOnly = True
        Me.WebTextBox.ReadOnly = True


    End Sub

    Private Sub koniecButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles koniecButton.Click

        Me.Close()
    End Sub

    Private Sub EmailLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class