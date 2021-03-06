using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data{
    public interface ICommandRepo{
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int Id);
        void CreateCommand(Command cmd);
        bool SaveChanges();
    }
}