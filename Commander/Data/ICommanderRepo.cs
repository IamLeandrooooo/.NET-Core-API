using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commander.Model;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();

        IEnumerable<Commands> GetCommands();
        Commands GetCommandById(int id);

        void CreateCommand(Commands cmd);

        void UpdateCommand(Commands cmd);

        void DeleteCommand(Commands cmd);

        //void PatchCommand(int id);


    }
}
