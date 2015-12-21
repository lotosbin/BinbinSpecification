﻿namespace BinbinSpecification {
    public interface ISpecification<in TEntity> {
        bool IsSatisfiedBy(TEntity entity);
    }
}