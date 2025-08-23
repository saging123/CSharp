using Day3.Libraries.Abstracts;

namespace Day3.NewGuns
{


    public class Pistol : GunManager
    {
        public Pistol() : base("Pistol", 10) { }
        public Pistol(int CurrBullet) : base("Pistol", 10,CurrBullet){}
       
    }
}