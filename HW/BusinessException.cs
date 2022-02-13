using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    public class BusinessException : Exception
    {
        public BusinessException (string message) : base(message)
        {

        }
    }
}
