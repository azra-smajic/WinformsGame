

namespace Game
{
   
    public class Level
    {
        public int Id { get; set; }
        public string  Ime { get; set; }
        public int XP { get; set; }
        public override string ToString()
        {
            return Ime;
        }
    }
}