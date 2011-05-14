namespace SpecificationBuilder.Specifications
{
    public class PostCodeStartsWithSpecification :ISpecification<Address,string>
    {


        public bool IsSatisfiedBy(Address input, string value)
        {
            if (input.PostCode.StartsWith(value))
            {
                return true;
            }
            return false;
        }
    }
}