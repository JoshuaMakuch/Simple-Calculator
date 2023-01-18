'Joshua Makuch
'RCET0265
'Fall 2023
'Simple Calculator
'
Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Please Pick a Number:")
        Dim num1 As Integer = Console.ReadLine()
        Console.WriteLine("Please Pick a Second Number:")
        Dim num2 As Integer = Console.ReadLine()
        Console.WriteLine("Choose one of the following options:")
        Console.WriteLine("1. Sum")
        Console.WriteLine("2. Product")
        Dim choice As Integer = Console.ReadLine()
        If choice = 1 Then
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}")
        ElseIf choice = 2 Then
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}")
        End If
    End Sub
End Module
