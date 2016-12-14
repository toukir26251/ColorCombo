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
    public partial class Form1 : Form
    {
        public int life=10;
        public int score=0;
        public Form1()
        {
            InitializeComponent();
            
                label4.Hide();
                label3.Hide();

        }

        public void setLife(int a)
        {
            life = a;
        }
        public void setScore(int a)
        {
            score = a;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Life : " + life;
            this.label2.Text = "Score : " + score;
            
        }



        public void picBoxGenRED()
        {
            Random rnd = new Random();
            int X = rnd.Next(1, 345);
            int Y = rnd.Next(1, 250);

            pictureBox2.Location = new Point(X,Y);
        }
        public void picBoxGenPink()
        {
            Random rnd = new Random();
            int X = rnd.Next(0, 330);
            int Y = rnd.Next(0, 240);
            

            pictureBox3.Location = new Point(X, Y);
        }

        public void picBoxGenGREEN()
        {
            Random rnd = new Random();
            int X = rnd.Next(0, 330);
            int Y = rnd.Next(0, 240);
            
            pictureBox5.Location = new Point(X,Y);

        }

        public void picBoxGenBLUE()
        {
            Random rnd = new Random();
            int X = rnd.Next(0, 345);
            int Y = rnd.Next(0, 250);

            
            pictureBox6.Location = new Point(X, Y);
        }

        public void picBoxGenMAROON()
        {
            Random rnd = new Random();
            int X = rnd.Next(0, 345);
            int Y = rnd.Next(0, 250);

            
            pictureBox7.Location = new Point(X, Y);

        }
        public void picBoxGenYELLOW()
        {
            Random rnd = new Random();
            int X = rnd.Next(0, 345);
            int Y = rnd.Next(0, 250);


            pictureBox4.Location = new Point(X, Y);
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            collition();
            if(life < 1)
            {
                this.timer1.Enabled = false;
                label1.Hide();
                label3.Show();
                label4.Show();
                if (score > Convert.ToInt32(NewGameFront.highScore))
                {
                    StreamWriter write = new StreamWriter(@"C:\Users\Toukir Tonmoy\Documents\Visual Studio 2015\Projects\newGame\newGame\HighScore.txt");
                    write.WriteLine(Convert.ToString(score));
                    write.Close();
                    //System.IO.File.AppendAllText(@"C:\Users\Toukir Tonmoy\Documents\Visual Studio 2015\Projects\newGame\newGame\HighScore.txt", Convert.ToString(score) + "\n");
                }
            }

            if (pictureBox2.Location.Y< 520)
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X,pictureBox2.Location.Y+5);
            }

            if (pictureBox2.Location.Y >= 519)
            {
                picBoxGenRED();
               
            }

            if (pictureBox3.Location.Y < 520)
            {
                pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y + 4);
            }

            if (pictureBox3.Location.Y >= 519)
            {
                picBoxGenPink();
            }

            if (pictureBox4.Location.Y < 520)
            {
                pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y + 5);
            }

            if (pictureBox4.Location.Y >= 519)
            {
                picBoxGenYELLOW();
            }

            if (pictureBox5.Location.Y < 520)
            {
                pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y + 7);
            }

            if (pictureBox5.Location.Y >= 519)
            {
                
                picBoxGenGREEN();
            }

            if (pictureBox6.Location.Y < 520)
            {
                pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y + 6);
            }

            if (pictureBox6.Location.Y >= 519)
            {
                
                picBoxGenBLUE();
            }
            if (pictureBox7.Location.Y < 520)
            {
                pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox6.Location.Y + 3);
            }

            if (pictureBox7.Location.Y >= 519)
            {
                picBoxGenMAROON();
            }
            if (score > 9)
            {
                this.timer1.Interval = 40;
            }
            if (score > 19)
            {
                this.timer1.Interval = 30;
            }
            if (score > 29)
            {
                this.timer1.Interval = 20;
            }
            if (score > 39)
            {
                this.timer1.Interval = 10;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.W && pictureBox1.Top > 0)
            {
                pictureBox1.Top = pictureBox1.Top - 7;
                
            }
            else if (e.KeyCode == Keys.S && pictureBox1.Top < 500)
            {
                pictureBox1.Top = pictureBox1.Top + 7;
            }
            else if (e.KeyCode == Keys.D && pictureBox1.Left < 342)
            {
                pictureBox1.Left = pictureBox1.Left + 7;
            }
            else if (e.KeyCode == Keys.A && pictureBox1.Left > 0)
            {
                pictureBox1.Left = pictureBox1.Left - 7;
            }
            
        }
        public void collition()
        {
            
            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                picBoxGenRED();
                life -= 1;
                this.label1.Text = "Life : " + life;
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                picBoxGenPink();
                
                life -= 1;
                this.label1.Text = "Life : " + life;
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                picBoxGenYELLOW();
                
                life -= 1;
                this.label1.Text = "Life : " + life;
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                picBoxGenBLUE();
                
                life -= 1;
                this.label1.Text = "Life : " + life;
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox7.Bounds))
            {
                picBoxGenMAROON();
                
                life -= 1;
                this.label1.Text = "Life : " + life;
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                picBoxGenGREEN();
                
                score += 1;
                this.label2.Text = "Score : " + score;

                
                
            }
        }

        
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            NewGameFront nf = new NewGameFront();
            nf.Show();
            this.Dispose();
        }
    }
}
