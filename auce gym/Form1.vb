Imports System.Data.OleDb

Public Class Form1
    Public user As String = "admin"
   


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'VarrDataSet1.varr' table. You can move, or remove it, as needed.
        Me.VarrTableAdapter.Fill(Me.VarrDataSet1.varr)

        DataGridView1.Visible = False



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pass As String = DataGridView1.Rows(0).Cells(8).Value.ToString
        Dim pass1 As String = DataGridView1.Rows(0).Cells(9).Value.ToString
        Dim pass2 As String = DataGridView1.Rows(0).Cells(10).Value.ToString
        
        If TextBox1.Text = "admin" And TextBox2.Text = pass Then
            ' My.Settings.currentuser = TextBox1.Text
            Try
                Dim queryy As String = "UPDATE [varr] SET [currentuser]=? WHERE [ID]=? "
                Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "varr.mdb;Jet OLEDB:Database Password=janitani2;")

                    Using cmd = New OleDbCommand(queryy, con)
                        con.Open()
                        cmd.Parameters.AddWithValue("@p1", TextBox1.Text)

                        cmd.Parameters.AddWithValue("@p2", "1")
                        cmd.ExecuteNonQuery()
                        con.Close()
                        con.Dispose()
                    End Using
                End Using

            Catch ex As Exception
                MsgBox(Convert.ToString(ex))
            End Try
            main.Show()
            Me.Close()
        ElseIf TextBox1.Text = "finance" And TextBox2.Text = pass1 Then
            ' My.Settings.currentuser = TextBox1.Text
            Try
                Dim queryy As String = "UPDATE [varr] SET [currentuser]=? WHERE [ID]=? "
                Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "varr.mdb;Jet OLEDB:Database Password=janitani2;")

                    Using cmd = New OleDbCommand(queryy, con)
                        con.Open()
                        cmd.Parameters.AddWithValue("@p1", TextBox1.Text)

                        cmd.Parameters.AddWithValue("@p2", "1")
                        cmd.ExecuteNonQuery()
                        con.Close()
                        con.Dispose()
                    End Using
                End Using

            Catch ex As Exception
                MsgBox(Convert.ToString(ex))
            End Try
            main.Show()
            Me.Close()
        ElseIf TextBox1.Text = "manager" And TextBox2.Text = pass2 Then
            ' My.Settings.currentuser = TextBox1.Text
            Try
                Dim queryy As String = "UPDATE [varr] SET [currentuser]=? WHERE [ID]=? "
                Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "varr.mdb;Jet OLEDB:Database Password=janitani2;")

                    Using cmd = New OleDbCommand(queryy, con)
                        con.Open()
                        cmd.Parameters.AddWithValue("@p1", TextBox1.Text)

                        cmd.Parameters.AddWithValue("@p2", "1")
                        cmd.ExecuteNonQuery()
                        con.Close()
                        con.Dispose()
                    End Using
                End Using

            Catch ex As Exception
                MsgBox(Convert.ToString(ex))
            End Try
           
            main.Show()
            Me.Close()
        Else
            MsgBox("wrong username or password")
            TextBox1.Text = ""
            TextBox2.Text = ""

        End If
    End Sub

   
End Class
