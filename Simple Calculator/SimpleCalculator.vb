'Joshua Makuch
'RCET0265
'Fall 2023
'Simple Calculator
'https://github.com/JoshuaMakuch/Simple-Calculator.git

Option Explicit On
Option Strict On

Imports System

Module SimpleCalculator
    Sub Main(args As String())

        Dim firstUserInput As Double
        Dim secondUserInput As Double
        Dim operatorChoice As Double

        Console.WriteLine("Please Pick a Number:") 'Assumes the user inputs a number and not an invalid value
        firstUserInput = CDbl(Console.ReadLine())
        Console.WriteLine("Please Pick a Second Number:")
        secondUserInput = CDbl(Console.ReadLine())
        Console.WriteLine("Choose one of the following options:")
        Console.WriteLine("1. Sum")
        Console.WriteLine("2. Product")

        'If the user input a valid option it will do it, but there is no way to check if it will crash
        'This reflects how bad of a coder I was and how much I've grown
        operatorChoice = CDbl(Console.ReadLine())
        If operatorChoice = 1 Then
            Console.WriteLine($"{firstUserInput} + {secondUserInput} = {firstUserInput + secondUserInput}")
        ElseIf operatorChoice = 2 Then
            Console.WriteLine($"{firstUserInput} * {secondUserInput} = {firstUserInput * secondUserInput}")
        End If

    End Sub
End Module
