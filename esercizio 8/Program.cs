using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_8
{
    internal class Program
    {
        public struct Veicoli
        {
            public string nome;
            public float km;
            public float consumi;
        }
        public static Veicoli[] v;
        public static int d;
        static void Main(string[] args)
        {
            
            Console.WriteLine("Inserire numero veicoli: ");
            int d=int.Parse(Console.ReadLine());
            
            for (int i = 0; i < d; i++)
            {
                Console.WriteLine("Inserire nome veicoli: ");
                v[i].nome = Console.ReadLine();
                Console.WriteLine("Inserire chilometri percorsi: ");
                v[i].km = float.Parse(Console.ReadLine());
                Console.WriteLine("Inserire litri consumati: ");
                v[i].consumi=float.Parse(Console.ReadLine());
                int x = Convert.ToInt32(v[i].km / v[i].consumi);
                Console.WriteLine("Consumo medio: " + x);
            }
        }
    }
}
