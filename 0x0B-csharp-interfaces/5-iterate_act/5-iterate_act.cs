using System;
using System.Collections.Generic;


/// <summary>
/// Abstract class Base 
/// </summary>
public abstract class Base
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
        return name + " is a " + this.GetType();
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
    /// Constructor sets value of 'name' if provided, else defaults to value of 'Door'
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
    /// Property durability of type int
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Public isQuestItem of type bool
    /// </summary>
    public bool isQuestItem;

    /// <summary>
    /// Constructor sets value of name, durability and isQuestItem
    /// </summary>
    /// <param name="name">string defaults to "Decoration" if none provided</param>
    /// <param name="durability">int defaults to 1 if none provided</param>
    /// <param name="isQuestItem">bool defaults to "false" if none provided</param>
    /// <exception cref="ArgumentException">'Durability must be greater than 0'</exception>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability < 1)
        {
            throw new ArgumentException("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Method Interact.
    /// If durability is 0 or less print 'The name has been broken.' 
    /// Else if isQuestItem is true, print 'You look at the name. There's a key inside.'
    /// Else ifisQuestItem is false, print 'You look at the 'name'. Not much to see here.'
    /// </summary>
    public void Interact()
    {
        if (durability < 1)
        {
            Console.WriteLine("The " + this.name + " has been broken.");
        }
        else if (isQuestItem == true)
        {
            Console.WriteLine("You look at the " + this.name + ". There's a key inside.");
        }
        else if (isQuestItem == false)
        {
            Console.WriteLine("You look at the " + this.name + ". Not much to see here.");
        }
    }

    /// <summary>
    /// Method Break.
    /// If durability is greater than 0 print 'You hit the name. It cracks.'
    /// If durability is 0, print 'You smash the name. What a mess.'
    /// If durability is less than 0, print 'The name is already broken.'
    /// </summary>
    public void Break()
    {
        durability--;
        if (durability > 0)
        {
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
}

/// <summary>
/// Class Key inherits from Base, ICollectable
/// </summary>
public class Key : Base, ICollectable
{
    /// <summary>
    /// Property isCollected of type bool
    /// </summary>
    public bool isCollected { get; set; }
    
    /// <summary>
    /// Constructor sets value of name and isCollected as parameters
    /// If name is null, set name to "Key"
    /// If isCollected is null, set isCollected to false
    /// </summary>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// Method Collect.
    /// If isCollected is false, set to true and print 'You picked up the name.'
    /// If isCollected is true, print 'You have already picked up the name.'
    /// </summary>
    public void Collect()
    {
        if (isCollected == false)
        {
            isCollected = true;
            Console.WriteLine("You pick up the " + this.name + ".");
        }
        else
        {
            Console.WriteLine("You have already picked up the " + this.name + ".");
        }
    }
}

/// <summary>
/// Class RoomObjects
/// </summary>
public class RoomObjects
{
    /// <summary>
    /// Method IterateAction take a list of all objects, iterates through it, and
    /// executes methods depending on interface the item implements.
    /// Do nothing if roomObjects or type not provided
    /// </summary>
    /// <param name="roomObjects">List base roomObjects</param>
    /// <param name="type">Type type</param>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        if (roomObjects != null && type != null)
        {
            foreach (Base item in roomObjects)
            {
                if (item is IBreakable && type == typeof(IBreakable))
                {
                    IBreakable breakable = (IBreakable)item;
                    breakable.Break();
                }
                if (item is IInteractive && type == typeof(IInteractive))
                {
                    IInteractive interactive = (IInteractive)item;
                    interactive.Interact();
                }
                if (item is ICollectable && type == typeof(ICollectable))
                {
                    ICollectable collectable = (ICollectable)item;
                    collectable.Collect();
                }
            }
        }
    }
}
