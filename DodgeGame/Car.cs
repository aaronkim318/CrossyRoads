using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DodgeGame
{
    
    internal class Car
    {
        public int height = 20;
        public int width = 50;
        public int x, y;
        public int xSpeed;



        public Car(int _x, int _y, int _xSpeed)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
        }
        public void Move(Size ss)
        {
            //makes the car move left and right
            x += xSpeed;

            //check if ball has reached right or left edge
            if (x > ss.Width - width || x < 0)
            {
                //if (x<0)
                //{
                //    x = 0;
                //}
                xSpeed *= -1;

            }
        }
        public bool Collison(Player p)
        {
            Rectangle CarRec = new Rectangle(x, y, width, height);
            Rectangle playerRec = new Rectangle(p.x, p.y, p.width, p.height);

            if (CarRec.IntersectsWith(playerRec))
            {
                xSpeed = 0;
                return true;
            }

            return false;
        }
    }
    
}
