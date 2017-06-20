using System.Net;

namespace CSPOS.Domain.Models
{
    public class DmServiceClientResponse
    {
        public HttpStatusCode ResponseCode { get; set; }
        public string ResponseResult { get; set; }
        public string ResponseMessage { get; set; }

        public DmServiceClientResponse()
        {
            ResponseCode = HttpStatusCode.OK;
        }
    }
}
