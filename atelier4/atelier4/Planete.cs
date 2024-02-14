using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier4
{
    internal class Planete : AstreCoeur, IComparable, ICloneable
    {
        private Lune[] _listeLune; // Liste de lune
        private int _nbLune; // Nombre de lunes
       
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom"> Nom de la planète </param>
        /// <param name="rayon"> Rayon de la planète </param>
        /// <param name="masse"> Masse de la planète </param>
        public Planete(string nom, double rayon, double masse, double coeur) : base(nom, rayon, masse, coeur)
        {
            _listeLune = new Lune[3];
            _nbLune = 0;
        }

        public override int NbElements()
        {
            int nbElement = _listeLune.Length;

            for (int i = 0; i < _listeLune.Length; i++)
            {
                if (!(this._listeLune[i] is null))
                    nbElement += _listeLune[i].NbElements();
            }
            return nbElement;
        }

        /// <summary>
        /// Vérifie si la planète est plus volumineuse qu'une autre
        /// </summary>
        /// <param name="p1"> Planète à comparer </param>
        /// <returns> Retourne faux si moins volumineuse et vrai si plus volumineuse </returns>
        public bool estPlusVolumineuse(Planete p1)
        {
            if (this.Volume < p1.Volume)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Vérifie si la planète est plus dense qu'une autre
        /// </summary>
        /// <param name="p1"> Planète à comparer </param>
        /// <returns> Retourne faux si moins dense et vrai si plus dense </returns>
        public bool estPlusDense(Planete p1)
        {
            if (this.MasseVolumique < p1.MasseVolumique)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Vérifie si la planète est identique selon son nom, son rayon et sa masse à une autre
        /// </summary>
        /// <param name="p1"> Planète à comparer </param>
        /// <returns> Vrai si elle est identique et faux si pas identique </returns>
        public bool estIdentique(Planete p1)
        {
            if (this.Nom == p1.Nom && this.Rayon == p1.Rayon && this.Masse == p1.Masse)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Vérifie si la planète est plus petite qu'une autre planète selon sa masse
        /// </summary>
        /// <param name="p1"> Planète à comparer </param>
        /// <returns> Retourne faux si plus petite et vrai si plus grande </returns>
        public bool estPlusPetite(Planete p1)
        {
            if (this.Masse < p1.Masse)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Vérifie si la planète est plus grande qu'une autre planète selon sa masse
        /// </summary>
        /// <param name="p1"> Planète à comparer </param>
        /// <returns> Retourne faux si plus grande et faux si plus petite </returns>
        public bool estPlusGrande(Planete p1)
        {
            if (this.Masse > p1.Masse)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Vérifie si une planète est égale avec une autre selon sa superficie
        /// </summary>
        /// <param name="p1"> Planète à vérifier </param>
        /// <returns></returns>
        public bool estEgale(Planete p1)
        {
            if (this.Superficie == p1.Superficie)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Vérifie si la planète est égale à une autre selon son nom, son rayon et sa masse
        /// </summary>
        /// <param name="obj"> Objet de type planète </param>
        /// <returns> Retourne vrai si égale et faux si pas égale </returns>
        public override bool Equals(object obj)
        {
            if (this.Nom == ((Planete)obj).Nom && this.Rayon == ((Planete)obj).Rayon && this.Masse == ((Planete)obj).Masse)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Compare le rayon de la planète à une autre
        /// </summary>
        /// <param name="obj"> Planète à comparer </param>
        /// <returns> Retourne 1 si le rayon est plus grand, -1 si plus petit et 0 si égale </returns>
        public int CompareTo(Object obj)
        {
            if (this.Rayon > ((Planete)obj).Rayon)
                return 1;
            else if (this.Rayon < ((Planete)obj).Rayon)
                return -1;
            else
                return 0;
        }

     

        public Lune this[int index]
        {
            get
            {
                if (index >= 0 && index < _nbLune)
                    return _listeLune[index];
                else
                {
                    Console.WriteLine("Le tableau de lune est plein.");
                    return null;
                }
            }
        }

        /// <summary>
        /// Afficher les information de la planète
        /// </summary>
        /// <returns> Information de la planète </returns>
        public override string ToString()
        {
            return "Planète : " + this._nom + " Rayon : " + this._rayon + " Masse : " + this._masse;
        }

        public static Planete operator +(Planete p1, Lune l1)
        {
            if (p1._nbLune < p1._listeLune.Length)
            {
                p1._listeLune[p1._nbLune] = l1;
                p1._nbLune++;
            }
            else
            {
                Console.WriteLine("Le tableau de lune est plein.");
            }
            return p1;
        }

        public static bool operator <(Planete p1, Planete p2)
        {
            return p1.Rayon < p2.Rayon;
        }

        public static bool operator >(Planete p1, Planete p2)
        {
            return p1.Rayon > p2.Rayon;
        }

        public static bool operator <=(Planete p1, Planete p2)
        {
            return p1.Rayon <= p2.Rayon;
        }

        public static bool operator >=(Planete p1, Planete p2)
        {
            return p1.Rayon >= p2.Rayon;
        }

    }
}
