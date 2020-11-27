using System;
namespace Inheritance
{
    public class Bird: Animal, IWalk, IFly 
    {
        public Bird(String newName) : base(newName)
        {
        }

        public override String ToString()
        {
            String output = "";
            output += "This is a bird named " + GetName() + ". It can fly and walk." +
            	" It appears to be ";
            if (IsAlive())
                output += "alive.";
            else
                output += "dead. ";

            return output;
        }

		public override void ShowStats()
		{
			Console.WriteLine("Name: " + this.GetName());
			Console.WriteLine("State: " + this.IsAlive());
			Console.WriteLine("Abilities: walk, fly");
		}

        public void Live()
        {
            Console.WriteLine("peepeepoopoo");
        }

        public void Walk()
        {
            Console.WriteLine("walk_animation.fbx");
        }

        public void Fly()
        {
            Console.WriteLine("fly_animation.gif");
        }
    }
}
