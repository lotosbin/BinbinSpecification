using System;
using System.Linq.Expressions;

namespace BinbinSpecification {
    public abstract class Specification2<T> : ISpecification2<T> {
        public abstract Expression<Func<T, bool>> IsSatisfiedBy();

        public static ISpecification2<T> operator |(Specification2<T> left, Specification2<T> right) {
            return new OrSpecification2<T>(left, right);
        }

        public static ISpecification2<T> operator &(Specification2<T> left, Specification2<T> right) {
            return new AddSpecification2<T>(left, right);
        }

        public static ISpecification2<T> operator !(Specification2<T> specification) {
            return new NotSpecification2<T>(specification);
        }

        public static bool operator false(Specification2<T> specification) {
            return false;
        }

        public static bool operator true(Specification2<T> specification) {
            return true;
        }
    }
}