using System.Collections.Generic;
using Commander.Models;
namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & pan"},
                new Command{Id=1, HowTo="cut bread", Line="cut the bread", Platform="knife & chopping table"},
                new Command{Id=2, HowTo="cup of tea", Line="Boil water", Platform="kettle & cup"}
            };
            
            return commands;
        }   

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & pan"};
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}