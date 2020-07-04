using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Commander.Data;
using Commander.Model;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Commands cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Commands cmd)
        {
            throw new NotImplementedException();
        }

        public Commands GetCommandById(int id)
        {
            return new Commands { Id = 1, HowTo = "Entrar numa pasta", Line = "cd", Platform = "Windows" };
        }

        public IEnumerable<Commands> GetCommands()
        {
            List<Commands> commands = new List<Commands>
            {
                new Commands { Id = 1, HowTo = "Entrar numa pasta", Line = "cd", Platform = "Windows" },
                new Commands { Id = 2, HowTo = "Ir para pasta anterior", Line = "cd ..", Platform = "Windows" },
                new Commands { Id = 3, HowTo = "Pingar Máquina", Line = "ping <IP>", Platform = "Windows" }
            };

            return commands;
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Commands cmd)
        {
            throw new NotImplementedException();
        }
    }
}
