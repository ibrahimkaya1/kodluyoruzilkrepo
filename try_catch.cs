using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        
        try
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a+b; 
            Console.WriteLine(c);
        } 
        catch(Exception ex)
        {   
            Console.WriteLine("Bir Hata Oluştu " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Operasyon Tamamlandı.");
        }
    
    }
}
