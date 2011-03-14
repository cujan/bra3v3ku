Public Class varovanie2

    Private Sub zavriet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zavriet.Click
        Me.Close()
        hlavna_aplikacia.Show()


    End Sub

    Private Sub zaregistrovat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zaregistrovat.Click
        registracia_aplikacie.Show()
        registracia_aplikacie.BringToFront()
        hlavna_aplikacia.Show()
        Me.Close()
    End Sub
End Class