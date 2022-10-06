Imports System.Data.OleDb

Public Class changepass

    Private Sub changepass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VarrDataSet2.varr' table. You can move, or remove it, as needed.
        Me.VarrTableAdapter.Fill(Me.VarrDataSet2.varr)
        
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        DataGridView1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pass As String = DataGridView1.Rows(0).Cells(8).Value.ToString
        Dim pass1 As String = DataGridView1.Rows(0).Cells(9).Value.ToString
        Dim pass2 As String = DataGridView1.Rows(0).Cells(10).Value.ToString
        If TextBox1.Text = "finance" And TextBox2.Text = pass1 And TextBox3.Text <> " " Then
            ' My.Settings.pass2 = TextBox3.Text
            Try
                Dim queryy As String = "UPDATE [varr] SET [pass2]=? WHERE [ID]=? "
                Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "varr.mdb;Jet OLEDB:Database Password=janitani2;")

                    Using cmd = New OleDbCommand(queryy, con)
                        con.Open()
                        cmd.Parameters.AddWithValue("@p1", TextBox3.Text)

                        cmd.Parameters.AddWithValue("@p2", "1")
                        cmd.ExecuteNonQuery()
                        con.Close()
                        con.Dispose()
                        MsgBox("password changed")
                    End Using
                End Using

            Catch ex As Exception
                MsgBox(Convert.ToString(ex))
            End Try

            Me.Close()
        ElseIf TextBox1.Text = "admin" And TextBox2.Text = pass And TextBox3.Text <> " " Then
            ' My.Settings.pass1 = TextBox3.Text
            Try
                Dim queryy As String = "UPDATE [varr] SET [pass1]=? WHERE [ID]=? "
                Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "varr.mdb;Jet OLEDB:Database Password=janitani2;")

                    Using cmd = New OleDbCommand(queryy, con)
                        con.Open()
                        cmd.Parameters.AddWithValue("@p1", TextBox3.Text)

                        cmd.Parameters.AddWithValue("@p2", "1")
                        cmd.ExecuteNonQuery()
                        con.Close()
                        con.Dispose()
                        MsgBox("password changed")
                    End Using
                End Using

            Catch ex As Exception
                MsgBox(Convert.ToString(ex))
            End Try

            Me.Close()
        ElseIf TextBox1.Text = "manager" And TextBox2.Text = pass2 And TextBox3.Text <> " " Then
            ' My.Settings.pass3 = TextBox3.Text
            Try
                Dim queryy As String = "UPDATE [varr] SET [pass3]=? WHERE [ID]=? "
                Using con = New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;DATA SOURCE=" & main.path + "varr.mdb;Jet OLEDB:Database Password=janitani2;")

                    Using cmd = New OleDbCommand(queryy, con)
                        con.Open()
                        cmd.Parameters.AddWithValue("@p1", TextBox3.Text)

                        cmd.Parameters.AddWithValue("@p2", "1")
                        cmd.ExecuteNonQuery()
                        con.Close()
                        con.Dispose()
                        MsgBox("password changed")
                    End Using
                End Using

            Catch ex As Exception
                MsgBox(Convert.ToString(ex))
            End Try
            Me.Close()
        Else
            MsgBox("user or password doesn't match please try again")
        End If
    End Sub
End Class