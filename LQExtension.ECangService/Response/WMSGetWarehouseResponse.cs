using System;
using System.Collections.Generic;
using System.Text;
using LQExtension.Model;

namespace LQExtension.ECangService.Response
{
    public class WMSGetWarehouseResponse : BaseResponse
    {
        public List<EC_Warehouse> Body { get; set; }
    }
}
