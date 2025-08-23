using Day3.Libraries.Interfaces; // Import GUn

namespace Day3.Libraries.Abstracts
{
    public abstract class GunManager : Gun
    {
        private string name;
        private int MaxBullets;
        private int CurrentBullets;
        // buy
        public GunManager(string GunName, int MaxBullets)
        {
            this.name = GunName;
            this.MaxBullets = MaxBullets;
            this.CurrentBullets = this.MaxBullets;
            Console.WriteLine("You bought " + this.name);
        }
        // pickup
        public GunManager(string GunName, int MaxBullets, int CurrentBullets)
        {
            this.name = GunName;
            this.MaxBullets = MaxBullets;
            this.CurrentBullets = CurrentBullets;
              Console.WriteLine("You Picked " + this.name);
        }
        public void Shoot()
        {
            if (this.CurrentBullets == 0)
            {
                Console.WriteLine("Empty Magazine");
                this.Reload();
            }
            // this.CurrentBullets--;
            this.CurrentBullets -= 1;
            Console.WriteLine("Shooting.. >>> ");

        }
        public void Reload()
        {

            if (this.CurrentBullets == 0)
            {
                this.CurrentBullets = this.MaxBullets;
            }
            else
            {
                int toAdd = this.MaxBullets - this.CurrentBullets;
                Console.WriteLine(" Remaining " + this.CurrentBullets + " Reloading " + toAdd);
                this.CurrentBullets += toAdd; // this.CurrentBullets = this.CurrentBullets + toAdd;
            }
            Console.WriteLine("Reloading");

        }
        public void Status()
        {
            Console.WriteLine("Remaining Bullets " + this.CurrentBullets + " Out of " + this.MaxBullets);

        }
    }

}