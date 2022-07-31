using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        
       int gun = DateTime.Now.Day;

       switch(gun)
       {
        case 1:
            Console.WriteLine("Ayın ilk günü");
            break;
        case 15:
            Console.WriteLine("Ayın 15 i çiğköfte sevenlerin günü :) ");
            break;
        case 30:
            Console.WriteLine("Ayın Sonuna geldik");
            break;
        default :
            Console.WriteLine($"Ayın {gun}. günü");
            break;
       }
    
    }
}
