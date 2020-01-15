Public Class auton
    Dim extra, high, low, max As Integer

    Private Sub BtnAddLowAuto_Click(sender As Object, e As EventArgs) Handles btnAddLowAuto.Click
        If Not low >= max Then
            low += 1
        End If
        txtLowAuto.Text = CStr(low)
    End Sub

    Private Sub BtnSubHighAuto_Click(sender As Object, e As EventArgs) Handles btnSubHighAuto.Click
        If Not high <= 0 Then
            high -= 1
        End If
        txtHighAuto.Text = CStr(high)
    End Sub

    Private Sub BtnAddHighAuto_Click(sender As Object, e As EventArgs) Handles btnAddHighAuto.Click
        If Not high >= max Then
            high += 1
        End If
        txtHighAuto.Text = CStr(high)
    End Sub

    Private Sub BtnExtraSubLow_Click(sender As Object, e As EventArgs) Handles btnExtraSubLow.Click
        If Not extra <= 0 Then
            extra -= 1
        End If
        txtExtraBalls.Text = CStr(extra)
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ''stats numbers
        ''0=crossed
        ''1=auto low
        ''2=auto high
        ''3=auto extra grabbed
        ''4=grabbed from rendevous
        ''5=grabbed from trench
        Dim cr, ren, tren As Integer
        If radMove.Checked Then
            cr = 1
        Else
            cr = 0
        End If
        If chkRend.Checked Then
            ren = 1
        Else
            ren = 0
        End If
        If chkTrench.Checked Then
            tren = 1
        Else
            tren = 0
        End If
        Dim nt As String = txtNotes.Text
        Form1.submitAutoStats(cr, low, high, extra, ren, tren, nt)
        tele.Show()
    End Sub

    Private Sub BtnAddExtra_Click(sender As Object, e As EventArgs) Handles btnAddExtra.Click
        If Not extra >= max Then
            extra += 1
        End If
        txtExtraBalls.Text = CStr(extra)
    End Sub

    Private Sub Auton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        extra = 0
        high = 0
        low = 0
        max = 10
        txtExtraBalls.Text = CStr(extra)
        txtHighAuto.Text = CStr(high)
        txtLowAuto.Text = CStr(low)
    End Sub

    Private Sub BtnSubLowAuto_Click(sender As Object, e As EventArgs) Handles btnSubLowAuto.Click
        If Not low <= 0 Then
            low -= 1
        End If
        txtLowAuto.Text = CStr(low)
    End Sub
End Class