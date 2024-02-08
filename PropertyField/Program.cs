// See https://aka.ms/new-console-template for more information
using System;

class PrivateField
{
  private int _value;
  public int Value
{
    get { return _value; }
    set { _value = value; }
  }
}

class Program
{
  static void Main()
    {
    PrivateField pf = new PrivateField();
    pf.Value = 5;
    Console.WriteLine(pf.Value);
    Console.ReadLine();
  }
}
