using Microsoft.VisualStudio.TestTools.UnitTesting;
using LQExtension.ECangService.Reqeust;

namespace LQExtension.MSTest
{
    [TestClass()]
    public class WMSGetWarehouseRequestTests
    {
        [TestMethod()]
        public async System.Threading.Tasks.Task RequestTestAsync()
        {
            WMSGetWarehouseRequest req = new WMSGetWarehouseRequest("admin", "eccang123456");
            var response = await req.Request();
        }
    }
}