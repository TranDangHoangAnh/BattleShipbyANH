using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipbyANH
{
    enum Direction { Up,Down,Left,Right};
     abstract class ImageProcess
    {
        private Image image;
        private Point location;
        private Size size;
        private int speed;

        public Point Location { get => location; set => location = value; }
        public Image Image { get => image; set => image = value; }
        public Size Size { get => size; set => size = value; }
        public int Speed { get => speed; set => speed = value; }

        protected ImageProcess(Image image, Point location, Size size, int speed)
        {
            this.image = image;
            this.location = location;
            this.size = size;
            this.speed = speed;
        }
        public Rectangle Rect { get => new Rectangle(location, size); }
        virtual public void Draw(Graphics g)
        {
            g.DrawImage(this.image,
                new Rectangle(this.location, this.size),
                new Rectangle(0, 0, this.image.Width, this.image.Height),
                GraphicsUnit.Pixel);
        }
        virtual public void Move(Direction dir)
        {
            switch (dir)
            {
                case Direction.Down:
                    location.Y += speed;
                    break;
                case Direction.Up:
                    location.Y -= speed;
                    break;
                case Direction.Left:
                    location.X -= speed;
                    break;
                case Direction.Right:
                    location.X += speed;
                    break;
            }
        }
        virtual public bool isCollision(ImageProcess obj)
        {
            return this.Rect.IntersectsWith(obj.Rect);
        }
        virtual public bool isOutOfFrame(Size size)
        {
            return !(new Rectangle(0, 0, size.Width, size.Height).IntersectsWith(this.Rect));
        }
    }
}
