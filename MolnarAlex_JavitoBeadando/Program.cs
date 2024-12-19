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

        static int[,] F03 (string[] szavak)
        {
            int[,] matrix = new int[szavak.Length,2];

            for (int i = 0; i < szavak.Length; i++)
            {
                string szo = szavak[i];
                int maganhangzok = f03maganhangzok(szo);
                int massalhangzok = szo.Length - maganhangzok;

                matrix[i, 0] = maganhangzok;
                matrix[i, 1] = massalhangzok;
            }

            return matrix;

        }

        static int f03maganhangzok (string szo)
        {
            int db = 0;
            string maganhangzok = "aáeéiíoóöőuúüű";

            foreach(char i in szo)
            {
                if (maganhangzok.Contains(i))
                {
                    db++;
                }
            }

            return db;
        }

        static void F04(string[] szavak)
        {
            Array.Sort(szavak);

            for (int i = 0;i < szavak.Length; i++)
            {
                Console.WriteLine(szavak[i]);
            }
        }

        static void F05(string[] szavak)
        {
            double atlag = F02(szavak);
            Console.WriteLine($"Ennyi szóban volt átlagoasan 2 db magánhangzó: {atlag}");

            int[,] matrix = F03(szavak);
            Console.WriteLine("Szavanként ennyi magán és mássalhangzó található a tömbben: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine($"Szó {i+1}: Magánhangzók: {matrix[i,0]}, Mássálhangzók: {matrix[i,1]}");
            }

            F04(szavak) ;
        }


        static void Main(string[] args)
        {
            string[] keszSzavak = new string[15];

            F01(keszSzavak);

            foreach (string szo in keszSzavak)
            {
                Console.WriteLine(szo);
            }


            string[] szavak = { "medve", "kutya", "macska", "telefon", "asztalilámpa", "gépház", "egér", "monitor", "papucs", "tengerimalac", "autó", "tea", "ing", "póló","túrórudi" };
            double eredmeny = F02(szavak);
            Console.WriteLine("Átlagosan ennyi szóban van pontosan 2 magánhangzó: "+eredmeny);


            int[,] f03eredmeny = F03(szavak);
            for (int i = 0; i < f03eredmeny.GetLength(0); i++)
            {
                Console.WriteLine($"Szó {i+1}: Maganhangzók: {f03eredmeny[i,0]}, Mássalhangzók: {f03eredmeny[i,1]}");
            }

            F04(szavak);

            F01(szavak);
            F05(szavak);






            Console.ReadKey();
        }
    }
}
