
namespace BinbinSpecification {
    public abstract class CompositeSpecification<T> : ICompsiteSpecification<T> {
        public abstract bool IsSatisfiedBy(T candidate);

        public ISpecification<T> Add(ISpecification<T> other) {
            return new AndSpecification<T>(this, other);
        }

        public ISpecification<T> Or(ISpecification<T> other) {
            return new OrSpecification<T>(this, other);
        }

        public ISpecification<T> Not() {
            return new NotSpecification<T>(this);
        }
    }
}