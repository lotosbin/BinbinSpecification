using System;
using System.Linq.Expressions;

namespace BinbinSpecification {
    public class OrSpecification2<T> : CompositeSpecification2<T> {
        private readonly ISpecification2<T> _left;
        private readonly ISpecification2<T> _right;

        public OrSpecification2(ISpecification2<T> left, ISpecification2<T> right) {
            _left = left;
            _right = right;
        }

        public override ISpecification2<T> Left => _left;

        public override ISpecification2<T> Right => _right;

        public override Expression<Func<T, bool>> IsSatisfiedBy() {
            return _left.IsSatisfiedBy().Or(_right.IsSatisfiedBy());
        }
    }
}