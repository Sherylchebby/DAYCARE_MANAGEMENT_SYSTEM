<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.msmainmenu = New System.Windows.Forms.MenuStrip()
        Me.HOMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SERVICESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnrollmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PickupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicalAdministationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailyReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutWeeCareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COONTACTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADMINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.btncontacts = New System.Windows.Forms.Button()
        Me.btnabbout = New System.Windows.Forms.Button()
        Me.btnreport = New System.Windows.Forms.Button()
        Me.btnmedical = New System.Windows.Forms.Button()
        Me.btnpickup = New System.Windows.Forms.Button()
        Me.btnpayment = New System.Windows.Forms.Button()
        Me.btnenrollment = New System.Windows.Forms.Button()
        Me.msmainmenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'msmainmenu
        '
        Me.msmainmenu.BackColor = System.Drawing.Color.YellowGreen
        Me.msmainmenu.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msmainmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HOMEToolStripMenuItem, Me.SERVICESToolStripMenuItem, Me.ABOUTUSToolStripMenuItem, Me.COONTACTSToolStripMenuItem, Me.ADMINToolStripMenuItem})
        Me.msmainmenu.Location = New System.Drawing.Point(0, 0)
        Me.msmainmenu.Name = "msmainmenu"
        Me.msmainmenu.Size = New System.Drawing.Size(800, 25)
        Me.msmainmenu.TabIndex = 0
        Me.msmainmenu.Text = "MenuStrip1"
        '
        'HOMEToolStripMenuItem
        '
        Me.HOMEToolStripMenuItem.Name = "HOMEToolStripMenuItem"
        Me.HOMEToolStripMenuItem.Size = New System.Drawing.Size(65, 21)
        Me.HOMEToolStripMenuItem.Text = "HOME"
        '
        'SERVICESToolStripMenuItem
        '
        Me.SERVICESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnrollmentToolStripMenuItem, Me.PaymentToolStripMenuItem, Me.MedicalAdministationToolStripMenuItem, Me.DailyReportToolStripMenuItem})
        Me.SERVICESToolStripMenuItem.Name = "SERVICESToolStripMenuItem"
        Me.SERVICESToolStripMenuItem.Size = New System.Drawing.Size(92, 21)
        Me.SERVICESToolStripMenuItem.Text = "SERVICES"
        '
        'EnrollmentToolStripMenuItem
        '
        Me.EnrollmentToolStripMenuItem.Name = "EnrollmentToolStripMenuItem"
        Me.EnrollmentToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.EnrollmentToolStripMenuItem.Text = "Enrollment"
        '
        'PaymentToolStripMenuItem
        '
        Me.PaymentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PickupToolStripMenuItem})
        Me.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        Me.PaymentToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.PaymentToolStripMenuItem.Text = "Payment"
        '
        'PickupToolStripMenuItem
        '
        Me.PickupToolStripMenuItem.Name = "PickupToolStripMenuItem"
        Me.PickupToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.PickupToolStripMenuItem.Text = "Pick-up"
        '
        'MedicalAdministationToolStripMenuItem
        '
        Me.MedicalAdministationToolStripMenuItem.Name = "MedicalAdministationToolStripMenuItem"
        Me.MedicalAdministationToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.MedicalAdministationToolStripMenuItem.Text = "Medical Administation"
        '
        'DailyReportToolStripMenuItem
        '
        Me.DailyReportToolStripMenuItem.Name = "DailyReportToolStripMenuItem"
        Me.DailyReportToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.DailyReportToolStripMenuItem.Text = "Daily Report"
        '
        'ABOUTUSToolStripMenuItem
        '
        Me.ABOUTUSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutWeeCareToolStripMenuItem})
        Me.ABOUTUSToolStripMenuItem.Name = "ABOUTUSToolStripMenuItem"
        Me.ABOUTUSToolStripMenuItem.Size = New System.Drawing.Size(98, 21)
        Me.ABOUTUSToolStripMenuItem.Text = "ABOUT US"
        '
        'AboutWeeCareToolStripMenuItem
        '
        Me.AboutWeeCareToolStripMenuItem.Name = "AboutWeeCareToolStripMenuItem"
        Me.AboutWeeCareToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.AboutWeeCareToolStripMenuItem.Text = "About Us"
        '
        'COONTACTSToolStripMenuItem
        '
        Me.COONTACTSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContactsToolStripMenuItem})
        Me.COONTACTSToolStripMenuItem.Name = "COONTACTSToolStripMenuItem"
        Me.COONTACTSToolStripMenuItem.Size = New System.Drawing.Size(105, 21)
        Me.COONTACTSToolStripMenuItem.Text = "CONTACTS"
        '
        'ContactsToolStripMenuItem
        '
        Me.ContactsToolStripMenuItem.Name = "ContactsToolStripMenuItem"
        Me.ContactsToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ContactsToolStripMenuItem.Text = "Contacts"
        '
        'ADMINToolStripMenuItem
        '
        Me.ADMINToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem})
        Me.ADMINToolStripMenuItem.Name = "ADMINToolStripMenuItem"
        Me.ADMINToolStripMenuItem.Size = New System.Drawing.Size(71, 21)
        Me.ADMINToolStripMenuItem.Text = "ADMIN"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbltitle.Font = New System.Drawing.Font("Jokerman", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(185, 24)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(347, 93)
        Me.lbltitle.TabIndex = 1
        Me.lbltitle.Text = "WeeCare"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BackgroundImage = Global.DAYCARE_MANAGEMENT_SYSTEM.My.Resources.Resources.DBPhotos1
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.btnlogin)
        Me.Panel1.Controls.Add(Me.btncontacts)
        Me.Panel1.Controls.Add(Me.btnabbout)
        Me.Panel1.Controls.Add(Me.btnreport)
        Me.Panel1.Controls.Add(Me.btnmedical)
        Me.Panel1.Controls.Add(Me.btnpickup)
        Me.Panel1.Controls.Add(Me.btnpayment)
        Me.Panel1.Controls.Add(Me.btnenrollment)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 821)
        Me.Panel1.TabIndex = 2
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.YellowGreen
        Me.btnlogin.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.Location = New System.Drawing.Point(12, 401)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(167, 23)
        Me.btnlogin.TabIndex = 7
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'btncontacts
        '
        Me.btncontacts.BackColor = System.Drawing.Color.YellowGreen
        Me.btncontacts.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncontacts.Location = New System.Drawing.Point(12, 358)
        Me.btncontacts.Name = "btncontacts"
        Me.btncontacts.Size = New System.Drawing.Size(167, 23)
        Me.btncontacts.TabIndex = 6
        Me.btncontacts.Text = "Contacts"
        Me.btncontacts.UseVisualStyleBackColor = False
        '
        'btnabbout
        '
        Me.btnabbout.BackColor = System.Drawing.Color.YellowGreen
        Me.btnabbout.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnabbout.Location = New System.Drawing.Point(12, 314)
        Me.btnabbout.Name = "btnabbout"
        Me.btnabbout.Size = New System.Drawing.Size(167, 23)
        Me.btnabbout.TabIndex = 5
        Me.btnabbout.Text = "About Us"
        Me.btnabbout.UseVisualStyleBackColor = False
        '
        'btnreport
        '
        Me.btnreport.BackColor = System.Drawing.Color.YellowGreen
        Me.btnreport.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreport.Location = New System.Drawing.Point(12, 276)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(167, 23)
        Me.btnreport.TabIndex = 4
        Me.btnreport.Text = "Daily Report"
        Me.btnreport.UseVisualStyleBackColor = False
        '
        'btnmedical
        '
        Me.btnmedical.BackColor = System.Drawing.Color.YellowGreen
        Me.btnmedical.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmedical.Location = New System.Drawing.Point(12, 229)
        Me.btnmedical.Name = "btnmedical"
        Me.btnmedical.Size = New System.Drawing.Size(180, 23)
        Me.btnmedical.TabIndex = 3
        Me.btnmedical.Text = "Medical Administration"
        Me.btnmedical.UseVisualStyleBackColor = False
        '
        'btnpickup
        '
        Me.btnpickup.BackColor = System.Drawing.Color.YellowGreen
        Me.btnpickup.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpickup.Location = New System.Drawing.Point(12, 186)
        Me.btnpickup.Name = "btnpickup"
        Me.btnpickup.Size = New System.Drawing.Size(167, 23)
        Me.btnpickup.TabIndex = 2
        Me.btnpickup.Text = "Pick-up"
        Me.btnpickup.UseVisualStyleBackColor = False
        '
        'btnpayment
        '
        Me.btnpayment.BackColor = System.Drawing.Color.YellowGreen
        Me.btnpayment.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpayment.Location = New System.Drawing.Point(12, 138)
        Me.btnpayment.Name = "btnpayment"
        Me.btnpayment.Size = New System.Drawing.Size(167, 23)
        Me.btnpayment.TabIndex = 1
        Me.btnpayment.Text = "Payment"
        Me.btnpayment.UseVisualStyleBackColor = False
        '
        'btnenrollment
        '
        Me.btnenrollment.BackColor = System.Drawing.Color.YellowGreen
        Me.btnenrollment.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnenrollment.Location = New System.Drawing.Point(12, 87)
        Me.btnenrollment.Name = "btnenrollment"
        Me.btnenrollment.Size = New System.Drawing.Size(167, 23)
        Me.btnenrollment.TabIndex = 0
        Me.btnenrollment.Text = "Enrollment"
        Me.btnenrollment.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.DAYCARE_MANAGEMENT_SYSTEM.My.Resources.Resources.aaron_mello_137671_unsplash_e1582763278284
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.msmainmenu)
        Me.MainMenuStrip = Me.msmainmenu
        Me.Name = "Form1"
        Me.Text = "Main"
        Me.msmainmenu.ResumeLayout(False)
        Me.msmainmenu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msmainmenu As MenuStrip
    Friend WithEvents HOMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SERVICESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABOUTUSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COONTACTSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ADMINToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnrollmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicalAdministationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbltitle As Label
    Friend WithEvents PickupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DailyReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutWeeCareToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnlogin As Button
    Friend WithEvents btncontacts As Button
    Friend WithEvents btnabbout As Button
    Friend WithEvents btnreport As Button
    Friend WithEvents btnmedical As Button
    Friend WithEvents btnpickup As Button
    Friend WithEvents btnpayment As Button
    Friend WithEvents btnenrollment As Button
End Class
