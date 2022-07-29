using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoManager
{
    internal interface IToDoList
    {
        List<string> Create();

        List<string> Postpone();
        List<string> Delete();

    }
}
