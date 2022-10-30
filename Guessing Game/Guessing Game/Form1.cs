using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_Game
{
    public partial class Form1 : Form
    {
        Random randomNumber = new Random();

        int number = 0;
        int guesses = 0;

        public Form1()
        {
            InitializeComponent();

            loadQuestions();
        }

        private void Guessingbutton_Click(object sender, EventArgs e)
        {
            
            int i = Convert.ToInt32(InputtextBox.Text);
            
            guesses += 1;
            guesslabel.Text = ("You guessed " + guesses + " times");


            if (i == number)
            {
                Outputlabel.Text = ("Well done! You've guessed the number." 
                + " You made " + guesses + " guesses. " + " Your last guess was " + number);
                loadQuestions();
                InputtextBox.Text = " ";
                guesses = 0;
            }

            else if (i > number)
            {
                Outputlabel.Text = (InputtextBox.Text + " is too high");
            }

            else 
            {
                Outputlabel.Text = (InputtextBox.Text + " is too low");
            }
        }

        private void loadQuestions()
        {
            number = randomNumber.Next(1,100);
            guesslabel.Text = "Try guessing a number between: 1 to 100";
        }


    }
}
