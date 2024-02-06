using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class FailureResult:Results
    {
        public FailureResult(string message) : base(true, message)
        {
        }

        public FailureResult() : base(true)
        {

        }
    }
}
