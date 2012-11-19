namespace BinbinSpecification
{
    public class OrSpecification : CompositeSpecification
    {
        private ISpecification One;
        private ISpecification Other;

        public OrSpecification(ISpecification x, ISpecification y)
        {
            One = x;
            Other = y;
        }

        public override bool IsSatisfiedBy(object candidate)
        {
            return One.IsSatisfiedBy(candidate) || Other.IsSatisfiedBy(candidate);
        }
    }
}