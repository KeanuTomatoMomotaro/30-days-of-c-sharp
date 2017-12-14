using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var mealPrice = Convert.ToDouble(Console.ReadLine());
        var tipPercent = Convert.ToInt32(Console.ReadLine());
        var taxPercent = Convert.ToInt32(Console.ReadLine());
        
        var tip = mealPrice * tipPercent / 100;
        var tax = mealPrice * taxPercent / 100;
        
        var totalCost = Math.Round(mealPrice + tip + tax);
        
        Console.WriteLine("The total meal cost is {0} dollars.", totalCost);
    }
}
