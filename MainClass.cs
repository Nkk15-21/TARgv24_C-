using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {


            //IV. osa

            //14 — Faili kirjutamine

            Console.WriteLine("\n--- Faili töö kuudega ---");
            FunctionClass_2osa.FailiTooKuudega();





            ////Доподнительнро задание

            ////9-1
            //Console.WriteLine("Ruutude arvutamine (for):");
            //List<int> ruudud = FunctionClass_2osa.ArvudeRuudud();
            //foreach (var r in ruudud)
            //    Console.WriteLine(r);

            ////9-2
            //Console.WriteLine("\nKahekordsed väärtused (foreach):");
            //List<int> topelt = FunctionClass_2osa.Kahekordsed();
            //foreach (var t in topelt)
            //    Console.WriteLine(t);

            ////9-3
            //Console.WriteLine("\nKolmega jaguvad arvud (while):");
            //int jaguvateArv = FunctionClass_2osa.KolmegaJaguvad();
            //Console.WriteLine($"Kokku: {jaguvateArv}");


            ////10
            //Console.WriteLine("\nPositiivsed, negatiivsed ja nullid (foreach):");
            //FunctionClass_2osa.PosNegNull();


            ////11
            //Console.WriteLine("\n--- Keskmisest suuremad ja do-while osa ---");
            //FunctionClass_2osa.KeskmisestSuuremad();


            ////12
            //Console.WriteLine("\n--- Suurima arvu ja indeksi leidmine (for) ---");
            //FunctionClass_2osa.LeiaSuurimArvJaIndeks();


            ////13
            //Console.WriteLine("\n--- Paaris ja paaritu loendus (List, foreach) ---");
            //FunctionClass_2osa.PaarisJaPaaritu();




            ////II.osa

            //List<string> sonad = FunctionClass_2osa.Sõnad();
            //foreach (var item in sonad)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("---------------------------------");

            ////-----------------------------------------------------------------

            //isik isik1 = new isik("Juku", 65, "12345678987", "Tallinn");
            //isik1.PrindiInfo();
            //isik isik2 = new isik();
            //isik2.Nimi = "Mari";
            //isik2.Aadress = "Tartu";
            //isik2.Isikukood = "98765432100";
            //isik2.Sugu = Sugu.Naine;
            //isik2.PrindiInfo();

            ////--------------------------------------------------------------------

            //int i;
            //string[] nimed = new string[10] { "a", "b", "c", "d", "e", "f", "g", "h", "j", "k" };
            //string[] aadressid = new string[10] { "Tallinn", "Tartu", "Pärnu", "Narva", "Kohtla", "Jõhvi", "Ahtme", "Rakvere", "Moskva", "Saint-Petersburg" };
            //Console.WriteLine("----------for++Massiv-------");
            //isik[] isikud = FunctionClass_2osa.isikud(nimed.Length, nimed, aadressid);

            //for (i = 0; i < nimed.Length; i++)
            //{
            //    isikud[i].PrindiInfo();
            //}

            ////-------------------------------------------------------------------------

            //Console.WriteLine("----------for--List-------");
            //List<isik> isikud2 = new List<isik>();
            //for (int j = i-1; j > -1; j--)
            //{
            //    Console.WriteLine(j);
            //    isik isik = new isik
            //    {
            //        Nimi = nimed[j],
            //        Vanus = j + 10,
            //        Isikukood = "12345678950",
            //        Aadress = aadressid[j]
            //    };
            //    isikud2.Add(isik);
            //}
            //foreach (var isik in isikud2)
            //{
            //    isik.PrindiInfo();
            //}



            //Console.WriteLine("------while------");
            //while (i>=0)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}
            //for (i=0; i<10; i++)
            //{
            //    isikud[i].PrindiInfo();
            //}

            //Console.WriteLine("-----------for-----------");





            ///*Console.BackgroundColor = ConsoleColor.Green;
            //Console.ForegroundColor = ConsoleColor.Blue;*/
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("Tere! Hea Päev! Привет!");
            //// I.osa Andmetüübd, If, Case, Random, Alamfunktsioonid
            //int a = 0;
            //string tekst = "Python";
            //char taht= 'A';
            //Console.WriteLine("Double arv: ");
            //double arv = Convert.ToDouble(Console.ReadLine());
            ////double.TryParse(Console.ReadLine(), out double arv)
            //Console.WriteLine("Float arv: ");
            //float arv1 = (float)Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Mis on sinu nimi? ");
            //tekst = Console.ReadLine();
            //Console.WriteLine("Tere!\n"+tekst);
            //Console.WriteLine("Tere!\n {0}",tekst);
            //FunktsioonideClass.Juku(tekst);
            //Console.Write("Arv 2: ");
            //int arv2=int.Parse(Console.ReadLine());
            ////Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);
            //arv1=FunktsioonideClass.Kalkulaator(a, arv2);
            //Console.WriteLine(arv1);
            //Console.WriteLine("Switch'i kasutamine");
            //Random rnd = new Random();
            //a=rnd.Next(1,7);
            //Console.WriteLine(a);
            //tekst=FunktsioonideClass.Nadala_paev(a);
            //Console.WriteLine(tekst);
            //Console.ReadKey();
        }

    }

}
