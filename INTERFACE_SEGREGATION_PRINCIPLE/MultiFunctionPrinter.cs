namespace Solid_Principles.INTERFACE_SEGREGATION_PRINCIPLE
{
    public class MultiFunctionPrinter : IMachine
        {
            public void Fax(Document d)
            {
                //
            }

            public void Print(Document d)
            {
                //
            }

            public void Scan(Document d)
            {
               //
            }
        }
    
}