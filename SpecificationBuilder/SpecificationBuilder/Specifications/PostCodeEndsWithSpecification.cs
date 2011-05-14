namespace SpecificationBuilder.Specifications
{
    public class PostCodeEndsWithSpecification : ISpecification<Address, string>
    {
        public bool IsSatisfiedBy(Address input, string value)
        {
            if (input.PostCode.EndsWith(value))
            {
                return true;
            }
            return false;
        }
    }
}