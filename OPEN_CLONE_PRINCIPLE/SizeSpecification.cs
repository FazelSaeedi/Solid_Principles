namespace Solid_Principles.OPEN_CLONE_PRINCIPLE
{
    public class SizeSpecification : ISpecifiaction<Product>
    {
        private Size size ;

        public SizeSpecification(Size size)
        {
            this.size = size;
        }

        public bool IsSatified(Product type)
        {
            return type.Size == size ; 
        }
    }

}