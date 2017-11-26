using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiemSinhVien.Models.User
{
    class UserProfile
    {
        public string userID;
        public string name;
        public string role;

        //  SingleTon instance
        static UserProfile instance;

        //  Setup SingleTon
        public static UserProfile sharedInstance()
        {
            if (instance == null)
            {
                instance = new UserProfile();
            }

            return instance;
        }

        //  Log in success
        public void loginSuccess(Dictionary<String, object> dict)
        {
            this.userID = dict["Id"] as string;
            this.name = dict["Name"] as string;
            this.role = dict["Role"] as string;
        }
    }
}
