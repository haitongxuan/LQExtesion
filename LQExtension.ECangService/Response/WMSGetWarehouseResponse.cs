﻿using LQExtension.ECangService.Response.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LQExtension.ECangService.Response
{
    public class WMSGetWarehouseResponse : BaseResponse
    {
        public List<EC_Warehouse> Body { get; set; }
    }
}
