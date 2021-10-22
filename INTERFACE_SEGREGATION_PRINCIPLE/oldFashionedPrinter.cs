using System;

namespace Solid_Principles.INTERFACE_SEGREGATION_PRINCIPLE
{
    public class oldFashionedPrinter : IMachine
        {
            public void Fax(Document d)
            {
                throw new NotImplementedException();
            }

            public void Print(Document d)
            {
                //
            }

            public void Scan(Document d)
            {
                throw new NotImplementedException();
            }
        }
    
}