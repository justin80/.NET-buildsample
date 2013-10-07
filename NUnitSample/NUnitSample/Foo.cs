using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSample
{
    public class Foo
    {
        public string SayHello(string name)
        {
            return string.Format("Hello, {0}", name);
        }

        public string SayGoodbye(string name)
        {
            return string.Format("Goodbye, {0}", name);
            //throw new NotImplementedException();
        }
    }
}
