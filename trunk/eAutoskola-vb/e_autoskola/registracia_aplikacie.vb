Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.FileIO
Imports System.IO
Public Class registracia_aplikacie

    Private Sub Vseobecne_udajeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vseobecne_udajeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Vseobecne_udajeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Spz_vseobecne_udaje)

    End Sub

    Private Sub registracia_aplikacie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Spz_vseobecne_udaje.vseobecne_udaje' table. You can move, or remove it, as needed.
        Me.Vseobecne_udajeTableAdapter.Fill(Me.Spz_vseobecne_udaje.vseobecne_udaje)
        Me.ica.Text = hlavna_aplikacia.ica_hodnota.Text
        Me.reg_cislo.Text = hlavna_aplikacia.Reg_cisloTextBox.Text

        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)

    End Sub

    Private Sub zavriet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zavriet.Click
        Me.Close()

    End Sub

    Private Sub registruj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles registruj.Click
        Dim reg As ULong
        'reg = Conversions.ToULong(Reg_cisloTextBox.Text)
        Try
            reg = Conversions.ToULong(reg_cislo.Text)
        Catch
        End Try


        Dim systemDir As String
        Dim plus As ULong
        Dim krat As ULong
        Dim diskSize As ULong



        systemDir = System.Environment.SystemDirectory

        If File.Exists(systemDir & "\5t7ir4h2") And File.Exists(systemDir & "\2t4yd75i8") Then


            diskSize = My.Computer.FileSystem.GetDriveInfo("C:\").TotalSize
            plus = My.Computer.FileSystem.ReadAllText(systemDir & "\5t7ir4h2")
            krat = My.Computer.FileSystem.ReadAllText(systemDir & "\2t4yd75i8")
        Else
            Me.Hide()
            varovanie1.Show()
        End If

        Dim kontrola As ULong


        Try
            kontrola = ((reg + 2) / krat) - plus

        Catch

        End Try

        If Not (kontrola = diskSize) Then
            hlavna_aplikacia.sprava_clenov_button.Visible = False
            hlavna_aplikacia.sprava_zdruzeni_button.Visible = False
            hlavna_aplikacia.nastavenia_button.Visible = False
            varovanie2.Show()
            varovanie2.BringToFront()
            hlavna_aplikacia.Hide()
            hlavna_aplikacia.nastavenia_splitter.Panel2Collapsed = True
            hlavna_aplikacia.nastavenia_button.Text = "v"


        Else
            hlavna_aplikacia.sprava_clenov_button.Visible = True
            hlavna_aplikacia.sprava_zdruzeni_button.Visible = True
            hlavna_aplikacia.nastavenia_button.Visible = True
        End If

        Me.Close()

        If Not hlavna_aplikacia.nastavenia_button.Visible Then
            hlavna_aplikacia.poznamka2.Visible = True
            hlavna_aplikacia.registrovat.Visible = True
        Else
            hlavna_aplikacia.poznamka2.Visible = False
            hlavna_aplikacia.registrovat.Visible = False

        End If






        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\spz_evidencia.accdb")
        con.Open()

        Dim com As New OleDb.OleDbCommand("UPDATE vseobecne_udaje SET reg_cislo ='" & reg & "' WHERE id =1", con)

        com.ExecuteNonQuery()
        con.Close()

        hlavna_aplikacia.Vseobecne_udajeTableAdapter.Fill(hlavna_aplikacia.Spz_vseobecne_udaje.vseobecne_udaje)

    End Sub

    Private Sub reg_cislo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reg_cislo.TextChanged

    End Sub

    Private Sub kontakt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kontakt.Click
        o_aplikacii.Show()
        o_aplikacii.BringToFront()

    End Sub
End Class