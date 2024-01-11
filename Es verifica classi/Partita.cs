using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_verifica_classi
{
    internal class Partita
    {
        public Squadra Squadra1 { get; set; }
        public Squadra Squadra2 { get; set; }
        public int Punteggio1 { get; set; }
        public int Punteggio2 { get; set; }
        public DateTime Data { get; set; }

        public Squadra SquadraVincente()
        {
            if (Punteggio1 > Punteggio2)
            {
                return Squadra1;
            }
            else 
            { 
                return Squadra2;
            }  
        }
    }
}
