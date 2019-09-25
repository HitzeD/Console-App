
Option Explicit On
Option Strict On



Namespace Models
	
	Public Class BankAccount
    
		Private id As Integer
        Private fname As String
        Private lname As String
        Private amount As Double
        
        Public Sub New(ByVal first As String, ByVal last As String, ByVal initial As Double)
            id = 200
            Me.fname = first
            Me.lname = last
            Me.amount = initial
        End Sub
        
        Public Function GetId() As String
            Return $"{id}"
        End Function
        
        Public Sub SetName(ByVal first As String, ByVal last As String)
            fname = first
            lname = last
        End Sub
        
        Public Function GetName() As String
            Return $"{fname} {lname}"
        End Function
        
        Public Function Purchase(ByVal purAmount As Double) As String
            amount -= purAmount
            Return $"You spent {purAmount}, You have {amount} left!"
        End Function
        
        Public Function Deposit(ByVal depAmount As Double) As String
            amount += depAmount
            Return $"You deposited {depAmount}, You now have {amount}!"
        End Function
        
	End Class
End Namespace
