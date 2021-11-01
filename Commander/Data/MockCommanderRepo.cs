using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data{
    public class MockCommanderRepo 
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>{
               new Command{Id = 0 , Platform = "dodo" , Line = "SoSo" , HowTo = "MoMo"},
               new Command{Id = 0 , Platform = "dodo" , Line = "SoSo" , HowTo = "MoMo"},
               new Command{Id = 0 , Platform = "dodo" , Line = "SoSo" , HowTo = "MoMo"}
            };
            return commands;
        }

        public Command GetCommandById(int Id)
        {
            return new Command{Id = 0 , Platform = "dodo" , Line = "SoSo" , HowTo = "MoMo"};
            
        }
    }
}