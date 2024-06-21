Public Class Form1
    Private Sub VSubmissionbtn_Click(sender As Object, e As EventArgs) Handles VSubmissionbtn.Click
        Try
            Dim viewForm As New ViewSubmissionform()
            viewForm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub CNSubmissionbtn_Click(sender As Object, e As EventArgs) Handles CNSubmissionbtn.Click
        Try
            Dim createForm As New CreateNewSubmissionform()
            createForm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Any initialization code here
    End Sub
End Class
