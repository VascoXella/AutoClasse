using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClasse
{
    internal class Proprietario: Persona
    {
        public List<Macchina> Macchine { get; set; }
    }
}
