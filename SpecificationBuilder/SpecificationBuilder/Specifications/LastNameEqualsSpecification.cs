using System;

namespace SpecificationBuilder.Specifications
{
    public class LastNameEqualsSpecification : ISpecification
    {
        public bool IsSatisfiedBy<Contact, TComparisonType>(T input, TComparisonType value)
        {
            throw new NotImplementedException();
        }
    }
}