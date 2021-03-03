using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public class Position
    {
        static Point p;
        static int X;
        static int Y;
        public Position()
        {
            p = new Point();
          
        }
        public static void SetControlPosition(Control c, int x, int y)
        {
            if(c is Button)
            {
                var btn = c as Button;
                X = x;
                Y = y;
                p.X = X;
                p.Y = Y;
                btn.Location = p;
            }
        }
       
    }
}
