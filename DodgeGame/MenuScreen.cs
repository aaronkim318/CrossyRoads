using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DodgeGame
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //exits application
            Application.Exit();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //changes the screen to gamescreen
            dodgeCars.ChangeScreen(this, new GameScreen());
        }
    }
}
