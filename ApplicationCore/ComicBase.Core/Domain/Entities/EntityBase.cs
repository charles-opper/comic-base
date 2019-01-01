using ComicBase.Core.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBase.Core.Domain.Entities
{
    /// <summary>
    /// Base class for all entity objects. Auto increment assumed for Id. Entity removal implemented via soft deletion. 
    /// </summary>
    public abstract class EntityBase : IEntity
    {
        public int? Id { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }

        public bool Active { get; set; }
    }
}
