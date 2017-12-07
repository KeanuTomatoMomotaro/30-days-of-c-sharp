using System;
using System.Collections.Generic;
using System.IO;

class Solution {
  static void Main(String[] args){
    int i = 4;
    double d = 4.0;
    string s = "HackerRank ";
    
    // Declare second integer, double, and String variables.
    int x = 0;
    double y = 0.0;
    string z = "";
    
    // Read and save an integer, double, and String to your variables.
    string x1 = Console.ReadLine();
    x = int.Parse(x1);
    string y1 = Console.ReadLine();
    y = double.Parse(y1);
    z = Console.ReadLine();
    
    // Print the sum of both integer variables on a new line.
    Console.WriteLine(i+x);
    
    // Print the sum of the double variables on a new line.
    Console.WriteLine("{0:F1}", d+y);
    
    // Concatenate and print the String variables on a new line
    // The 's' variable above should be printed first.
    
    Console.WriteLine(s+z);
  }
}
