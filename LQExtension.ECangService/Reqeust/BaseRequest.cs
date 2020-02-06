using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LQExtension.ECangService.Response;

namespace LQExtension.ECangService.Reqeust
{
    public abstract class BaseRequest<T> where T : BaseResponse
    {
        public ECService service { get; set; }
        public BaseRequest(string username, string password)
        {
            this.service = new ECService(username, password);
            service.Username = username;
            service.Password = password;
        }

        public abstract Task<T> Request();
    }
}
