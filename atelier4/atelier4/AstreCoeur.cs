using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier4
{
    internal abstract class AstreCoeur : Astre
    {

        double _coeur; // Rayon du coeur

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="rayon"> </param>
        /// <param name="masse"> </param>
        /// <param name="coeur"> </param>
        public AstreCoeur(string nom, double rayon, double masse, double coeur) : base (nom, rayon, masse)
        {
            _coeur = coeur;
        }
    }
}
