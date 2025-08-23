using Day3.NewGuns;
using Day3.Libraries.Interfaces;

namespace Day3
{

    public class Program
    {
        public static void Main(String[] args)
        {
            Gun g1 = new Ak47(4);

            int fireAuto = 20;
            for (int i = 0; i < fireAuto; i++)
            {
                g1.Shoot();
            }
            g1.Reload();
            g1.Status();
        }
    }
}