using System.Collections.Generic;
using System.Linq;
using commander.Data;
using Commander.Models;

namespace Commander.Data{
    public class SqlCommandRepo : ICommandRepo
    {
        private readonly CommanderContext _context ;
        public SqlCommandRepo(CommanderContext context)
        {
            this._context = context;
        }
        public IEnumerable<Command> GetAppCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int Id) => _context.Commands.FirstOrDefault(x => x.Id == Id);
    }
}