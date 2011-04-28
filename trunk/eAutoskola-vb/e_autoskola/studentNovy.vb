Public Class studentNovy

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EAutoskolaDBDataSet.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.EAutoskolaDBDataSet.student)
        'TODO: This line of code loads data into the 'EAutoskolaDBDataSet.osoba' table. You can move, or remove it, as needed.
        Me.OsobaTableAdapter.Fill(Me.EAutoskolaDBDataSet.osoba)
        'TODO: This line of code loads data into the 'EAutoskolaDBDataSet.osoba' table. You can move, or remove it, as needed.


    End Sub

    Private Sub OsobaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vlozStudenta.Click

        Dim con As New OleDbConnection(pripojovaci_retazec)

        'vlozenie udajov o studentovi do tabulky osoba
        Dim com As New OleDbCommand("INSERT INTO osoba (titulPred, priezvisko, rodnePriezvisko, meno, titulZa, datumNarodenia, rodneCislo, miestoNarodenia, ulica, ulicaCislo, mesto, psc, telefon, mobil, email, cisloOp, cisloVp) VALUES   (@titulPred, @priezvisko, @rodnePriezvisko, @meno, @titulZa, @datumNarodenia, @rodneCislo, @miestoNarodenia, @ulica, @ulicaCislo, @mesto, @psc, @telefon, @mobil, @email, @cisloOp, @cisloVp)", con)

        With com.Parameters
            .AddWithValue("titulPred", TitulPredTextBox.Text)
            .AddWithValue("priezvisko", PriezviskoTextBox.Text)
            .AddWithValue("rodnePriezvisko", RodnePriezviskoTextBox.Text)
            .AddWithValue("meno", MenoTextBox.Text)
            .AddWithValue("titulZa", TitulZaTextBox.Text)
            .AddWithValue("datumNarodenia", DatumNarodeniaTextBox.Text)
            .AddWithValue("rodneCislo", RodneCisloTextBox.Text)
            .AddWithValue("miestoNarodenia", MiestoNarodeniaTextBox.Text)
            .AddWithValue("ulica", UlicaTextBox.Text)
            .AddWithValue("ulicaCislo", UlicaCisloTextBox.Text)
            .AddWithValue("mesto", MestoTextBox.Text)
            .AddWithValue("psc", PscTextBox.Text)
            .AddWithValue("telefon", TelefonTextBox.Text)
            .AddWithValue("mobil", MobilTextBox.Text)
            .AddWithValue("email", EmailTextBox.Text)
            .AddWithValue("cisloOp", CisloOpTextBox.Text)
            .AddWithValue("cisloVp", CisloVpTextBox.Text)
        End With

        con.Open()
        com.ExecuteNonQuery()
        con.Close()


        'vlozenie zaznamu o osobe ze je student, do tabulky student

        'zistenie id v osoba podla rodneho cisla

        Dim idcko As Integer
        Dim com1 As New OleDbCommand("SELECT id FROM osoba where rodneCislo = @rodneCislo", con)
        com1.Parameters.AddWithValue("rodneCislo", RodneCisloTextBox.Text)
        con.Open()
        idcko = com1.ExecuteScalar()
        con.Close()

        MsgBox(idcko)
        'vlozenie id do tabulky student

        Dim com2 As New OleDbCommand("INSERT INTO student (id) VALUES (@idcko)", con)
        com2.Parameters.AddWithValue("idcko", idcko)
        con.Open()
        com2.ExecuteNonQuery()
        con.Close()

        'refresh tabulku osob
        Me.OsobaTableAdapter.Fill(Me.EAutoskolaDBDataSet.osoba)
        'refresh tabulka student
        Me.StudentTableAdapter.Fill(Me.EAutoskolaDBDataSet.student)
    End Sub

    Private Sub OsobaBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OsobaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OsobaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EAutoskolaDBDataSet)

    End Sub
End Class