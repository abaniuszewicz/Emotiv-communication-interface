using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsetController.Services.Communication.Requests
{
    public interface IRequest
    {
        string JsonRpc { get; }
        string Method { get; }
        int Id { get; }
    }
}
