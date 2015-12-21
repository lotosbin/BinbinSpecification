namespace BinbinSpecification {
    public abstract class CompositeSpecification2<T> : Specification2<T> {
        public abstract ISpecification2<T> Left { get; }
        public abstract ISpecification2<T> Right { get; }
    }
}