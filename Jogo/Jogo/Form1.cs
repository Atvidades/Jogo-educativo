using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jogo
{
    public partial class Form1 : Form
    {
        public string A;

        public Form1()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (A == "sol")
            {
                if (textBox1.Text == "SOL")
                {
                    pictureBox2.Visible = true;
                    pictureBox2.Image = Properties.Resources.images;
                }
                else
                {
                    pictureBox2.Visible = true;
                    pictureBox2.Image = Properties.Resources.ERRADO;
                }
            }
            if (A == "bola")
            {
                if (textBox1.Text == "BOLA")
                {
                    pictureBox2.Visible = true;
                    pictureBox2.Image = Properties.Resources.images;
                }
                else
                {
                    pictureBox2.Visible = true;
                    pictureBox2.Image = Properties.Resources.ERRADO;
                }
            }
            textBox1.Text = null;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            A = "sol";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Image = Properties.Resources.bola;
            A = "bola";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Image = Properties.Resources.sol;
            A = "sol";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
