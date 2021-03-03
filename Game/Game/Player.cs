using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Player
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Password { get; set; }
        public virtual Level Level { get; set; }
        public byte[] Slika { get; set; }
        public int XP { get; set; }
        public override string ToString()
        {
            return Ime;
        }
    }
}
