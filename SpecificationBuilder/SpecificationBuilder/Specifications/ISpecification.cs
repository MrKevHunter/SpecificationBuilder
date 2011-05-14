namespace SpecificationBuilder.Specifications
{
    public interface ISpecification
    {
        bool IsSatisfiedBy<T, TComparisonType>(T input, TComparisonType value);
    }
}