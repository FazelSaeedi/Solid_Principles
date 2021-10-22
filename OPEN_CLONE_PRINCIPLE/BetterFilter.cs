using System.Collections.Generic;

namespace Solid_Principles.OPEN_CLONE_PRINCIPLE
{
    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecifiaction<Product> spec)
        {
            foreach(var i in items)
                if(spec.IsSatified(i))
                    yield return i ;
        }
    }

}