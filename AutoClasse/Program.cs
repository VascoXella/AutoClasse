using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Macchina a1 = new Macchina();
            Macchina a2 = new Macchina();
            Macchina a3 = new Macchina();

            //dato il colore, trova il modello di macchina corrispondente

            a1.Modello = "FIAT";
            a1.Colore = "Giallo";
            a2.Modello = "Ferrari";            
            a2.Colore = "Rosso";
            a3 = a1;

            foreach (Macchina m in Macchina)
            {
                if(m.Colore == "Rosso")
                {
                    Console.WriteLine("{0}", m.Modello);
                }
            }


            Console.ReadLine();
        }
    }
}
