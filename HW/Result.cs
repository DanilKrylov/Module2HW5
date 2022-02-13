using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    public class Result
    {
        public bool Status { get; }

        public string Message { get; }

        public Result( bool status)
        {
            Status = status;
        }

        public Result(bool status, string message) : this(status)
        {
            Message = message;
        }
    }
}
