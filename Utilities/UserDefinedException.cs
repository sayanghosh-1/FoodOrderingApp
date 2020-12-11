using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingApp.Utilities
{
    class UserDefinedException : Exception
    {
        string error;
        public UserDefinedException(string error)
        {
            this.error = error;
        }
    }
}
