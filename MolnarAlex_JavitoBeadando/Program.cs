using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolnarAlex_JavitoBeadando
{
    internal class Program
    {
        static void F01(string[] szavak)
        {
            Random r = new Random();
            
            
            
            for (int i = 0; i < szavak.Length; i++)
            {
                szavak[i] = RandomSzavak(r);
            }

            
        }

        static string RandomSzavak(Random random)
        {
            string betuk = "abcdefghjklmnop";
            char[] szo = new char[10];

            for (int i = 0;i < 10; i++)
            {
                szo[i] = betuk[random.Next(betuk.Length)];
            }

             return new string(szo);
            


        }




        static void Main(string[] args)
        {
            string[] keszSzavak = new string[15];

            F01(keszSzavak);
            
            foreach(string szo  in keszSzavak)
            {
                Console.WriteLine(szo);
            }



            Console.ReadKey();
        }
    }
}
