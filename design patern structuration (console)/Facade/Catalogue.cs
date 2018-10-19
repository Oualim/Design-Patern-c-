using System;
using System.Collections.Generic;

namespace DesignPattern.Facade
{
  public interface Catalogue
  {
    IList<string> retrouveVehicules(int prixMin, int
      prixMax);
  }
}