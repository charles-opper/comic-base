using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBase.Core.Domain.Exceptions
{
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
