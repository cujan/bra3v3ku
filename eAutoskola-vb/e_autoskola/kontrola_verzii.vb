Public Class kontrola_verzii

    Private Sub microsoft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles microsoft.Click
        Process.Start("http://www.microsoft.com/downloads/details.aspx?familyid=d9ae78d9-9dc6-4b38-9fa6-2c745a175aed&displaylang=en")

    End Sub

    Private Sub instaluj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles instaluj.Click
        Try
            Process.Start("AccessRuntime.exe")
        Catch
            MsgBox("Nepodarilo sa nájsť program AccessRuntime, pokúsime sa stiahnuť aplikáciu z internetu.")
            Process.Start("http://www.microsoft.com/downloads/details.aspx?familyid=d9ae78d9-9dc6-4b38-9fa6-2c745a175aed&displaylang=en")
        End Try

        hlavna_aplikacia.Close()
        Me.Close()

    End Sub

    Private Sub zavriet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zavriet.Click
        hlavna_aplikacia.Close()
        Me.Close()
    End Sub
End Class