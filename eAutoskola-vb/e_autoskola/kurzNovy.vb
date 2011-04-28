Public Class kurzNovy

    Private Sub KurzBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.KurzBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EAutoskolaDBDataSet)

    End Sub

    Private Sub kurzNovy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EAutoskolaDBDataSet.kurz' table. You can move, or remove it, as needed.
        Me.KurzTableAdapter.Fill(Me.EAutoskolaDBDataSet.kurz)
        'TODO: This line of code loads data into the 'EAutoskolaDBDataSet.kurz' table. You can move, or remove it, as needed.
        Me.KurzTableAdapter.Fill(Me.EAutoskolaDBDataSet.kurz)

    End Sub

    Private Sub KurzBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KurzBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.KurzBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EAutoskolaDBDataSet)

    End Sub

    Private Sub vlozKurz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vlozKurz.Click
        'vloyenie noveho kurzu

        Dim con As New OleDbConnection(pripojovaci_retazec)
        Dim com As New OleDbCommand("INSERT INTO kurz (zaciatokDatum, denVykonavania, hodinaVykonavania, skupiny, idInstruktor) VALUES     (@zaciatokDatum, @denVykonavania, @hodinaVykonavania, @skupiny, @idInstruktor)", con)
        With com.Parameters
            .AddWithValue("zaciatokDatum", ZaciatokDatumDateTimePicker.Value.Date)
            .AddWithValue("denVykonavania", DenVykonavaniaTextBox.Text)
            .AddWithValue("hodinaVykonavania", HodinaVykonavaniaTextBox.Text)
            .AddWithValue("skupiny", SkupinyTextBox.Text)
            .AddWithValue("idInstruktor", IdInstruktorTextBox.Text)
        End With

        con.Open()
        com.ExecuteNonQuery()
        con.Close()

        Me.KurzTableAdapter.Fill(Me.EAutoskolaDBDataSet.kurz)

    End Sub
End Class