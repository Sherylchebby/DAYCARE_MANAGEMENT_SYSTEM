<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.pnlvision = New System.Windows.Forms.Panel()
        Me.rtbvision = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlmission = New System.Windows.Forms.Panel()
        Me.rtbmission = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncontacts = New System.Windows.Forms.Button()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.lblabout = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.pnlvision.SuspendLayout()
        Me.pnlmission.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlvision
        '
        Me.pnlvision.Controls.Add(Me.rtbvision)
        Me.pnlvision.Controls.Add(Me.Label2)
        Me.pnlvision.Location = New System.Drawing.Point(191, 306)
        Me.pnlvision.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlvision.Name = "pnlvision"
        Me.pnlvision.Size = New System.Drawing.Size(597, 115)
        Me.pnlvision.TabIndex = 0
        '
        'rtbvision
        '
        Me.rtbvision.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rtbvision.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbvision.Location = New System.Drawing.Point(8, 33)
        Me.rtbvision.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rtbvision.Name = "rtbvision"
        Me.rtbvision.Size = New System.Drawing.Size(584, 81)
        Me.rtbvision.TabIndex = 2
        Me.rtbvision.Text = "WeeCare Daycare envisions being a leading force in early childhood education, fos" &
    "tering a community that empowers children to explore, learn, and thrive in a nur" &
    "turing setting."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(191, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Vision"
        '
        'pnlmission
        '
        Me.pnlmission.Controls.Add(Me.rtbmission)
        Me.pnlmission.Controls.Add(Me.Label1)
        Me.pnlmission.Location = New System.Drawing.Point(191, 159)
        Me.pnlmission.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlmission.Name = "pnlmission"
        Me.pnlmission.Size = New System.Drawing.Size(597, 115)
        Me.pnlmission.TabIndex = 3
        '
        'rtbmission
        '
        Me.rtbmission.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rtbmission.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbmission.Location = New System.Drawing.Point(12, 29)
        Me.rtbmission.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rtbmission.Name = "rtbmission"
        Me.rtbmission.Size = New System.Drawing.Size(584, 82)
        Me.rtbmission.TabIndex = 1
        Me.rtbmission.Text = resources.GetString("rtbmission.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mission"
        '
        'btncontacts
        '
        Me.btncontacts.BackColor = System.Drawing.Color.Black
        Me.btncontacts.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncontacts.ForeColor = System.Drawing.Color.White
        Me.btncontacts.Location = New System.Drawing.Point(323, 467)
        Me.btncontacts.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btncontacts.Name = "btncontacts"
        Me.btncontacts.Size = New System.Drawing.Size(100, 27)
        Me.btncontacts.TabIndex = 4
        Me.btncontacts.Text = "Contact us"
        Me.btncontacts.UseVisualStyleBackColor = False
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(926, 84)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(25, 467)
        Me.VScrollBar1.TabIndex = 6
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.Color.Black
        Me.btnhome.ForeColor = System.Drawing.Color.White
        Me.btnhome.Location = New System.Drawing.Point(519, 467)
        Me.btnhome.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(100, 27)
        Me.btnhome.TabIndex = 7
        Me.btnhome.Text = "Home"
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'lblabout
        '
        Me.lblabout.AutoSize = True
        Me.lblabout.BackColor = System.Drawing.Color.PapayaWhip
        Me.lblabout.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblabout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblabout.Location = New System.Drawing.Point(361, 119)
        Me.lblabout.Name = "lblabout"
        Me.lblabout.Size = New System.Drawing.Size(98, 18)
        Me.lblabout.TabIndex = 8
        Me.lblabout.Text = "ABOUT US:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.lbltitle)
        Me.Panel1.Location = New System.Drawing.Point(-3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(954, 81)
        Me.Panel1.TabIndex = 30
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbltitle.Font = New System.Drawing.Font("Jokerman", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(293, 9)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(263, 70)
        Me.lbltitle.TabIndex = 28
        Me.lbltitle.Text = "WeeCare"
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(951, 550)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblabout)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.btncontacts)
        Me.Controls.Add(Me.pnlmission)
        Me.Controls.Add(Me.pnlvision)
        Me.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form9"
        Me.Text = "About Us"
        Me.pnlvision.ResumeLayout(False)
        Me.pnlvision.PerformLayout()
        Me.pnlmission.ResumeLayout(False)
        Me.pnlmission.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlvision As Panel
    Friend WithEvents rtbvision As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlmission As Panel
    Friend WithEvents rtbmission As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btncontacts As Button
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents btnhome As Button
    Friend WithEvents lblabout As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbltitle As Label
End Class
