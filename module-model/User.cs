using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    [Serializable]
    public class User
    {
        private int userId;
        private string userName;
        private string password;
        private string fullName;

        public User(int userId, String password, String userName, String fullName)
        {
            this.userId = userId;
            this.userName = userName;
            this.password = password;
            this.fullName = fullName;
        }

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
    }
}
