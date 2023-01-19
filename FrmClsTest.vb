Imports System.ComponentModel

Public Class FrmClsTest

    Dim WithEvents Tester1 As New Class1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Tester1.subGo()

    End Sub

    Private Sub Tester1_Pop(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tester1.Pop

        'メッセージボックス表示
        MsgBox("Pop!")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sCol(2) As String
        Dim sBox As String

        sCol(0) = TextBox1.Text
        sCol(1) = TextBox2.Text
        sCol(2) = TextBox3.Text

        'コメント
        Call setColor(sCol)

        sBox = c1.nametest & vbCrLf
        sBox = sBox & c2.nametest & vbCrLf
        sBox = sBox & c3.nametest

        TextBox4.Text = sBox
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call POPCODE.POP_CODE()
    End Sub
End Class