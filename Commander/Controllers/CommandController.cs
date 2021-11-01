using System.Collections.Generic;
using AutoMapper;
using Commander.Data;
using Commander.Dtos;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace commander.Controllers{
    [ApiController]
    [Route("api/command/")]
    public class CommandController : ControllerBase
    {
        private readonly ICommandRepo _repo;
        private readonly IMapper _mapper;

        public CommandController(ICommandRepo _repo,IMapper mapper){
            this._repo = _repo;
            _mapper = mapper;
        }

        
        [HttpGet("{id}")]
        public ActionResult<CommandReadDto> GetCommandById(int Id){
            var command = _repo.GetCommandById(Id);
            return Ok(_mapper.Map<CommandReadDto>(command));
        }

        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDto>> GetCommands (){
            var commands = _repo.GetAppCommands();
            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commands));
        }
        [HttpPost]
        public ActionResult<CommandCreateDto> CreateCommand(CommandCreateDto commandCreateDto){
            var commandModel = _mapper.Map<Command>(commandCreateDto);
            _repo.CreateCommand(commandModel);

            _repo.SaveChanges();
            var commandRead = _mapper.Map<CommandReadDto>(commandModel);
            return Ok(commandModel);
        }
    }

}