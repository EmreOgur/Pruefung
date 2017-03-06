using Pruefung.Contract.Services;
using System;
using System.Web.Http;

namespace Pruefung.Web.Controllers.Api
{
    [RoutePrefix("api/Test")]
    public class TestController : ApiController
    {
        private readonly ITestService _testService;

        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        [Route("Messages/Add")]
        [HttpPost]
        public IHttpActionResult AddMessage([FromBody]string message)
        {
            _testService.SaveMessage(message);

            return Ok();
        }

        [Route("Messages/GetAll")]
        [HttpGet]
        public IHttpActionResult GetMessages(DateTime? fromDate = null)
        {
            if(!fromDate.HasValue)
                fromDate = DateTime.Now.AddMinutes(-10);

            var messages = _testService.GetMessages(fromDate.Value);

            return Ok(messages);
        }
    }
}
