using System;
using System.Linq;
using System.Linq.Expressions;

namespace BinbinSpecification {
    public static class ExpressionBuilder {
        private static Expression<T> Compose<T>(this Expression<T> left, Expression<T> right, Func<Expression, Expression, Expression> merge) {
            var params1 = left.Parameters;
            var params2 = right.Parameters;
            var map = params1.Select((p, i) => new { p, s = params2[i] }).ToDictionary(p => p.s, p => p.p);
            var rightBody = ParameterRebinder.ReplaceParameters(map, right.Body);
            return Expression.Lambda<T>(merge(left, rightBody), left.Parameters);
        }

        public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> left, Expression<Func<T, bool>> right) {
            return left.Compose(right, Expression.Add);
        }

        public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> left, Expression<Func<T, bool>> right) {
            return left.Compose(right, Expression.Or);
        }
    }
}