Imports System.IO
Public Class zaloha_databazy

    Private Sub obnova_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles obnova.CheckedChanged
        zaloha_label.Enabled = False
        zalohuj.Enabled = False
        poznamka.Enabled = False

        obnov.Enabled = True
        obnova_label.Enabled = True
        obnova_label2.Enabled = True
        obnov_listbox.Enabled = True
        obnova_nadpis_label.Enabled = True
        vymaz_zalohu.Enabled = True
        poznamka_obnova.Visible = False

        obnov_listbox.Items.Clear()
        Dim cDir As String
        cDir = CurDir()
        Dim fileEntries As String()
        Try
            fileEntries = Directory.GetFiles(cDir & "\backup", "*.accdb-*")

            Dim fileName As String
            Dim tempFile As String
            For Each fileName In fileEntries
                tempFile = fileName.Remove(0, (cDir & "\backup").Length + 1)
                obnov_listbox.Items.Add(tempFile)

            Next fileName
        Catch ex As Exception
            MsgBox("Adresár so zálohami nenájdený. Možná príčina - zatial ste nerobili žiadne zálohy. Prosím spravte zálohu databázy.")
        End Try


    End Sub

    Private Sub zaloha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zaloha.CheckedChanged
        zaloha_label.Enabled = True
        zalohuj.Enabled = True
        poznamka.Enabled = True

        obnov.Enabled = False
        obnova_label.Enabled = False
        obnova_label2.Enabled = False
        obnov_listbox.Enabled = False
        obnova_nadpis_label.Enabled = False
        poznamka.Visible = False
        vymaz_zalohu.Enabled = False



    End Sub

    Private Sub zalohuj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zalohuj.Click
        Dim cDir As String
        Dim source As String
        Dim destination As String
        Dim now As String
        cDir = CurDir()
        now = Format(DateTime.Now, "dd-MM-yyyy--HH-mm-ss")

        source = cDir & "\spz_evidencia.accdb"
        destination = cDir & "\backup\spz_evidencia.accdb-" & now


        'poznamka.Text = source & "     " & destination

        Try
            If My.Computer.FileSystem.DirectoryExists(cDir & "\backup") Then
                My.Computer.FileSystem.CopyFile(source, destination)
                poznamka.Visible = True
                poznamka.Text = "Záloha databázy úspešne vytvorená."

            Else
                My.Computer.FileSystem.CreateDirectory(cDir & "\backup")
                My.Computer.FileSystem.CopyFile(source, destination)
                poznamka.Visible = True
                poznamka.Text = "Záloha databázy úspešne vytvorená."

            End If
        Catch ex As Exception
            MsgBox("Nepodarilo sa zálohovať databázu.")
        End Try

    End Sub

    Private Sub zaloha_databazy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Me.TopLevel = False
        hlavna_aplikacia.hlavny_splitter.Panel2.Controls.Add(Me)


        zaloha_label.Enabled = True
        zalohuj.Enabled = True
        poznamka.Enabled = True

        obnov.Enabled = False
        obnova_label.Enabled = False
        obnova_label2.Enabled = False
        obnov_listbox.Enabled = False
        obnova_nadpis_label.Enabled = False
        vymaz_zalohu.Enabled = False

    End Sub

    Private Sub obnov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles obnov.Click
        Dim cDir As String
        Dim source As String
        Dim destination As String

        cDir = CurDir()


        If Not obnov_listbox.SelectedIndex = -1 Then

            source = cDir & "\backup\" & obnov_listbox.SelectedItem
            destination = cDir & "\spz_evidencia.accdb"

            'poznamka.Text = source & "     " & destination

            Try
                My.Computer.FileSystem.CopyFile(source, destination, True)
                poznamka_obnova.Visible = True
                poznamka_obnova.Text = "Obnova databázy úspešná."
            Catch ex As Exception
                MsgBox("Nepodarilo sa spraviť obnovu databázy.")

            End Try

        Else
            MsgBox("Pre obnovu musíte označiť položku zo zoznamu záloh databázy.")
        End If



    End Sub

    Private Sub vymaz_zalohu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vymaz_zalohu.Click
        Dim cDir As String
        Dim source As String


        cDir = CurDir()


        If Not obnov_listbox.SelectedIndex = -1 Then

            source = cDir & "\backup\" & obnov_listbox.SelectedItem


            'poznamka.Text = source & "     " & destination

            Try
                My.Computer.FileSystem.DeleteFile(source)
                poznamka_obnova.Visible = True
                poznamka_obnova.Text = "Vymazanie zálohy databázy úspešné."
            Catch ex As Exception
                MsgBox("Nepodarilo sa vymazať zálohu databázy.")

            End Try

        Else
            MsgBox("Pre vymazanie musíte označiť položku zo zoznamu záloh databázy.")
        End If

        obnov_listbox.Items.Clear()

        Dim fileEntries As String()
        Try
            fileEntries = Directory.GetFiles(cDir & "\backup", "*.accdb-*")

            Dim fileName As String
            Dim tempFile As String
            For Each fileName In fileEntries
                tempFile = fileName.Remove(0, (cDir & "\backup").Length + 1)
                obnov_listbox.Items.Add(tempFile)

            Next fileName
        Catch ex As Exception
            MsgBox("Adresár so zálohami nenájdený.")
        End Try


    End Sub

    Private Sub zavriet_kartu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zavriet_kartu.Click
        Me.Close()

    End Sub
End Class