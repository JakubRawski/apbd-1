using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie1.Classes
{
    public class BClass : Classa1
    {
        public int MyProp { get; set; }
        public BClass(int num,int prop) : base(num) { 
            MyProp = prop;
        }

        public override void SendMessage(string message)
        {
            Console.WriteLine("xd" +message);
        }
    }
}
