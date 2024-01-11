using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_verifica_classi
{
    internal class Squadra
    {
        public int IdentificativoNumerico { get; set; }
        public string NomeAlfanumerico { get; set; }
        public List<Giocatore> Giocatori { get; set; }

    }
}
