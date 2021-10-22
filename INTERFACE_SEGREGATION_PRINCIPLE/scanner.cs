using System;

namespace Solid_Principles.INTERFACE_SEGREGATION_PRINCIPLE
{
    public class scanner : IScanner
        {
            public void scan(Document d)
            {
                Console.WriteLine($" {d.Name} Scaned");
            }
        }
    
}