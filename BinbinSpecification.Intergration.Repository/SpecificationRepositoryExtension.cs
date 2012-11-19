using System.Collections.Generic;
using System.Linq;
using BinbinRepository;

namespace BinbinSpecification.Intergration.Repository
{
    public static class SpecificationRepositoryExtension
    {
        public static IEnumerable<TEntity> Find<TEntity, TKey>(this IRepository<TEntity, TKey> repository, ISpecification specification) where TEntity : class
        {
            return repository.Find(t => true).ToList().Where(specification.IsSatisfiedBy);
        }
    }
}