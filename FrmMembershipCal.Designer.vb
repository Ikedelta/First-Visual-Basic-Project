<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMembershipCal
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
        Me.grpTypeofMembership = New System.Windows.Forms.GroupBox()
        Me.rdoSeniorCitizen = New System.Windows.Forms.RadioButton()
        Me.rdoStudent = New System.Windows.Forms.RadioButton()
        Me.rdoChild = New System.Windows.Forms.RadioButton()
        Me.rdoStandardAdult = New System.Windows.Forms.RadioButton()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.chkPersonalTrainer = New System.Windows.Forms.CheckBox()
        Me.chkKarate = New System.Windows.Forms.CheckBox()
        Me.chkYoga = New System.Windows.Forms.CheckBox()
        Me.grpMembershipLength = New System.Windows.Forms.GroupBox()
        Me.txtM = New System.Windows.Forms.TextBox()
        Me.lblNumberofMonth = New System.Windows.Forms.Label()
        Me.grpMembershipFee = New System.Windows.Forms.GroupBox()
        Me.lblT = New System.Windows.Forms.Label()
        Me.lblM = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblMonthlyfee = New System.Windows.Forms.Label()
        Me.btnCalculator = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.grpTypeofMembership.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.grpMembershipLength.SuspendLayout()
        Me.grpMembershipFee.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTypeofMembership
        '
        Me.grpTypeofMembership.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpTypeofMembership.Controls.Add(Me.rdoSeniorCitizen)
        Me.grpTypeofMembership.Controls.Add(Me.rdoStudent)
        Me.grpTypeofMembership.Controls.Add(Me.rdoChild)
        Me.grpTypeofMembership.Controls.Add(Me.rdoStandardAdult)
        Me.grpTypeofMembership.Location = New System.Drawing.Point(83, 65)
        Me.grpTypeofMembership.Name = "grpTypeofMembership"
        Me.grpTypeofMembership.Size = New System.Drawing.Size(261, 206)
        Me.grpTypeofMembership.TabIndex = 0
        Me.grpTypeofMembership.TabStop = False
        Me.grpTypeofMembership.Text = "Type of Membership"
        '
        'rdoSeniorCitizen
        '
        Me.rdoSeniorCitizen.Location = New System.Drawing.Point(28, 147)
        Me.rdoSeniorCitizen.Name = "rdoSeniorCitizen"
        Me.rdoSeniorCitizen.Size = New System.Drawing.Size(104, 33)
        Me.rdoSeniorCitizen.TabIndex = 3
        Me.rdoSeniorCitizen.TabStop = True
        Me.rdoSeniorCitizen.Text = "Senior Citizen"
        Me.rdoSeniorCitizen.UseVisualStyleBackColor = True
        '
        'rdoStudent
        '
        Me.rdoStudent.Location = New System.Drawing.Point(28, 108)
        Me.rdoStudent.Name = "rdoStudent"
        Me.rdoStudent.Size = New System.Drawing.Size(104, 33)
        Me.rdoStudent.TabIndex = 2
        Me.rdoStudent.TabStop = True
        Me.rdoStudent.Text = "Student"
        Me.rdoStudent.UseVisualStyleBackColor = True
        '
        'rdoChild
        '
        Me.rdoChild.Location = New System.Drawing.Point(28, 69)
        Me.rdoChild.Name = "rdoChild"
        Me.rdoChild.Size = New System.Drawing.Size(116, 33)
        Me.rdoChild.TabIndex = 1
        Me.rdoChild.TabStop = True
        Me.rdoChild.Text = "Child (12 && Under)"
        Me.rdoChild.UseVisualStyleBackColor = True
        '
        'rdoStandardAdult
        '
        Me.rdoStandardAdult.Location = New System.Drawing.Point(28, 31)
        Me.rdoStandardAdult.Name = "rdoStandardAdult"
        Me.rdoStandardAdult.Size = New System.Drawing.Size(104, 33)
        Me.rdoStandardAdult.TabIndex = 0
        Me.rdoStandardAdult.TabStop = True
        Me.rdoStandardAdult.Text = "Standard Adult"
        Me.rdoStandardAdult.UseVisualStyleBackColor = True
        '
        'grpOptions
        '
        Me.grpOptions.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpOptions.Controls.Add(Me.chkPersonalTrainer)
        Me.grpOptions.Controls.Add(Me.chkKarate)
        Me.grpOptions.Controls.Add(Me.chkYoga)
        Me.grpOptions.Location = New System.Drawing.Point(412, 65)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(261, 206)
        Me.grpOptions.TabIndex = 1
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'chkPersonalTrainer
        '
        Me.chkPersonalTrainer.Location = New System.Drawing.Point(32, 133)
        Me.chkPersonalTrainer.Name = "chkPersonalTrainer"
        Me.chkPersonalTrainer.Size = New System.Drawing.Size(115, 47)
        Me.chkPersonalTrainer.TabIndex = 2
        Me.chkPersonalTrainer.Text = "Personal Trainer"
        Me.chkPersonalTrainer.UseVisualStyleBackColor = True
        '
        'chkKarate
        '
        Me.chkKarate.Location = New System.Drawing.Point(32, 80)
        Me.chkKarate.Name = "chkKarate"
        Me.chkKarate.Size = New System.Drawing.Size(115, 47)
        Me.chkKarate.TabIndex = 1
        Me.chkKarate.Text = "Karate"
        Me.chkKarate.UseVisualStyleBackColor = True
        '
        'chkYoga
        '
        Me.chkYoga.Location = New System.Drawing.Point(32, 31)
        Me.chkYoga.Name = "chkYoga"
        Me.chkYoga.Size = New System.Drawing.Size(115, 47)
        Me.chkYoga.TabIndex = 0
        Me.chkYoga.Text = "Yoga"
        Me.chkYoga.UseVisualStyleBackColor = True
        '
        'grpMembershipLength
        '
        Me.grpMembershipLength.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpMembershipLength.Controls.Add(Me.txtM)
        Me.grpMembershipLength.Controls.Add(Me.lblNumberofMonth)
        Me.grpMembershipLength.Location = New System.Drawing.Point(83, 309)
        Me.grpMembershipLength.Name = "grpMembershipLength"
        Me.grpMembershipLength.Size = New System.Drawing.Size(261, 131)
        Me.grpMembershipLength.TabIndex = 2
        Me.grpMembershipLength.TabStop = False
        Me.grpMembershipLength.Text = "Membership Length"
        '
        'txtM
        '
        Me.txtM.Location = New System.Drawing.Point(28, 66)
        Me.txtM.Multiline = True
        Me.txtM.Name = "txtM"
        Me.txtM.Size = New System.Drawing.Size(211, 44)
        Me.txtM.TabIndex = 1
        '
        'lblNumberofMonth
        '
        Me.lblNumberofMonth.Location = New System.Drawing.Point(25, 35)
        Me.lblNumberofMonth.Name = "lblNumberofMonth"
        Me.lblNumberofMonth.Size = New System.Drawing.Size(142, 27)
        Me.lblNumberofMonth.TabIndex = 0
        Me.lblNumberofMonth.Text = "Enter the Number of Months"
        '
        'grpMembershipFee
        '
        Me.grpMembershipFee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpMembershipFee.Controls.Add(Me.lblT)
        Me.grpMembershipFee.Controls.Add(Me.lblM)
        Me.grpMembershipFee.Controls.Add(Me.lblTotal)
        Me.grpMembershipFee.Controls.Add(Me.lblMonthlyfee)
        Me.grpMembershipFee.Location = New System.Drawing.Point(412, 309)
        Me.grpMembershipFee.Name = "grpMembershipFee"
        Me.grpMembershipFee.Size = New System.Drawing.Size(261, 131)
        Me.grpMembershipFee.TabIndex = 3
        Me.grpMembershipFee.TabStop = False
        Me.grpMembershipFee.Text = "Membership Fee"
        '
        'lblT
        '
        Me.lblT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblT.Location = New System.Drawing.Point(106, 75)
        Me.lblT.Name = "lblT"
        Me.lblT.Size = New System.Drawing.Size(135, 35)
        Me.lblT.TabIndex = 2
        '
        'lblM
        '
        Me.lblM.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblM.Location = New System.Drawing.Point(106, 23)
        Me.lblM.Name = "lblM"
        Me.lblM.Size = New System.Drawing.Size(135, 35)
        Me.lblM.TabIndex = 1
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(29, 85)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "Total"
        '
        'lblMonthlyfee
        '
        Me.lblMonthlyfee.Location = New System.Drawing.Point(29, 35)
        Me.lblMonthlyfee.Name = "lblMonthlyfee"
        Me.lblMonthlyfee.Size = New System.Drawing.Size(100, 23)
        Me.lblMonthlyfee.TabIndex = 0
        Me.lblMonthlyfee.Text = "Monthly Fee"
        '
        'btnCalculator
        '
        Me.btnCalculator.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCalculator.Location = New System.Drawing.Point(83, 457)
        Me.btnCalculator.Name = "btnCalculator"
        Me.btnCalculator.Size = New System.Drawing.Size(132, 50)
        Me.btnCalculator.TabIndex = 4
        Me.btnCalculator.Text = "Calculate"
        Me.btnCalculator.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.Location = New System.Drawing.Point(221, 457)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(132, 50)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(403, 457)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(132, 50)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.Location = New System.Drawing.Point(541, 457)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(132, 50)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'FrmMembershipCal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 529)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculator)
        Me.Controls.Add(Me.grpMembershipFee)
        Me.Controls.Add(Me.grpMembershipLength)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.grpTypeofMembership)
        Me.Name = "FrmMembershipCal"
        Me.Text = "Membership Fee Calculator"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpTypeofMembership.ResumeLayout(False)
        Me.grpOptions.ResumeLayout(False)
        Me.grpMembershipLength.ResumeLayout(False)
        Me.grpMembershipLength.PerformLayout()
        Me.grpMembershipFee.ResumeLayout(False)
        Me.grpMembershipFee.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpTypeofMembership As GroupBox
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents grpMembershipLength As GroupBox
    Friend WithEvents grpMembershipFee As GroupBox
    Friend WithEvents rdoStandardAdult As RadioButton
    Friend WithEvents rdoSeniorCitizen As RadioButton
    Friend WithEvents rdoStudent As RadioButton
    Friend WithEvents rdoChild As RadioButton
    Friend WithEvents chkPersonalTrainer As CheckBox
    Friend WithEvents chkKarate As CheckBox
    Friend WithEvents chkYoga As CheckBox
    Friend WithEvents lblNumberofMonth As Label
    Friend WithEvents lblT As Label
    Friend WithEvents lblM As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblMonthlyfee As Label
    Friend WithEvents txtM As TextBox
    Friend WithEvents btnCalculator As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnBack As Button
End Class
