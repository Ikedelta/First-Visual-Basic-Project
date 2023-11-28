<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVehicleLoanCalculator
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdoUsed = New System.Windows.Forms.RadioButton()
        Me.rdoNew = New System.Windows.Forms.RadioButton()
        Me.grpVehicleLoanInfo = New System.Windows.Forms.GroupBox()
        Me.txtCostofvehicle = New System.Windows.Forms.TextBox()
        Me.txtNumberofMonths = New System.Windows.Forms.TextBox()
        Me.txtAmountofDownPayment = New System.Windows.Forms.TextBox()
        Me.lblNumberofMonth = New System.Windows.Forms.Label()
        Me.lblDownpayment = New System.Windows.Forms.Label()
        Me.lblCostVehicle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAnnualRate = New System.Windows.Forms.Label()
        Me.lstout = New System.Windows.Forms.ListBox()
        Me.btnCalculator = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.grpVehicleLoanInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.rdoUsed)
        Me.GroupBox2.Controls.Add(Me.rdoNew)
        Me.GroupBox2.Location = New System.Drawing.Point(474, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(137, 159)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "New or Used"
        '
        'rdoUsed
        '
        Me.rdoUsed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rdoUsed.AutoSize = True
        Me.rdoUsed.Location = New System.Drawing.Point(20, 76)
        Me.rdoUsed.Name = "rdoUsed"
        Me.rdoUsed.Size = New System.Drawing.Size(50, 17)
        Me.rdoUsed.TabIndex = 1
        Me.rdoUsed.TabStop = True
        Me.rdoUsed.Text = "Used"
        Me.rdoUsed.UseVisualStyleBackColor = True
        '
        'rdoNew
        '
        Me.rdoNew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rdoNew.AutoSize = True
        Me.rdoNew.Location = New System.Drawing.Point(20, 36)
        Me.rdoNew.Name = "rdoNew"
        Me.rdoNew.Size = New System.Drawing.Size(47, 17)
        Me.rdoNew.TabIndex = 0
        Me.rdoNew.TabStop = True
        Me.rdoNew.Text = "New"
        Me.rdoNew.UseVisualStyleBackColor = True
        '
        'grpVehicleLoanInfo
        '
        Me.grpVehicleLoanInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpVehicleLoanInfo.Controls.Add(Me.txtCostofvehicle)
        Me.grpVehicleLoanInfo.Controls.Add(Me.txtNumberofMonths)
        Me.grpVehicleLoanInfo.Controls.Add(Me.txtAmountofDownPayment)
        Me.grpVehicleLoanInfo.Controls.Add(Me.lblNumberofMonth)
        Me.grpVehicleLoanInfo.Controls.Add(Me.lblDownpayment)
        Me.grpVehicleLoanInfo.Controls.Add(Me.lblCostVehicle)
        Me.grpVehicleLoanInfo.Location = New System.Drawing.Point(49, 76)
        Me.grpVehicleLoanInfo.Name = "grpVehicleLoanInfo"
        Me.grpVehicleLoanInfo.Size = New System.Drawing.Size(365, 159)
        Me.grpVehicleLoanInfo.TabIndex = 2
        Me.grpVehicleLoanInfo.TabStop = False
        Me.grpVehicleLoanInfo.Text = "Vehicle Loan Information"
        '
        'txtCostofvehicle
        '
        Me.txtCostofvehicle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCostofvehicle.Location = New System.Drawing.Point(175, 30)
        Me.txtCostofvehicle.Multiline = True
        Me.txtCostofvehicle.Name = "txtCostofvehicle"
        Me.txtCostofvehicle.Size = New System.Drawing.Size(171, 29)
        Me.txtCostofvehicle.TabIndex = 3
        '
        'txtNumberofMonths
        '
        Me.txtNumberofMonths.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNumberofMonths.Location = New System.Drawing.Point(175, 118)
        Me.txtNumberofMonths.Multiline = True
        Me.txtNumberofMonths.Name = "txtNumberofMonths"
        Me.txtNumberofMonths.Size = New System.Drawing.Size(171, 29)
        Me.txtNumberofMonths.TabIndex = 5
        '
        'txtAmountofDownPayment
        '
        Me.txtAmountofDownPayment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAmountofDownPayment.Location = New System.Drawing.Point(175, 75)
        Me.txtAmountofDownPayment.Multiline = True
        Me.txtAmountofDownPayment.Name = "txtAmountofDownPayment"
        Me.txtAmountofDownPayment.Size = New System.Drawing.Size(171, 29)
        Me.txtAmountofDownPayment.TabIndex = 4
        '
        'lblNumberofMonth
        '
        Me.lblNumberofMonth.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNumberofMonth.Location = New System.Drawing.Point(27, 124)
        Me.lblNumberofMonth.Name = "lblNumberofMonth"
        Me.lblNumberofMonth.Size = New System.Drawing.Size(100, 23)
        Me.lblNumberofMonth.TabIndex = 2
        Me.lblNumberofMonth.Text = "Number of Months"
        '
        'lblDownpayment
        '
        Me.lblDownpayment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDownpayment.Location = New System.Drawing.Point(27, 81)
        Me.lblDownpayment.Name = "lblDownpayment"
        Me.lblDownpayment.Size = New System.Drawing.Size(132, 23)
        Me.lblDownpayment.TabIndex = 1
        Me.lblDownpayment.Text = "Amount of Down Payment"
        '
        'lblCostVehicle
        '
        Me.lblCostVehicle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCostVehicle.Location = New System.Drawing.Point(27, 36)
        Me.lblCostVehicle.Name = "lblCostVehicle"
        Me.lblCostVehicle.Size = New System.Drawing.Size(100, 23)
        Me.lblCostVehicle.TabIndex = 0
        Me.lblCostVehicle.Text = "Cost of Vehicle"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Location = New System.Drawing.Point(654, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Annual Interest"
        '
        'lblAnnualRate
        '
        Me.lblAnnualRate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAnnualRate.BackColor = System.Drawing.Color.White
        Me.lblAnnualRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnnualRate.Location = New System.Drawing.Point(654, 108)
        Me.lblAnnualRate.Name = "lblAnnualRate"
        Me.lblAnnualRate.Size = New System.Drawing.Size(100, 23)
        Me.lblAnnualRate.TabIndex = 4
        '
        'lstout
        '
        Me.lstout.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lstout.FormattingEnabled = True
        Me.lstout.Location = New System.Drawing.Point(49, 268)
        Me.lstout.Name = "lstout"
        Me.lstout.Size = New System.Drawing.Size(562, 160)
        Me.lstout.TabIndex = 5
        '
        'btnCalculator
        '
        Me.btnCalculator.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCalculator.Location = New System.Drawing.Point(49, 451)
        Me.btnCalculator.Name = "btnCalculator"
        Me.btnCalculator.Size = New System.Drawing.Size(112, 49)
        Me.btnCalculator.TabIndex = 6
        Me.btnCalculator.Text = "Calculator"
        Me.btnCalculator.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.Location = New System.Drawing.Point(201, 451)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(112, 49)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(344, 451)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 49)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPrevious.Location = New System.Drawing.Point(499, 451)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(112, 49)
        Me.btnPrevious.TabIndex = 9
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'FrmVehicleLoanCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 512)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculator)
        Me.Controls.Add(Me.lstout)
        Me.Controls.Add(Me.lblAnnualRate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpVehicleLoanInfo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FrmVehicleLoanCalculator"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpVehicleLoanInfo.ResumeLayout(False)
        Me.grpVehicleLoanInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents grpVehicleLoanInfo As GroupBox
    Friend WithEvents lblCostVehicle As Label
    Friend WithEvents txtCostofvehicle As TextBox
    Friend WithEvents txtNumberofMonths As TextBox
    Friend WithEvents txtAmountofDownPayment As TextBox
    Friend WithEvents lblNumberofMonth As Label
    Friend WithEvents lblDownpayment As Label
    Friend WithEvents rdoUsed As RadioButton
    Friend WithEvents rdoNew As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAnnualRate As Label
    Friend WithEvents lstout As ListBox
    Friend WithEvents btnCalculator As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnPrevious As Button
End Class
