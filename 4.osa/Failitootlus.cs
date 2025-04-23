using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TARgv24_C-
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");
                using (StreamWriter text = new StreamWriter(path, true))
                {
                    Console.WriteLine("Sisesta mingi tekst: ");
                    string lause = Console.ReadLine();
                    text.WriteLine(lause);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mingi viga failiga: " + ex.Message);
            }
        }
    }
}
