using System.Collections.Generic;
using System.Linq.Expressions;

namespace BinbinSpecification {
    public class ParameterRebinder : ExpressionVisitor {
        private readonly Dictionary<ParameterExpression, ParameterExpression> _Map;

        public ParameterRebinder(Dictionary<ParameterExpression, ParameterExpression> map) {
            _Map = map;
        }

        protected override Expression VisitParameter(ParameterExpression node) {
            ParameterExpression replacement;
            if (_Map.TryGetValue(node, out replacement)) {
                node = replacement;
            }
            return base.VisitParameter(node);
        }

        public static Expression ReplaceParameters(Dictionary<ParameterExpression, ParameterExpression> map, Expression exp) {
            return (new ParameterRebinder(map)).Visit(exp);
        }
    }
}