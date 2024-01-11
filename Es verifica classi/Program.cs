using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Es_verifica_classi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Giocatore giocatore1 = new Giocatore();
            Console.WriteLine("Inserisci nome giocatore: ");
            giocatore1.Nome = Console.ReadLine();
            Console.WriteLine("\nInserisci congnome giocatore: ");
            giocatore1.Cognome = Console.ReadLine();
        }
    }
}
