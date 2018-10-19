using System;

namespace DesignPattern.Decorator
{
  public class VueVehicule : ComposantGraphiqueVehicule
  {
    public void affiche()
    {
      Console.WriteLine("Affichage du v¨¦hicule");
    }
  }
}