using GameApp.Libraries.Abstracts;
using GameApp.Libraries.Interfaces;

namespace GameApp.Libraries.Items
{

    class MagicBag : GameItem
    {
        public GameItem[] Items;
        public int MaxCapacity;
        private int Current;
        public MagicBag(String name, int MaxCapacity) : base(name)
        {
            this.MaxCapacity = MaxCapacity;
            Items = new GameItem[this.MaxCapacity];
            this.Current = 0;
        }

        public override void AddItem(GameItem item)
        {
            Console.WriteLine("You have added " + item.Name);
            this.Items[this.Current++] = item;
        }

        public override GameItem GetItem(int Index)
        {
            return this.Items[Index];
        }


        public override void UseItem()
        {
            // specific effect or damage
            Console.WriteLine("You have these: ");
            this.PrintItems();
        }
        private void PrintItems() {
            for (int i = 0; i < this.Current; i++)
            {
                Console.WriteLine("Item:" + (i+1) + " " + this.Items[i].Name);
    
            }
        }

    }




}