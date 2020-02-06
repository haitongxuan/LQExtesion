using LQExtension.ECangService.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LQExtension.ECangService.Reqeust
{
    public class WMSGetProductListRequest : BaseRequest<WMSGetWarehouseResponse>
    {
        public WMSGetProductListRequest(string username, string password) : base(username, password)
        {
            service.Service = "getProductList";
        }
        public override Task<WMSGetWarehouseResponse> Request()
        {
            throw new NotImplementedException();
        }
    }
}
