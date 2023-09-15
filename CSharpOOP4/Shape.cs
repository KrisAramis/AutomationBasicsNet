using System.Runtime.CompilerServices;

namespace CSharpOOP4
{
 public abstract class Shape
 {
  protected string _name;

  public string Name
  {
   get => _name;
  }

  public Shape()
  {
  }

  public Shape(string name)
  {
   _name = name;
  }

  public abstract double GetSquare();
  
  public virtual void ShapeInfo()
  {
   Console.WriteLine($"{Name} has square {GetSquare():F2}");
  }
 }
}