using System;

namespace NumberGuessGameWinForm
{
    public partial class Form1 : Form
    {
        public int targetNumber;
        public int Lives = 10;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            targetNumber = random.Next(1, 101);
            lblLives.Text = "Remaining rights ❤️: " + Lives;
        }


        private void btnGuess_Click(object sender, EventArgs e)
        {
            int number;
            try
            {
                number = Convert.ToInt32(txtGuess.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGuess.Clear();
                txtGuess.Focus();
                return;
            }
            if (number == targetNumber)
            {
                lblMessage.Text = "CONGRATULATIONS! You got it right! 🎉";
                lblMessage.ForeColor = Color.Green;
                lblMessage.BackColor = Color.LightGreen;
                btnGuess.Enabled = false;
            }
            else
            {
                Lives--;
                lblLives.Text = "Remaining rights ❤️: " + Lives;
                lblLast.Visible = true;
                lblLast.Text = "Latest number: "+ number;

                if (number < targetNumber)
                {
                    lblMessage.Text = "Enter a BIGGER number ⬆️";
                    lblMessage.ForeColor = Color.Red;
                }
                else if (number > targetNumber)
                {
                    lblMessage.Text = "Enter a SMALLER number ⬇️";
                    lblMessage.ForeColor = Color.Red;
                }
            }

            if (Lives == 0 && number != targetNumber)
            {
                lblMessage.Text = "YOU LOST! Number: " + targetNumber;
                btnGuess.Enabled = false;
            }

            txtGuess.Clear();
            txtGuess.Focus();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Lives = 10;
            targetNumber = random.Next(1, 101);

            lblLives.Text = "Remaining rights ❤️: " + Lives;
            lblMessage.Text = "";
            lblLast.Text = "";
            lblMessage.ForeColor = Color.Black;
            lblMessage.BackColor = Color.Transparent;
            txtGuess.Clear();

            btnGuess.Enabled = true;

            txtGuess.Focus();
        }
    }
}
