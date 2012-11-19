using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinbinSpecification
{
    internal class AndSpecification<TEntity> : ISpecification<TEntity>
    {
        private ISpecification<TEntity> Spec1;
        private ISpecification<TEntity> Spec2;

        internal AndSpecification(ISpecification<TEntity> s1, ISpecification<TEntity> s2)
        {
            Spec1 = s1;
            Spec2 = s2;
        }

        public bool IsSatisfiedBy(TEntity candidate)
        {
            return Spec1.IsSatisfiedBy(candidate) && Spec2.IsSatisfiedBy(candidate);
        }
    }
}
