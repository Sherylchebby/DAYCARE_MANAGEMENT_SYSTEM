Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DaycareDBDataSet._Pick_up' table. You can move, or remove it, as needed.
        Me.Pick_upTableAdapter.Fill(Me.DaycareDBDataSet._Pick_up)
        'TODO: This line of code loads data into the 'DaycareDBDataSet._Pick_up' table. You can move, or remove it, as needed.
        ' Me.Pick_upTableAdapter.Fill(Me.DaycareDBDataSet.Pick_up)
        'TODO: This line of code loads data into the 'DaycareDataSet._Pick_up' table. You can move, or remove it, as needed.
        'Me.Pick_upTableAdapter.Fill(Me.DaycareDBDataSet._Pick_up)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Dim new1 As New Form1
        new1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        PickupBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        PickupBindingSource.MoveNext()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        PickupBindingSource.MovePrevious()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        PickupBindingSource.EndEdit()
        Pick_upTableAdapter.Update(DaycareDBDataSet._Pick_up)
    End Sub
End Class