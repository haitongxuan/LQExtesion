using System;
using System.Collections.Generic;
using System.Text;
using LQExtension.ECangService.Response;
using LQExtension.ECangService.Response.Model;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
namespace LQExtension.ECangService.Reqeust
{
    public class WMSGetWarehouseRequest : BaseRequest<WMSGetWarehouseResponse>
    {
        public WMSGetWarehouseRequest(string username, string password) : base(username, password)
        {
            service.Plateform = "WMS";
            service.Service = "getWarehouse";
            service.ParamsJson = "";
        }

        public override async Task<WMSGetWarehouseResponse> Request()
        {
            WMSGetWarehouseResponse response = new WMSGetWarehouseResponse();
            List<EC_Warehouse> list = new List<EC_Warehouse>();
            try
            {
                var body = await service.ResponseServiceAsync();

                JObject j = (JObject)JsonConvert.DeserializeObject(body.Data);
                IEnumerable<JProperty> properties = j.Properties();
                foreach (JProperty p in properties)
                {
                    string key = p.Name;
                    EC_Warehouse warehouse = j[key].ToObject<EC_Warehouse>();
                    list.Add(warehouse);
                }
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
