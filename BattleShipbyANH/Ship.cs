using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipbyANH
{
    class Ship :ImageProcess
    {
        public Ship(Image img, Point loc, Size size, int v) : base(img, loc, size, v) { }
        public Rocket Fire()
        {
            Image kaboom = Properties.Resources.KaBoom;
            Image rocketImg = Properties.Resources.rocket;
            return new Rocket(kaboom,rocketImg, new Point(this.Location.X, this.Location.Y - this.Size.Height), this.Size,10);
        }
    }
}
