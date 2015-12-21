using System;
using System.Linq.Expressions;

namespace BinbinSpecification {
    public interface ISpecification2<T> {
        Expression<Func<T, bool>> IsSatisfiedBy();
    }
}