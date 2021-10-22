using System;

namespace Solid_Principles.INTERFACE_SEGREGATION_PRINCIPLE
{
    public class photocopier : IPrinter, IScanner
        {
            public void Print(Document d)
            {
                throw new NotImplementedException();
            }

            public void scan(Document d)
            {
                throw new NotImplementedException();
            }
        }
    
}