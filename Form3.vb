Public Class Form3
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DaycareDB1DataSet.Enrollment' table. You can move, or remove it, as needed.
        Me.EnrollmentTableAdapter.Fill(Me.DaycareDB1DataSet.Enrollment)

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnpreviious.Click
        EnrollmentBindingSource.MovePrevious()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        EnrollmentBindingSource.MoveNext()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        EnrollmentBindingSource.AddNew()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            EnrollmentBindingSource.EndEdit()
            EnrollmentTableAdapter.Update(DaycareDB1DataSet.Enrollment)
            MessageBox.Show("Your changes have been saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Form1.Show()
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving changes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this item?",
                                                             "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.Yes Then
            If EnrollmentBindingSource.Current IsNot Nothing Then
                Try
                    EnrollmentBindingSource.RemoveCurrent()
                    MessageBox.Show("Record deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Failed to delete the record. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btncontinue.Click
        Dim form4 As New Form4()
        form4.Show()
        Me.Hide()
    End Sub
End Class