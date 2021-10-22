using System.Collections.Generic;

namespace Solid_Principles.OPEN_CLONE_PRINCIPLE
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items , ISpecifiaction<T> spec);
    }

}