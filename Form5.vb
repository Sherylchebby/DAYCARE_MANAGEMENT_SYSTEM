Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DaycareDBDataSet.Medical_Administration' table. You can move, or remove it, as needed.
        Me.Medical_AdministrationTableAdapter.Fill(Me.DaycareDBDataSet.Medical_Administration)
        'TODO: This line of code loads data into the 'DaycareDataSet.Medical_Administration' table. You can move, or remove it, as needed.
        Me.Medical_AdministrationTableAdapter.Fill(Me.DaycareDBDataSet.Medical_Administration)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Dim new1 As New Form1
        new1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        MedicalAdministrationBindingSource.EndEdit()
        Medical_AdministrationTableAdapter.Update(DaycareDBDataSet.Medical_Administration)
        MessageBox.Show("Saved Successfully")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If MedicalAdministrationBindingSource.Current IsNot Nothing Then
            MedicalAdministrationBindingSource.CancelEdit()
            DaycareDBDataSet.RejectChanges()
            MessageBox.Show("Changes have been cancelled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        MedicalAdministrationBindingSource.AddNew()
    End Sub
End Class