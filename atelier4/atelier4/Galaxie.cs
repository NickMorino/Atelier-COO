using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier4
{
    internal class Galaxie : CorpCeleste, ICloneable
    {
        private SystemeSolaire[] _systemeSolaires; // Tableau des systèmes solaires
        private string _type; // Type de galaxie
        private int _nbSystemeSolaires; // Nombre de système solaire

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom"> Nom de la galaxie </param>
        /// <param name="type"> Type de galaxie </param>
        public Galaxie(string nom, string type) : base(nom)
        {
            _type = type;
            _systemeSolaires = new SystemeSolaire[10];
            _nbSystemeSolaires = 0;
        }

        public Galaxie(Galaxie galaxie)
        {
            galaxie._type = _type;
            galaxie._nom = _nom;
            galaxie._nbSystemeSolaires = _nbSystemeSolaires;
            galaxie._systemeSolaires = _systemeSolaires;
        }

        public object Clone()
        {
            return new Galaxie(this);
        }

        /// <summary>
        /// Accesseur / Retourne le nombre de systèmes solaires de la galaxie
        /// </summary>
        public string NbSystemeSolaire
        {
            get { return "Nombres de sytèmes solaires : " + _nbSystemeSolaires; }
        }

        /// <summary>
        /// Accesseur / Retourne ou modifie le type de la galaxie
        /// </summary>
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public override int NbElements()
        {
            int nbElement = _systemeSolaires.Length;

            for (int i= 0; i < _systemeSolaires.Length; i++)
            {
                if(this._systemeSolaires[i] != null)
                    nbElement += _systemeSolaires[i].NbElements();
            }
            return nbElement;
        }
        
        /// <summary>
        /// Indexeur
        /// </summary>
        /// <param name="index"> Index du système solaire </param>
        /// <returns> Retourne le système solaire si l'index est valide sinon null </returns>
        public SystemeSolaire this[int index]
        {
            get
            {
                if (index >= 0 && index < _nbSystemeSolaires)
                {
                    return _systemeSolaires[index];
                }
                else
                {
                    Console.WriteLine("L'index n'est pas valide.");
                    return null;
                }
            }
        }

        /// <summary>
        /// Surchage de l'opérateur + pour ajouter un système solaire à une galaxie
        /// </summary>
        /// <param name="galaxie"> La galaxie choisie </param>
        /// <param name="systemeSolaire"> Le système solaire à ajouter </param>
        /// <returns> La galaxie </returns>
        public static Galaxie operator +(Galaxie galaxie, SystemeSolaire systemeSolaire)
        {
            if (galaxie._nbSystemeSolaires < galaxie._systemeSolaires.Length)
            {
                galaxie._systemeSolaires[galaxie._nbSystemeSolaires] = systemeSolaire;
                galaxie._nbSystemeSolaires++;
            }
            else
            {
                Console.WriteLine("Le tableau des systèmes solaires est plein.");
            }
            return galaxie;
        }
    }
}
