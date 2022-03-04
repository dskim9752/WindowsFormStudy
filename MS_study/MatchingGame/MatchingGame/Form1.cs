using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace MatchingGame
{
    public partial class Form1 : Form
    {
        Random rd = new Random();
        Label firstClicked = null;
        Label secondCliced = null;

        List<string> icons = new List<string>()
        {
            "!","!","N","N",",",",","k","k","b","b","v","v","w","w","z","z"
        };

        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        private void AssignIconsToSquares()
        {
            foreach(Control con in tableLayoutPanel1.Controls)
            {
                Label iconLabel = con as Label;
                iconLabel.ForeColor = iconLabel.BackColor;
                if(iconLabel != null)
                {
                    int randomNumber = rd.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    icons.RemoveAt(randomNumber);
                }

            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                if(firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }

                secondCliced = clickedLabel;
                secondCliced.ForeColor = Color.Black;

                CheckForWinner();

                if (firstClicked.Text == secondCliced.Text)
                {
                    firstClicked = null;
                    secondCliced = null;
                    return;
                }

                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondCliced.ForeColor = secondCliced.BackColor;

            firstClicked = null;
            secondCliced = null;
        }



        private void CheckForWinner()
        {
            // Go through all of the labels in the TableLayoutPanel, 
            // checking each one to see if its icon is matched
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            // If the loop didn’t return, it didn't find
            // any unmatched icons
            // That means the user won. Show a message and close the form
            MessageBox.Show("You matched all the icons!", "Congratulations");
            Close();
        }
    }
}
