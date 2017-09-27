using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClient
{
    public class ApiResponse<TData>
    {
        public TData data;
        public Boolean success;
        public string message;
    }
}
