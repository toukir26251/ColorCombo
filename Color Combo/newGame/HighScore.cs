using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace newGame
{
    public partial class HighScore : Form
    {
        public HighScore()
        {
            InitializeComponent();
        }

        private void HighScore_Load(object sender, EventArgs e)
        {
            label2.Text = NewGameFront.highScore;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            NewGameFront n = new NewGameFront();
            n.Show();
        }
    }
}
