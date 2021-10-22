namespace Solid_Principles.INTERFACE_SEGREGATION_PRINCIPLE
{
    public class MultiFunctionMachine : IMultiFunctionDevice
        {
            private IPrinter printer ;
            private IScanner scanner ;

            public MultiFunctionMachine(IPrinter printer, IScanner scanner)
            {
                this.printer = printer;
                this.scanner = scanner;
            }

            public void Print(Document d)
            {
                printer.Print(d);
            }

            public void scan(Document d)
            {
                scanner.scan(d);
            } // decorator
        }
    
}