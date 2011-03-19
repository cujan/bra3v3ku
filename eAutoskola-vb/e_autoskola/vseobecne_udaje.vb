Public Class vseobecne_udaje

    Private Sub Vseobecne_udajeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vseobecne_udajeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VseobecneUdajeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VseobecneUdajeDataset)





    End Sub

    Private Sub vseobecne_udaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VseobecneUdajeDataset.vseobecneUdaje' table. You can move, or remove it, as needed.
        Me.VseobecneUdajeTableAdapter.Fill(Me.VseobecneUdajeDataset.vseobecneUdaje)
        'TODO: This line of code loads data into the 'Spz_vseobecne_udaje.vseobecne_udaje' table. You can move, or remove it, as needed.



        Me.NazovOrganizacieTextBox.ReadOnly = True
        Me.UlicaTextBox.ReadOnly = True
        Me.UlicaCisloTextBox.ReadOnly = True
        Me.MestoTextBox.ReadOnly = True
        Me.PscTextBox.ReadOnly = True
        Me.IcoTextBox.ReadOnly = True
        Me.DicTextBox.ReadOnly = True
        Me.TelefonTextBox.ReadOnly = True
        Me.MobilTextBox.ReadOnly = True
        Me.EmailTextBox.ReadOnly = True
        Me.WwwTextBox.ReadOnly = True

        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)
    End Sub

    Private Sub upravButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upravButton.Click
        Me.upravButton.Visible = False
        Me.ulozButton.Visible = True

        Me.NazovOrganizacieTextBox.ReadOnly = False
        Me.UlicaTextBox.ReadOnly = False
        Me.UlicaCisloTextBox.ReadOnly = False
        Me.MestoTextBox.ReadOnly = False
        Me.PscTextBox.ReadOnly = False
        Me.IcoTextBox.ReadOnly = False
        Me.DicTextBox.ReadOnly = False
        Me.TelefonTextBox.ReadOnly = False
        Me.MobilTextBox.ReadOnly = False
        Me.EmailTextBox.ReadOnly = False
        Me.WwwTextBox.ReadOnly = False


    End Sub

    Private Sub ulozButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ulozButton.Click
        Me.Validate()
        Me.VseobecneUdajeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VseobecneUdajeDataset)

        Me.upravButton.Visible = True
        Me.ulozButton.Visible = False


        Me.NazovOrganizacieTextBox.ReadOnly = True
        Me.UlicaTextBox.ReadOnly = True
        Me.UlicaCisloTextBox.ReadOnly = True
        Me.MestoTextBox.ReadOnly = True
        Me.PscTextBox.ReadOnly = True
        Me.IcoTextBox.ReadOnly = True
        Me.DicTextBox.ReadOnly = True
        Me.TelefonTextBox.ReadOnly = True
        Me.MobilTextBox.ReadOnly = True
        Me.EmailTextBox.ReadOnly = True
        Me.WwwTextBox.ReadOnly = True



    End Sub

    Private Sub koniecButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles koniecButton.Click

        Me.Close()
    End Sub

    Private Sub EmailLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class