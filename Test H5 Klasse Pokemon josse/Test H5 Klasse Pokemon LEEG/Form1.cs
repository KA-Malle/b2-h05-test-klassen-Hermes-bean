using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_H5_Klasse_Pokemon_LEEG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // josse denis
        // 6ADB
        // 24/4/2025

        Speler _speler1 = new Speler();
        Speler _speler2 = new Speler();
        Random _will = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            _speler1.Naam = "James";
            _speler1.Gezondheid = 100;
            _speler1.PositieX = _will.Next(0, 500);
            _speler1.PositieY = _will.Next(0, 500);
            _speler1.Levend = true;

            _speler2.Naam = "Daisy";
            _speler2.Gezondheid = 100;
            _speler2.PositieX = _will.Next(0,500);
            _speler2.PositieY = _will.Next(0, 500);
            _speler2.Levend = true;    

            labelGezondheid1.Text = _speler1.Gezondheid.ToString();
            labelGezondheid2.Text = _speler2.Gezondheid.ToString();
            label1.Text = _speler1.Naam.ToString();
            label3.Text = _speler2.Naam.ToString();

        }

        private void buttonValAan1_Click(object sender, EventArgs e)
        {
            int schade;
            schade =_will.Next(0, 10);
            _speler2.Gezondheid= _speler2.OntvangSchade(schade);
            labelGezondheid2.Text = _speler2.Gezondheid.ToString();
            if (_speler2.Levend == false)
            {
                MessageBox.Show("" + _speler2.Naam + " is dood","Dood",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void buttonValAan2_Click(object sender, EventArgs e)
        {
            int schade;
            schade = _will.Next(0, 10);
            _speler1.Gezondheid = _speler1.OntvangSchade(schade);
            labelGezondheid1.Text = _speler1.Gezondheid.ToString();
            if (_speler1.Levend == false)
            {
                MessageBox.Show("" + _speler1.Naam + " is dood", "Dood", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonGenees1_Click(object sender, EventArgs e)
        {
            int genees;
            genees = _will.Next(0, 5);
            _speler1.Gezondheid = _speler1.Genees(genees);
            labelGezondheid1.Text = _speler1.Gezondheid.ToString();

        }

        private void buttonGenees2_Click(object sender, EventArgs e)
        {
            int genees;
            genees = _will.Next(0, 5);
            _speler2.Gezondheid = _speler2.Genees(genees);
            labelGezondheid2.Text = _speler2.Gezondheid.ToString();
        }

        private void buttonToonPos_Click(object sender, EventArgs e)
        {
            string text;
            text = "speler 1 " + _speler1.Naam + ": {" + _speler1.PositieX.ToString() + "," + _speler1.PositieY.ToString() + "}";
            text += Environment.NewLine;
            text+= "speler 2 " + _speler2.Naam + ": {" + _speler2.PositieX.ToString() + "," + _speler2.PositieY.ToString() + "}";
            MessageBox.Show(text, "positie", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
