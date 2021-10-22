using System;

namespace Solid_Principles.OPEN_CLONE_PRINCIPLE
{
    public class AndSpecification<T> : ISpecifiaction<T>
    {
        ISpecifiaction<T> first , second ;

        public AndSpecification(ISpecifiaction<T> first, ISpecifiaction<T> second)
        {
            this.first = first ?? throw new ArgumentNullException(paramName: nameof(first));
            this.second = second  ?? throw new ArgumentNullException(paramName: nameof(second));
        }

        public bool IsSatified(T type)
        {
            return first.IsSatified(type) && second.IsSatified(type); 
        }
    }

}