using System.Collections.Generic;

namespace HeadsetController.Services.API.Responses
{
    public class ListResponse<T> : List<T>, IResult where T : IResult
    {
    }
}
