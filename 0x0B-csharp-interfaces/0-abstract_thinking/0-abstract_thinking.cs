using System;

/// <summary>
/// Abstract class Base 
/// </summary>
public abstract class Base
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
}
