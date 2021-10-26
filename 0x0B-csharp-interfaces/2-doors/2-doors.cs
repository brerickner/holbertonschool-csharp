using System;

/// <summary>
/// Abstract class Base 
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Public property name of type string
    /// </summary>
    string name { get; set; }
    
    /// <summary>
    /// Override method ToString that returns string for name's type 'name is a type'
    /// </summary>
    /// <returns>string</returns>
    public override string ToString()
    {
        return name + " is a " + this.GetType().Name;
    }
}

/// <summary>
/// Interface IInteractive
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Method Interact of type void
    /// </summary>
    void Interact();
}

/// <summary>
/// Interface IBreakable
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// Property durability of type int
    /// </summary>
    int durability { get; set; }
    
    /// <summary>
    /// Method Break of type void
    /// </summary>
    void Break();
}

/// <summary>
/// Interface ICollectable
/// </summary>
public interface ICollectable
{
    ///<summary>
    /// Property isCollected of type bool
    ///</summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Method Collect of type void
    /// </summary>
    void Collect();
}

/// <summary>
/// Class Door inherits from Base and IInteractive
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// Public property name of type string
    /// </summary>
    public string name { get; set; }
    
    /// <summary>
    /// Override method ToString that returns string for name's type 'name is a type'
    /// </summary>
    /// <returns>string</returns>
    public override string ToString()
    {
        return name + " is a " + this.GetType().Name;
    }

    /// <summary>
    /// Constructor sets value of 'name' if provided, else default value of 'Door'
    /// </summary>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    /// <summary>
    /// Method Interact implemented to print 'You try to open the 'name'. It's locked.'
    /// </summary>
    public void Interact()
    {
        Console.WriteLine("You try to open the " + this.name + ". It's locked.");
    }
}