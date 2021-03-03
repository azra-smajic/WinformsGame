using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public class RandButton
    {
        public static void SetRandButton(Button btn)
        {
            
            btn.Height = btn.Height + 40;
            //btn.BackgroundImage = Image.FromFile("C:\\Users\\HOME\\Desktop\\New folder\\Amir\\Igrica\\Game\\bad_guy.png");
            //btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.BackColor = Color.Gray;
            btn.FlatStyle = FlatStyle.Popup;
        }
    }
}
