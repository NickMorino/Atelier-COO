using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier4
{
    internal abstract class CorpCeleste
    {
        protected string _nom; // Nom du corps celeste

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom"> Nom du corps celeste </param>
        public CorpCeleste (string nom)
        {
            _nom = nom;
        }

        /// <summary>
        /// Accesseur
        /// </summary>
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
    }
}
