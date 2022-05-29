using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViktorinaProjectUser
{
    public class User
    {
        public string Password;
        public string UserName;
        public  string Login;
        public DateTime BurnTime;
        public int MyRecord { get; set; }
        public void Write()
        {

        }
        public User()
        {
            Password = string.Empty;
            UserName = string.Empty;
            Login = string.Empty;
            BurnTime = DateTime.Now;
            MyRecord = 0;
        }
        public void Clone(User clone)
        {
            this.Password = clone.Password;
            this.UserName = clone.UserName;
            this.Login = clone.Login;
            this.BurnTime = clone.BurnTime;
            this.MyRecord = clone.MyRecord;
        }


    }
}
