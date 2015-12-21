namespace BinbinSpecification {
    public interface ISpecification {
        bool IsSatisfiedBy(object candidate);
        ISpecification And(ISpecification other);
        ISpecification Or(ISpecification other);
        ISpecification Not();
    }
}