' Imports the System.Diagnostics.Eventing.Reader namespace (not used in this code)
Imports System.Diagnostics.Eventing.Reader

' This line declares a module named Module1
Module Module1

    ' This enumeration defines different table size options for multiplication tables
    ' - Ten: Represents a 10x10 table
    ' - Hundred: Represents a 100x100 table
    ' - Thousand: Represents a 1000x1000 table
    Enum TableModes
        Ten = 10
        Hundred = 100
        Thousand = 1000
    End Enum

    ' This line defines the Main subroutine, which is the entry point of the program
    Sub Main()

        ' Set the foreground color of the console output to Magenta
        System.Console.ForegroundColor = ConsoleColor.Magenta

        ' Display a title for the table mode options
        System.Console.WriteLine("-------- Help Table Modes --------")

        ' Set different foreground colors for each table mode option in the menu
        System.Console.ForegroundColor = ConsoleColor.Green
        System.Console.WriteLine("1 - Ten By Ten Multiplication Table = ten")
        System.Console.ForegroundColor = ConsoleColor.Blue
        System.Console.WriteLine("2 - Hundred By Hundred Multiplication Table = hundred")
        System.Console.ForegroundColor = ConsoleColor.DarkRed
        System.Console.WriteLine("3 - Thousand By Thousand Multiplication Table = thousand")
        System.Console.ForegroundColor = ConsoleColor.Gray
        System.Console.WriteLine("-------------------------------------------------------")

        ' Set the foreground color to Cyan for user input prompt
        System.Console.ForegroundColor = ConsoleColor.Cyan
        System.Console.Write("Enter the table type : ")

        ' Set the foreground color to Yellow for user input
        System.Console.ForegroundColor = ConsoleColor.Yellow

        ' Read user input, convert it to lowercase, and store it in the string variable 'mode'
        Dim mode As String = System.Console.ReadLine().ToLower()

        ' Define a default table size (10 by 10)
        Dim number As Integer = 10

        ' Use an If-ElseIf structure to determine the table size based on user input
        If mode = "ten" Then
            number = TableModes.Ten ' Set table size to 10
        ElseIf mode = "hundred" Then
            number = TableModes.Hundred ' Set table size to 100
        ElseIf mode = "thousand" Then
            number = TableModes.Thousand ' Set table size to 1000
        End If

        ' Display a separator line
        System.Console.ForegroundColor = ConsoleColor.Gray
        System.Console.WriteLine("-------------------------------------------------------")

        ' Set background color to Gray and foreground color to Black for table output
        System.Console.ForegroundColor = ConsoleColor.Black
        System.Console.BackgroundColor = ConsoleColor.Gray

        ' Nested loops to iterate through the rows and columns of the table
        For i As Integer = 1 To number
            For j As Integer = 1 To number
                ' Calculate the product of i and j and write it with a tab character for spacing
                System.Console.Write(i * j & vbTab)
            Next j
            ' Move to the next line after each row is printed
            System.Console.WriteLine()
        Next i

        ' Reset background color to Black and set foreground color to Magenta for separator
        System.Console.BackgroundColor = ConsoleColor.Black
        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.WriteLine("-----------------------")

        ' Set foreground color to Red for programmer information
        System.Console.ForegroundColor = ConsoleColor.Red
        System.Console.WriteLine("Programmer : Amin Mirzaei - Github(UserName) : AminMirzaeiOne")

        ' Pause the console window until the user presses any key
        System.Console.ReadKey()

    End Sub

End Module
