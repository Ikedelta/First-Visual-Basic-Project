Public Class Form3
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        lblTime.Text = ProgressBar1.Value & "Completing"

        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Timer2.Start()

            Me.Hide()
            frmLogin.Show()
        End If


        If ProgressBar1.Value = 90 Then
            lblTime.Text = ProgressBar1.Value & "Getting Ready"
        End If

        If ProgressBar1.Value = 91 Then
            lblTime.Text = ProgressBar1.Value & "Getting Ready"
        End If

        If ProgressBar1.Value = 92 Then
            lblTime.Text = ProgressBar1.Value & "Getting Ready"
        End If

        If ProgressBar1.Value = 93 Then
            lblTime.Text = ProgressBar1.Value & "Getting Ready"
        End If

        If ProgressBar1.Value = 94 Then
            lblTime.Text = ProgressBar1.Value & "Getting Ready"
        End If

        If ProgressBar1.Value = 95 Then
            lblTime.Text = ProgressBar1.Value & "Getting Ready"
        End If

        If ProgressBar1.Value = 96 Then
            lblTime.Text = ProgressBar1.Value & "Getting Ready"
        End If

        If ProgressBar1.Value = 97 Then
            lblTime.Text = ProgressBar1.Value & "Getting Ready"
        End If

        If ProgressBar1.Value = 98 Then
            lblTime.Text = ProgressBar1.Value & "Getting Ready"
        End If

        If ProgressBar1.Value = 99 Then
            lblTime.Text = ProgressBar1.Value & "Done"
        End If




    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0
        Timer1.Start()
    End Sub

End Class