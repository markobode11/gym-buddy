﻿using Contracts.DAL.Base.Repositories;
using DAL.App.DTO;

namespace Contracts.DAL.App.Repositories
{
    public interface IMuscleRepository :
        IBaseRepository<Muscle>,
        IMuscleRepositoryCustom<Muscle>
    {
    }

    public interface IMuscleRepositoryCustom<TEntity>
    {
    }
}