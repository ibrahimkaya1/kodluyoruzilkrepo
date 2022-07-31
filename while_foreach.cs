using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        
        int sayac=5;
       while(sayac<=5)
       {
            Console.WriteLine(sayac);
            sayac++;
       }
       int[] sayiDizisi = {2,4,5,1,2,4};
       int toplam = 0 ;

       foreach(int i in SayiDizisi)
       {
           toplam += i ;
       }
       Console.WriteLine(toplam);
    }
}
