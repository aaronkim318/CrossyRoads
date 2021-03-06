using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace DodgeGame
{
    public partial class GameScreen : UserControl
    {
        SoundPlayer gameOver = new SoundPlayer(Properties.Resources.game_over);
        SoundPlayer gainedPoint = new SoundPlayer(Properties.Resources.upPoint);
        SoundPlayer zoom = new SoundPlayer(Properties.Resources.zoom);

        Player hero;


        List<Car> cars = new List<Car>();


        Size screenSize;

        bool leftArrowDown = false;
        bool rightArrowDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;

        Random randgen = new Random();
        int location;
        int location2;
        public static int score = 0;
        int updateTimerSet = 500;
        int newCarTimer = 5;
        int timerSet = 10;

        int xSpeed = 5;


        public GameScreen()
        {
            InitializeComponent();

            screenSize = new Size(this.Width, this.Height);
            hero = new Player(300, 500);

            newCar();
            timerGo.Enabled = true;
            score = 0;
        }


        public void newCar()
        {
            location = randgen.Next(0, 3);
            switch (location)
            {
                case 0:
                    Car a = new Car(5, 50, xSpeed);
                    cars.Add(a);
                    break;
                case 1:
                    Car b = new Car(this.Width - 55, 100, -xSpeed);
                    cars.Add(b);
                    break;
                case 2:
                    Car c = new Car(5, 150, xSpeed);
                    cars.Add(c);
                    break;
                case 3:
                    Car d = new Car(this.Width - 55, 200, -xSpeed);
                    cars.Add(d);
                    break;
            }

            location2 = randgen.Next(0, 4);
            switch (location2)
            {
                case 0:
                    Car e = new Car(5, 250, xSpeed);
                    cars.Add(e);
                    break;
                case 1:
                    Car f = new Car(this.Width - 55, 300, -xSpeed);
                    cars.Add(f);
                    break;
                case 2:
                    Car g = new Car(5, 350, xSpeed);
                    cars.Add(g);
                    break;
                case 3:
                    Car h = new Car(this.Width - 55, 400, -xSpeed);
                    cars.Add(h);
                    break;
                case 4:
                    Car i = new Car(5, 450, xSpeed);
                    cars.Add(i);
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
            updateTimerSet--;
            newCarTimer--;
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
                    gameOver.Play();
                    dodgeCars.ChangeScreen(this, new GameOver());
                    timerGo.Enabled = false;
                    break;
                }
            }

            if (updateTimerSet == 200)
            {
                timerSet = 20;
            }
            else if (updateTimerSet == 100)
            {
                timerSet = 5;
            }
            else if(updateTimerSet == 0)
            {
                updateTimerSet = 300;
            }
 

            if (newCarTimer <= 0)
            {
                newCarTimer = timerSet;
                newCar();
            }

            if (hero.y < 0 + hero.height)
            {


                gainedPoint.Play();
                score++;
                hero.y = 500;

                if (score % 5 == 0)
                {
                    xSpeed += 10;
                }
            }
            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            scoreLabel.Text = $"{score}";

            foreach (Car c in cars)
            {
                e.Graphics.FillEllipse(Brushes.Red, c.x, c.y, c.width, c.height);
            }
            e.Graphics.FillRectangle(Brushes.Blue, hero.x, hero.y, hero.width, hero.height);
        }
    }
}
