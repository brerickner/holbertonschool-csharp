using System;

namespace Enemies
{
    /// <summary>Represents a Zombie within Enemies</summary>
    public class Zombie
    {
        /// <summary>Member <see cref="Zombie.health"/> of <see cref="Zombie"/> class.</summary>
        public int health;
        /// <summary>Member "name" of <see cref="Zombie"/> class.</summary>
        private string name = "(No name)";
   
        /// <summary>Gets or sets the name.</summary>
        public string Name 
        { 
            get
            {
                return (name);
            } 
            set
            {
                name = value;
            }
        }
        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class.</summary>
        public Zombie()
        {
            health = 0;
        }
        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class.</summary>
        /// <param name="value">Amount of health</param>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
                health = value;
        }
        /// <summary>Retrieves health status of <see cref="Zombie"/> object.</summary>lth() 
        /// <returns>that returns the value of health of the Zombie object</returns> 
        public int GetHealth()
        {
            return (health);
        }
        /// <summary>Customizes string representation</summary>
        /// <returns>Name of zombie and health status</returns>
        public override string ToString()
        {
            return ($"Zombie Name: {name} / Total Health: {health}");
        }
    }
}
