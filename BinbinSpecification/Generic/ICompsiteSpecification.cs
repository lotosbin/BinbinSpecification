namespace BinbinSpecification {
    public interface ICompsiteSpecification<T> : ISpecification<T> {
        ISpecification<T> Add(ISpecification<T> other);
        ISpecification<T> Or(ISpecification<T> other);
        ISpecification<T> Not();
    }
}