using System;

namespace DesignPattern.Bridge
{
  public class Utilisateur
  {
    public void LoadBridge() {
      FormImmatriculationLuxembourg formulaire1 = new FormImmatriculationLuxembourg(new FormHtmlImpl());
      formulaire1.affiche();
      if (formulaire1.gereSaisie())
        formulaire1.genereDocument();
      Console.WriteLine();
      FormImmatriculationFrance formulaire2 = new FormImmatriculationFrance(new FormAppletImpl());
      formulaire2.affiche();
      if (formulaire2.gereSaisie())
        formulaire2.genereDocument();
      
    }
  }
}