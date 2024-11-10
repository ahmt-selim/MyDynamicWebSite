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
    public class MyInfoController : ControllerBase
    {
        private IMyInfoService _myInfoService;
        public MyInfoController()
        {
            _myInfoService = new MyInfoManager();
        }
        [HttpGet]
        public List<MyInfo> Get()
        {
            return _myInfoService.GetAllMyInfos();
        }
        [HttpGet("{id}")]
        public MyInfo Get(int id)
        {
            return _myInfoService.GetMyInfoById(id);
        }
        [HttpPost]
        public MyInfo Post([FromBody]MyInfo myinfo)
        {
            return _myInfoService.CreateMyInfo(myinfo);
        }
        [HttpPut]
        public MyInfo Put([FromBody] MyInfo myinfo)
        {
            return _myInfoService.UpdateMyInfo(myinfo);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _myInfoService.DeleteMyInfo(id);
        }
    }
}
