using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Brewery.Domain.Contracts
{
    [Serializable]
    public class ContractException : Exception
    {
        public ContractException()
        {
        }

        public ContractException(string message)
            : base(message)
        {
        }

        public ContractException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected ContractException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
