Public Class FrmMembershipCal
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblM.Click

    End Sub

    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        'For the Standard Adult Radio Button
        If rdoStandardAdult.Checked = True Then
            lblM.Text = 40

            'For just one Tick in a checkbox
            If chkYoga.Checked = True Then
                lblM.Text = 40 + 10
            End If

            If chkKarate.Checked = True Then
                lblM.Text = 40 + 30
            End If

            If chkPersonalTrainer.Checked = True Then
                lblM.Text = 40 + 50
            End If

            'for two check
            If chkYoga.Checked AndAlso chkKarate.Checked = True Then
                lblM.Text = 40 + 10 + 30
            End If

            If chkYoga.Checked AndAlso chkPersonalTrainer.Checked = True Then
                lblM.Text = 40 + 10 + 50
            End If

            If chkKarate.Checked AndAlso chkPersonalTrainer.Checked = True Then
                lblM.Text = 40 + 30 + 50
            End If

            'for three ticks in checkbox
            If chkPersonalTrainer.Checked AndAlso chkPersonalTrainer.Checked AndAlso chkYoga.Checked = True Then
                lblM.Text = 40 + 10 + 30 + 50
            End If



            'for the Child radio button
        ElseIf rdoChild.Checked = True Then
            lblM.Text = 20

            'for just one check
            If chkYoga.Checked = True Then
                lblM.Text = 20 + 10
            End If

            If chkKarate.Checked = True Then
                lblM.Text = 20 + 30
            End If

            If chkPersonalTrainer.Checked = True Then
                lblM.Text = 20 + 50
            End If

            'for two check
            If chkYoga.Checked AndAlso chkKarate.Checked = True Then
                lblM.Text = 20 + 10 + 30
            End If

            If chkYoga.Checked AndAlso chkPersonalTrainer.Checked = True Then
                lblM.Text = 20 + 10 + 50
            End If

            If chkKarate.Checked AndAlso chkPersonalTrainer.Checked = True Then
                lblM.Text = 20 + 30 + 50
            End If

            'for three check
            If chkYoga.Checked AndAlso chkKarate.Checked AndAlso chkPersonalTrainer.Checked = True Then
                lblM.Text = 20 + 10 + 30 + 50
            End If

            'for student radio button
        ElseIf rdoStudent.Checked = True Then
            lblM.Text = 25

            'for one check

            If chkYoga.Checked = True Then
                lblM.Text = 25 + 10
            End If

            If chkKarate.Checked = True Then
                lblM.Text = 25 + 30
            End If

            If chkPersonalTrainer.Checked = True Then
                lblM.Text = 25 + 50
            End If

            'for two check
            If chkYoga.Checked AndAlso chkKarate.Checked = True Then
                lblM.Text = 25 + 10 + 30
            End If

            If chkYoga.Checked AndAlso chkPersonalTrainer.Checked = True Then
                lblM.Text = 25 + 10 + 50
            End If

            If chkKarate.Checked AndAlso chkPersonalTrainer.Checked = True Then
                lblM.Text = 25 + 30 + 50
            End If

            'for three check
            If chkYoga.Checked AndAlso chkKarate.Checked AndAlso chkPersonalTrainer.Checked = True Then
                lblM.Text = 25 + 10 + 30 + 50
            End If
        ElseIf rdoSeniorCitizen.Checked = True Then
            lblM.Text = 30

            'for one check
            If chkYoga.Checked = True Then
                lblM.Text = 30 + 10
            End If

            If chkKarate.Checked = True Then
                lblM.Text = 30 + 30
            End If

            If chkPersonalTrainer.Checked = True Then
                lblM.Text = 30 + 50
            End If

            'for two check
            If chkYoga.Checked AndAlso chkKarate.Checked = True Then
                lblM.Text = 30 + 10 + 30
            End If

            If chkYoga.Checked AndAlso chkPersonalTrainer.Checked = True Then
                lblM.Text = 30 + 10 + 50
            End If

            If chkKarate.Checked AndAlso chkPersonalTrainer.Checked = True Then
                lblM.Text = 30 + 30 + 50
            End If

            'for three check
            If chkKarate.Checked AndAlso chkYoga.Checked AndAlso chkPersonalTrainer.Checked = True Then
                lblM.Text = 30 + 10 + 30 + 50
            End If
        ElseIf chkKarate.Checked Or chkYoga.Checked Or chkPersonalTrainer.Checked = False Then
            MessageBox.Show("Select membership")

        End If


        lblT.Text = Integer.Parse(lblM.Text) * Integer.Parse(txtM.Text)


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtM.Clear()
        lblM.Text = String.Empty
        rdoChild.Checked = False
        rdoSeniorCitizen.Checked = False
        rdoStandardAdult.Checked = False
        rdoStudent.Checked = False
        chkKarate.Checked = False
        chkPersonalTrainer.Checked = False
        chkYoga.Checked = False
        lblT.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do you wish to continue", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmHome.Show()
    End Sub


End Class
