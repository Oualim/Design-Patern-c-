using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        
            static void Main(string[] args)
            {
                ClientVehicule client = new ClientVehicule(); // Instancie l objet dans lequel se trouve mon prog d'affichage

                client.LoadBuilder(); //appel de la methode de l'objet instancié au dessus
            }
        
    }
    
}
