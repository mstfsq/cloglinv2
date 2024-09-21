Imports System
Module Program
    
    
    dim  mPass, iPass as string
    dim tPrice as single
    dim sProd1 as string
    
    
    Sub Main(args As String())
        
        mPass = "D16661"
        
        Console.WriteLine("Welcome to the program,please enter the master password to continue")
        iPass = console.readline()
        
        
        Do while mpass <> iPass
            
            Console.WriteLine("Acess Denied.Please try again")
            ipass = console.ReadLine()
            
        Loop 
        
        Console.WriteLine("Access Granted.Welcome to the program")
        ' After this point the real program begins
        
        Console.WriteLine("    (  )   (   )  )
     ) (   )  (  (
     ( )  (    ) )
     _____________
    <_____________> ___
    |             |/ _ \
    |               | | |
    |               |_| |
 ___|             |\___/
/    \___________/    \
\_____________________/")
        
        
        tprice = 0
        
        
    Console.writeline("
Coffee-1.99
Tea-1.50")  
        
        dim rpt as string
        
  Console.WriteLine("Please enter the product you would like") 
   sProd1 = console.readline()
        
        do 
        
        if sProd1 = "Coffee"  Then
            tprice = tprice + 0.89
            
       else if sprod1 = "Tea"  then 
        tprice = tprice + 1.30

           
            
            
        End If
            
            Console.WriteLine("Would you like to order again?")
            rpt = console.ReadLine()
            
        loop while rpt = "yes"    
        
        Console.WriteLine("Your total price is " & tPrice )
        
        
        
                dim cash as Single
                dim change as Single
                dim owed as single
                dim rpay as single 
                dim roundedChange as single
        
       
        Console.writeline("Please input cash you would like to pay")
        cash = console.ReadLine()
        
        dim owedAmount as single
        dim pOwedAmount as single
        dim secondPayment as single
        
        change = cash - tprice 
        owedAmount = change * -1
        
        pOwedAmount = owedAmount
        
        
        
        
        
        
        if change >= 0 Then
            Console.WriteLine("Change is " & Math.Round(change,2))
        
        
        else if change < 0 Then
            
            
            do
            
            
           
            Console.WriteLine("You owe " & Math.Round(Powedamount, 2))
            
            Console.WriteLine("How much more would you like to pay")
            secondPayment = console.ReadLine()
                
                owedAmount= change + secondPayment
                
                pOwedAmount  = owedamount * -1
                
                
                
            loop until owedamount >= owedAmount
            
            
            
            
            
            
            
            
            
            
            
        End If
        
        Console.writeline("Thanks,Have a nice day")
        
        
        
        
            
            
            
        
        
        
        
        
        
        
        
        
        
        
        
    End Sub
End Module
