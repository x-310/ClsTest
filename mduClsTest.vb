Public Class Class1
    Private m_ImpResult As String

    Public Enum Result
        RETURN_NOMAL
        RETURN_ABNORMAL
        RETURN_STAY
    End Enum
    Sub New()
        m_ImpResult = Result.RETURN_NOMAL
    End Sub

    Public Event Pop(ByVal sender As Object, ByVal e As EventArgs)
    Public Sub subGo()
        RaiseEvent Pop(Me, New EventArgs)
    End Sub

    Private name As String
    Public Property nametest() As String
        Get
            Return name
        End Get
        Set(ByVal value As String)
            name = value
        End Set
    End Property
End Class

Module Module1
    Public c1 As New Class1
    Public c2 As New Class1
    Public c3 As New Class1
    Public Sub setColor(ByVal sCol() As String)

        c1.nametest = sCol(0)
        c2.nametest = sCol(1)
        c3.nametest = sCol(2)

        'Console.WriteLine(c1.nametest) '赤
        'Console.WriteLine(c2.nametest) '黄
        'Console.WriteLine(c3.nametest) '青
    End Sub
End Module