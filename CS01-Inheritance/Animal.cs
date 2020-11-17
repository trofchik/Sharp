using System;
namespace Inheritance
{
    public abstract class Animal
    {
        bool alive = false;

        string name = "";

        public Animal(string newName)
        {
            this.SetName(newName);
            this.SetState(true);
        }

        public String GetName()
        {
            return name;
        }

        public void SetName(String newName)
        {
            name = newName;
        }

        public bool IsAlive()
        {
            return alive;
        }

        public void SetState(bool state)
        {
            alive = state;
        }

        public override String ToString()
        {
            String output = "";
            output += "This is an animal named " + GetName() + ". It appears to be ";
            if (IsAlive())
                output += "alive.";
            else
                output += "dead. ";

            return output;
        }
    }
}