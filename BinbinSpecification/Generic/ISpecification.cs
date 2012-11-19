namespace BinbinSpecification
{
    public interface ISpecification<TEntity>
    {
        bool IsSatisfiedBy(TEntity entity);
    }
}