using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_LAB_02
{
    [Serializable]
    public class Users
    {
        public List<User> UserList = new List<User>();

        public Users(User user)
        {
            UserList.Add(user);
        }

        public void Add(User user)
        {
            UserList.Add(user);
        }

        public int Count()
        {
            return UserList.Count;
        }

        public Users() { }
    }
}
