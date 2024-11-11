/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class table {
  static void Main() {
    Console.WriteLine("Multiplication Tables");
     int num = Convert.ToInt32(Console.ReadLine());
      num=6;
          for (int i = 2; i <= 10; i++) {
           Console.WriteLine(num + " x " + i + " = " + num * i);
        }

    }
}