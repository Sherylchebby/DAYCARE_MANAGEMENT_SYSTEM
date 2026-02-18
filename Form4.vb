Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DaycareDBDataSet.Payment' table. You can move, or remove it, as needed.
        Me.PaymentTableAdapter.Fill(Me.DaycareDBDataSet.Payment)
        'TODO: This line of code loads data into the 'DaycareDataSet.Payment' table. You can move, or remove it, as needed.
        Me.PaymentTableAdapter.Fill(Me.DaycareDBDataSet.Payment)

    End Sub
    Private Sub tButton1_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        '  Try
        PaymentBindingSource.EndEdit() ' Change to your Payment BindingSource
            PaymentTableAdapter.Update(DaycareDBDataSet.Payment) ' Change to your Payment TableAdapter and DataSet
        ' MessageBox.Show("Your changes have been saved successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Me.Close()
        'Form1.Show()
        'Catch ex As Exception
        'MessageBox.Show("An error occurred while saving changes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ' End Try
    End Sub
    Private Sub PaymentBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles PaymentBindingSource.CurrentChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btncontinue.Click
        Dim form6 As New Form6()
        form6.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        PaymentBindingSource.AddNew()
    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        PaymentBindingSource.MovePrevious()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        PaymentBindingSource.MoveNext()
    End Sub
End Class