using LQExtension.ECangService.Response.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LQExtension.ECangService.Response
{
   public class EBGetOrderListResponse : BaseResponse
    {
        public List<EC_SalesOrder> Body { get; set; }
    }
}
