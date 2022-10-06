Public Class editapplicants

    Private Sub editapplicants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Applicants1DataSet2.medical' table. You can move, or remove it, as needed.
        Me.MedicalTableAdapter.Fill(Me.Applicants1DataSet2.medical)
        'TODO: This line of code loads data into the 'Applicants1DataSet.medical' table. You can move, or remove it, as needed.
       
        Me.ApplicantsTableAdapter.Fill(Me.Applicants1DataSet1.applicants)
        DataGridView2.Visible = False
    End Sub
   
   
    
    Private Sub TextBox7_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox9.TextChanged, TextBox8.TextChanged, TextBox7.TextChanged
        Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "applicants1.mdb")
        con.Open()
        Dim myadapter As New OleDb.OleDbDataAdapter("select * from applicants where Name like'" + TextBox7.Text + "%' and lastName like'" + TextBox8.Text + "%' and ID like'" + TextBox9.Text + "%'", con)
        Dim ds As New DataSet
        myadapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
       
        Try
            ginfoupdate.TextBox1.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            ginfoupdate.TextBox2.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
            ginfoupdate.ComboBox1.Text = DataGridView1.SelectedRows(0).Cells(7).Value.ToString
            ginfoupdate.DateTimePicker1.Value = DataGridView1.SelectedRows(0).Cells(8).Value.ToString
            ginfoupdate.TextBox4.Text = DataGridView1.SelectedRows(0).Cells(9).Value.ToString
            ginfoupdate.ComboBox4.Text = DataGridView1.SelectedRows(0).Cells(10).Value.ToString
            ginfoupdate.ComboBox2.Text = DataGridView1.SelectedRows(0).Cells(11).Value.ToString
            ginfoupdate.TextBox6.Text = DataGridView1.SelectedRows(0).Cells(12).Value.ToString
            ginfoupdate.TextBox3.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            ginfoupdate.Label13.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
            ginfoupdate.TextBox5.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString
            ginfoupdate.TextBox10.Text = DataGridView1.SelectedRows(0).Cells(5).Value.ToString
            ginfoupdate.TextBox11.Text = DataGridView1.SelectedRows(0).Cells(6).Value.ToString
            Dim s As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells(0).Value.ToString)
            ginfoupdate.TextBox7.Text = DataGridView2.Rows(s - 1).Cells(1).Value.ToString
            ginfoupdate.TextBox8.Text = DataGridView2.Rows(s - 1).Cells(2).Value.ToString
            ginfoupdate.TextBox9.Text = DataGridView2.Rows(s - 1).Cells(3).Value.ToString
            ginfoupdate.TextBox12.Text = DataGridView2.Rows(s - 1).Cells(4).Value.ToString
            ginfoupdate.TextBox13.Text = DataGridView2.Rows(s - 1).Cells(5).Value.ToString
            ginfoupdate.TextBox14.Text = DataGridView2.Rows(s - 1).Cells(6).Value.ToString
            ginfoupdate.TextBox15.Text = DataGridView2.Rows(s - 1).Cells(7).Value.ToString
            ginfoupdate.Label23.Text = DataGridView2.Rows(s - 1).Cells(0).Value.ToString
            ginfoupdate.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
End Class