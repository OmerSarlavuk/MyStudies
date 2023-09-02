using System;

namespace MyErrorClass
{
    public class RecordNotFoundException : Exception
    {
        public RecordNotFoundException(string message) : base(message)
        {

        }
    }
}
