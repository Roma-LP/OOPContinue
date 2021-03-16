using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_LAB_02
{
    [Serializable]
    public class User
    {
        PC Pc;
        public string Name;
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

        public User() { }

        public override string ToString()
        {
            return Name+"  " + SecName+"  " + Number +"  "+ NameFile;
        }
    }


}
