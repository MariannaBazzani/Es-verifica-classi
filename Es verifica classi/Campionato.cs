using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_verifica_classi
{
    internal class Campionato
    { 
        public List<Squadra> Squadre{ get; set; }
        public List<Partita> Partite { get; set; }

        public int VittorieSquadraCounter(Squadra s)
        {
            int partiteVinte = 0;
            foreach (var Partita in Partite)
            {
                if (Partita.SquadraVincente() == s)
                {
                    partiteVinte++;
                }
            }

            return partiteVinte;
        }

        public Squadra SquadraInTesta()
        {
            Squadra squadraVincente = Squadre[0];
            if(squadraVincente == null)
            {
                return null;
            }
            else
            {
                foreach (var Squadra in Squadre)
                {
                    if (VittorieSquadraCounter(Squadra) > VittorieSquadraCounter(squadraVincente))
                    {
                        squadraVincente = Squadra;
                    }
                }
            }

            return squadraVincente;
        }
    }
}
