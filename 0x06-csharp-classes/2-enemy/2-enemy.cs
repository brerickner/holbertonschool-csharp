using System;

namespace Enemies
{
    /// <summary>Represents a Zombie within Enemies</summary>
    public class Zombie
    {
        /// <summary>Member <see cref="Zombie.health"/> of <see cref="Zombie"/> class.</summary>
        public int health;
        
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
    }
}
