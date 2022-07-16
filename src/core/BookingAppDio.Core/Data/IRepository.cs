﻿using BookingAppDio.Core.ModelsAggregate;

namespace BookingAppDio.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregate
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
