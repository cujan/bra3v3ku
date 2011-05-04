Public Class ciselnikSkupina

    Private Sub CislenikSkupinaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CislenikSkupinaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EAutoskolaDBDataSet)

    End Sub

    Private Sub ciselnikSkupina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
    End Sub

   

    Private Sub PridajButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CislenikSkupinaBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CislenikSkupinaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CislenikSkupinaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EAutoskolaDBDataSet)

    End Sub
End Class