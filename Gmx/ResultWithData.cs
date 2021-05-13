using System;
using System.Collections.Generic;
using System.Text;

namespace Gmx
{
    public class Result<T> : Result
    {
        public Result() : base()
        {
        }

        // **********
        public T Data { get; set; }
        // **********
    }
}
