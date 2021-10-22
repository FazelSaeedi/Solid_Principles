using System;

namespace Solid_Principles.OPEN_CLONE_PRINCIPLE
{
    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;
        public Product(string name, Color color, Size size)
        {
            if(name == null)
            {
                throw new ArgumentNullException(paramName: nameof(name));
            }

            Name = name ;
            Color = color ;
            Size = size ;
        }  
    }

}