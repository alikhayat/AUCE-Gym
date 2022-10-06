Public Class records

    Private Sub records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ActiveregDataSet1.ActiveReg' table. You can move, or remove it, as needed.
        Me.ActiveRegTableAdapter.Fill(Me.ActiveregDataSet1.ActiveReg)

       
       
        

       

    End Sub
End Class