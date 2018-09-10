using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MemoryMatchingGame
{
    public partial class GameWindow : Form
    {
        //Global Varibales
        //The random funtion generates random values from X and Y list
        //This means cards will be placed randomly everytime the game starts
        Random locaion = new Random();
        List<int> X = new List<int>();
        List<int> Y = new List<int>();
        //Boolean used to keep track if user wants to play again
        bool playAgain = false;
        Timer timer1 = new Timer();
        Label label = new Label();

        public GameWindow()
        {
            InitializeComponent();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            //Set the timer settings
            timer1.Tick += new EventHandler(Timer_Tick); //trigger event when timer1 counts down
            timer1.Interval = 5000; //timer1 countsdown/up for 5 seconds
            //Debug.Print("This is a test");
            timer1.Enabled = true; //enbaled the timer1
            timer1.Start(); //start timer1 to start counting

            //label.Location = new Point(100, 100);
            //label.AutoSize = true;
            //label.Text = String.Empty;

            //this.Controls.Add(label);

            //for each card below we are assigning a image
            card1.Image = Properties.Resources.red;
            dupCard1.Image = Properties.Resources.red;
            card2.Image = Properties.Resources.orange;
            dupCard2.Image = Properties.Resources.orange;
            card3.Image = Properties.Resources.yellow;
            dupCard3.Image = Properties.Resources.yellow;
            card4.Image = Properties.Resources.green;
            dupCard4.Image = Properties.Resources.green;
            card5.Image = Properties.Resources.blue;
            dupCard5.Image = Properties.Resources.blue;
            card6.Image = Properties.Resources.indigo;
            dupCard6.Image = Properties.Resources.indigo;
            card7.Image = Properties.Resources.violet;
            dupCard7.Image = Properties.Resources.violet;
            card8.Image = Properties.Resources.white;
            dupCard8.Image = Properties.Resources.white;
            card9.Image = Properties.Resources.black;
            dupCard9.Image = Properties.Resources.black;
            card10.Image = Properties.Resources.grey;
            dupCard10.Image = Properties.Resources.grey;
                        
            
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            //Debug.Print("This is a test");
            //label.Text = "GO!!";//DateTime.Now.ToString();

            //When the timer1 counts down the follwing code will be executed

            //foreach goes through each instance of the pictureBox in the panel to apply the same cover image
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                //for each picture (pictureBox) the cover image stored in the resources of the application is set
                picture.Image = Properties.Resources.cover;
            }

            //stop the timer1 after this occurs once but we do not use it as we need to chnage image if the cards do not match 
            //timer1.Stop();
        }

        //Function names should start with a CAPS but name of the card is in small CAPS
        //Below 20 funtions are click functions for each card ***need to make it more efficient by combing it into one function***
        private void card1_Click(object sender, EventArgs e)
        {

            //In the form1.Designer.cs file the intiailizeComponent is declared, here the cards are intilaized ie name, size and initial image
            //here we need to declare an event for the card click like the following this.card1.Click += new System.EventHandler(this.card1_Click);
            //this binds the function with the card an alternative way is doubling clicking on the card in design window

            //This chnages the image of card1 when its clicked
            card1.Image = Properties.Resources.red;

        }

        private void dupCard1_Click(object sender, EventArgs e)
        {
            dupCard1.Image = Properties.Resources.red;
        }

        private void card2_Click(object sender, EventArgs e)
        {
            card2.Image = Properties.Resources.orange;
        }

        private void dupCard2_Click(object sender, EventArgs e)
        {
            dupCard2.Image = Properties.Resources.orange;
        }

        private void card3_Click(object sender, EventArgs e)
        {
            card3.Image = Properties.Resources.yellow;
        }

        private void dupCard3_Click(object sender, EventArgs e)
        {
            dupCard3.Image = Properties.Resources.yellow;
        }

        private void card4_Click(object sender, EventArgs e)
        {
            card4.Image = Properties.Resources.green;
        }

        private void dupCard4_Click(object sender, EventArgs e)
        {
            dupCard4.Image = Properties.Resources.green;
        }

        private void card5_Click(object sender, EventArgs e)
        {
            card5.Image = Properties.Resources.blue;
        }

        private void dupCard5_Click(object sender, EventArgs e)
        {
            dupCard5.Image = Properties.Resources.blue;
        }

        private void card6_Click(object sender, EventArgs e)
        {
            card6.Image = Properties.Resources.indigo;
        }

        private void dupCard6_Click(object sender, EventArgs e)
        {
            dupCard6.Image = Properties.Resources.indigo;
        }

        private void card7_Click(object sender, EventArgs e)
        {
            card7.Image = Properties.Resources.violet;
        }

        private void dupCard7_Click(object sender, EventArgs e)
        {
            dupCard7.Image = Properties.Resources.violet;
        }

        private void card8_Click(object sender, EventArgs e)
        {
            card8.Image = Properties.Resources.white;
        }

        private void dupCard8_Click(object sender, EventArgs e)
        {
            dupCard8.Image = Properties.Resources.white;
        }

        private void card9_Click(object sender, EventArgs e)
        {
            card9.Image = Properties.Resources.black;
        }

        private void dupCard9_Click(object sender, EventArgs e)
        {
            dupCard9.Image = Properties.Resources.black;
        }

        private void card10_Click(object sender, EventArgs e)
        {
            card10.Image = Properties.Resources.grey;
        }

        private void dupCard10_Click(object sender, EventArgs e)
        {
            dupCard10.Image = Properties.Resources.grey;
        }
    }
}
