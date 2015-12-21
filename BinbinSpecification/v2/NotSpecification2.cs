using System;
using System.Linq;
using System.Linq.Expressions;

namespace BinbinSpecification {
    public class NotSpecification2<T> : Specification2<T> {
        private readonly ISpecification2<T> _wrapped;

        public NotSpecification2(ISpecification2<T> wrapped) {
            _wrapped = wrapped;
        }

        public override Expression<Func<T, bool>> IsSatisfiedBy() {
            return Expression.Lambda<Func<T, bool>>(Expression.Not(_wrapped.IsSatisfiedBy().Body), _wrapped.IsSatisfiedBy().Parameters.Single());
        }
    }
}