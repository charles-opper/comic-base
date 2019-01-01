using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBase.Core.Domain.Exceptions
{
    /// <summary>
    /// Thrown when an entity for a given type T is not found in a repository.
    /// </summary>
    /// <typeparam name="T">The entity object type.</typeparam>
    public class EntityNotFoundException<T> : Exception
    {
        public EntityNotFoundException (int id)
            : base()
        {
            Id = id;
        }

        public int Id { get; private set; }

        public override string Message => $"Entity of type { typeof(T).Name } not found in repository for id: { Id }.";
    }
}
