﻿using Ecommerce.Domain.Common.Interfaces;

namespace Ecommerce.Domain.Common
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
