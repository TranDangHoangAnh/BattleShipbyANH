using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShipbyANH
{


    public partial class GamePlay : Form
    {
        List<Rocket> rockets;
        bool isGameover;
        Ship ship;
        List<Asteroid> asteroids;
        int Score;
        int MAXAsSLICE = 10;
        int AsSlice;
        int DelayFalling = 1;
        int count;
        Image Asteroidimg;
        Timer refresh;

        Random random;


        public GamePlay()
        {
            Image imageShip = Properties.Resources.ship;

            InitializeComponent();
            this.ClientSize = new Size(500, 700);
            ship = new Ship(imageShip, new Point(this.ClientSize.Width / 2 - 30, this.ClientSize.Height - 50), new Size(60, 60), 20);

            asteroids = new List<Asteroid>();
            AsSlice = MAXAsSLICE;
            Asteroidimg = Properties.Resources.rock;
            random = new Random((int)DateTime.Now.Ticks);
            rockets = new List<Rocket>();
            Score = 0;
            isGameover = false;
            refresh = new Timer();
            refresh.Interval = 2;
            refresh.Tick += refresh_Tick;
            refresh.Start();
        }
        private void refresh_Tick(object sender, EventArgs e)
        {
            if (!isGameover)
            {
                for (int i = asteroids.Count - 1; i >= 0; i--)
                {
                    if (ship.isCollision(asteroids[i]))
                    {
                        isGameover = true;
                    }
                    if (asteroids[i].isOutOfFrame(this.ClientSize))
                    {
                        asteroids.RemoveAt(i);
                    }
                    else
                    {
                        asteroids[i].Move(Direction.Down);
                    }
                }
                if (AsSlice == 0)
                {
                    if (count < DelayFalling)
                    {
                        count++;
                    }
                    else
                    {
                        count = 0;
                        asteroids.Add(
                        new Asteroid(Asteroidimg, new Point(random.Next(0, this.ClientSize.Width - 60), 0),
                        new Size(60, 60), 7));
                    }
                }
                AsSlice--;
                if (AsSlice < 0)
                    AsSlice = MAXAsSLICE;

                for (int i = rockets.Count - 1; i >= 0; i--)
                {
                    if (rockets[i].IsBoom)
                    {
                        rockets.RemoveAt(i);
                        break;
                    }
                    bool isCol = false;
                    foreach (var s in asteroids)
                    {
                        if (rockets[i].isCollision(s))
                        {
                            isCol = true;
                            asteroids.Remove(s);
                            Score++;
                            rockets[i].IsBoom = true;
                            break;
                        }
                    }
                    if (!isCol)
                        rockets[i].Move(Direction.Up);
                }
                this.Invalidate();

            }
            else
                GamOver();
        }

        private void GamOver()
        {
            this.refresh.Stop();
            DialogResult result = MessageBox.Show(this, $"SCORE:{Score}\nHIT YES TO RESTART OR NO TO EXIST GAME", "GAME OVER", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                GamePlay gamePlay = new GamePlay();
                gamePlay.Show();

            }
            else
            {
                Application.Exit();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            ship.Draw(g);
            foreach (var s in asteroids)
            {
                s.Draw(g);
            }
            foreach (var r in rockets)
            {
                r.Draw(g);
            }
            string strScore = "Scores: " + Score.ToString();
            Font scoreFont = new Font(FontFamily.GenericSansSerif, 20);
            Size size = TextRenderer.MeasureText(strScore, scoreFont);
            g.DrawString(strScore, scoreFont, new SolidBrush(Color.White), new Point(0, this.ClientSize.Height - size.Height));
        }
        private void GamePlay_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    ship.Move(Direction.Left);
                    break;
                case Keys.Right:
                    ship.Move(Direction.Right);
                    break;
                case Keys.Up:
                    ship.Move(Direction.Up);
                    break;
                case Keys.Down:
                    ship.Move(Direction.Down);
                    break;
                case Keys.Space:
                    rockets.Add(ship.Fire());
                    break;
            }

        }

        private void GamePlay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
