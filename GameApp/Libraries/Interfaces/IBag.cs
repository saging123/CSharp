using GameApp.Libraries.Abstracts;

namespace GameApp.Libraries.Interfaces
{
    interface IBag
    {
        void AddItem(GameItem item);
        GameItem GetItem(int index);
    }
}