using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier4
{
    internal abstract class Astre : CorpCeleste
    {
        protected double _rayon;
        protected double _masse;

        public Astre(string nom, double rayon, double masse) : base(nom)
        {
            _rayon = rayon;
            _masse = masse;
        }

        /// <summary>
        /// Retourne le rayon ou modifie le rayon si valeur est plus grand que 0
        /// </summary>
        public double Rayon
        {
            get { return _rayon; }
            set
            {
                if (value > 0)
                    _rayon = value;
            }
        }

        /// <summary>
        /// Retourne la masse ou modifie la masse si valeur est plus grand que 0.
        /// </summary>
        public double Masse
        {
            get { return _masse; }
            set
            {
                if (value > 0)
                    _masse = value;
            }
        }

        /// <summary>
        /// Retourne la superficie de l'astre
        /// </summary>
        public double Superficie
        {
            get { return 4 * (_rayon * 2) * Math.PI; }
        }

        /// <summary>
        /// Retourne le volume de la l'astre
        /// </summary>
        public double Volume
        {
            get { return 4 / (3 * Math.PI * Math.Pow(_rayon, 3)); }
        }

        /// <summary>
        /// Retourne la masse volumique de l'astre
        /// </summary>
        public double MasseVolumique
        {
            get { return _masse / Volume; }
        }
    }
}
