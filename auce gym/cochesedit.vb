Imports System.Data.OleDb

Public Class cochesedit

    

    Private Sub cochesedit_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged, TextBox1.TextChanged, MyBase.TextChanged
        Try
            Dim con As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & "C:\Users\ahmad\Desktop\coaches.mdb;Jet OLEDB:Database Password=janitani2;")
            con.Open()
            Dim myadapter As New OleDb.OleDbDataAdapter("select * from coaches where FullName like'" + TextBox1.Text + "%' and PhoneNb like'" + TextBox2.Text + "%' and Active like'" + ComboBox1.Text + "%'", con)
            Dim ds As New DataSet
            myadapter.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        Try
            Dim s As String = TextBox1.Text
            TextBox1.Clear()
            TextBox1.Text = s
        Catch ex As Exception

        End Try
       

    End Sub

    Private Sub cochesedit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CoachesDataSet.coaches' table. You can move, or remove it, as needed.
        Me.CoachesTableAdapter.Fill(Me.CoachesDataSet.coaches)


    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Try
            coachesupdate.TextBox1.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            coachesupdate.TextBox2.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            coachesupdate.TextBox3.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
            coachesupdate.DateTimePicker1.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString
            coachesupdate.TextBox4.Text = DataGridView1.SelectedRows(0).Cells(5).Value.ToString
            coachesupdate.ComboBox1.Text = DataGridView1.SelectedRows(0).Cells(6).Value.ToString
            coachesupdate.TextBox5.Text = DataGridView1.SelectedRows(0).Cells(7).Value.ToString
            coachesupdate.TextBox6.Text = DataGridView1.SelectedRows(0).Cells(8).Value.ToString
            coachesupdate.TextBox7.Text = DataGridView1.SelectedRows(0).Cells(9).Value.ToString
            coachesupdate.TextBox8.Text = DataGridView1.SelectedRows(0).Cells(10).Value.ToString
            coachesupdate.TextBox9.Text = DataGridView1.SelectedRows(0).Cells(11).Value.ToString
            coachesupdate.TextBox10.Text = DataGridView1.SelectedRows(0).Cells(12).Value.ToString
            coachesupdate.ComboBox2.Text = DataGridView1.SelectedRows(0).Cells(13).Value.ToString
            coachesupdate.TextBox11.Text = DataGridView1.SelectedRows(0).Cells(14).Value.ToString
            coachesupdate.ComboBox3.Text = DataGridView1.SelectedRows(0).Cells(15).Value.ToString
            coachesupdate.TextBox12.Text = DataGridView1.SelectedRows(0).Cells(16).Value.ToString
            coachesupdate.ComboBox4.Text = DataGridView1.SelectedRows(0).Cells(17).Value.ToString
            coachesupdate.TextBox13.Text = DataGridView1.SelectedRows(0).Cells(18).Value.ToString
            coachesupdate.TextBox14.Text = DataGridView1.SelectedRows(0).Cells(19).Value.ToString
            coachesupdate.Label25.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
            coachesupdate.Label27.Text = DataGridView1.SelectedRows(0).Cells(20).Value.ToString
            coachesupdate.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub
End Class