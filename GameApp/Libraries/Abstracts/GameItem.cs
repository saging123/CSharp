using GameApp.Libraries.Interfaces;

namespace GameApp.Libraries.Abstracts
{
    abstract class GameItem : IGameItem, IBag
    {
        public String Name;

        public GameItem(String name)
        {
            this.Name = name;
        }

        public abstract void AddItem(GameItem item);

        public abstract GameItem GetItem(int index);

        public void ShowInfo()
        {
            Console.WriteLine("Item: " + this.Name);
        }
        public abstract void UseItem();
    }
}