using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiemSinhVien.Models.User;
using QuanLyDiemSinhVien.Models.CreditClass;
using QuanLyDiemSinhVien.Models.CreditClassDetail;
using QuanLyDiemSinhVien.Models.ValidCreditClass;

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

        //  Credit class
        //  Insert Credit Class
        string SE_INSERT_CREDIT_CLASS = "INSERT INTO LOP_TC (MaMon, Nhom, HocKy, MaNK, MaGV, SVToiThieu, NgayMoDK, NgayDongDK, NgayThi, MaKh, TrangThai) VALUES ('{0}', {1}, {2}, '{3}', '{4}', {5}, '{6}', '{7}', '{8}', '{9}', '{10}')";

        //  Insert Credit Class Detail
        string SE_INSERT_CREDIT_CLASS_DETAIL = "INSERT INTO CT_LOP_TC (MaLTC, MaPh, Thu, Buoi, NgayBatDau, NgayKetThuc) VALUES ({0}, '{1}', {2}, '{3}', '{4}', '{5}')";

        //  Get valid Credit Class
        string SE_GET_VALID_CREDIT_CLASS = "SELECT * FROM VIEW_ValidCreditClass";

        //  Get valid Credit Class
        string SE_GET_CREDIT_CLASS_DETAIL = "SELECT * FROM CT_LOP_TC WHERE MaLTC = {0}";

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

                List<object> items = response as List<object>;

                Dictionary<String, object> userDict = items[0] as Dictionary<String, object>;
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

        //  Get Valid Credit Class
        public void getValidCreditClass(SuccessBlock success, FailureBlock failure)
        {
            //  Init sql
            string sql = SE_GET_VALID_CREDIT_CLASS;

            //  Exec sql
            execSql(sql, response => {

                List<object> items = response as List<object>;

                List<ValidCreditClassModel> listValidCreditClass = new List<ValidCreditClassModel>();
                foreach (Dictionary<string, object> item in items)
                {
                    ValidCreditClassModel validCreditClass = new ValidCreditClassModel();
                    validCreditClass.creditID = (int)item["MaLTC"];
                    validCreditClass.subjectId = item["MaMon"] as string;
                    validCreditClass.subjectName = item["TenMon"] as string;
                    validCreditClass.group = (int)item["Nhom"];
                    validCreditClass.numberCredit = (int)item["SoTC"];
                    validCreditClass.teacherName = item["CBGD"] as string;

                    //  Get detail of MaLTC
                    getCreditClassDetail(validCreditClass.creditID, details => {
                        validCreditClass.details = details as List<CreditClassDetailModel>;
                    }, error => {
                        Console.WriteLine("MaLTC {0} load details failure", validCreditClass.subjectId);
                    });

                    listValidCreditClass.Add(validCreditClass);
                }

                success(listValidCreditClass);
            }, error => {
                failure(error);
            });
        }

        //  Get Credit Class Detail
        public void getCreditClassDetail(int creditID, SuccessBlock success, FailureBlock failure)
        {
            //  Init sql
            string sql = string.Format(SE_GET_CREDIT_CLASS_DETAIL, creditID);

            //  Exec sql
            execSql(sql, response => {

                List<object> items = response as List<Object>;

                List<CreditClassDetailModel> listCreditClassDetail = new List<CreditClassDetailModel>();
                foreach (Dictionary<string, object> item in items)
                {
                    CreditClassDetailModel model = new CreditClassDetailModel();
                    model.MaLTC = ((int)item["MaLTC"]).ToString();
                    model.MaPh = item["MaPh"] as string;
                    model.Thu = item["Thu"] as string;
                    model.Buoi = item["Buoi"] as string;
                    model.NgayBatDau = ((DateTime)item["NgayBatDau"]).ToString();
                    model.NgayKetThuc = ((DateTime)item["NgayKetThuc"]).ToString();

                    listCreditClassDetail.Add(model);
                }
                success(listCreditClassDetail);
            }, error => {
                failure(error);
            });
        }
    }
}
