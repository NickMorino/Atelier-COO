using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier4
{
    internal class Soleil : AstreCoeur, IOrbitable, ICloneable
    {
        double _couronne; // Taille de la couronne

        public Soleil(string nom, double rayon, double masse, double coeur, double couronne) : base(nom, rayon, masse, coeur)
        {
            _couronne = couronne;
        }

        public override int NbElements()
        {
            int nbElement = 0;

            for (int i = 0; i < this._satellites.Length; i++)
            {
                if (this._satellites[i] != null)
                    nbElement++;
            }
            return nbElement;

        }
    }
}
