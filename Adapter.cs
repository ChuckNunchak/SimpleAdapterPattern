using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Adapter : UnchangedClass,IAdapter
    {
        public void OtherMethod(string message)
        {
            this.SomeMethod(message);
        }
    }
}
