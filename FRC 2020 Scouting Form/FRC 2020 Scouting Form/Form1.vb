Imports System.IO
Imports System.Text
Public Class Form1

    Structure Match
        Dim matchNo As Integer
        Dim red1 As Integer
        Dim red2 As Integer
        Dim red3 As Integer
        Dim blue1 As Integer
        Dim blue2 As Integer
        Dim blue3 As Integer
    End Structure
    Dim stats(17) As Integer
    Dim notes(1) As String
    Dim matches(199) As Match
    Dim matchNo As Integer
    Dim team As Integer
    ''stats numbers
    ''0=crossed
    ''1=auto low
    ''2=auto high
    ''3=auto extra grabbed
    ''4=grabbed from rendevous
    ''5=grabbed from trench
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

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        matchNo = CInt(matchList.SelectedItem)
        For Each matchCheck In matches
            If matchCheck.matchNo = matchNo Then
                If red1Rad.Checked Then
                    team = matchCheck.red1
                ElseIf red2Rad.Checked Then
                    team = matchCheck.red2
                ElseIf red3Rad.Checked Then
                    team = matchCheck.red3
                ElseIf blue1Rad.Checked Then
                    team = matchCheck.blue1
                ElseIf blue2Rad.Checked Then
                    team = matchCheck.blue2
                Else
                    team = matchCheck.blue3
                End If
            End If
        Next
        auton.txtTeamNumber.Text = CStr(team)
        tele.txtTeamNumber.Text = CStr(team)
        auton.Show()
    End Sub

    Sub LoadMatches()
        Dim fileName = "matchlist.txt"
        Dim sr As IO.StreamReader = IO.File.OpenText(fileName)
        Dim i As Integer = 0
        Do While (sr.Peek() <> -1)
            Dim line As String = sr.ReadLine()
            Dim data() As String = line.Split(","c)
            matches(i).matchNo = CInt(data(0))
            matches(i).red1 = CInt(data(1))
            matches(i).red2 = CInt(data(2))
            matches(i).red3 = CInt(data(3))
            matches(i).blue1 = CInt(data(4))
            matches(i).blue2 = CInt(data(5))
            matches(i).blue3 = CInt(data(6).Trim)
            i += 1
        Loop
        ReDim Preserve matches(i)
        matchList.Items.Clear()
        For Each mat In matches
            Dim num As Integer = mat.matchNo
            matchList.Items.Add(num)
        Next
        matchList.Items.RemoveAt(matchList.Items.Count - 1)

    End Sub

    Sub submitAutoStats(crossed As Integer, aLow As Integer, aHigh As Integer, aEGrab As Integer,
                        aRen As Integer, aTrench As Integer, noteTake As String)
        ''stats numbers
        ''0=crossed
        ''1=auto low
        ''2=auto high
        ''3=auto extra grabbed
        ''4=grabbed from rendevous
        ''5=grabbed from trench
        stats(0) = crossed
        stats(1) = aLow
        stats(2) = aHigh
        stats(3) = aEGrab
        stats(4) = aRen
        stats(5) = aTrench
        notes(0) = noteTake
    End Sub

    Sub submitTeleOpStats(low As Integer, high As Integer, fouls As Integer, climbed As Integer,
                               level As Integer, balancedW As Integer, panel2 As Integer, panel3 As Integer,
                               broken As Integer, comms As Integer, defense As Integer, onBar As Integer, note As String)
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
        ''17=spotonBar
        stats(6) = low
        stats(7) = high
        stats(8) = fouls
        stats(9) = climbed
        stats(10) = level
        stats(11) = balancedW
        stats(12) = panel2
        stats(13) = panel3
        stats(14) = broken
        stats(15) = comms
        stats(16) = defense
        stats(17) = onBar
        notes(1) = note
        submitStats()
    End Sub
    Sub submitStats()
        Dim data As String = CStr(team) + "|" + CStr(matchNo) + "|"
        For Each stat In stats
            data += CStr(stat) + "|"
        Next
        For Each note In notes
            data += note + "|"
        Next
        Dim fPath = "data.txt"
        Dim afile As New StreamWriter(fPath, True)
        afile.WriteLine(data)
        afile.Close()
        If matchList.SelectedIndex < matchList.Items.Count - 1 Then
            matchList.SelectedIndex += 1
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMatches()
    End Sub
End Class
