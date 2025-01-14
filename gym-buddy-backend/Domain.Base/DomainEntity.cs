﻿using System;
using Contracts.Domain.Base;

namespace Domain.Base
{
    public class DomainEntity : DomainEntity<int>, IDomainEntity
    {
    }

    public class DomainEntity<TKey> : DomainEntityId<TKey>, IDomainEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        public string CreatedBy { get; set; } = "system";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string UpdatedBy { get; set; } = "system";
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}