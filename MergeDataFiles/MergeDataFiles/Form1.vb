Imports System.IO

Public Class Form1

    Dim fileName As String

    Structure Match
        Dim matchNo As Integer
        Dim team As Integer
    End Structure
    Dim matches(9999) As Match
    Private Sub Merge(sender As Object, e As EventArgs) Handles btnMerge.Click
        Dim sr As StreamReader = File.OpenText("data.txt")
        Dim i As Integer = 0
        Do While (sr.Peek() <> -1)
            Dim line As String = sr.ReadLine()
            Dim data() As String = line.Split("|"c)
            matches(i).matchNo = CInt(data(0))
            matches(i).team = CInt(data(1))
            i += 1
        Loop
        sr.Close()
        Dim sr2 As StreamReader = File.OpenText(fileName)
        Dim afile As New StreamWriter("data.txt", True)
        Dim there As Boolean
        Do While (sr2.Peek() <> -1)
            Dim line As String = sr2.ReadLine()
            Dim data() As String = line.Split("|"c)
            there = False
            For Each m In matches
                If data(0) = m.matchNo Then
                    If data(1) = m.team Then
                        there = True
                    End If
                End If
            Next
            If there = False Then
                matches(i).matchNo = CInt(data(0))
                matches(i).team = CInt(data(1))
                afile.WriteLine(line)
                i += 1
            End If
        Loop
        sr2.Close()
        afile.Close()
        ReDim Preserve matches(i)
        txtFileName.Text = "Merged Successfully!"
    End Sub

    Private Sub GetFile(sender As Object, e As EventArgs) Handles btnSelectFile.Click
        OpenFileDialog1.ShowDialog()
        fileName = OpenFileDialog1.FileName
        txtFileName.Text = fileName

    End Sub
End Class
