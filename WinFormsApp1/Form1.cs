using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int plusone;
        void Enable_False()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        void score()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.BackColor = System.Drawing.Color.PowderBlue;
                button2.BackColor = System.Drawing.Color.PowderBlue;
                button3.BackColor = System.Drawing.Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = System.Drawing.Color.PowderBlue;
                button5.BackColor = System.Drawing.Color.PowderBlue;
                button6.BackColor = System.Drawing.Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = System.Drawing.Color.PowderBlue;
                button8.BackColor = System.Drawing.Color.PowderBlue;
                button9.BackColor = System.Drawing.Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = System.Drawing.Color.PowderBlue;
                button4.BackColor = System.Drawing.Color.PowderBlue;
                button7.BackColor = System.Drawing.Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = System.Drawing.Color.PowderBlue;
                button5.BackColor = System.Drawing.Color.PowderBlue;
                button8.BackColor = System.Drawing.Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button3.BackColor = System.Drawing.Color.PowderBlue;
                button6.BackColor = System.Drawing.Color.PowderBlue;
                button9.BackColor = System.Drawing.Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = System.Drawing.Color.PowderBlue;
                button5.BackColor = System.Drawing.Color.PowderBlue;
                button9.BackColor = System.Drawing.Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = System.Drawing.Color.PowderBlue;
                button5.BackColor = System.Drawing.Color.PowderBlue;
                button7.BackColor = System.Drawing.Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button1.BackColor = System.Drawing.Color.PowderBlue;
                button2.BackColor = System.Drawing.Color.PowderBlue;
                button3.BackColor = System.Drawing.Color.PowderBlue;

                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button4.BackColor = System.Drawing.Color.PowderBlue;
                button5.BackColor = System.Drawing.Color.PowderBlue;
                button6.BackColor = System.Drawing.Color.PowderBlue;

                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                button7.BackColor = System.Drawing.Color.PowderBlue;
                button8.BackColor = System.Drawing.Color.PowderBlue;
                button9.BackColor = System.Drawing.Color.PowderBlue;

                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button1.BackColor = System.Drawing.Color.PowderBlue;
                button4.BackColor = System.Drawing.Color.PowderBlue;
                button7.BackColor = System.Drawing.Color.PowderBlue;

                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button2.BackColor = System.Drawing.Color.PowderBlue;
                button5.BackColor = System.Drawing.Color.PowderBlue;
                button8.BackColor = System.Drawing.Color.PowderBlue;

                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                button3.BackColor = System.Drawing.Color.PowderBlue;
                button6.BackColor = System.Drawing.Color.PowderBlue;
                button9.BackColor = System.Drawing.Color.PowderBlue;

                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                button1.BackColor = System.Drawing.Color.PowderBlue;
                button5.BackColor = System.Drawing.Color.PowderBlue;
                button9.BackColor = System.Drawing.Color.PowderBlue;

                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button3.BackColor = System.Drawing.Color.PowderBlue;
                button5.BackColor = System.Drawing.Color.PowderBlue;
                button7.BackColor = System.Drawing.Color.PowderBlue;

                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            else if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                MessageBox.Show("The game was a draw!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone + 1);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                label3.ForeColor = Color.Blue;
                label2.ForeColor = Color.FromArgb(192, 192, 255);
            }
            else
            {
                label2.ForeColor = Color.Blue;
                label3.ForeColor = Color.FromArgb(192, 192, 255);
            }
            if (checker == false)
            {
                button1.Text = "X";
                checker = true;
            }
            else
            {
                button1.Text = "O";
                checker = false;
            }
            button1.Enabled = false;
            score();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                label3.ForeColor = Color.Blue;
                label2.ForeColor = Color.FromArgb(192, 192, 255);
            }
            else
            {
                label2.ForeColor = Color.Blue;
                label3.ForeColor = Color.FromArgb(192, 192, 255);
            }
            if (checker == false)
            {
                button2.Text = "X";
                checker = true;
            }
            else
            {
                button2.Text = "O";
                checker = false;
            }
            button2.Enabled = false;
            score();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                label3.ForeColor = Color.Blue;
                label2.ForeColor = Color.FromArgb(192, 192, 255);
            }
            else
            {
                label2.ForeColor = Color.Blue;
                label3.ForeColor = Color.FromArgb(192, 192, 255);
            }
            if (checker == false)
            {
                button3.Text = "X";
                checker = true;
            }
            else
            {
                button3.Text = "O";
                checker = false;
            }
            button3.Enabled = false;
            score();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                label3.ForeColor = Color.Blue;
                label2.ForeColor = Color.FromArgb(192, 192, 255);
            }
            else
            {
                label2.ForeColor = Color.Blue;
                label3.ForeColor = Color.FromArgb(192, 192, 255);
            }
            if (checker == false)
            {
                button4.Text = "X";
                checker = true;
            }
            else
            {
                button4.Text = "O";
                checker = false;
            }
            button4.Enabled = false;
            score();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (checker == false)
            {
                label3.ForeColor = Color.Blue;
                label2.ForeColor = Color.FromArgb(192, 192, 255);
            }
            else
            {
                label2.ForeColor = Color.Blue;
                label3.ForeColor = Color.FromArgb(192, 192, 255);
            }
            if (checker == false)
            {
                button5.Text = "X";
                checker = true;
            }
            else
            {
                button5.Text = "O";
                checker = false;
            }
            button5.Enabled = false;
            score();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                label3.ForeColor = Color.Blue;
                label2.ForeColor = Color.FromArgb(192, 192, 255);
            }
            else
            {
                label2.ForeColor = Color.Blue;
                label3.ForeColor = Color.FromArgb(192, 192, 255);
            }
            if (checker == false)
            {
                button6.Text = "X";
                checker = true;
            }
            else
            {
                button6.Text = "O";
                checker = false;
            }
            button6.Enabled = false;
            score();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                label3.ForeColor = Color.Blue;
                label2.ForeColor = Color.FromArgb(192, 192, 255);
            }
            else
            {
                label2.ForeColor = Color.Blue;
                label3.ForeColor = Color.FromArgb(192, 192, 255);
            }
            if (checker == false)
            {
                button7.Text = "X";
                checker = true;
            }
            else
            {
                button7.Text = "O";
                checker = false;
            }
            button7.Enabled = false;
            score();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (checker == false)
            {
                label3.ForeColor = Color.Blue;
                label2.ForeColor = Color.FromArgb(192, 192, 255);
            }
            else
            {
                label2.ForeColor = Color.Blue;
                label3.ForeColor = Color.FromArgb(192, 192, 255);
            }
            if (checker == false)
            {
                button8.Text = "X";
                checker = true;
            }
            else
            {
                button8.Text = "O";
                checker = false;
            }
            button8.Enabled = false;
            score();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                label3.ForeColor = Color.Blue;
                label2.ForeColor = Color.FromArgb(192, 192, 255);
            }
            else
            {
                label2.ForeColor = Color.Blue;
                label3.ForeColor = Color.FromArgb(192, 192, 255);
            }
            if (checker == false)
            {
                button9.Text = "X";
                checker = true;
            }
            else
            {
                button9.Text = "O";
                checker = false;
            }
            button9.Enabled = false;
            score();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try 
            {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            label4.Text = "0";
            label5.Text = "0";

            button1.BackColor = Color.FromArgb(64, 64, 64);
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button4.BackColor = Color.FromArgb(64, 64, 64);
            button5.BackColor = Color.FromArgb(64, 64, 64);
            button6.BackColor = Color.FromArgb(64, 64, 64);
            button7.BackColor = Color.FromArgb(64, 64, 64);
            button8.BackColor = Color.FromArgb(64, 64, 64);
            button9.BackColor = Color.FromArgb(64, 64, 64);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
}

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;

                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                button12.Enabled = true;

                button1.BackColor = Color.FromArgb(64, 64, 64);
                button2.BackColor = Color.FromArgb(64, 64, 64);
                button3.BackColor = Color.FromArgb(64, 64, 64);
                button4.BackColor = Color.FromArgb(64, 64, 64);
                button5.BackColor = Color.FromArgb(64, 64, 64);
                button6.BackColor = Color.FromArgb(64, 64, 64);
                button7.BackColor = Color.FromArgb(64, 64, 64);
                button8.BackColor = Color.FromArgb(64, 64, 64);
                button9.BackColor = Color.FromArgb(64, 64, 64);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirm if you want to exit", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (iExit == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {}
        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The highlighted text of Player X or Y shows whos turn it is.\nPressing a tile will place X or O respective to whos turn it is.\nThe number infront of the Player X or O shows how many games each player has won.\nA draw results in a point for both Players.\nPressing reset resets the board giving a fresh board. New game starts a new game altogether reseting the score.\n\nThis game was created by Abdullah Zia & Haseeb Ahmad.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
