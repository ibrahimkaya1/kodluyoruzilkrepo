
using System;

public class ArtirTopla
{
    public static void Main(string[] args)
    {
        int x = 3;
        int y = 4;
        int sonuc = Topla(ref x, ref y);
        
        int Topla(ref int x, ref int y)
        {
            x+=1;
            y+=y;
            return (x+y);
        }
       Console.WriteLine(sonuc);
    }
}