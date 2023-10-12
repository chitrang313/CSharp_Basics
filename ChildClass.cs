using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics {
    internal class ChildClass : Program{
        public static void Main(string[] args) {
            ChildClass c = new ChildClass();
            c.ProtectedFunction();
            c.InternalFunctin();
            c.InternalProtectedFunction();
            c.PublicFunction();
        }
    }
}
