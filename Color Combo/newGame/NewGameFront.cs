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
    public partial class NewGameFront : Form
    {
        public static string highScore;

        public NewGameFront()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            //f1.Refresh();
            //f1.Activate();
            f1.Show();
            f1.timer1.Enabled = true;
            f1.setLife(10);
            f1.setScore(0);
            this.Hide();
        }

        private void NewGameFront_SizeChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StreamReader read = new StreamReader("HighScore.txt");
            highScore = read.ReadLine();
            HighScore hs = new HighScore();
            hs.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instruction i = new Instruction();
            i.Show();
        }
    }
}
