using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace BattleShipbyANH
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var file = $"{Path.GetTempPath()}temp.mp3";
            if (!File.Exists(file))
            {
                using (Stream output = new FileStream(file, FileMode.Create))
                {
                    output.Write(Properties.Resources.theme, 0, Properties.Resources.theme.Length);
                }
            }
            var wmp = new WindowsMediaPlayer { URL = file };
            wmp.controls.play();
                   
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BattleShipbyANH());
        }
    }
}
