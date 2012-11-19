namespace BinbinSpecification
{
    public class NotSpecification : CompositeSpecification
    {
        private ISpecification Wrapped;

        public NotSpecification(ISpecification x)
        {
            Wrapped = x;
        }

        public override bool IsSatisfiedBy(object candidate)
        {
            return !Wrapped.IsSatisfiedBy(candidate);
        }
    }
}