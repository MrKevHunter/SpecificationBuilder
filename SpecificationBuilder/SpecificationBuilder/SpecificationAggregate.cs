using System.Collections;
using System.Collections.Generic;
using SpecificationBuilder.Specifications;

namespace SpecificationBuilder
{
    public class SpecificationAggregate<T, TComparisonType>
    {
        private List<ISpecification<T,TComparisonType>> specs = new List<ISpecification<T, TComparisonType>>();
        public IEnumerable<ISpecification<T, TComparisonType>> GetList()
        {
            return specs;
        }

        public void AddSpecification(ISpecification<T,TComparisonType> input)
        {
            specs.Add(input);
        }
    }
}