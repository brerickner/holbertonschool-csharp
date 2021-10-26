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
/// Class TestObject that inherits from Base, IInteractive, IBreakable, ICollectable
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>
    /// Public property name of type string
    /// </summary>
    public string name;

    /// <summary>
    /// Override method ToString that returns string for name's type 'name is a type'
    /// </summary>
    /// <returns>string</returns>
    public override string ToString()
    {
        return name + " is a " + this.GetType().Name;
    }

    ///<summary>
    /// Property isCollected of type bool
    ///</summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Property durability of type int
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Method Interact of type void
    /// </summary>
    public void Interact()
    {
        Console.WriteLine("Interaction with " + this.name);
    }
    
    /// <summary>
    /// Method Break of type void
    /// </summary>
    public void Break()
    {
        Console.WriteLine("Break " + this.name);
    }

    /// <summary>
    /// Method Collect of type void
    /// </summary>
    public void Collect()
    {
        Console.WriteLine("Collect " + this.name);
    }
}
