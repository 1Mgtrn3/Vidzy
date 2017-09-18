using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
         var DBContext = new VidzyEntities();
         var ReleaseDate = new System.DateTime(2008, 3, 9);
            
         DBContext.AddVideo("Se7en", ReleaseDate, "Horror", (byte)Classification.Platinum);
         DBContext.AddVideo("Watchmen",  new System.DateTime(2009, 7, 10), "Action", 2);   
         
            

        }
    }
}
