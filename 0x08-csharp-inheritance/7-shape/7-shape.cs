using System;

/// <summary>
/// Class Shape
/// </summary>
class Shape
{
    /// <summary>
    /// Throw an exception for Not Implemented Exception
    /// </summary>
    /// <returns></returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Initializes a new instance of the <see cref="Shape"/> class.
/// </summary>
    class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// Retrieves width
    /// </summary>
    /// <value>width</value>
    public int Width{
        get => width;
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
            {
                width = value;
            }
        }
    }

    /// <summary>
    /// Retrieves height
    /// </summary>
    /// <value></value>
    public int Height{
        get => height;
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
            {
                height = value;
            }
        }
    }

    /// <summary>
    /// Calculates area
    /// </summary>
    /// <returns></returns>
    public new int Area()
    {
        return width * height;
    }

    /// <summary>
    /// Overrides str repr
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"[Rectangle] {width} / {height}";
    }
};
