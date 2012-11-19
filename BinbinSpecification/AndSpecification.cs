namespace BinbinSpecification
{
    public class AndSpecification : CompositeSpecification
    {
        private ISpecification One;
        private ISpecification Other;

        public AndSpecification(ISpecification x, ISpecification y)
        {
            One = x;
            Other = y;
        }

        public override bool IsSatisfiedBy(object candidate)
        {
            return One.IsSatisfiedBy(candidate) && Other.IsSatisfiedBy(candidate);
        }
    }
}