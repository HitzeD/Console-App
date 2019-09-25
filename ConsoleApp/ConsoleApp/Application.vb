Imports System
Imports ConsoleApp.Models

Public Class Application
	Public Shared Sub Main()
		Dim cust1 As New BankAccount("Dakotah", "Hitze", 200.00)
        
        Console.WriteLine(cust1.GetName())
	End Sub
End Class
