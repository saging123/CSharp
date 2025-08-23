using Day3.Libraries.Interfaces;

namespace Day3.Libraries
{

    public class Pistol : Gun
    {

        // can only be read but not allowed to reassign value
        private readonly String name = "Pistol";
        private int MaxBullets;
        private int CurrentBullets;

        // buying Phase constructor
        public Pistol()
        {
            this.MaxBullets = 10;
            this.CurrentBullets = this.MaxBullets;
            Console.WriteLine("You Have purchased " + this.name);
        }
        // Picking Up
        public Pistol(int bullets)
        {
            this.MaxBullets = 10;
            this.CurrentBullets = bullets;
            Console.WriteLine("You have picked Up " + this.name);
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

