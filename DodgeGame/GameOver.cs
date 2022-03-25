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
    public partial class GameOver : UserControl
    {
        public GameOver()
        {
            InitializeComponent();
            endScoreLabel.Text = $"{GameScreen.score}";
        }
        

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            dodgeCars.ChangeScreen(this, new MenuScreen());
        }
    }
}
