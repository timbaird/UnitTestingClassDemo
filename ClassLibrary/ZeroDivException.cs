
using System;

namespace ClassLibrary
{
    public class ZeroDivException:Exception
    {
        public ZeroDivException(string message):base(message){}
    }
}