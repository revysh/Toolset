using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostsharpSample
{
    public class PostSharpTest
    {
        [PostSharpMethodBoundary]
        public void PostSharpMethodBoundaryTest()
        {
            Console.WriteLine("PostSharpMethodBoundaryTest -ravi");
        }

        [PostSharpMethodInterception]
        public void PostSharpMethodInterceptionTest()
        {
            Console.WriteLine("PostSharpMethodInterceptionTest -ravi");
        }
    }
}
