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
    public partial class BattleShipbyANH : Form
    {
        public BattleShipbyANH()
        {
            InitializeComponent();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "1. ARROW KEY TO MOVE\n2. SPACE BAR TO SHOOT", "HOW TO PLAY",MessageBoxButtons.OK);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GamePlay gamePlay = new GamePlay();
            gamePlay.Show();

        }
    }
}
