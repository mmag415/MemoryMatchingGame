using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public GameWindow()
        {
            InitializeComponent();
        }

       /* private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }*/

        private void GameWindow_Load(object sender, EventArgs e)
        {
            //foreach goes through each instance of the pictureBox in the panel to apply the same cover image
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                //for each picture (pictureBox) the cover image stored in the resources of the application is set
                picture.Image = Properties.Resources.cover;
            }
        }
    }
}
