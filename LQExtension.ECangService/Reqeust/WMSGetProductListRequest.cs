﻿using LQExtension.ECangService.Reqeust.Model;
using LQExtension.ECangService.Response;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using LQExtension.ECangService.Response.Model;
using System.ComponentModel;

namespace LQExtension.ECangService.Reqeust
{
    public class WMSGetProductListRequest : BaseRequest<WMSGetProductListResponse>
    {
        public WMSGetProductListRequest(string username, string password, WMSGetProductListReqModel reqModel) : base(username, password)
        {
            service.Service = "getProductList";
            service.Plateform = "WMS";
            service.ParamsJson = JsonConvert.SerializeObject(reqModel);
        }
        public override async Task<WMSGetProductListResponse> Request()
        {
            WMSGetProductListResponse response = new WMSGetProductListResponse();
            List<EC_Product> list = new List<EC_Product>();
            try
            {
                var body = await service.ResponseServiceAsync();
                string data = body.Data;
                //返回字符串中出现时间0000-00-00 00:00:00 导致反序列化异常
                data = data.Replace("0000-00-00 00:00:00", "");

                list = JsonConvert.DeserializeObject<List<EC_Product>>(data);
                response.Body = list;
                return response;
            }
            catch (ECExceptoin)
            {
                throw;
            }
        }
    }
}
