using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoozGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int coin = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            if (coin%2==0)
            {
                btn.Text = "X";
                btn.BackColor = Color.Cornsilk;
            }
            else
            {
                btn.Text = "O";
                btn.BackColor = Color.Orange;
            }
            btn.Enabled = false;
            coin++;
            IsWin("X");
            IsWin("O");
            
        }

        private void IsWin(string a)
        {
            if (button1.Text ==a && button2.Text==a && button3.Text==a ||
                button4.Text == a && button5.Text == a && button6.Text == a ||
                button7.Text == a && button8.Text == a && button9.Text == a ||
                button1.Text == a && button5.Text == a && button9.Text == a ||
                button3.Text == a && button5.Text == a && button7.Text == a ||
                button1.Text == a && button4.Text == a && button7.Text == a ||
                button2.Text == a && button5.Text == a && button8.Text == a ||
                button3.Text == a && button6.Text == a && button9.Text == a)
            {
                MessageBox.Show($"Player ( {a} ) is win!");
                Reset();
            }
        }
        private void Reset()
        {
            button1.Text = "";
            button1.Enabled = true;
            button1.BackColor = Color.White;
            button2.Text = "";
            button2.Enabled = true;
            button2.BackColor = Color.White;
            button3.Text = "";
            button3.Enabled = true;
            button3.BackColor = Color.White;
            button4.Text = "";
            button4.Enabled = true;
            button4.BackColor = Color.White;
            button5.Text = "";
            button5.Enabled = true;
            button5.BackColor = Color.White;
            button6.Text = "";
            button6.Enabled = true;
            button6.BackColor = Color.White;
            button7.Text = "";
            button7.Enabled = true;
            button7.BackColor = Color.White;
            button8.Text = "";
            button8.Enabled = true;
            button8.BackColor = Color.White;
            button9.Text = "";
            button9.Enabled = true;
            button9.BackColor = Color.White;
        }

        private void Again(object sender, EventArgs e)
        {
            
            Reset();
        }

        private void End(object sender, EventArgs e)
        {
            MessageBox.Show("Do you sure leave the game?");
            
            Close();
        }

    }
}
