using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_LAB_02
{
    class User
    {
        PC Pc;
        string Name;
        string SecName;
        string Number;
        string NameFile;

        public User(PC pc, string name, string secname, string number, string nameFile)
        {
            Pc = pc;
            Name = name;
            SecName = secname;
            Number = number;
            NameFile = nameFile;
        }
    }


}
