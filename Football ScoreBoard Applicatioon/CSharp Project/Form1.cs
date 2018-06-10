using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Project
{
    public partial class Form1 : Form 
    {
        string Name1;
        string Name2;
        private ScoreBoard scoreboard;


        public Form1()
        {
            InitializeComponent();
            Name1 = "Aresnal";
            Name2 = "Chelsea";
            scoreboard = new ScoreBoard(Name1, Name2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scoreboard.Zeroise();
        }

        private void HomeGoal_Click(object sender, EventArgs e)
        {
            scoreboard.HomeGoal();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            scoreboard.AwayGoal();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DISPLAYCHANGER.Text = scoreboard.GetData();
            
        }

    }
}

