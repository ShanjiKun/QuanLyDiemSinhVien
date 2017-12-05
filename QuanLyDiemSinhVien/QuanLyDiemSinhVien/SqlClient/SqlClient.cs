using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSinhVien.Models.User;
using QuanLyDiemSinhVien.Models.CreditClass;
using QuanLyDiemSinhVien.Models.CreditClassDetail;

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

        //  Insert Credit Class
        string SE_INSERT_CREDIT_CLASS = "INSERT INTO LOP_TC (MaMon, Nhom, HocKy, MaNK, MaGV, SVToiThieu, NgayMoDK, NgayDongDK, NgayThi, MaKh, TrangThai) VALUES ('{0}', {1}, {2}, '{3}', '{4}', {5}, '{6}', '{7}', '{8}', '{9}', '{10}')";

        //  Insert Credit Class Detail
        string SE_INSERT_CREDIT_CLASS_DETAIL = "INSERT INTO CT_LOP_TC (MaLTC, MaPh, Thu, Buoi, NgayBatDau, NgayKetThuc) VALUES ({0}, '{1}', {2}, '{3}', '{4}', '{5}')";

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

        //  Insert Credit Class
        public void insertCreditClass(CreditClassModel model, SuccessNonParamBlock success, FailureBlock failure)
        {
            //  Init sql
            model.MaKh = scienceID;
            model.TrangThai = "MO";
            string sql = string.Format(SE_INSERT_CREDIT_CLASS, model.MaMon, model.Nhom, model.HocKy, model.MaNK, model.MaGV, model.SVToiThieu, model.NgayMoDK, model.NgayDongDK, model.NgayThi, model.MaKh, model.TrangThai);

            //  Exec sql
            execSqlNoResponse(sql, () =>
            {
                success();
            }, error => {
                failure(error);
            });
        }

        //  Insert Credit Class detail
        public void insertCreditClassDetail(CreditClassDetailModel model, SuccessNonParamBlock success, FailureBlock failure)
        {
            //  Init sql
            string sql = string.Format(SE_INSERT_CREDIT_CLASS_DETAIL, model.MaLTC, model.MaPh, model.Thu, model.Buoi, model.NgayBatDau, model.NgayKetThuc);

            //  Exec sql
            execSqlNoResponse(sql, () =>
            {
                success();
            }, error => {
                failure(error);
            });
        }
    }
}
