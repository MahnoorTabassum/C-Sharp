/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class program 
{
    static void Main() 
    {
        int item1 = 900;
        int item2 = 800;
        int item3 = 2000;
        int item4 = 100;
        int item5 = 3500;

        int total = (item1+item2+item3+item4+item5);
        if (total > 5000){
            int discount = total* 5/ 100;
            int AfterDiscount = total - discount;
       Console.WriteLine("25% discount");
     Console.WriteLine("Discount applied: " + AfterDiscount);
  
        }
    }
}