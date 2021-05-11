using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipbyANH
{
    class Rocket :ImageProcess
    {
        Image effectImage;
        bool isBoom;
        public Rocket(Image effectImage, Image img, Point loc, Size size, int v) : base(img, loc, size, v) 
        {
            this.effectImage = effectImage;
            this.isBoom = false;
        }
        public Image EffectImage { get => effectImage; set => effectImage = value; }
        public bool IsBoom { get => isBoom; set => isBoom = value; }
        override public void Draw(Graphics g)
        {
            g.DrawImage(this.Image,
                new Rectangle(this.Location, this.Size),
                new Rectangle(0, 0, this.Image.Width, this.Image.Height),
                GraphicsUnit.Pixel);
        }
        public override bool isCollision(ImageProcess obj)
        {
            bool isCol = base.isCollision(obj);
            if (isCol)
            {
                this.isBoom = true;
                this.Image = this.effectImage;
            }
            return isCol;
        }
    }
}
