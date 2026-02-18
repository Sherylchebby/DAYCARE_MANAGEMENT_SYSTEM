Public Class Form7
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DaycareDB1DataSet.Daily_Report' table. You can move, or remove it, as needed.
        Me.Daily_ReportTableAdapter.Fill(Me.DaycareDB1DataSet.Daily_Report)

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Dim new1 As New Form1
        new1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        DailyReportBindingSource.EndEdit()
        Daily_ReportTableAdapter.Update(DaycareDB1DataSet.Daily_Report)
        MessageBox.Show("Saved Successfully")

    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        DailyReportBindingSource.AddNew()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        DailyReportBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        DailyReportBindingSource.MoveNext()
    End Sub
End Class