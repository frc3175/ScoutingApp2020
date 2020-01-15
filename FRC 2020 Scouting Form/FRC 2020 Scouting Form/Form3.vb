Public Class tele
    Dim fouls, high, low, balance As Integer
    Private Sub BtnSubHighTele_Click(sender As Object, e As EventArgs) Handles btnSubHighTele.Click
        If Not high <= 0 Then
            high -= 1
        End If
        txtHighTele.Text = CStr(high)
    End Sub

    Private Sub BtnAddHighTele_Click(sender As Object, e As EventArgs) Handles btnAddHighTele.Click
        high += 1
        txtHighTele.Text = CStr(high)
    End Sub

    Private Sub BtnBalanceSub_Click(sender As Object, e As EventArgs) Handles btnBalanceSub.Click
        If Not balance <= 0 Then
            balance -= 1
        End If
        txtLevelBots.Text = CStr(balance)
    End Sub

    Private Sub BtnBalanceAdd_Click(sender As Object, e As EventArgs) Handles btnBalanceAdd.Click
        If Not balance >= 2 Then
            balance += 1
        End If
        txtLevelBots.Text = CStr(balance)
    End Sub

    Private Sub BtnSubFouls_Click(sender As Object, e As EventArgs) Handles btnSubFouls.Click
        If Not fouls <= 0 Then
            fouls -= 1
        End If
        txtFouls.Text = CStr(fouls)
    End Sub

    Private Sub BtnAddFouls_Click(sender As Object, e As EventArgs) Handles btnAddFouls.Click
        fouls += 1
        txtFouls.Text = CStr(fouls)
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ''6=tele low
        ''7=tele high
        ''8=fouls
        ''9=climbed
        ''10=level
        ''11=teams balanced with
        ''12=control panel stage 2
        ''13=control panel stage 3
        ''14=broken robot
        ''15=lost communication
        ''16=defense
        Dim climb, lvl, panel2, panel3, broken, comms, defense, onBar As Integer
        Dim noteTake As String = txtNotes.Text
        If chkClimb.Checked Then
            climb = 1
        Else
            climb = 0
        End If
        If chkLevel.Checked Then
            lvl = 1
        Else
            lvl = 0
        End If
        If chkStg2.Checked Then
            panel2 = 1
        Else
            panel2 = 0
        End If
        If chkStg3.Checked Then
            panel3 = 1
        Else
            panel3 = 0
        End If
        If chkBroken.Checked Then
            broken = 1
        Else
            broken = 0
        End If
        If chkComms.Checked Then
            comms = 1
        Else
            comms = 0
        End If
        defense = trkDefense.Value
        If chkClimb.Checked Then
            onBar = trkOnBar.Value
        Else
            onBar = 0
            balance = 0
        End If
        Form1.submitTeleOpStats(low, high, fouls, climb, lvl, balance, panel2,
                                panel3, broken, comms, defense, onBar, noteTake)
        auton.Close()
        Close()
    End Sub

    Private Sub ChkLevel_CheckedChanged(sender As Object, e As EventArgs) Handles chkLevel.CheckedChanged
        If Not chkClimb.Checked Then
            chkLevel.Checked = False
        End If
    End Sub

    Private Sub BtnAddLowTele_Click(sender As Object, e As EventArgs) Handles btnAddLowTele.Click
        low += 1
        txtLowTele.Text = CStr(low)
    End Sub

    Private Sub Tele_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fouls = 0
        high = 0
        low = 0
        balance = 0
        txtFouls.Text = CStr(fouls)
        txtHighTele.Text = CStr(high)
        txtLowTele.Text = CStr(low)
        txtLevelBots.Text = CStr(balance)
    End Sub

    Private Sub BtnSubLowTele_Click(sender As Object, e As EventArgs) Handles btnSubLowTele.Click
        If Not low <= 0 Then
            low -= 1
        End If
        txtLowTele.Text = CStr(low)
    End Sub
End Class