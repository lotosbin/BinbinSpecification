namespace BinbinSpecification {
    public class AndSpecification : CompositeSpecification {
        private readonly ISpecification _one;
        private readonly ISpecification _other;

        public AndSpecification(ISpecification x, ISpecification y) {
            _one = x;
            _other = y;
        }

        public override bool IsSatisfiedBy(object candidate) {
            return _one.IsSatisfiedBy(candidate) && _other.IsSatisfiedBy(candidate);
        }
    }
}