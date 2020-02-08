using Microsoft.VisualStudio.TestTools.UnitTesting;
using LQExtension.ECangService.Reqeust;
using System;
using System.Collections.Generic;
using System.Text;
using LQExtension.ECangService.Reqeust.Model;

namespace LQExtension.MSTest
{
    [TestClass()]
    public class EBGetOrderListRequestTests
    {
        [TestMethod()]
        public async System.Threading.Tasks.Task RequestTestAsync()
        {
            EBGetOrderListReqModel model = new EBGetOrderListReqModel();
            model.GetAddress = IsOrNotEnum.是;
            model.GetDetail = IsOrNotEnum.是;
            model.Page = 1;
            model.PageSize = 50;

            Conditions con = new Conditions();
            List<string> SaleOrderCodes = new List<string>{ "8008275478477785" };
            con.SaleOrderCodes = SaleOrderCodes;

            con.Status = StatusEnum.待发货;
            model.Condition = con;

            EBGetOrderListRequest req = new EBGetOrderListRequest("admin", "eccang123456", model);
            var response = await req.Request();

        }
    }
}