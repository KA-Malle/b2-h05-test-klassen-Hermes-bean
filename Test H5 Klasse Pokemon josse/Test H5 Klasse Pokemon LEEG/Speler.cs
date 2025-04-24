using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Test_H5_Klasse_Pokemon_LEEG
{
    internal class Speler
    {
        // instanite variabelen
        private string _Naam;
        private int _Gezondheid;
        private int _PositieX;
        private int _PositieY;
        private bool _IsLevend;

       


        // Properties
        public string Naam
        {
            get { return _Naam; }
            set { _Naam = value; }
        }
        public int Gezondheid
        {
            get { return _Gezondheid; }
            set { _Gezondheid = value; }
        }
        public int PositieX
        {
            get { return _PositieX; }
            set { _PositieX = value; }
        }
        public int PositieY
        {
            get { return _PositieY; }
            set { _PositieY = value; }
        }
        public bool Levend
        {
            get { return _IsLevend; }
            set { _IsLevend = value; }
        }
        // constructor
        public Speler()
        {
            Naam = "Naamloos";
            Gezondheid = 100;
            PositieX = 0;
            PositieY = 0;
            Levend = true;
        }
        // 2de constructor new(arg...) => overloading
        public Speler(string naam, int hp, int px, int py, bool life)
        {
            Naam = naam;
            Gezondheid = hp;
            PositieX = px;
            PositieY = py;
            Levend = life;
        }

        // Methods
        public int Verplaats(int postitieX, int positsieY) 
        {
            if (postitieX >0 && positsieY >0)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        public int OntvangSchade(int damage)
        {
            int uitvoer;
            uitvoer = Gezondheid - damage;
            if (uitvoer <0)
            {
                Levend = false;
                return uitvoer;
            }
            else
            {
                Levend = true;
                return uitvoer;
            }
            

        }
        public int Genees(int heal)
        {
            int uitvoer;
            uitvoer = Gezondheid + heal;
            if (uitvoer > 100)
            {
                Gezondheid = 100;
                uitvoer = Gezondheid;
                return uitvoer;
            }
            else
            {
                return uitvoer;
            }
        }


    }
}
