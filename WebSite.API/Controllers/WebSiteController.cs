using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Business.Abstract;
using WebSite.Business.Concreate;
using WebSite.Entities;

namespace WebSite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebSiteController : ControllerBase
    {
        private IWebSiteService _webSiteService;
        public WebSiteController()
        {
            _webSiteService = new WebSiteManager();
        }
        [HttpGet]
        public List<MyInfo> Get()
        {
            return _webSiteService.GetAllMyInfos();
        }
        [HttpGet("{id}")]
        public MyInfo Get(int id)
        {
            return _webSiteService.GetMyInfoById(id);
        }
        [HttpPost]
        public MyInfo Post([FromBody]MyInfo myinfo)
        {
            return _webSiteService.CreateMyInfo(myinfo);
        }
        [HttpPut]
        public MyInfo Put([FromBody] MyInfo myinfo)
        {
            return _webSiteService.UpdateMyInfo(myinfo);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _webSiteService.DeleteMyInfo(id);
        }
    }
}
