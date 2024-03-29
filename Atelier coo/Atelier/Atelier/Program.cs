﻿using Atelier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Planete 
    {
        private string _nom;
        private double _rayon;
        private double _masse; // Masse de la planète terre
        private Lune [] _listeLune;

        public Planete(string nom, double rayon, double masse)
        {
            _nom = nom;
            _rayon = rayon;
            _masse = masse;
            _listeLune = new Lune[3];  
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public double Rayon
        {
            get { return _rayon; }
            set
            {
                if (value > 0)
                    _rayon = value;
            }
        }

        public double Masse
        {
            get { return Masse; }
            set
            {
                if (value > 0)
                    _masse = value;
            }
        }
        

        public double Superficie
        {
            get { return 4 * (_rayon * 2) * Math.PI; }
        }

        public double Volume
        {
            get { return 4 / (3 * Math.PI * Math.Pow(_rayon, 3)); }
        }

        public double MasseVolumique
        {
            get { return _masse / Volume; }
        }

        public bool estPlusVolumineuse(Planete p1)
        {
            if (this.Volume < p1.Volume)
                return false;
            else
                return true;
        }

        public bool estPlusDense(Planete p1)
        {
            if (this.MasseVolumique < p1.MasseVolumique)
                return false;
            else
                return true;
        }

        public bool estIdentique(Planete p1)
        {
            if (this.Nom == p1.Nom && this.Rayon == p1.Rayon && this.Masse == p1.Masse)
                return true;
            else
                return false;
        }

        public bool estPlusPetite(Planete p1)
        {
            if (this.Masse < p1.Masse)
                return false;
            else
                return true;
        }

        public bool estPlusGrande(Planete p1)
        {
            if (this.Masse > p1.Masse)
                return true;
            else
                return false;
        }
        public bool estEgale(Planete p1)
        {
            if (this.Superficie == p1.Superficie)
                return true;
            else
                return false;
        }

        public override bool Equals(object obj)
        {
            if (this.Nom == ((Planete)obj).Nom && this.Rayon == ((Planete)obj).Rayon && this.Masse == ((Planete)obj).Masse) 
                return true;
            else 
                return false;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Planete p1 = new Planete("Venus", 10, 50);
            Planete p2 = new Planete("Saturne", 20, 60);

            Console.WriteLine(p1.Superficie);

            Console.ReadLine();
        }
    }
}

