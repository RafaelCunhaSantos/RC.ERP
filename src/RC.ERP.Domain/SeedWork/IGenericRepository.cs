﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC.ERP.Domain.SeedWork
{
    public interface IGenericRepository<TAggregate> : IRepository where TAggregate : AggregateRoot
    {
        public Task Insert(TAggregate aggregate, CancellationToken cancellationToken);
        public Task<TAggregate> Get(Guid id, CancellationToken cancellationToken);
        public Task Delete(TAggregate aggregate, CancellationToken cancellationToken);
        public Task Update(TAggregate aggregate, CancellationToken cancellationToken);
    }
}
