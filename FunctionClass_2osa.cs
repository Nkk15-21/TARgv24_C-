using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C
{
    internal class FunctionClass_2osa
    {
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

    }
}
