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

        //  Get Registered
        string SE_GET_REGISTERED = "SELECT MaLTC FROM DANG_KY_MON_HOC WHERE MaSV = '{0}'";

        //  Insert Registration
        string SE_INSERT_REGISTRATION = "INSERT INTO DANG_KY_MON_HOC(MaSV, MaLTC) VALUES('{0}', {1})";

        //  Delete Registraion
        string SE_DELETE_REGISTRATION = "DELETE FROM DANG_KY_MON_HOC WHERE MaSV = '{0}' AND MaLTC={1}";

        //  Insert Subject
        string SE_INSERT_SUBJECT = "INSERT INTO MON(MaMon, Ten, SoTLT, SoTTH, SoTC) VALUES('{0}', N'{1}', {2}, {3}, {4})";

        //  Insert Class
        string SE_INSERT_CLASS = "INSERT INTO LOP(MaLop, Ten, MaKh) VALUES ('{0}', N'{1}', '{2}')";

        //  Insert Teacher
        string SE_INSERT_TEACHER = "INSERT INTO GIANG_VIEN(MaGV, HoTen, HocVi, HocHam, ChuyenMon, MaKh) VALUES('{0}', N'{1}', N'{2}', N'{3}', N'{4}', '{5}')";

        //  Insert Student
        string SE_INSERT_STUDENT = "INSERT INTO SINH_VIEN(MaSV, HoTen, Phai, DiaChi, NgaySinh, KhoaHoc, MaLop, MaCN) VALUES('{0}', N'{1}', N'{2}', N'{3}', '{4}', {5}, '{6}', {7})";

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

                    DateTime dateBegin = ((DateTime)item["NgayBatDau"]);
                    DateTime dateEnd = ((DateTime)item["NgayKetThuc"]);
                    model.NgayBatDau = dateToYYYYMMDD(dateBegin);
                    model.NgayKetThuc = dateToYYYYMMDD(dateEnd);

                    listCreditClassDetail.Add(model);
                }
                success(listCreditClassDetail);
            }, error => {
                failure(error);
            });
        }

        //  Get Registered
        public void getRegistered(SuccessBlock success, FailureBlock failure)
        {
            //  Init sql
            string sql = string.Format(SE_GET_REGISTERED, UserProfile.sharedInstance().userID);

            //  Exec sql
            execSql(sql, response => {

                List<int> creditIDs = new List<int>();
                List<Object> items = response as List<Object>;
                foreach (Dictionary<string, object> item in items)
                {
                    creditIDs.Add((int)item["MaLTC"]);
                }
                success(creditIDs);
            }, error => {
                failure(error);
            });
        }

        //  Insert registration
        public void insertRegistration(int creditID, SuccessNonParamBlock success, FailureBlock failure)
        {
            //  Init sql
            string studentID = UserProfile.sharedInstance().userID;
            string sql = string.Format(SE_INSERT_REGISTRATION, studentID, creditID);

            // Exec sql
            execSqlNoResponse(sql, () => {
                success();
            }, error => {
                failure(error);
            });
        }

        //  Delete registration
        public void deleteRegistration(int creditID, SuccessNonParamBlock success, FailureBlock failure)
        {
            //  Init sql
            string studentID = UserProfile.sharedInstance().userID;
            string sql = string.Format(SE_DELETE_REGISTRATION, studentID, creditID);

            //  Exec sql
            execSqlNoResponse(sql, () => {
                success();
            }, error => {
                failure(error);
            });
        }

        //  Insert Subject
        public void insertSubject(string newId, string name, string theory, string practise, string numberCredit, SuccessNonParamBlock success, FailureBlock failure)
        {
            //  Init sql
            string sql = string.Format(SE_INSERT_SUBJECT, newId, name, theory, practise, numberCredit);

            //  Exec sql
            execSqlNoResponse(sql, () => {
                success();
            }, error => {
                failure(error);
            });
        }

        //  Insert class
        public void insertClass(string classID, string name, SuccessNonParamBlock success, FailureBlock failure)
        {
            //  Init sql
            string sql = string.Format(SE_INSERT_CLASS, classID, name, scienceID);

            //  Exec sql
            execSqlNoResponse(sql, () => {
                success();
            }, error => {
                failure(error);
            });
        }

        //  Insert Teacher
        public void insertTeacher(string id, string name, string degree, string title, string professional, SuccessNonParamBlock success, FailureBlock failure)
        {
            //  Init sql
            string sql = string.Format(SE_INSERT_TEACHER, id, name, degree, title, professional, scienceID);

            //  Exec sql
            execSqlNoResponse(sql, () => {
                success();
            }, error => {
                failure(error);
            });
        }

        //  Insert Student
        public void insertStudent(string id, string name, string sex, string address, string birthDay, string year, string classID, string major, SuccessNonParamBlock success, FailureBlock failure)
        {
            //  Init sql
            major = major == "NULL" ? "NULL" : "'" + major + "'";
            string sql = string.Format(SE_INSERT_STUDENT, id, name, sex, address, birthDay, year, classID, major);

            //  Exec sql
            execSqlNoResponse(sql, ()=> {
                success();
            }, error=> {
                failure(error);
            });
        }

        //  Utils
        string dateToYYYYMMDD(DateTime date)
        {
            return date.ToString("yyyy/MM/dd");
        }
    }
}
