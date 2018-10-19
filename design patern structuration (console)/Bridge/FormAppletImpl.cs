using System;


namespace DesignPattern.Bridge
{
  public class FormAppletImpl : FormulaireImpl
  {

    public void dessineTexte(string texte)
    {
      Console.WriteLine("Applet : " + texte);
    }

    public string gereZoneSaisie()
    {
      return Console.ReadLine();
    }
  }
}