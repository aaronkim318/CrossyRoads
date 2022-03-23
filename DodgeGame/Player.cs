using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DodgeGame
{
    internal class Player
    {
        public int x, y;
        public int height = 10;
        public int width = 6;
        public int speed = 6;

        public Player(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public void Move(string direction, Size ss)
        {
            //if the direction is left. go left
            if (direction == "left")
            {
                x -= speed;

                if (x < 0)
                {
                    x = 0;
                }
            }
            //changes the direction to right
            if (direction == "right")
            {
                x += speed;

                if (x > ss.Width - width)
                {
                    x = ss.Width - width;
                }
            }
            //changes the direction up
            if (direction == "up" == true)
            {
                y -= speed;

                if (y < 0)
                {
                    y = 0;
                }
            }
            //change the direction down
            if (direction == "down")
            {
                y += speed;

                if (y > ss.Height - height)
                {
                    y = ss.Height - height;
                }
            }
        }
    }
}
