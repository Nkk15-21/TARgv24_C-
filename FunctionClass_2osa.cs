using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C
{
    internal class FunctionClass_2osa
    {
        // ----------------------------------------------------------------

        public static List<string> Sõnad()
        {
            List<string> sonad = new List<string>();
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("Nimi: ");
                sonad.Add(Console.ReadLine());
            }
            return sonad;
        }

        // ----------------------------------------------------------------

        public static isik[] isikud(int k, string[] nimed, string[] aadressid)
        {
            isik[] isikud = new isik[k];

            for (int i = 0; i < k;i++)
            {
                Console.WriteLine(i);
                Console.Write("Isikukood: ");
                isikud[i] = new isik
                {
                    Nimi = nimed[i],
                    Vanus = i + 10,
                    Isikukood = Console.ReadLine(),
                    Aadress = aadressid[i]
                };
            }
            return isikud;
                
        }

        // ---------------------------9/1-------------------------------------

        public static List<int> ArvudeRuudud() // создаём список для чисел
        {
            int[] arvud = { 2, 4, 6, 8, 10, 12 }; //библиотека чисел
            List<int> ruudud = new List<int>(); //создаём список квадратов чисел и новый список куда будем писать

            for (int i = 0; i < arvud.Length; i++) 
                // начинаем с нуля,  не меньше того, что в массиве arvud, + 1 каждый раз
            {
                ruudud.Add(arvud[i] * arvud[i]);// добавляем в список квадратов(число[i] в квадрат)
            }

            return ruudud;
        }

        // ----------------------------9/2------------------------------------

        public static List<int> Kahekordsed() // создаём список для чисел
        {
            int[] arvud = { 2, 4, 6, 8, 10, 12 }; //массив чисел
            List<int> topelt = new List<int>(); // создаём список для результатов 

            foreach (int arv in arvud) // берём отдельное число, а не весь массив
            {
                topelt.Add(arv * 2); //доюавляем в список topelt(умноженое число а)
            }

            return topelt;
        }

        // ------------------------------9/3----------------------------------

        public static int KolmegaJaguvad() // создаём список для чисел
        {
            int[] arvud = { 2, 4, 6, 8, 10, 12 }; //массив чисел
            int loendur = 0; // счётчик
            int i = 0;

            while (i < arvud.Length) // Пока i меньше длины массива — продолжаем.
            {
                if (arvud[i] % 3 == 0) // проверка, делится ли число на 3 без остатка.
                {
                    loendur++; //если да, то добавляем к счётчику +1
                }
                i++; // обязательно увеличиваем i, иначе цикл будет бесконечным).
            }

            return loendur; //возвращаем, сколько чисел делится на 3.
        }

        // -------------------------------10/1-----------------------------------

        public static void PosNegNull()
        {
            int[] arvud = { 5, -3, 0, 8, -1, 4, -7, 2, 0, -5, 6, 9 };

            int positiivsed = 0;
            int negatiivsed = 0;
            int nullid = 0;

            foreach (int arv in arvud) //перебираем каждый arv из arvud
            {
                if (arv > 0)
                    positiivsed++;
                else if (arv < 0)
                    negatiivsed++;
                else
                    nullid++;
            }

            Console.WriteLine($"Positiivseid: {positiivsed}");
            Console.WriteLine($"Negatiivseid: {negatiivsed}");
            Console.WriteLine($"Nulle: {nullid}");
        }


        //---------------------------------11------------------------------

        public static void KeskmisestSuuremad()
        {
            Random rnd = new Random(); // генератор рандома чисел
            int[] arvud = new int[15]; // создаём массив на 15 чисел (всё пока 0)

            for (int i = 0; i < arvud.Length; i++)
            {
                arvud[i] = rnd.Next(1, 101); // случайное число от 1 до 100
            }

            int summa = 0;
            foreach (int arv in arvud)
            {
                summa += arv;
            }

            double keskmine = (double)summa / arvud.Length; // (double) — обязательно, иначе получится целое число (с округлением).
            Console.WriteLine($"Keskmine väärtus: {keskmine:F2}"); // F2 — выводим 2 знака после запятой.

            Console.WriteLine("\nSuuremad kui keskmine:"); // Перебираем массив и печатаем только те числа, которые больше среднего.
            foreach (int arv in arvud)
            {
                if (arv > keskmine)
                {
                    Console.Write(arv + " ");
                }
            }

            Console.WriteLine("\n\nArvude do-while väljastamine (kuni < 10):"); // do-while — цикл, который всегда срабатывает хотя бы один раз.

            int j = 0;
            do
            {
                Console.Write(arvud[j] + " ");
                j++;
            } while (j < arvud.Length && arvud[j - 1] >= 10); // остановка, если число < 10
        }

        // ---------------------------------------------12----------------------------------------

        public static void LeiaSuurimArvJaIndeks()
        {
            int[] numbrid = { 12, 56, 78, 2, 90, 43, 88, 67 };

            int suurim = numbrid[0];   // предполагаем, что первый — самый большой
            int indeks = 0;            // и его индекс — 0

            for (int i = 1; i < numbrid.Length; i++) // начинаем с i = 1
            {
                if (numbrid[i] > suurim)
                {
                    suurim = numbrid[i]; // нашли число побольше — обновляем
                    indeks = i;          // и сохраняем его индекс
                }
            }

            Console.WriteLine($"Suurim arv: {suurim}");
            Console.WriteLine($"Selle indeks massiivis: {indeks}");
        }

        // -------------------------------------- 13 ----------------------------------------------

        public static void PaarisJaPaaritu()
        {
            Random rnd = new Random();
            List<int> numbrid = new List<int>();

            // Заполняем список случайными числами
            for (int i = 0; i < 20; i++)
            {
                numbrid.Add(rnd.Next(1, 51)); // от 1 до 50 включительно
            }

            int paaris = 0;    // счётчик чётных
            int paaritu = 0;   // счётчик нечётных

            foreach (int arv in numbrid)
            {
                if (arv % 2 == 0)
                    paaris++;
                else
                    paaritu++;
            }

            // Выводим список
            Console.WriteLine("Genereeritud arvud:");
            foreach (int arv in numbrid)
            {
                Console.Write(arv + " ");
            }

            Console.WriteLine($"\n\nPaarisarvude kogus: {paaris}");
            Console.WriteLine($"Paaritud arvude kogus: {paaritu}");
        }


        // ------------------------------- 4.osa ----------------------------------

        public static void FailiTooKuudega()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");

            // 1. Записываем 3 месяца
            if (!File.Exists(path))
            {
                File.WriteAllLines(path, new string[] { "Mai", "Juuni", "Juuli" });
                Console.WriteLine("Esimesed kuud kirjutatud faili.");
            }

            // 2. Читаем файл в список
            List<string> kuude_list = new List<string>();
            try
            {
                foreach (string rida in File.ReadAllLines(path))
                {
                    kuude_list.Add(rida);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
                return;
            }

            // 3. Удаляем "Juuni"
            kuude_list.Remove("Juuni");

            // 4. Меняем 1-й элемент
            if (kuude_list.Count > 0)
                kuude_list[0] = "Veeel kuuu";

            // 5. Печатаем всё
            Console.WriteLine("--------------Kuud peale muutmist-----------");
            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }

            // 6. Поиск
            Console.WriteLine("Sisesta kuu nimi, mida otsida:");
            string otsitav = Console.ReadLine();

            if (kuude_list.Contains(otsitav))
                Console.WriteLine("Kuu " + otsitav + " on olemas.");
            else
                Console.WriteLine("Sellist kuud pole.");

            // 7. Сохраняем изменения обратно
            File.WriteAllLines(path, kuude_list);
            Console.WriteLine("Andmed on salvestatud.");
        }
    












    }
}
