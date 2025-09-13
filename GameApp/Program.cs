using GameApp.Libraries.Abstracts;
using GameApp.Libraries.Items;

namespace GameApp
{
    class Program
    {
        public static void Main(String[] args)
        {

            GameItem magicBag = new MagicBag("Small Bag", 3);

            GameItem commonShield = new Shield("Zag Shield", 70);
            GameItem epicShield = new Shield("Areg Shield", 120);

            GameItem smallHeal = new Potion("Small Heal", 20);
            GameItem bigHeal = new Potion("Big Heal", 50);

            commonShield.ShowInfo();
            commonShield.UseItem();

            epicShield.ShowInfo();
            epicShield.UseItem();

            smallHeal.ShowInfo();
            smallHeal.UseItem();

            bigHeal.ShowInfo();
            bigHeal.UseItem();

            Console.WriteLine("----------------------");
            magicBag.ShowInfo();
            magicBag.AddItem(bigHeal);
            magicBag.AddItem(smallHeal);
            magicBag.AddItem(epicShield);
            magicBag.ShowInfo();
            magicBag.UseItem();

            
            



        }
    }
}