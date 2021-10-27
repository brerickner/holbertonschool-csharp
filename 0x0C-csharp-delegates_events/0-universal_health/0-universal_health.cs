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
}
