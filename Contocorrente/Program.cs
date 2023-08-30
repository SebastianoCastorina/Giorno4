using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Contocorrente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Come ti chiami?");
               string Nome=Console.ReadLine();
             Console.WriteLine("Cognome?");
               string Cognome =Console.ReadLine();
            Contocorrente NomeConto = new Contocorrente( Nome, Cognome);
            int choice = 0;
            while (choice !=5)
            {
                Console.WriteLine("SCEGLI L'OPERAZIONE DA EFFETTUARE");
                Console.WriteLine("1 --- Apri un Nuovo Conto Corrente");
                Console.WriteLine("2 --- Effettua un Versamento");
                Console.WriteLine("3 --- Se li hai, effettua un Prelievo");
                Console.WriteLine("4 --- Mostra Saldo");
                Console.WriteLine("5 --- Esci");
                 choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Per aprire un nuovo conto ti servono minimo 1000 euro, inserisci l'ammontare");
                    double Ammontare = Convert.ToDouble(Console.ReadLine());
                    NomeConto.AprireConto(Ammontare);

                }
                else if (choice == 2)
                {
                    Console.WriteLine("Quanto vuoi Depositare?");
                    double Ammontare = Convert.ToDouble(Console.ReadLine());
                    NomeConto.Versamento(Ammontare);
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Quanto vuoi Prelevare?");
                    double SoldiPrelevati = Convert.ToDouble(Console.ReadLine());
                    NomeConto.Prelievo(SoldiPrelevati);
                }
                else if (choice == 4)
                {
                    Console.WriteLine($"Il tuo Saldo è {NomeConto.Saldo}");
                
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Ritirare la carta entro 30 secondi, l'operazione è stata conclusa");
                }
                else
                {
                    Console.WriteLine("La scelta non è valida");
                }

            }




        }
    }
}
