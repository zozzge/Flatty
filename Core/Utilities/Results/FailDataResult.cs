using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class FailDataResult<T> : DataResult<T>
    {
        public FailDataResult(T data, string message) : base(data, false, message)
        {
        }

        public FailDataResult(T data) : base(data, false)
        {
        }

        public FailDataResult(string message) : base(default, false, message)
        {

        }

        public FailDataResult() : base(default, false)
        {

        }
    }

}
