using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie1.Classes
{
    
    
    public class Classa1 : Interface
    {
        public int id { get; set; }
        public Classa1(int num) { 
            id = num;
        }

        public virtual void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
