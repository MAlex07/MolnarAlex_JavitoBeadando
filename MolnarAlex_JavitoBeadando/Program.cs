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


        static double F02(string[] tomb)
        {
            double atlag = 0;
            int db = 0;

            foreach(string szo in tomb)
            {
                int maganhangzokszama = maganhangzokSzama(szo);

                if (maganhangzokszama == 2)
                {
                    db++;
                }
            }
            if (tomb.Length > 0)
            {
                atlag = (double)db / tomb.Length;
            }

            return Math.Round(atlag,2);
        }

        static int  maganhangzokSzama (string szo)
        {
            int db = 0;
            string maganhangzok = "aáeéoóöőuúüűií";

            foreach (char i in szo)
            {
                if (maganhangzok.Contains(i))
                {
                    db++;
                }
            }
            return db;
        }




        static void Main(string[] args)
        {
            string[] keszSzavak = new string[15];

            F01(keszSzavak);

            foreach (string szo in keszSzavak)
            {
                Console.WriteLine(szo);
            }


            string[] szavak = { "medve", "kutya", "macska", "telefon", "asztalilámpa" };
            double eredmeny = F02(szavak);
            Console.WriteLine("Átlagosan ennyi szóban van pontosan 2 magánhangzó: "+eredmeny);


            Console.ReadKey();
        }
    }
}
