using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier4
{
    internal class SystemeSolaire : CorpCeleste
    {
        private Planete[] _planete; // Tableau des planètes
        private int _nbPlanete; // Nombre de planètes

        /// <summary>
        /// Constructeur 
        /// </summary>
        /// <param name="nom"> Nom du système solaire </param>
        public SystemeSolaire(string nom) : base(nom)
        {
            _planete = new Planete[10];
            _nbPlanete = 0;
        }

        public string NbPlanete
        {
            get { return "Le nombre de planète dans le système solaire : " + _nbPlanete;  }
        }

        /// <summary>
        /// Retourne le nom du système solaire
        /// </summary>
        /// <returns> Le nom du système solaire </returns>
        public override string ToString()
        {
            return "Nom du sytème solaire : " + _nom;
        }

        /// <summary>
        /// Indexeur
        /// </summary>
        /// <param name="index"> Index de la planète </param>
        /// <returns> Retourne la planète si l'index est valide sinon null </returns>
        public Planete this [int index]
        {
            get
            {
                if (index >= 0 && index < _nbPlanete)
                {
                    return _planete[index];
                }
                else
                {
                    Console.WriteLine("L'index n'est pas valide.");
                    return null;
                }
            }
        }

        /// <summary>
        /// Surchage de l'opérateur + pour ajouter une planète à un système solaire
        /// </summary>
        /// <param name="systemeSolaire"> Le système solaire </param>
        /// <param name="planete"> La planèete à ajouter </param>
        /// <returns> Le système solaire </returns>
        public static SystemeSolaire operator +(SystemeSolaire systemeSolaire, Planete planete)
        {
            if (systemeSolaire._nbPlanete < systemeSolaire._planete.Length)
            {
                systemeSolaire._planete[systemeSolaire._nbPlanete] = planete;
                systemeSolaire._nbPlanete++;
            }
            else
            {
                Console.WriteLine("Le tableau de planète est plein.");
            }
            return systemeSolaire;
        }
    }
}
