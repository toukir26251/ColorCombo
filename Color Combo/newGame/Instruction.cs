using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newGame
{
    public partial class Instruction : Form
    {
        public Instruction()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
            NewGameFront n = new NewGameFront();
            n.Show();
        }
    }
}
