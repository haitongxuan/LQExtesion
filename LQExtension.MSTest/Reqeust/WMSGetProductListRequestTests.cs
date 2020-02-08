using Microsoft.VisualStudio.TestTools.UnitTesting;
using LQExtension.ECangService.Reqeust;
using System;
using System.Collections.Generic;
using System.Text;
using LQExtension.ECangService.Reqeust.Model;

namespace LQExtension.MSTest
{
    [TestClass()]
    public class WMSGetProductListRequestTests
    {
        [TestMethod()]
        public async System.Threading.Tasks.Task RequestTestAsync()
        {
            WMSGetProductListReqModel model = new WMSGetProductListReqModel();
            model.Page = 1;
            model.PageSize = 50;
            model.IsCombination = IsOrNotEnum.是;
            WMSGetProductListRequest req = new WMSGetProductListRequest("admin", "eccang123456",model);
            var response = await req.Request();
        }
    }
}