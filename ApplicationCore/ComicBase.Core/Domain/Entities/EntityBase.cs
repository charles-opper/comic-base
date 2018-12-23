using ComicBase.Core.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBase.Core.Domain.Entities
{
    public abstract class EntityBase : IEntity
    {
        public int? Id { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }

        public bool Active { get; set; }
    }
}
