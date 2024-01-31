using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier3
{
    internal class Planete : IComparable
    {
        private string _nom; // Nom de la planète
        private double _rayon; // Rayon de la planète
        private double _masse; // Masse de la planète terre
        private Lune[] _listeLune; // Liste de lune

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom"> Nom de la planète </param>
        /// <param name="rayon"> Rayon de la planète </param>
        /// <param name="masse"> Masse de la planète </param>
        public Planete(string nom, double rayon, double masse)
        {
            _nom = nom;
            _rayon = rayon;
            _masse = masse;
            _listeLune = new Lune[3];
        }

        /// <summary>
        /// Retourne le nom ou modifie le nom
        /// </summary>
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
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
        /// Retourne la superficie de la planète
        /// </summary>
        public double Superficie
        {
            get { return 4 * (_rayon * 2) * Math.PI; }
        }

        /// <summary>
        /// Retourne le volume de la planète
        /// </summary>
        public double Volume
        {
            get { return 4 / (3 * Math.PI * Math.Pow(_rayon, 3)); }
        }

        /// <summary>
        /// Retourne la masse volumique de la planète
        /// </summary>
        public double MasseVolumique
        {
            get { return _masse / Volume; }
        }

        public Lune this[int i]
        {
            get { return this._listeLune[i]; }
            set { this._listeLune[i] = value; }
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

        /// <summary>
        /// Afficher les information de la planète
        /// </summary>
        /// <returns> Information de la planète </returns>
        public override string ToString()
        {   
            return "Planète : " + this._nom + " Rayon : " + this._rayon + " Masse : " + this._masse;
        }

        public static bool operator ==(Planete p1, Planete p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Planete p1, Planete p2) 
        { 
            return !p1.Equals(p2); 
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
