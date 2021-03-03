using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public class CollisionCalc
    {
        public static bool Calc(Button btnGlavni, Button btn)
        {
            return ((btnGlavni.Location.X + btnGlavni.Width) >= btn.Location.X && (btnGlavni.Location.X + btnGlavni.Width) <= (btn.Location.X + btn.Width) && ((btnGlavni.Location.Y >= btn.Location.Y && btnGlavni.Location.Y <= (btn.Location.Y + btn.Height)) ||
                                     ((btnGlavni.Location.Y + btnGlavni.Height) >= btn.Location.Y && (btnGlavni.Location.Y + btnGlavni.Height) <= (btn.Location.Y + btn.Height))));
        }
        public static bool CalcFire(Button btnGlavni, PictureBox fire)
        {
            if( btnGlavni.Location.X >=55 && btnGlavni.Location.X <= 70)
            {
                return true;
            }
            return false;
        }
        public static void Check()
        {

        }
    }
}
