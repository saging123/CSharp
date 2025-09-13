using GameApp.Libraries.Abstracts;

namespace GameApp.Libraries.Items
{

    class Potion: GameItem
    {
        public int HealAmount;
        public Potion(String name, int healAmount) : base(name)
        {
            this.HealAmount = healAmount;
        }

        public override void AddItem(GameItem item)
        {
            throw new NotImplementedException();
        }

        public override GameItem GetItem(int index)
        {
            throw new NotImplementedException();
        }

        public override void UseItem()
        {
            // specific effect or damage
            Console.WriteLine("You drank "+this.Name+"Restored " +this.HealAmount+ "HP!");
        }

    }




}