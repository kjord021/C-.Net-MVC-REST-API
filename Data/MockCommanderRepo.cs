
using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {

        //use this until you get your server up and running

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Kettle & Pan" },
                new Command { Id = 0, HowTo = "Cut Bread", Line = "Get a knife", Platform = "Knife and chopping board" },
                new Command { Id = 0, HowTo = "Make cup of tea", Line = "Place teabag in cup", Platform = "Kettle & Cup" },
        };

            return commands;

        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Kettle & Pan" };
        }
    }
}
