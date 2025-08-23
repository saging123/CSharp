using Day3.Libraries.Abstracts; // gun manager

namespace Day3.NewGuns
{


    public class Ak47 : GunManager
    {
        public Ak47() : base("AK47", 20) { }
        public Ak47(int CurrBullet) : base("Ak47", 20,CurrBullet){}
       
    }
}