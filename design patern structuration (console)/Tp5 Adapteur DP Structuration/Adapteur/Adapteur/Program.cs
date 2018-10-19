using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapteur
{
    class Program
    {
        static void Main(string[] args)
        {
            



            ServeurWeb _adapter = new ServeurWeb();

            _adapter.LoadAdapter();
                              
        }
    }
}
