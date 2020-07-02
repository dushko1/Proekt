using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class GameMenu : Form
    {
        public GameMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Level1 f2 = new Level1();
            this.Hide();
            f2.ShowDialog();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            Level2 f3 = new Level2();
            this.Hide();
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Level3 f4 = new Level3();
            this.Hide();
            f4.ShowDialog();
        }

    }
}
