using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Novit.HttpStatus.Controllers.ViewModels;
using System.Collections.Generic;

namespace Novit.HttpStatus.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class HttpController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<HttpRequestViewModel>> Get()
        {
            return Ok(new List<HttpRequestViewModel>() { new HttpRequestViewModel() {
                codigo = 200,
                nombre = "OK",
                categoria = "Success",
                referencia = "https://httpstatuses.com/200"
            } });
        }

        [HttpGet("{codigo}")]
        public ActionResult<HttpRequestViewModel> Get(int codigo)
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult Post([FromBody] HttpRequestViewModel http)
        {
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        public ActionResult CrearConLista([FromBody] List<HttpRequestViewModel> https)
        {
            return Ok();
        }

        [HttpPut("{codigo}")]
        public ActionResult Put(int codigo, HttpRequestViewModel http)
        {
            return Ok();
        }

        [HttpDelete("{codigo}")]
        public ActionResult Delete(int codigo)
        {
            return Ok();
        }
    }
}
