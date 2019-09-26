Imports System
Imports ConsoleApp.Models

Public Class Application

	Public Shared Sub Main()
    
		Dim cust1 As BankAccount
        Dim quit AS Boolean
        Dim fname As String
        Dim lname As String
        Dim initial As String
        
        Console.WriteLine("What is your First Name: ")
        fname = Console.ReadLine()
        Console.WriteLine("What is your Last Name: ")
        lname = Console.ReadLine()
        Console.WriteLIne("How much is the initial deposit: ")
        initial = Console.ReadLine()
        
        cust1 = New BankAccount(fname, lname, CDbl(initial))
        
        quit = True
        while quit
        
            Dim temp As String
            Dim deptemp As String
            'Dim lower As String
            Console.WriteLine($"Hello {cust1.GetName()}, What would you like to do?: (Q)uit, (D)eposit, (P)urchase, (A)mount")
            temp = Console.ReadLine()
            'lower = LCase(temp)
            
            If (temp = "q") Then
            
                quit = False
                
            ElseIf (temp = "d") Then
            
                Console.WriteLine("Deposit Amount: ")
                deptemp = Console.ReadLine()
                cust1.Deposit(CDbl(deptemp))
                
            ElseIf (temp = "p") Then
            
                Console.WriteLine("Purchase Amount: ")
                deptemp = Console.ReadLine()
                cust1.Purchase(CDbl(deptemp))
                
            ElseIf (temp = "a") Then
            
                cust1.GetAmount()
                
            End If
        End while
        
        
	End Sub
End Class
