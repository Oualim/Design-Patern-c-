using System;
namespace DesignPattern.Flyweight
{
  public class Client
  {
    public void LoadFlyweight(){
      
      FabriqueOption fabrique = new FabriqueOption();
      VehiculeCommande vehicule = new VehiculeCommande();
      vehicule.ajouteOptions("air bag", 80, fabrique);
      vehicule.ajouteOptions("direction assist�e", 90,
                             fabrique);
      vehicule.ajouteOptions("vitres �lectriques", 85,
                             fabrique);
      vehicule.afficheOptions();
    }
  }
}