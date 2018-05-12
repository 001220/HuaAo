using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AdminsModel
    {
        public AdminsModel()
        {
             

        }
        public AdminsModel(int UserID,string UserName, string UserPwd,string UserCompellation)
        {
             this.UserID = UserID;
             this.UserName = UserName;
             this.UserPwd = UserPwd;
             this.UserCompellation = UserCompellation;
        }
        public AdminsModel(string UserName, string UserPwd, string UserCompellation)
        {
            this.UserName = UserName;
            this.UserPwd = UserPwd;
            this.UserCompellation = UserCompellation;
        }
        private int UserID;

        public int UserID1
        {
            get { return UserID; }
            set { UserID = value; }
        }
        private string UserName;

        public string UserName1
        {
            get { return UserName; }
            set { UserName = value; }
        }
        private string UserPwd;

        public string UserPwd1
        {
            get { return UserPwd; }
            set { UserPwd = value; }
        }
        private string UserCompellation;

        public string UserCompellation1
        {
            get { return UserCompellation; }
            set { UserCompellation = value; }
        }
    }
}
