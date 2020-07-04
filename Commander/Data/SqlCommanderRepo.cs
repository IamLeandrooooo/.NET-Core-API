using Commander.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _dbContext;
        public SqlCommanderRepo(CommanderContext context)
        {
            _dbContext = context;
        }

        public void CreateCommand(Commands cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _dbContext.Command.Add(cmd);
        }

        public void DeleteCommand(Commands cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _dbContext.Command.Remove(cmd);
        }

        public Commands GetCommandById(int id)
        {
            return _dbContext.Command.FirstOrDefault(d => d.Id == id);
        }

        public IEnumerable<Commands> GetCommands()
        {
            return _dbContext.Command.ToList();
        }

        public bool SaveChanges()
        {
            return (_dbContext.SaveChanges() >= 0);
        }

        public void UpdateCommand(Commands cmd)
        {
            //Nothing
        }
    }
}
