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
    public partial class GameScreen : UserControl
    {
        Car carObject;
        Player hero;

        List<Car> cars = new List<Car>();


        Size screenSize;

        bool leftArrowDown = false;
        bool rightArrowDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;

        Random randgen = new Random();
        int location;

        public GameScreen()
        {
            InitializeComponent();

            screenSize = new Size(this.Width, this.Height);
            hero = new Player(450, 350);

            newCar();
        }
        public void newCar()
        {
            location = randgen.Next(0, 3);
            switch (location)
            {
                case 0:
                    Car a = new Car(5, 50);
                    cars.Add(a);
                    break;
                case 1:
                    Car b = new Car(this.Width - 5, 100);
                    cars.Add(b);
                    break;
                case 2:
                    Car c = new Car(5, 150);
                    cars.Add(c);
                    break;
                case 3:
                    Car d = new Car(this.Width - 5, 200);
                    cars.Add(d);
                    break;

            }
        }


        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
            }
        }
        private void timerGo_Tick(object sender, EventArgs e)
        {

            //check when the player has made any movements, and activate the code accordingly
            if (leftArrowDown == true)
            {
                hero.Move("left", screenSize);
            }

            if (rightArrowDown == true)
            {
                hero.Move("right", screenSize);
            }

            if (upArrowDown == true)
            {
                hero.Move("up", screenSize);
            }

            if (downArrowDown == true)
            {
                hero.Move("down", screenSize);
            }
            foreach (Car c in cars)
            {
                c.Move(screenSize);
            }
            foreach (Car c in cars)
            {
                if (c.Collison(hero))
                {

                    dodgeCars.ChangeScreen(this, new GameOver());
                    timerGo.Enabled = false;
                    return;
                }
            }




            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (Car c in cars)
            {
                e.Graphics.FillEllipse(Brushes.Red, c.x, c.y, c.width, c.height);
            }
            e.Graphics.FillRectangle(Brushes.Black, hero.x, hero.y, hero.width, hero.height);
        }
    }
}
