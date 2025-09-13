using GameApp.Libraries.Abstracts;

namespace GameApp.Libraries.Items
{

    class Shield : GameItem
    {
        public int Defense;
        public Shield(String name, int defense) : base(name)
        {
            this.Defense = defense;
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
            Console.WriteLine("You equipped "+this.Name+". Defense increased by !" + this.Defense);

        }

    }




}