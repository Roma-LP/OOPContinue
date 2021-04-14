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
        public PC Pc;
        public string FirstName;
        public string SecName;
        public string Number;
        public string NameFile;

        public User(PC pc, string name, string secname, string number, string nameFile)
        {
            Pc = pc;
            FirstName = name;
            SecName = secname;
            Number = number;
            NameFile = nameFile;
        }

        public User() { }

        public override string ToString()
        {
            return FirstName+"  " + SecName+"  " + Number +"  "+ NameFile+"  "  + Pc.ToString();
        }
    }
}
