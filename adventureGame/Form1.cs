using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

/// Alana Fortin
/// October 2022
/// adventure game

namespace adventureGame
{
    public partial class form1 : Form
    {
        // Tracks what page of the story the user is at
        int page = 1;
        public form1()
        {
            InitializeComponent();
            //Display initial message and options
            outputLabel.Text = "who would you like to go on a date with?";
            optionLabel1.Text = "Flynn Ryder";
            optionLabel2.Text = "Merida";
            optionLabel3.Text = "Lightning McQueen";

        }



        private void option1Button_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 1

            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6)
            {
                Random randGen = new Random();
                int chance = randGen.Next(1, 101);
                if (chance < 50)
                {
                    page = 7;
                }
                else
                {
                    page = 8;
                }
            }
            else if (page == 7)
            {
                page = 1;
                option3Button.Enabled = true;
                optionLabel3.Visible = true;
                option3Button.Visible = true;
            }
            else if (page == 8)
            {
                page = 1;
                option3Button.Enabled = true;
                optionLabel3.Visible = true;
                option3Button.Visible = true;
            }
            else if (page == 13)
            {
                page = 19;
            }
            else if (page == 20)
            {
                page = 1;
            }

            /// Display text and game options to screen based on the 
            /// current page
            switch (page)
            {
                case 1:
                    optionLabel1.Text = "Flynn Ryder";
                    outputLabel.Text = "Who would you like to go on a date with?";
                    optionLabel1.Text = "Flynn";
                    optionLabel2.Text = "Merida";
                    optionLabel3.Text = "Lightning McQueen";
                    break;
                case 2:
                    outputLabel.Text = "What would you like to do on the date?";
                    optionLabel1.Text = "Boat ride to see the lanterns";
                    optionLabel2.Text = "Attend an art class";
                    option3Button.Enabled = false;
                    optionLabel3.Visible = false;
                    break;
                case 3:
                    outputLabel.Text = "You are having an amazing time! He tries to grab your hand. Do you accept?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    optionLabel3.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 4:
                    outputLabel.Text = "You guys are now holding hands! He asks if you want to go on a second date. What do you say?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    optionLabel3.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 5:
                    outputLabel.Text = "The date ends and he texts you the next morning asking if you want to hangout with him that night. Do you respond?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    optionLabel3.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 6:
                    outputLabel.Text = "You hangout with him that night and he asks you to be his gf. Do you say yes?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    optionLabel3.Visible = false;
                    option3Button.Visible = false;
                    break;
                case 7:
                    outputLabel.Text = "You two date for years!! on your three month anniversary. ";
                    optionLabel1.Text = "";
                    optionLabel2.Text = "";
                    optionLabel3.Visible = false;
                    option3Button.Visible = false;
                    Thread.Sleep(2000);
                    Refresh();
                    outputLabel.Text += "He proposed and you are now engaged!! you live happy ever after! play again?";
                    optionLabel1.Text += "Yes";
                    optionLabel2.Text += "No";
                    break;
                case 8:
                    outputLabel.Text = "You two date for years!! on your three month anniversary.";
                    optionLabel1.Text = "";
                    optionLabel2.Text = "";
                    optionLabel3.Visible = false;
                    option3Button.Visible = false;
                    Thread.Sleep(2000);
                    Refresh();
                    outputLabel.Text += "he breaks up with you. Play again?";
                    optionLabel1.Text += "Yes";
                    optionLabel2.Text += "No";
                    break;
                case 19:
                    outputLabel.Text = "You guys kiss! Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
            }
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            // seccond options for date with flynn
            if (page == 3)
            {
                page = 9;
            }
            else if (page == 4)
            {
                page = 10;
            }
            else if (page == 5)
            {
                page = 11;
            }
            else if (page == 6)
            {
                page = 12;
            }
            else if (page == 2)
            {
                page = 13;
            }
            else if (page == 13)
            {
                page = 18;
            }
            else if (page == 1 )
            {
                page = 20;
            }
            else if (page == 20)
            {
                page = 1;
            }
            else if (page == 20)
            {
                page = 21;
            }
            else if (page == 21)
            {
                page = 1;
            }

            switch (page)
            {
                case 3:
                    outputLabel.Text = "You are having an amazing time! He tries to grab your hand. Do you accept?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 10:
                    outputLabel.Text = "He Pushes you over board and you drown. Play Again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 11:
                    outputLabel.Text = "You leave the date and ghost him. Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    break;
                case 13:
                    outputLabel.Text = "";
                    optionLabel1.Text = "";
                    optionLabel2.Text = "";
                    break;
                case 20:
                    outputLabel.Text = "She never showed up. go cry at home. Play again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    option3Button.Visible = false;
                    optionLabel3.Visible = false;
                    break;
                case 21:
                    outputLabel.Text = " Thank you for playing";
                    optionLabel1.Text = "";
                    optionLabel2.Text = "";
                    option3Button.Visible = true;
                    optionLabel3.Visible = true;
                    break;
                
                    
            }
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 30;
            }

            switch (page)
            {
                case 30:
                    outputLabel.Text = "He never showed up. Go cry at home Play Again?";
                    optionLabel1.Text = "Yes";
                    optionLabel2.Text = "No";
                    option3Button.Visible = false;
                    optionLabel3.Visible = false;
                    break;

            }
        }


    }
}

