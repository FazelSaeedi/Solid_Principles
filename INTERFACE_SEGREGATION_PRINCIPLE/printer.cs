using System;

namespace Solid_Principles.INTERFACE_SEGREGATION_PRINCIPLE
{
    public class printer : IPrinter
        {
            public void Print(Document d)
            {
                Console.WriteLine($" {d.Name} Printed");
            }
        }
    
}