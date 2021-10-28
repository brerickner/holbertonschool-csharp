using System;

/// <summary>
/// Public class {CurrentHPArgs} inherits from EventArgs.
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// Public property type float {currentHP} cannot be modified.
    /// </summary>
    public float currentHP { get; private set; }

    /// <summary>
    /// Constructor
    /// Takes type float {newHp} and sets it as {currentHp}
    /// </summary>
    /// <param name="newHp">float newHp</param>
    public CurrentHPArgs(float newHp)
    {
        this.currentHP = newHp;
    }
}

/// <summary>
/// Enum {Modifier} with values {Weak} {Base} {Strong}.
/// </summary>
public enum Modifier
{
    /// <summary>Modifier value Weak.</summary>
    Weak,
    /// <summary>Modifier value Base.</summary>
    Base,
    /// <summary>Modifier value Strong.</summary>
    Strong
}
/// <summary>Delegate {CalculateModifier} takes float {baseValue} and Modifier {modifier}.</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>Delegate {CalculateHealth} takes float{amount}</summary>
public delegate void CalculateHealth(float amount);


/// <summary>Public class {Player}</summary>
public class Player
{
    /// <summary>Public property type string {name}</summary>
    private string name;

    /// <summary>Public eventHandler of type {CurrentHPArgs}{HPCheck}</summary>
    public EventHandler<CurrentHPArgs> HPCheck;

    /// <summary>Private proerty type string {status} default '{name} is ready to go!'</summary>
    private string status;


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
        this.status = this.name + " is ready to go!";
        this.HPCheck = this.CheckStatus;
    }

    /// <summary>
    /// Public method type void {PrintHealth}.
    /// Prints '{name} has {hp} / {maxHp} health'.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }



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
            Console.WriteLine("{0} takes {1} damage!", this.name, damage);
            ValidateHP(this.hp -= damage);
        }
    }

    /// <summary>
    /// Public method {HealDamage} type void takes float{heal}.
    /// Prints '{name} heals {heal} HP!'.
    /// If {heal} negative, {Player} {heal} is 0 HP and prints '{name} heals 0 HP!'.
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
            Console.WriteLine("{0} heals {1} HP!", this.name, heal);
            ValidateHP(this.hp += heal);
        }
    }

   /// <summary>
    /// Public method {ValidateHP} takes float {newHp}.
    /// If {damage} taken, subtract {damage} from {hp}
    /// If health is healed, add {heal} to {hp}
    /// </summary>
    /// <param name="newHp">float newHp</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            newHp = 0;
        }
        if (newHp > this.maxHp)
        {
            newHp = this.maxHp;
        }
        this.hp = newHp;
        this.HPCheck(this, new CurrentHPArgs(this.hp));
    }

    /// <summary>
    /// Method {ApplyModifier} takes float {baseValue} and Modifier {modifier}.
    /// If {modifier} is Weak, return half of {baseValue}.
    /// If {modifier} is Base, return {baseValue}.
    /// If {modifier} is Strong, return 1.5 * {baseValue}.
    /// </summary>
    /// <param name="baseValue">float baseValue</param>
    /// <param name="modifier">Modifier modifier</param>
    /// <returns>float</returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
        {
            return baseValue / 2;
        }
        else if (modifier == Modifier.Base)
        {
            return baseValue;
        }
        else
        {
            return baseValue * 1.5f;
        }
    }

    /// <summary>
    /// Private method {CheckStatus} with parameters of type object {sender} and 
    /// type {CurrentHPArgs}{e}.
    /// Depending on {e.currentHP} value, set Player {status} and print statements regarding status.
    /// If {e.currentHp} is equal to {maxHp} print '{name} is in perfect health!'.
    /// If {e.currentHp} between 0.5 of {maxHp}(inclusive) and {maxHp}(exclusive)
    /// print '{name} is doing well'.
    /// If {e.currentHp} between 0.25 of {maxHp}(inclusive) and 0.5(exclusive)
    /// print '{name} is isn't doing to great...'.
    /// If {e.currentHp} between 0(exclusive) and 0.25(exclusive)
    /// print '{name} is knocked out!'.
    /// </summary>
private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHP == this.maxHp)
        {
           System.Console.WriteLine(this.name + " is in perfect health!"); 
        }
        else if (e.currentHP >= this.maxHp * 0.5f && e.currentHP < this.maxHp)
        {
            System.Console.WriteLine(this.name + " is doing well!");
        }
        else if (e.currentHP >= this.maxHp * 0.25f && e.currentHP < this.maxHp * 0.5f)
        {
            System.Console.WriteLine(this.name + " isn't doing too great..."); 
        }
        else if (e.currentHP > 0 && e.currentHP < this.maxHp * 0.5f)
        {
            System.Console.WriteLine(this.name + " needs help!"); 
        }
        else
        {
            System.Console.WriteLine(this.name + " is knocked out!");
        }
    }
}
