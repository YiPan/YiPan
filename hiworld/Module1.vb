Module Module1

    'Sub Main()
    'Dim i, num, sum As Integer
    'Console.Write("請輸入總人數")
    'num = Val(Console.ReadLine())
    'Dim tall(num - 1) As Integer
    'For i = 0 To tall.GetUpperBound(0)
    '    Console.Write("請輸入第{0}位身高:", (i + 1).ToString())
    '    tall(i) = Val(Console.ReadLine())
    'Next
    'For Each height As Integer In tall
    '    sum += height
    'Next
    'Console.WriteLine("平均身高:{0}", CInt((sum / num)).ToString())
    'Console.ReadLine()

    'Function getwelcome(ByVal username As String, ByVal ismale As Boolean) As String
    '    If ismale Then
    '        Return username & "先生，歡迎光臨!"
    '    Else
    '        getwelcome = username & "小姐，歡迎光臨!"
    '    End If
    '   End Function

    Sub main()
        '       Dim name As String = "王曉華", welcome As String
        '       welcome = getwelcome(name, True)
        '       Console.WriteLine(welcome)
        '       Console.WriteLine()
        '       Console.WriteLine(getwelcome("李每每", False))
        '       Console.Read()
        Console.WriteLine("1,5,3中最大樹是{0}", getmax(1, 5, 3).tostring())
        Console.WriteLine()
        Console.WriteLine("10,5,3,100,23中最大數是{0}", getmax(10, 5, 3, 100, 23).ToString())
        Console.Read()
    End Sub

    Function getmax(ByVal ParamArray x() As Integer) As Integer
        Dim max As Integer
        max = x(0)
        For i As Integer = 1 To x.Length - 1
            If x(i) > max Then
                max = x(i)
            End If
        Next
        Return max

    End Function
End Module
