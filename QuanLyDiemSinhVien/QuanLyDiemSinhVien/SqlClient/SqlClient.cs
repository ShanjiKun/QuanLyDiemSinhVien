using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSinhVien.Models.User;

namespace QuanLyDiemSinhVien.Sql
{
    class SqlClient : BaseClient
    {
        //  MARK: Variables
        //  SingleTon instance
        static SqlClient instance;

        //  BaseURL
        string initURL = "Data Source = {0}; Initial Catalog = QLDSV; User ID = {1}; Password={2}";

        //  Login
        string SE_LOGIN = "EXEC SP_Login {0}";

        //  MARK: Functions
        //  SingleTon setup
        public static SqlClient sharedInstance()
        {
            if (instance == null)
            {
                instance = new SqlClient();
            }

            return instance;
        }

        //  Login
        public void login(Dictionary<string, string> param, SuccessNonParamBlock success, FailureBlock failure)
        {
            //  Init Base Connect String
            sqlConnectString = string.Format(initURL, param["server"], param["username"], param["password"]);

            //  Init sql
            string sql = string.Format(SE_LOGIN, param["username"]);

            //  Exec sql
            execSql(sql, response => {
                //  Map response to User Profile
                Dictionary<String, object> userDict = response[0] as Dictionary<String, object>;
                UserProfile.sharedInstance().loginSuccess(userDict);

                //  Login success
                success();
            }, error => {
                //  Login failure
                failure(error);
            });
        }
    }
}
