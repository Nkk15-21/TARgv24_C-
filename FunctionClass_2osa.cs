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

    }
}
