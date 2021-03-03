using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public class ChangeLevel
    {
        static List<Color> RandColor { get; set; } = new List<Color>();
        public static int Level = 1;
        public static int RandBtnHeight { get; set; } = 0;
        public static int RandBtnWidth { get; set; } = 0;

        public static int NextLevel(Button btnGlavni, Form frm)
        {
            btnGlavni.Height += 10;
            btnGlavni.Width += 10;
            btnGlavni.BackColor = GetRandomColor();
            frm.BackColor = GetRandomColor();
          
            return Level++;
        }
        public static void NextLevel(Button btnRand)
        {

            if (RandBtnHeight == 0 && RandBtnWidth == 0) {
                RandBtnHeight = btnRand.Height;
                RandBtnWidth = btnRand.Width;
            }
            btnRand.Height =RandBtnHeight+5;
            btnRand.Width =RandBtnWidth+5;
            RandBtnHeight = btnRand.Height;
            RandBtnWidth = btnRand.Width;
            btnRand.BackColor = GetRandomColor();
            Level++;
          
        }

        private static void InsertColors()
        {
            
            RandColor.Add(Color.AliceBlue);
            RandColor.Add(Color.LightGreen);
            RandColor.Add( Color.Bisque);
            RandColor.Add( Color.Brown);
            RandColor.Add( Color.BlueViolet);
            RandColor.Add( Color.BurlyWood);
            RandColor.Add( Color.CornflowerBlue);
            RandColor.Add( Color.DarkRed);
            RandColor.Add( Color.Azure);
            RandColor.Add( Color.Cyan);
            RandColor.Add(Color.Magenta);

        }
        private static Color GetRandomColor()
        {
            InsertColors();
            for (int i = 0; i < RandColor.Count(); i++)
            {
                Random r = new Random();
                return RandColor[r.Next(0, RandColor.Count())];
            }
            return default(Color);
        }
    }
}
