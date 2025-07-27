using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
    public class EmptyLinkedListException : Exception
    {
        public EmptyLinkedListException() { }

        public EmptyLinkedListException(string message) : base(message) { }

        public EmptyLinkedListException(string message, Exception innerException) : base(message, innerException) { }
    }
}


