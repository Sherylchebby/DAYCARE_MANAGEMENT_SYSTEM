Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub MedicalAdministationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicalAdministationToolStripMenuItem.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub EnrollmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnrollmentToolStripMenuItem.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub SERVICESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERVICESToolStripMenuItem.Click

    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub AboutWeeCareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutWeeCareToolStripMenuItem.Click
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnpickup.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnenrollment.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnpayment.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnmedical.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnabbout.Click
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btncontacts.Click
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Form2.Show()
        Me.Hide()
    End Sub


    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles btnenrollment.MouseEnter
        btnenrollment.BackColor = Color.YellowGreen
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles btnenrollment.MouseLeave
        btnenrollment.BackColor = Color.Orange
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles btnpayment.MouseEnter
        btnpayment.BackColor = Color.YellowGreen
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles btnpayment.MouseLeave
        btnpayment.BackColor = Color.Orange
    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles btnpickup.MouseEnter
        btnpickup.BackColor = Color.YellowGreen
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles btnpickup.MouseLeave
        btnpickup.BackColor = Color.Orange
    End Sub

    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles btnmedical.MouseEnter
        btnmedical.BackColor = Color.YellowGreen
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles btnmedical.MouseLeave
        btnmedical.BackColor = Color.Orange
    End Sub

    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles btnreport.MouseEnter
        btnreport.BackColor = Color.YellowGreen
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles btnreport.MouseLeave
        btnreport.BackColor = Color.Orange
    End Sub

    Private Sub Button6_MouseEnter(sender As Object, e As EventArgs) Handles btnabbout.MouseEnter
        btnabbout.BackColor = Color.YellowGreen
    End Sub

    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs) Handles btnabbout.MouseLeave
        btnabbout.BackColor = Color.Orange
    End Sub

    Private Sub Button7_MouseEnter(sender As Object, e As EventArgs) Handles btncontacts.MouseEnter
        btncontacts.BackColor = Color.GreenYellow
    End Sub

    Private Sub Button7_MouseLeave(sender As Object, e As EventArgs) Handles btncontacts.MouseLeave
        btncontacts.BackColor = Color.Orange
    End Sub

    Private Sub Button8_MouseEnter(sender As Object, e As EventArgs) Handles btnlogin.MouseEnter
        btnlogin.BackColor = Color.YellowGreen
    End Sub

    Private Sub Button8_MouseLeave(sender As Object, e As EventArgs) Handles btnlogin.MouseLeave
        btnlogin.BackColor = Color.Orange
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
