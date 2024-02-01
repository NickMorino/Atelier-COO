using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier4
{
    internal class Galaxie : CorpCeleste
    {
        private SystemeSolaire[] _systemeSolaires;
        private string _type;
        private int nbSystemeSolaires;

        public Galaxie(string nom, string type) : base(nom)
        {
            _type = type;
        }
        
            
    }
}
