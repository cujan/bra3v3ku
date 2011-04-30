Imports System.Windows.Forms
Imports Microsoft.Win32
Imports Microsoft.VisualBasic.FileIO
Imports System.IO
Imports Microsoft.VisualBasic.CompilerServices

Public Class hlavna_aplikacia
    Private bInstalled As Boolean



    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*" 

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub sprava_clenov_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sprava_clenov_button.Click
        Dim sprava_clenov_splitter_position As New System.Drawing.Point
        Dim sprava_zdruzeni_splitter_position As New System.Drawing.Point
        Dim tl_zostavy_splitter_position As New System.Drawing.Point

        If sprava_clenov_button.Text = "v" Then
            sprava_clenov_splitter.Panel2Collapsed = False
            sprava_clenov_button.Text = "^"
            sprava_clenov_splitter_position.Y = sprava_clenov_splitter.Location.Y + 100
            sprava_clenov_splitter_position.X = sprava_clenov_splitter.Location.X
            sprava_zdruzeni_splitter.Location = sprava_clenov_splitter_position

            If sprava_zdruzeni_splitter.Panel2Collapsed = False Then

                sprava_zdruzeni_splitter_position.Y = sprava_zdruzeni_splitter.Location.Y + 100
            Else
                sprava_zdruzeni_splitter_position.Y = sprava_zdruzeni_splitter.Location.Y + 34
            End If

            sprava_zdruzeni_splitter_position.X = sprava_zdruzeni_splitter.Location.X
            tl_zostavy_splitter.Location = sprava_zdruzeni_splitter_position

            If tl_zostavy_splitter.Panel2Collapsed = False Then
                tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 265

            Else
                tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 34

            End If
            tl_zostavy_splitter_position.X = tl_zostavy_splitter.Location.X
            nastavenia_splitter.Location = tl_zostavy_splitter_position

        Else
            sprava_clenov_splitter.Panel2Collapsed = True
            sprava_clenov_button.Text = "v"
            sprava_clenov_splitter_position.Y = sprava_clenov_splitter.Location.Y + 34
            sprava_clenov_splitter_position.X = sprava_clenov_splitter.Location.X
            sprava_zdruzeni_splitter.Location = sprava_clenov_splitter_position

            If sprava_zdruzeni_splitter.Panel2Collapsed = False Then

                sprava_zdruzeni_splitter_position.Y = sprava_zdruzeni_splitter.Location.Y + 100
            Else
                sprava_zdruzeni_splitter_position.Y = sprava_zdruzeni_splitter.Location.Y + 34
            End If

            sprava_zdruzeni_splitter_position.X = sprava_zdruzeni_splitter.Location.X
            tl_zostavy_splitter.Location = sprava_zdruzeni_splitter_position

            If tl_zostavy_splitter.Panel2Collapsed = False Then
                tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 265

            Else
                tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 34

            End If
            tl_zostavy_splitter_position.X = tl_zostavy_splitter.Location.X
            nastavenia_splitter.Location = tl_zostavy_splitter_position

        End If

    End Sub


    Private Sub novy_clen_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles novy_clen_button.Click
 

    End Sub

    Private Sub edituj_clena_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
 

    End Sub

    Private Sub karta_clena_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub prehlad_clenov_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prehlad_clenov_button.Click

    End Sub




    Private Sub sprava_zdruzeni_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sprava_zdruzeni_button.Click
        Dim sprava_zdruzeni_splitter_position As New System.Drawing.Point
        Dim tl_zostavy_splitter_position As New System.Drawing.Point
        If sprava_zdruzeni_button.Text = "v" Then
            sprava_zdruzeni_button.Text = "^"
            sprava_zdruzeni_splitter.Panel2Collapsed = False
            sprava_zdruzeni_splitter_position.Y = sprava_zdruzeni_splitter.Location.Y + 100
            sprava_zdruzeni_splitter_position.X = sprava_zdruzeni_splitter.Location.X
            tl_zostavy_splitter.Location = sprava_zdruzeni_splitter_position

            If tl_zostavy_splitter.Panel2Collapsed = False Then
                tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 265

            Else
                tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 34

            End If
            tl_zostavy_splitter_position.X = tl_zostavy_splitter.Location.X
            nastavenia_splitter.Location = tl_zostavy_splitter_position

        Else
            sprava_zdruzeni_button.Text = "v"
            sprava_zdruzeni_splitter.Panel2Collapsed = True

            sprava_zdruzeni_splitter_position.Y = sprava_zdruzeni_splitter.Location.Y + 34
            sprava_zdruzeni_splitter_position.X = sprava_zdruzeni_splitter.Location.X
            tl_zostavy_splitter.Location = sprava_zdruzeni_splitter_position

            If tl_zostavy_splitter.Panel2Collapsed = False Then
                tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 265

            Else
                tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 34

            End If
            tl_zostavy_splitter_position.X = tl_zostavy_splitter.Location.X
            nastavenia_splitter.Location = tl_zostavy_splitter_position

        End If

    End Sub

    Private Sub TitulyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitulyToolStripMenuItem.Click

    End Sub

    Private Sub ŠtátnaPríslušnosťToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ŠtátnaPríslušnosťToolStripMenuItem.Click

    End Sub

    Private Sub hlavna_aplikacia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VseobecneUdajeDataset.vseobecneUdaje' table. You can move, or remove it, as needed.
        Me.VseobecneUdajeTableAdapter.Fill(Me.VseobecneUdajeDataset.vseobecneUdaje)
        'TODO: This line of code loads data into the 'Spz_vseobecne_udaje.vseobecne_udaje' table. You can move, or remove it, as needed.

        Try
            'Dim oApp As Object = CreateObject("Access.Application")
            Dim oApp As Object = CreateObject("Microsoft.ACE.OLEDB.12.0")
            bInstalled = True
            ' Label2.Text = bInstalled.ToString
        Catch
            bInstalled = False
            'MessageBox.Show("Runtime Access 2007 nie je nainstalovany.", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If Not bInstalled Then
            'MessageBox.Show("Runtime Access 2007.", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Me.Visible = False
            Me.Hide()
            kontrola_verzii.Show()
            kontrola_verzii.BringToFront()
            'Else
            '    'Me.Visible = False
            '    Me.Hide()
            '    kontrola_verzii.Show()
            '    kontrola_verzii.BringToFront()
            '    'MessageBox.Show("Runtime Access 2007 nie je nainstalovany.", "Varovanie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If



        Dim mesiac As String
        Dim mesiac_string As String
        mesiac_string = ""

        mesiac = Date.Today.Month
        If mesiac = 1 Then
            mesiac_string = "Január"
        ElseIf mesiac = 2 Then
            mesiac_string = "Február"
        ElseIf mesiac = 3 Then
            mesiac_string = "Marec"
        ElseIf mesiac = 4 Then
            mesiac_string = "Apríl"
        ElseIf mesiac = 5 Then
            mesiac_string = "Máj"
        ElseIf mesiac = 6 Then
            mesiac_string = "Jún"
        ElseIf mesiac = 7 Then
            mesiac_string = "Júl"
        ElseIf mesiac = 8 Then
            mesiac_string = "August"
        ElseIf mesiac = 9 Then
            mesiac_string = "September"
        ElseIf mesiac = 10 Then
            mesiac_string = "Október"
        ElseIf mesiac = 11 Then
            mesiac_string = "November"
        ElseIf mesiac = 12 Then
            mesiac_string = "December"
        End If


        If (mesiac <= 9) And (mesiac >= 1) Then
            mesiac = "0" & mesiac

        End If
        'zaciatok = DateTime.Parse("1." & (mesiac.SelectedIndex + 1).ToString & ".1900")
        'koniec = DateTime.Parse("31." & (mesiac.SelectedIndex + 1).ToString & "." & rok.Text)
        ''''' NARODKY DOROBIT !!!!!!!!!!

        'narodky.clenoviaTableAdapter.Fill(narodky.narodeniny_DataSet.clenovia, mesiac)
        'Label2.Text = "V mesiaci " & mesiac_string & " má narodeniny " & narodky.clenoviaBindingSource.Count & " členov."

        'security


        Dim systemDir As String
        Dim plus As ULong
        Dim krat As ULong
        Dim diskSize As ULong
        Dim ica As ULong


        systemDir = System.Environment.SystemDirectory

        'If File.Exists(systemDir & "\5t7ir4h2") And File.Exists(systemDir & "\2t4yd75i8") Then


        '    diskSize = My.Computer.FileSystem.GetDriveInfo("C:\").TotalSize
        '    plus = My.Computer.FileSystem.ReadAllText(systemDir & "\5t7ir4h2")
        '    krat = My.Computer.FileSystem.ReadAllText(systemDir & "\2t4yd75i8")


        '    ica = diskSize + plus
        '    registracia_aplikacie.ica.Text = ica.ToString
        '    Me.ica_hodnota.Text = ica.ToString

        'Else
        '    Me.Hide()
        '    varovanie1.Show()
        'End If

        'Dim reg_cislo As ULong
        'Dim kontrola As ULong

        'try
        '    reg_cislo = Conversions.ToULong(Me.Reg_cisloTextBox.Text)
        'Catch
        'End Try


        'Try
        '    kontrola = ((reg_cislo + 2) / krat) - plus

        'Catch

        'End Try

        'docasne vypnutie kontroly registracie, zapnut !!!!!!!!!!!
        Dim kontrola As ULong = 1
        diskSize = 1

        If Not (kontrola = diskSize) Then
            Me.sprava_clenov_button.Visible = False
            Me.sprava_zdruzeni_button.Visible = False
            Me.nastavenia_button.Visible = False
            Me.Hide()
            varovanie2.Show()
            varovanie2.BringToFront()

        End If

        If Not nastavenia_button.Visible Then
            poznamka2.Visible = True
            registrovat.Visible = True
        Else
            poznamka2.Visible = False
            registrovat.Visible = False

        End If

    End Sub

    Private Sub TitulZaMenomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitulZaMenomToolStripMenuItem.Click

    End Sub




    Private Sub nastavenia_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nastavenia_button.Click
        If nastavenia_button.Text = "v" Then
            nastavenia_button.Text = "^"
            nastavenia_splitter.Panel2Collapsed = False
        Else
            nastavenia_button.Text = "v"
            nastavenia_splitter.Panel2Collapsed = True

        End If
    End Sub

    Private Sub hlavny_splitter_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles hlavny_splitter.Panel1.Paint

    End Sub

    Private Sub nastavenia_ciselniky_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nastavenia_ciselniky_button.Click
        ciselniky.Show()
        ciselniky.BringToFront()

    End Sub

    

    Private Sub upravit_udaje_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upravit_udaje_button.Click
        vseobecne_udaje.Show()
        vseobecne_udaje.BringToFront()

    End Sub


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Dim url As String
        url = Label1.Text
        If url.Contains("http") Or url.Contains("HTTP") Then
            url = url
        Else
            url = "http://" & url
        End If
        Shell("explorer.exe " & url)

    End Sub

    Private Sub hlavny_splitter_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles hlavny_splitter.Panel2.Paint

    End Sub

    Private Sub nastavenia_splitter_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles nastavenia_splitter.Panel1.Paint, tl_zostavy_splitter.Panel1.Paint

    End Sub

    Private Sub prehlad_zdruzeni_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prehlad_zdruzeni_button.Click


    End Sub

    Private Sub nove_zdruzenie_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nove_zdruzenie_button.Click


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub



    Private Sub tl_zostavy_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tl_zostavy_button.Click


        Dim tl_zostavy_splitter_position As New System.Drawing.Point
        If tl_zostavy_button.Text = "v" Then
            tl_zostavy_button.Text = "^"
            tl_zostavy_splitter.Panel2Collapsed = False
            tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 265
            tl_zostavy_splitter_position.X = tl_zostavy_splitter.Location.X
            nastavenia_splitter.Location = tl_zostavy_splitter_position

        Else
            tl_zostavy_button.Text = "v"
            tl_zostavy_splitter.Panel2Collapsed = True
            tl_zostavy_splitter_position.Y = tl_zostavy_splitter.Location.Y + 34
            tl_zostavy_splitter_position.X = tl_zostavy_splitter.Location.X

            nastavenia_splitter.Location = tl_zostavy_splitter_position

        End If

    End Sub



    Private Sub zoznam_clenov_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zoznam_clenov_button.Click


    End Sub

    Private Sub zoznam_zdruzeni_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zoznam_zdruzeni_button.Click


    End Sub

    Private Sub platnost_clenstva_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles platnost_clenstva_button.Click


    End Sub

    Private Sub kont_strelby_brok_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kont_strelby_brok_button.Click


    End Sub

    Private Sub kont_strelby_gula_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kont_strelby_gula_button.Click
 
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub narodeniny_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles narodeniny.Click



    End Sub

    Private Sub registracia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles registracia.Click
        registracia_aplikacie.Show()
        registracia_aplikacie.BringToFront()



    End Sub

    Private Sub registrovat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles registrovat.Click
 

    End Sub

    Private Sub o_aplikacii_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o_aplikacii_button.Click
        o_aplikacii.Show()
        o_aplikacii.BringToFront()

    End Sub




    Private Sub zoznam_clenov_podla_zdruzeni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zoznam_clenov_podla_zdruzeni.Click


    End Sub

    Private Sub zalohuj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zalohuj.Click
        zaloha_databazy.Show()
        zaloha_databazy.BringToFront()

    End Sub

    Private Sub VseobecneUdajeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.VseobecneUdajeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VseobecneUdajeDataset)

    End Sub

    Private Sub sprava_clenov_label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sprava_clenov_label.Click

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        studentNovy.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        studentPrehlad.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        kurzNovy.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        kurzPrehlad.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        PrihlaskaReportForm.Show()

    End Sub
End Class
