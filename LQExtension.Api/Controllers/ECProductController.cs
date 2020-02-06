using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LQExtension.BLL;
using LQExtension.Model;
using Microsoft.AspNetCore.Authorization;

namespace LQExtension.Api.Controllers
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/ECProduct")]
    public class ECProductController : Controller
    {
        EC_ProductBLL bll = new EC_ProductBLL();

        
    }
}