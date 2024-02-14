using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier4
{
    internal class Lune : Astre, IComparable, IOrbitable
    {

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom"> Nom de la lune </param>
        /// <param name="rayon"> Rayon de la lune </param>
        /// <param name="masse"> Masse de la lune </param>
        public Lune(string nom, double rayon, double masse) : base(nom, rayon, masse)
        {

        }

        public override int NbElements()
        {
            int nbElement = 0;

            for (int i= 0; i < this._satellites.Length; i++)
            {
                if (this._satellites[i] != null)
                    nbElement++;
            }
            return nbElement;
        }

        /// <summary>
        /// Vérifie si la lune est plus volumineuse qu'une autre
        /// </summary>
        /// <param name="l1"> lune à comparer </param>
        /// <returns> Retourne faux si moins volumineuse et vrai si plus volumineuse </returns>
        public bool estPlusVolumineuse(Lune l1)
        {
            if (this.Volume < l1.Volume)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Vérifie si la lune est plus dense qu'une autre
        /// </summary>
        /// <param name="l1"> lune à comparer </param>
        /// <returns> Retourne faux si moins dense et vrai si plus dense </returns>
        public bool estPlusDense(Lune l1)
        {
            if (this.MasseVolumique < l1.MasseVolumique)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Vérifie si la lune est identique selon son nom, son rayon et sa masse à une autre
        /// </summary>
        /// <param name="l1"> lune à comparer </param>
        /// <returns> Vrai si elle est identique et faux si pas identique </returns>
        public bool estIdentique(Lune l1)
        {
            if (this.Nom == l1.Nom && this.Rayon == l1.Rayon && this.Masse == l1.Masse)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Vérifie si la lune est plus petite qu'une autre lune selon sa masse
        /// </summary>
        /// <param name="l1"> lune à comparer </param>
        /// <returns> Retourne faux si plus petite et vrai si plus grande </returns>
        public bool estPlusPetite(Lune l1)
        {
            if (this.Masse < l1.Masse)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Vérifie si la lune est plus grande qu'une autre lune selon sa masse
        /// </summary>
        /// <param name="l1"> lune à comparer </param>
        /// <returns> Retourne faux si plus grande et faux si plus petite </returns>
        public bool estPlusGrande(Lune l1)
        {
            if (this.Masse > l1.Masse)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Vérifie si une lune est égale avec une autre selon sa superficie
        /// </summary>
        /// <param name="l1"> lune à vérifier </param>
        /// <returns></returns>
        public bool estEgale(Lune l1)
        {
            if (this.Superficie == l1.Superficie)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Vérifie si la lune est égale à une autre selon son nom, son rayon et sa masse
        /// </summary>
        /// <param name="obj"> Objet de type lune </param>
        /// <returns> Retourne vrai si égale et faux si pas égale </returns>
        public override bool Equals(object obj)
        {
            if (this.Nom == ((Lune)obj).Nom && this.Rayon == ((Lune)obj).Rayon && this.Masse == ((Lune)obj).Masse)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Compare le rayon de la lune à une autre
        /// </summary>
        /// <param name="obj"> lune à comparer </param>
        /// <returns> Retourne 1 si le rayon est plus grand, -1 si plus petit et 0 si égale </returns>
        public int CompareTo(Object obj)
        {
            if (this.Rayon > ((Lune)obj).Rayon)
                return 1;
            else if (this.Rayon < ((Lune)obj).Rayon)
                return -1;
            else
                return 0;
        }

        /// <summary>
        /// Afficher les information de la lune
        /// </summary>
        /// <returns> Information de la lune </returns>
        public override string ToString()
        {
            return "Lune : " + this._nom + " Rayon : " + this._rayon + " Masse : " + this._masse;
        }

        public static bool operator ==(Lune l1, Lune l2)
        {
            return l1.Equals(l2);
        }

        public static bool operator !=(Lune l1, Lune l2)
        {
            return !l1.Equals(l2);
        }

        public static bool operator <(Lune l1, Lune l2)
        {
            return l1.Rayon < l2.Rayon;
        }

        public static bool operator >(Lune l1, Lune l2)
        {
            return l1.Rayon > l2.Rayon;
        }

        public static bool operator <=(Lune l1, Lune l2)
        {
            return l1.Rayon <= l2.Rayon;
        }

        public static bool operator >=(Lune l1, Lune l2)
        {
            return l1.Rayon >= l2.Rayon;
        }
    }
}
