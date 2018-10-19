using System;

namespace DesignPattern.Bridge
{
  public interface FormulaireImpl
  {
    void dessineTexte(string texte);
    string gereZoneSaisie();
  }
}