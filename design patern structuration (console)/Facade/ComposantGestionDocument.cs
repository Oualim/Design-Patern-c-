using System;

namespace DesignPattern.Facade
{
  public class ComposantGestionDocument : GestionDocument
  {

    public string document(int index)
    {
      return "Document numero " + index;
    }
  }
}