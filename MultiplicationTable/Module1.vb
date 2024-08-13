Imports System.Diagnostics.Eventing.Reader

Module Module1
    Enum TableModes
        Ten = 10
        Hundred = 100
        Thousand = 1000
    End Enum

    Sub Main()

        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.WriteLine("-------- Help Table Modes --------")
        System.Console.ForegroundColor = ConsoleColor.Green
        System.Console.WriteLine("1 - Ten By Ten Multiplication Table = ten")
        System.Console.ForegroundColor = ConsoleColor.Blue
        System.Console.WriteLine("2 - Hundred By Hundred Multiplication Table = hundred")
        System.Console.ForegroundColor = ConsoleColor.DarkRed
        System.Console.WriteLine("3 - Thousand By Thousand Multiplication Table = thousand")
        System.Console.ForegroundColor = ConsoleColor.Gray
        System.Console.WriteLine("-------------------------------------------------------")
        System.Console.ForegroundColor = ConsoleColor.Cyan
        System.Console.Write("Enter the table type : ")
        System.Console.ForegroundColor = ConsoleColor.Yellow
        Dim mode As String = System.Console.ReadLine().ToLower()
        Dim number As Integer = 10

        If mode = "ten" Then
            number = TableModes.Ten
        ElseIf mode = "hundred" Then
            number = TableModes.Hundred
        ElseIf mode = "thousand" Then
            number = TableModes.Thousand
        End If
        System.Console.ForegroundColor = ConsoleColor.Gray
        System.Console.WriteLine("-------------------------------------------------------")

        System.Console.ForegroundColor = ConsoleColor.Black
        System.Console.BackgroundColor = ConsoleColor.Gray
        For i As Integer = 1 To number

            For j As Integer = 1 To number
                System.Console.Write(i * j & vbTab)
            Next

            System.Console.WriteLine()
        Next
        System.Console.BackgroundColor = ConsoleColor.Black
        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.WriteLine("-----------------------")
        System.Console.ForegroundColor = ConsoleColor.Red
        System.Console.WriteLine("Programmer : Amin Mirzaei - Github(UserName) : AminMirzaeiOne")
        System.Console.ReadKey()
    End Sub

End Module
