using System;

namespace Course_143.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
