namespace Solid_Principles.INTERFACE_SEGREGATION_PRINCIPLE
{
    public interface IMachine
        {
            void Print(Document d);
            void Scan(Document d);
            void Fax(Document d);
        }
    
}