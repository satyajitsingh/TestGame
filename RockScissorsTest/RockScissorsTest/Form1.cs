using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockScissorsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblPlay1.Text = "Computer 1";
            lblPlay2.Text = "Computer 2";
            
        }

        private void strButton_Click(object sender, EventArgs e)
        {
            if (strButton.Text == "Start Game")
            {
                plyCombo.Items.Clear();
                compCombo.Items.Clear();
                plyCombo.Items.Add("paper");
                plyCombo.Items.Add("rock");
                plyCombo.Items.Add("scissors");
                compCombo.Items.Add("rock");
                compCombo.Items.Add("paper");
                compCombo.Items.Add("scissors");
                strButton.Text = "Play Again";
                startGame();
            }
            else
            {
                strButton.Text = "Start Game";
                clearGame();
            }
        }
        public void startGame()
        {
            formPanel.Visible = false;
            gamePanel.Visible = true;

            if (radioButton1.Checked)
            {
                plyCombo.Enabled = true;
                compCombo.Visible = false;
                MessageBox.Show("Player 1: Select from the dropdown");
            }
            else if(radioButton2.Checked)
            {
                computerPlay("textBox1");
            }
        }
        public void clearGame()
        {
            gamePanel.Visible = false;
            formPanel.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            gamePanel.Visible = false;
            lblPlay1.Text = "Player 1";
        }

        private void plyCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (plyCombo.Text.Length > 2)
            {
                textBox1.Text = plyCombo.Text;
                plyCombo.Enabled = false;
                plyCombo.SelectedIndex = 0;

            }
        }
        public void computerPlay(string textBoxName)
        {
            Random r = new Random();
            int computerChoice = r.Next(0,3);
            if (computerChoice >= 0 && computerChoice < 3)
            {
                if (textBoxName == "textBox1")
                {
                    this.plyCombo.SelectedIndex = computerChoice;
                    textBox1.Text = plyCombo.Text;
                 
                }
                else if (textBoxName == "textBox2")
                {
                    this.compCombo.SelectedIndex = computerChoice;
                    textBox2.Text = compCombo.Text;
                }
            }
        }            

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 1)
            {
                computeResult();
            }
        }
        public void computeResult()
        {
            try
            {
                int compChoice = compCombo.SelectedIndex;
                string title = radioButton2.Checked ? "Computer 1 " : string.Empty;
                if (compChoice == 0)
                {
                    if (textBox1.Text == "rock")
                    {
                        MessageBox.Show(title + "The computer chose rock too. It is a tie");
                    }
                    else if (textBox1.Text == "paper")
                    {
                        MessageBox.Show(title + "Sorry you lose,rock beat paper");
                    }
                    else if (textBox1.Text == "scissors")
                    {
                        MessageBox.Show(title + "Sorry you lose,rock beats scissors");
                    }
                }
                else if (compChoice == 1)
                {
                    if (textBox1.Text == "rock")
                    {
                        MessageBox.Show(title + "You win,rock beat scissors");
                    }
                    else if (textBox1.Text == "paper")
                    {
                        MessageBox.Show(title + "Sorry you lose,scissors beats paper;");
                    }
                    else if (textBox1.Text == "scissors")
                    {
                        MessageBox.Show(title + "You win,scissors beat paper");
                    }
                }
                if (compChoice == 2)
                {
                    if (textBox1.Text == "rock")
                    {
                        MessageBox.Show(title + "You win,rock beat paper");
                    }
                    else if (textBox1.Text == "paper")
                    {
                        MessageBox.Show(title + "Sorry you lose,rock beat paper");
                    }
                    else if (textBox1.Text == "scissors")
                    {
                        MessageBox.Show(title + "The computer chose scissors too. It is a tie");
                    }
                }
                compChoice = 0;
                this.compCombo.Text = "";
                this.textBox1.Text = "";
                this.textBox2.Text = "";
                this.strButton.Text = "Start Game";
            }
            catch (Exception e)
            {
                MessageBox.Show("An error has ocurrerd");
            }

            finally
            {
                clearGame();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 2 && strButton.Text== "Play Again")
            computerPlay("textBox2");
        }
    }
}
