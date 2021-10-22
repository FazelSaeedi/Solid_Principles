namespace Solid_Principles.OPEN_CLONE_PRINCIPLE
{
    public class ColorSpecification : ISpecifiaction<Product>
    {
        private Color color ; 

        public ColorSpecification(Color color)
        {
            this.color = color;
        }
        public bool IsSatified(Product type)
        {
            return type.Color == color ; 
        }

   }

}