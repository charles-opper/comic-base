﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBase.Core.Domain.Interfaces
{
    /// <summary>
    /// The entity base interface.
    /// </summary>
    public interface IEntity
    {
        int? Id { get; set; }
        DateTime Created { get; set; }
        DateTime Updated { get; set; }
        bool Active { get; set; }
    }
}
