namespace BinbinSpecification {
    public class NotSpecification : CompositeSpecification {
        private readonly ISpecification _wrapped;

        public NotSpecification(ISpecification x) {
            _wrapped = x;
        }

        public override bool IsSatisfiedBy(object candidate) {
            return !_wrapped.IsSatisfiedBy(candidate);
        }
    }
}