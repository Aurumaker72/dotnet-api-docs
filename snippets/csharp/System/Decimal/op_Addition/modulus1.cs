﻿// <Snippet19>
using System;

public class Example
{
   public static void Main()
   {
      Decimal number1 = 16.8m;
      Decimal number2 = 4.1m;
      Decimal number3 = number1 % number2;
      Console.WriteLine("{0:N2} % {1:N2} = {2:N2}",
                        number1, number2, number3);
   }
}
// The example displays the following output:
//        16.80 % 4.10 = 0.40
// </Snippet19>
