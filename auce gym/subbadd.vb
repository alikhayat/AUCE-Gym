Public Class subbadd

    Private Sub subbadd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Applicants1DataSet4.medical' table. You can move, or remove it, as needed.
        Me.MedicalTableAdapter.Fill(Me.Applicants1DataSet4.medical)
        'TODO: This line of code loads data into the 'Applicants1DataSet3.applicants' table. You can move, or remove it, as needed.
        Me.ApplicantsTableAdapter.Fill(Me.Applicants1DataSet3.applicants)
        'TODO: This line of code loads data into the 'Applicants1DataSet2.medical' table. You can move, or remove it, as needed.
        editapplicants.MedicalTableAdapter.Fill(editapplicants.Applicants1DataSet2.medical)
        'TODO: This line of code loads data into the 'Applicants1DataSet.medical' table. You can move, or remove it, as needed.

        editapplicants.ApplicantsTableAdapter.Fill(editapplicants.Applicants1DataSet1.applicants)
        DataGridView1.Visible = False
    End Sub

    Private Sub DataGridView2_SelectionChanged(sender As Object, e As EventArgs) Handles dd.SelectionChanged
        Try
            assign.Label45.Text = dd.SelectedRows(0).Cells(0).Value.ToString
            assign.Label1.Text = dd.SelectedRows(0).Cells(1).Value.ToString
            assign.Label2.Text = dd.SelectedRows(0).Cells(2).Value.ToString
            assign.Label3.Text = dd.SelectedRows(0).Cells(3).Value.ToString
            assign.Label4.Text = dd.SelectedRows(0).Cells(4).Value.ToString
            assign.Label5.Text = dd.SelectedRows(0).Cells(5).Value.ToString
            assign.Label6.Text = dd.SelectedRows(0).Cells(6).Value.ToString
            assign.Label7.Text = dd.SelectedRows(0).Cells(7).Value.ToString
            assign.Label8.Text = dd.SelectedRows(0).Cells(8).Value.ToString
            assign.Label9.Text = dd.SelectedRows(0).Cells(9).Value.ToString
            assign.Label16.Text = dd.SelectedRows(0).Cells(10).Value.ToString
            assign.Label17.Text = dd.SelectedRows(0).Cells(11).Value.ToString
            assign.Label18.Text = dd.SelectedRows(0).Cells(12).Value.ToString

            Dim s As Integer = Convert.ToInt32(dd.SelectedRows(0).Cells(0).Value.ToString)
            assign.Label36.Text = DataGridView1.Rows(s - 1).Cells(1).Value.ToString
            assign.Label37.Text = DataGridView1.Rows(s - 1).Cells(2).Value.ToString
            assign.Label38.Text = DataGridView1.Rows(s - 1).Cells(3).Value.ToString
            assign.Label39.Text = DataGridView1.Rows(s - 1).Cells(4).Value.ToString
            assign.Label40.Text = DataGridView1.Rows(s - 1).Cells(5).Value.ToString
            assign.Label41.Text = DataGridView1.Rows(s - 1).Cells(6).Value.ToString
            assign.Label42.Text = DataGridView1.Rows(s - 1).Cells(7).Value.ToString
            assign.Label27.Text = DataGridView1.Rows(s - 1).Cells(0).Value.ToString

            assign.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged, TextBox6.TextChanged, TextBox5.TextChanged
        Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "applicants1.mdb;Jet OLEDB:Database Password=janitani2;")
        con.Open()
        Dim myadapter As New OleDb.OleDbDataAdapter("select * from applicants where Name like'" + TextBox5.Text + "%' and lastName like'" + TextBox6.Text + "%' and ID like'" + TextBox7.Text + "%'", con)
        Dim ds As New DataSet
        myadapter.Fill(ds)
        dd.DataSource = ds.Tables(0)
        con.Close()
    End Sub
End Class