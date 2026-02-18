Imports System.Data.OleDb

Public Class Form2
    Dim connection As New OleDbConnection(My.Settings.DaycareDBConnectionString)
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DaycareDBDataSet.Login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.DaycareDBDataSet.Login)
        'TODO: This line of code loads data into the 'DaycareDataSet1.Login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.DaycareDBDataSet.Login)
        'TODO: This line of code loads data into the 'DaycareDataSet.Login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.DaycareDBDataSet.Login)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtusername.Text = Nothing Or txtpassword.Text = Nothing Then
            MsgBox("Please enter your username and password", MsgBoxStyle.Exclamation)
        Else
            If connection.State = ConnectionState.Closed Then connection.Open()
            Dim cmd As New OleDbCommand("SELECT COUNT(*) FROM login WHERE username=? AND password=?", connection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtusername.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = txtpassword.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                MsgBox("Login successful", MsgBoxStyle.Information)
                Dim newForm As New Form1
                newForm.Show()
                Me.Hide()
            Else
                MsgBox("Account not found", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        txtusername.Clear()
        txtpassword.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub
End Class