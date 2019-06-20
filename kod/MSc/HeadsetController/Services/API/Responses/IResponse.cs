using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace HeadsetController.Services.API.Responses
{
    public interface IResponse<T>
    {
        int id { get; }
        string jsonrpc { get; }
        T result { get; }
    }
}
