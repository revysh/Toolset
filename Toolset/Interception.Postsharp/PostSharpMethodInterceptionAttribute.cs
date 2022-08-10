using PostSharp.Aspects;
using PostSharp.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostsharpSample
{
    [PSerializable]
    public class PostSharpMethodInterceptionAttribute : MethodInterceptionAspect
    {

        public override void RuntimeInitialize(System.Reflection.MethodBase method)
        {
            base.RuntimeInitialize(method);
        }

        public override void OnInvoke(MethodInterceptionArgs args)
        {
            Console.WriteLine("PostSharpMethodInterceptionAttribute start");
            args.Proceed();
            Console.WriteLine("PostSharpMethodInterceptionAttribute end");
        }
    }
}
