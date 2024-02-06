using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Results : IResults
    {
        

        public Results(bool success,string message):this(success)
        {
            Message = message;
            

        }

        public Results(bool success)
        {
            IsSuccess = success;
        }

        //overload 

        public bool IsSuccess {  get; }
        public string Message { get; }
    }
}
