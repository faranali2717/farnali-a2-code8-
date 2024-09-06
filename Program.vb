Imports System.Console
'Create a currency converter where the number of pounds is entered and the procedure 
'calculates the number Of Euros. Assume the exchange rate Of £1 = €1.15. 
'Adjust your program To allow any exchange rate.

Module Program
    Sub Main()
        Dim pounds, euros As Double
        WriteLine("enter number of pounds")
        pounds = ReadLine()
        euros = pounds * 1.15
        WriteLine(euros)
        ReadKey()


    End Sub
End Module
