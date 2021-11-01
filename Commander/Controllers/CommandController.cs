using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace commander.Controllers{
    [ApiController]
    [Route("api/command/")]
    public class CommandController : ControllerBase
    {
        private readonly ICommandRepo _repo;
       

        public CommandController(ICommandRepo _repo){
            this._repo = _repo;
    
        }

        
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int Id){
            var command = _repo.GetCommandById(Id);
            return Ok(command);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetCommands (){
            var commands = _repo.GetAppCommands();
            return Ok(commands);
        }
    }

}