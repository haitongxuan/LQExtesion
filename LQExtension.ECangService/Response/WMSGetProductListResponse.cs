using System;
using System.Collections.Generic;
using System.Text;
using LQExtension.ECangService.Response.Model;

namespace LQExtension.ECangService.Response
{
    public class WMSGetProductListResponse : BaseResponse
    {
        public List<EC_Product> Body { get; set; }
    }
    
}
