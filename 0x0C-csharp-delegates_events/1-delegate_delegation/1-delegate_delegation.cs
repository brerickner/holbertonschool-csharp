using System;

/// <summary>Public class {Player}</summary>
public class Player
{
    /// <summary>Public property type string {name}</summary>
    private string name;

    /// <summary>Public property type float {maxHp}</summary>
    private float maxHp;

    /// <summary>Public property type float {hp}</summary>
    private float hp;

    /// <summary>
    /// Constructor.
    /// Prototype: public Player(string name, float maxHp).
    /// MaxHp must be greater than 0, else set maxHp to the default 100f 
    /// and print 'maxHp must be greater than 0. maxHp set to 100f by default.'.
    /// Value of hp set to maxHp.
    /// </summary>
    /// <param name="name">string name = Player(default)</param>
    /// <param name="maxHp">float maxHp = 100f(default)</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        else
        {
            this.name = name;
            this.maxHp = maxHp;
        }
        this.hp = maxHp;
    }

    /// <summary>
    /// Public method type void {PrintHealth}.
    /// Prints '{name} has {hp} / {maxHp} health'.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }

    /// <summary>Delegate {CalculateHealth} takes float{amount}</summary>
    public delegate void CalculateHealth(float amount);

    /// <summary>Public method {TakeDamage} type void takes float{damage}.
    /// Prints '{name} takes {damage} damage!'.
    /// If {damage} negative, {Player} takes 0 damage and prints '{name} takes 0 damage!'
    /// </summary>
    /// <param name="damage">float damage</param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            Console.WriteLine("{0} takes 0 damage!", this.name);
        }
        else
        {
            this.hp -= damage;
            Console.WriteLine("{0} takes {1} damage!", this.name, damage);
        }
    }

    /// <summary>
    /// Public method {HealDamage} type void takes float{heal}.
    /// Prints '{name} heals {heal} HP!'.
    /// If {heal} negative, {Player} heals 0 HP and prints '{name} heals 0 HP!'.
    /// </summary>
    /// <param name="heal">float heal</param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            Console.WriteLine("{0} heals 0 HP!", this.name);
        }
        else
        {
            this.hp += heal;
            Console.WriteLine("{0} heals {1} HP!", this.name, heal);
        }
    }
}
