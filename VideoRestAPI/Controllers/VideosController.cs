using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VideoMenuBLL;
using VideoMenuBLL.BusinessObjects;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VideoRestAPI.Controllers
{
    [Route("api/[controller]")]
    public class VideosController : Controller
    {

        BLLFacade facade = new BLLFacade();

        // GET: api/values
        [HttpGet]
        public IEnumerable<VideoBO> Get()
        {
            return facade.VideoService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public VideoBO Get(int id)
        {
            return facade.VideoService.Get(id);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]VideoBO vid)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return StatusCode(201, facade.VideoService.Create(vid));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]VideoBO vid)
        {
            if (id != vid.Id)
            {
                return BadRequest("Path Id does not match Video Id in json object");
            }
            else
            {
                try
                {
                    return Ok(facade.VideoService.Update(vid));
                }
                catch (InvalidOperationException e)
                {
                    return StatusCode(404, e.Message);
                }
            }

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            facade.VideoService.Delete(id);
        }
    }
}
