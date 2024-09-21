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
        
        if sProd1 = "Coffee" Then
            tprice = tprice + 1.99
            
       else if sprod1 = "Tea" then 
        tprice = tprice + 1.99

           
            
            
        End If
            
            Console.WriteLine("Would you like to order again?")
            rpt = console.ReadLine()
            
        loop while rpt = "yes"    
        
        Console.WriteLine("Your total price is " & tPrice )
        
        
        
                dim cash as Single
                dim change as Single
                dim Aowed as single
                dim rpay as single 
        Console.writeline("Please input cash you would like to pay")
        cash = console.ReadLine()
        
        
        
        change = cash - tprice 
        
        if change >= 0 Then
            Console.WriteLine("Change is " & change )
        End If
        
        
        do while 0 > change 
            aowed = change * -1
            
            Console.WriteLine("You owe " & aowed)
            
            Console.writeline("Please enter amount you would like to give")
            rpay = console.ReadLine()
            
            change = aowed + rpay
            
            
            
            
            
        loop 
        
        Console.writeline("Thanks,Have a nice day")
        
        
        
        
            
            
            
        
        
        
        
        
        
        
        
        
        
        
        
    End Sub
End Module
