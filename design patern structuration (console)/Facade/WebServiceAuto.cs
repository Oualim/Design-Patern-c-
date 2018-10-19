using System;
using System.Collections.Generic;

namespace DesignPattern.Facade
{
  public interface WebServiceAuto
  {
    string document(int index);
    IList<string> chercheVehicules(int prixMoyen, int
      ecartMax);
  }
}