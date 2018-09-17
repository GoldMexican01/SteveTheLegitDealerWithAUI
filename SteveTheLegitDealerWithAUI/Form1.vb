Public Class Form1
    Sub Main()
        Dim cardsuit As Integer
        Dim cardnum As Integer
        Dim suit As String
        Dim card As String
        Console.BackgroundColor = ConsoleColor.White
        For deal = 1 To 6
            Randomize()
            cardsuit = Int(4 * Rnd() + 1) 'this generates the suit
            Randomize()
            cardnum = Int(13 * Rnd() + 1)

            If cardsuit = "1" Then 'This gives the suit number a friendly name and a color
                suit = "Hearts"
                Console.ForegroundColor = ConsoleColor.DarkRed
            ElseIf cardsuit = "2" Then
                suit = "Diamonds"
                Console.ForegroundColor = ConsoleColor.DarkRed
            ElseIf cardsuit = "3" Then
                suit = "Clubs"
                Console.ForegroundColor = ConsoleColor.Black
            ElseIf cardsuit = "4" Then
                suit = "Spades"
                Console.ForegroundColor = ConsoleColor.Black
            End If

            If cardnum = "1" Then 'This gives the card number a friendly name
                card = "Ace"
            ElseIf cardnum = "11" Then
                card = "Jack"
            ElseIf cardnum = "12" Then
                card = "Queen"
            ElseIf cardnum = "13" Then
                card = "King"
            Else
                card = cardnum
            End If

            Console.WriteLine(card & " of " & suit)
        Next
        Console.ReadLine()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
End Class
