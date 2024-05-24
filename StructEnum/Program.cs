using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEnum
{
    internal class Program
    {
        public enum Giorno
        {
            Lunedi,
            Martedi,
            Mercoledi,
            Giovedi,
            Venerdi,
            Sabato,
            Domenica
        }

        public struct Product
        {
            public double Prezzo;
            public string Name;
        }
        static void printDay(Giorno x)
        {
            Console.WriteLine("x={0}", x);
            Console.WriteLine("x={0}", (int)x);
        }
        static void Main(string[] args)
        {
            Product pesce = new Product();
            pesce.Prezzo = 12.22;
            pesce.Name = "Pesce";

            Giorno x = Giorno.Lunedi;
            foreach (var item in Enum.GetValues(typeof(Giorno)))
            {
                Console.WriteLine("{0} {1}", (int)item, item);
            }
            
            printDay(Giorno.Martedi);
            Console.Read();
        }
    }
}
