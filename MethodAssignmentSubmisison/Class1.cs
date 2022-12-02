using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignmentSubmisison
{
    public class Class1
    {
        public int Value { get; set; }
        public int Valueb { get; set; } 


        public int MethodA(Class1 one)
        {
            return Value + Valueb;
        }
  
    }
}
