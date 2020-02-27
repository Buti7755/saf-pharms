Public Class mainPage
    Private Sub mainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox(Me.Width.ToString + " " + ListView1.Width.ToString)
        DisplayTimer.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        loginPanel.Dispose()
        menuPanel.Show()
        TitleAndDatePanel.Show()


    End Sub

    Private Sub employeeButton_Click(sender As Object, e As EventArgs) Handles employeeButton.Click
        employeePanel.Show()
        AddorEditEmployeePanel.Show()
    End Sub

    Private Sub DisplayTimer_Tick(sender As Object, e As EventArgs) Handles DisplayTimer.Tick
        displayDateLabel.Text = Date.Now.ToString("dd MMM yyyy   hh:mm:ss")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Panel1.Dispose()
        AddorEditEmployeePanel.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Panel1.Show()
        AddorEditEmployeePanel.Dispose()
    End Sub
End Class