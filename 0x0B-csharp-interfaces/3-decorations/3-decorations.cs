﻿using System;

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

/// <summary>
/// Class Decoration that inherits from Base, IInteractive and IBreakable
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// Public property name of type string
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Public property durability of type int
    /// </summary>
    public int durability { get; set; }
    
    /// <summary>
    /// Override method ToString that returns string for name's type 'name is a type'
    /// </summary>
    /// <returns>string</returns>
    public override string ToString()
    {
        return name + " is a " + this.GetType().Name;
    }

    /// <summary>
    /// Constructor sets value of 'name' if provided, else default value of 'Decoration'
    /// </summary>
    public Decoration(string name = "Decoration")
    {
        this.name = name;
    }

    /// <summary>
    /// Method Interact implemented to print 'The name has been broken.' if
    /// durability is 0 or less. 
    /// Else if isQuestItem is true, print 'You look at the name. There's a key inside.'
    /// Else isQuestItem is false, print 'You look at the 'name'. Not much to see here.'
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine("The " + this.name + " has been broken.");
        }
        else if (isQuestItem)
        {
            Console.WriteLine("You look at the " + this.name + ". There's a key inside.");
        }
        else
        {
            Console.WriteLine("You look at the " + this.name + ". Not much to see here.");
        }
    }

    /// <summary>
    /// Method Break implemented to decrement durability by 1.
    /// If durability is greater than 0, print 'You hit the 'name'. It cracks.'
    /// If durability is 0, print 'You smash the 'name'. What a mess.'
    /// if durability is less than 0, print 'The 'name' is already broken.'
    /// </summary>
    public void Break()
    {
        if (durability > 0)
        {
            durability--;
            Console.WriteLine("You hit the " + this.name + ". It cracks.");
        }
        else if (durability == 0)
        {
            Console.WriteLine("You smash the " + this.name + ". What a mess.");
        }
        else
        {
            Console.WriteLine("The " + this.name + " is already broken.");
        }
    }

    /// <summary>
    /// Public isQuestItem of type bool
    /// </summary>
    public bool isQuestItem { get; set; }

    /// <summary>
    /// Constructor sets value of name, durability and isQuestItem
    /// </summary>
    /// <param name="name">string defaults to "Decoration" if none provided</param>
    /// <param name="durability">int defaults to 1 if none provided</param>
    /// <param name="isQuestItem">bool defaults to "false" if none provided</param>
    /// <exception cref="ArgumentException">'Durability must be greater than 0'</exception>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new ArgumentException("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

}
