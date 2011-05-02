Public Class vseobecne_udaje

    Private Sub Vseobecne_udajeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vseobecne_udajeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VseobecneUdajeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VseobecneUdajeDataset)





    End Sub

    Private Sub vseobecne_udaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EAutoskolaDBDataSet.vseobecneUdaje' table. You can move, or remove it, as needed.
        Me.VseobecneUdajeTableAdapter1.Fill(Me.EAutoskolaDBDataSet.vseobecneUdaje)
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

        'nacitanie udajov pre zaskrtavacie policka skupin PRI NAHRANI FORMULARA

        If ATextBox.Text = 1 Then ACheckBox.Checked = True
        If A1TextBox.Text = 1 Then A1CheckBox.Checked = True
        If BTextBox.Text = 1 Then BCheckBox.Checked = True
        If B1TextBox.Text = 1 Then B1CheckBox.Checked = True
        If CTextBox.Text = 1 Then CCheckBox.Checked = True
        If DTextBox.Text = 1 Then DCheckBox.Checked = True
        If BETextBox.Text = 1 Then BECheckBox.Checked = True
        If CETextBox.Text = 1 Then CECheckBox.Checked = True
        If DETextBox.Text = 1 Then DECheckBox.Checked = True
        If AMTextBox.Text = 1 Then AMCheckBox.Checked = True
        If TTextBox.Text = 1 Then TCheckBox.Checked = True




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

        'ulozenie udajov do DB
        Dim con As New OleDbConnection(pripojovaci_retazec)
        Dim com As New OleDbCommand("UPDATE    vseobecneUdaje SET nazovOrganizacie = @nazovOrganizacie, ulica = @ulica, ulicaCislo = @ulicaCislo, mesto = @mesto, psc = @psc, ico = @ico, dic = @dic, telefon = @telefon, mobil = @mobil, email = @email, www = @www, A = @A, A1 = @A1, AM = @AM, B = @B, B1 = @B1, BE = @BE, C = @C, CE = @CE, D = @D, DE = @DE, T = @T WHERE     (id = 1)", con)

        With com.Parameters
            .AddWithValue("nazovOrganizacie", NazovOrganizacieTextBox.Text)
            .AddWithValue("ulica", UlicaTextBox.Text)
            .AddWithValue("ulicaCislo", UlicaCisloTextBox.Text)
            .AddWithValue("mesto", MestoTextBox.Text)
            .AddWithValue("psc", PscTextBox.Text)
            .AddWithValue("ico", IcoTextBox.Text)
            .AddWithValue("dic", DicTextBox.Text)
            .AddWithValue("telefon", TelefonTextBox.Text)
            .AddWithValue("mobil", MobilTextBox.Text)
            .AddWithValue("email", EmailTextBox.Text)
            .AddWithValue("Www", WwwTextBox.Text)
            .AddWithValue("A", ATextBox.Text)
            .AddWithValue("A1", A1TextBox.Text)
            .AddWithValue("AM", AMTextBox.Text)
            .AddWithValue("B", BTextBox.Text)
            .AddWithValue("B1", B1TextBox.Text)
            .AddWithValue("BE", BETextBox.Text)
            .AddWithValue("C", CTextBox.Text)
            .AddWithValue("CE", CETextBox.Text)
            .AddWithValue("D", DTextBox.Text)
            .AddWithValue("DE", DETextBox.Text)
            .AddWithValue("T", TTextBox.Text)
        End With

        con.Open()
        com.ExecuteNonQuery()
        con.Close()


    End Sub

    Private Sub koniecButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles koniecButton.Click

        Me.Close()
    End Sub

    Private Sub EmailLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ACheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACheckBox.CheckedChanged
        If ACheckBox.Checked Then
            ATextBox.Text = 1
        Else
            ATextBox.Text = 0
        End If
    End Sub

    Private Sub A1CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1CheckBox.CheckedChanged
        If A1CheckBox.Checked Then
            A1TextBox.Text = 1
        Else
            A1TextBox.Text = 0
        End If
    End Sub

    Private Sub BCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCheckBox.CheckedChanged
        If BCheckBox.Checked Then
            BTextBox.Text = 1
        Else
            BTextBox.Text = 0
        End If
    End Sub

    Private Sub B1CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1CheckBox.CheckedChanged
        If B1CheckBox.Checked Then
            B1TextBox.Text = 1
        Else
            B1TextBox.Text = 0
        End If
    End Sub

    Private Sub CCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CCheckBox.CheckedChanged
        If CCheckBox.Checked Then
            CTextBox.Text = 1
        Else
            CTextBox.Text = 0
        End If
    End Sub

    Private Sub DCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DCheckBox.CheckedChanged
        If DCheckBox.Checked Then
            DTextBox.Text = 1
        Else
            DTextBox.Text = 0
        End If
    End Sub

    Private Sub BECheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BECheckBox.CheckedChanged
        If BECheckBox.Checked Then
            BETextBox.Text = 1
        Else
            BETextBox.Text = 0
        End If
    End Sub

    Private Sub CECheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CECheckBox.CheckedChanged
        If CECheckBox.Checked Then
            CETextBox.Text = 1
        Else
            CETextBox.Text = 0
        End If
    End Sub

    Private Sub DECheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DECheckBox.CheckedChanged
        If DECheckBox.Checked Then
            DETextBox.Text = 1
        Else
            DETextBox.Text = 0
        End If
    End Sub

    Private Sub AMCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AMCheckBox.CheckedChanged
        If AMCheckBox.Checked Then
            AMTextBox.Text = 1
        Else
            AMTextBox.Text = 0
        End If
    End Sub

    Private Sub TCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TCheckBox.CheckedChanged
        If TCheckBox.Checked Then
            TTextBox.Text = 1
        Else
            TTextBox.Text = 0
        End If
    End Sub
End Class