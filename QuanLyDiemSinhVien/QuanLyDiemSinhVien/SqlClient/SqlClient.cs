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

        //  Student password default
        string PW_STUDENT = "1234";

        //  Login
        string SE_LOGIN = "EXEC SP_Login '{0}'";

        //  Credit class
        //  Insert Credit Class
        string SE_INSERT_CREDIT_CLASS = "INSERT INTO LOP_TC (MaMon, Nhom, HocKy, MaNK, MaGV, SVToiThieu, NgayMoDK, NgayDongDK, NgayThi, MaKh, TrangThai) VALUES ('{0}', {1}, {2}, '{3}', '{4}', {5}, '{6}', '{7}', '{8}', '{9}', '{10}')";

        //  Insert Credit Class Detail
        string SE_INSERT_CREDIT_CLASS_DETAIL = "INSERT INTO CT_LOP_TC (MaLTC, MaPh, Thu, Buoi, NgayBatDau, NgayKetThuc) VALUES ({0}, '{1}', {2}, '{3}', '{4}', '{5}')";

        //  Get valid Credit Class
        string SE_GET_VALID_CREDIT_CLASS = "SELECT * FROM VIEW_ValidCreditClass";

        //  Get valid Credit Detail Class
        string SE_GET_CREDIT_CLASS_DETAIL = "SELECT * FROM CT_LOP_TC WHERE MaLTC = {0}";

        //  Get Credit Class
        string SE_GET_SPECIFY_CREDIT_CLASS_INFOR = "SELECT MaLTC, m.Ten, Nhom, NgayThi, HocKy, MaNK FROM MON m INNER JOIN (SELECT MaLTC, MaMon, Nhom, NgayThi, HocKy, MaNK FROM LOP_TC WHERE MaLTC = {0}) tc ON m.MaMon = tc.MaMon";

        //  Cancel Credit Class
        string SE_CANCEL_CREDIT_CLASS = "EXEC SP_CancelCreditClass {0}";

        //  Get Registered
        string SE_GET_REGISTERED = "SELECT dk.MaLTC FROM VIEW_ValidCreditClass vv INNER JOIN (SELECT MaLTC FROM DANG_KY_MON_HOC WHERE MaSV = '{0}') dk ON vv.MaLTC = dk.MaLTC";

        //  Insert Registration
        string SE_INSERT_REGISTRATION = "INSERT INTO DANG_KY_MON_HOC(MaSV, MaLTC) VALUES('{0}', {1})";

        //  Delete Registraion
        string SE_DELETE_REGISTRATION = "DELETE FROM DANG_KY_MON_HOC WHERE MaSV = '{0}' AND MaLTC={1}";

        //  Insert Subject
        string SE_INSERT_SUBJECT = "INSERT INTO MON(MaMon, Ten, SoTLT, SoTTH, SoTC) VALUES('{0}', N'{1}', {2}, {3}, {4})";

        //  Update Subject
        string SE_UPDATE_SUBJECT = "UPDATE MON SET Ten=N'{0}', SoTLT={1}, SoTTH={2}, SoTC={3} WHERE MaMon='{4}'";

        //  Insert Class
        string SE_INSERT_CLASS = "INSERT INTO LOP(MaLop, Ten, MaKh) VALUES ('{0}', N'{1}', '{2}')";

        //  Update Class
        string SE_UPDATE_CLASS = "UPDATE LOP SET Ten = N'{0}' WHERE MaLop = '{1}'";

        //  Delete Class
        string SE_DELETE_CLASS = "DELETE FROM LOP WHERE MaLop='{0}'";

        //  Insert Teacher
        string SE_INSERT_TEACHER = "INSERT INTO GIANG_VIEN(MaGV, HoTen, HocVi, HocHam, ChuyenMon, MaKh) VALUES('{0}', N'{1}', N'{2}', N'{3}', N'{4}', '{5}')";

        //  Update Teacher
        string SE_UPDATE_TEACHER = "UPDATE GIANG_VIEN SET HoTen=N'{0}', HocVi=N'{1}', HocHam=N'{2}', ChuyenMon=N'{3}' WHERE MaGV = '{4}'";

        //  Insert Student
        string SE_INSERT_STUDENT = "INSERT INTO SINH_VIEN(MaSV, HoTen, Phai, DiaChi, NgaySinh, KhoaHoc, MaLop, MaCN) VALUES('{0}', N'{1}', N'{2}', N'{3}', '{4}', {5}, '{6}', {7})";

        //  Update Student
        string SE_UPDATE_STUDENT = "UPDATE SINH_VIEN SET HoTen = N'{0}', Phai = N'{1}', DiaChi = N'{2}', NgaySinh = '{3}', KhoaHoc = {4}, MaCN = {5} WHERE MaSV = '{6}'";

        //  Update point
        string SE_UPDATE_POINT = "UPDATE DANG_KY_MON_HOC SET Diem = {0} WHERE MaSV = '{1}' AND MaLTC = '{2}'";

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
            string password = param["password"] == "" ? PW_STUDENT : param["password"];
            sqlConnectString = string.Format(initURL, param["server"], param["username"], password);

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

        //  Cancel Credit class
        public void cancelCreditClass(string id, SuccessBlock success, FailureBlock failure)
        {
            //  Init sql
            string sql = string.Format(SE_CANCEL_CREDIT_CLASS, id);

            //  Exec sql
            execSql(sql, response => {
                List<Object> dicts = response as List<object>;
                Dictionary<string, object> dict = dicts[0] as Dictionary<string, object>;
                success(dict["RESPONSE"]);
            }, error => {
                failure(error);
            });
        }

        // Get specify credit class
        public void getSpecifyCreditClass(string id, SuccessBlock success, FailureBlock failure)
        {
            // Init sql
            string sql = string.Format(SE_GET_SPECIFY_CREDIT_CLASS_INFOR, id);

            // Exec sql
            execSql(sql, response => {
                success(response);
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

        //  Update Subject
        public void updateSubject(string newId, string name, string theory, string practise, string numberCredit, SuccessNonParamBlock success, FailureBlock failure)
        {
            //  Init sql
            string sql = string.Format(SE_UPDATE_SUBJECT, name, theory, practise, numberCredit, newId);

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

        //  Update class
        public void updateClass(string classID, string name, SuccessNonParamBlock success, FailureBlock failure)
        {
            //  Init sql
            string sql = string.Format(SE_UPDATE_CLASS, name, classID);

            //  Exec sql
            execSqlNoResponse(sql, () => {
                success();
            }, error => {
                failure(error);
            });
        }

        //  Delete class
        public void deleteClass(string classID, SuccessNonParamBlock success, FailureBlock failure)
        {
            //  Init sql
            string sql = string.Format(SE_DELETE_CLASS, classID);

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

        //  Update Teacher
        public void updateTeacher(string id, string name, string degree, string title, string professional, SuccessNonParamBlock success, FailureBlock failure)
        {
            //  Init sql
            string sql = string.Format(SE_UPDATE_TEACHER, name, degree, title, professional, id);

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
            execSqlNoResponse(sql, () => {
                signup(id, PW_STUDENT, id, "SINHVIEN", () => {
                    success();
                }, errorMessage => {
                    failure(errorMessage);
                });
            }, error => {
                failure(error);
            });
        }

        //  Update Student
        public void updateStudent(string id, string name, string sex, string address, string birthDay, string year, string classID, string major, SuccessNonParamBlock success, FailureBlock failure)
        {
            //  Init sql
            major = major == "NULL" ? "NULL" : "'" + major + "'";
            string sql = string.Format(SE_UPDATE_STUDENT, name, sex, address, birthDay, year, major, id);

            //  Exec sql
            execSqlNoResponse(sql, () => {
                success();
            }, error => {
                failure(error);
            });
        }

        //  Update point
        public void updatePoint(string studentId, string creditId, string point, SuccessNonParamBlock success, FailureBlock failure)
        {
            //  Init sql
            string sql = string.Format(SE_UPDATE_POINT, point, studentId, creditId);

            //  Exec sql
            execSqlNoResponse(sql, () => {
                success();
            }, error => {
                failure(error);
            });
        }

        // MARK: Sign Up
        string SE_SIGN_UP = "EXECUTE SP_SignUp '{0}' ,'{1}' ,'{2}' ,'{3}'";
        public void signup(string login, string password, string id, string role, SuccessNonParamBlock success, FailureBlock failure)
        {
            //  Init sql
            string sql = string.Format(SE_SIGN_UP, login, password, id, role);

            //  Exec sql
            execSqlNoResponse(sql, () => {
                success();
            }, error => {
                failure(error);
            });
        }

        string SE_CHECK_SIGN_UP_EMPLOYEE = "SELECT MaNV FROM NHAN_VIEN WHERE MaNV={0}";
        string SE_CHECK_SIGN_UP_TEACHER = "SELECT MaGV FROM GIANG_VIEN WHERE MaGV='{0}'";
        public void checkSignUp(string id, SuccessBlock success, FailureBlock failure)
        {
            string role = UserProfile.sharedInstance().role;
            string query = role == "PGV" ? SE_CHECK_SIGN_UP_EMPLOYEE : SE_CHECK_SIGN_UP_TEACHER;
            //  Init sql
            string sql = string.Format(query, id);

            //  Exec sql
            execSql(sql, response => {
                success(response);
            }, error => {
                failure(error);
            });
        }

        //  MARK: Multiple DB
        //  Get class
        string SE_MD_GET_CLASS = "SELECT MaLop, Ten FROM {0}LOP";
        public void MDGetClass(string scienceID, SuccessBlock success, FailureBlock failure)
        {
            //  Init sql
            string server = scienceID == this.scienceID ? "" : "LINK1.QLDSV.dbo.";
            string sql = string.Format(SE_MD_GET_CLASS, server);

            //  Exec sql
            execSql(sql, response =>{
                success(response);
            }, error => {
                failure(error);
            });
        }

        //  Get class
        string SE_MD_GET_CREDIT_CLASS = "SELECT MaLTC FROM {0}LOP_TC";
        public void MDGetCreditClass(string scienceID, SuccessBlock success, FailureBlock failure)
        {
            //  Init sql
            string server = scienceID == this.scienceID ? "" : "LINK1.QLDSV.dbo.";
            string sql = string.Format(SE_MD_GET_CREDIT_CLASS, server);

            //  Exec sql
            execSql(sql, response => {
                success(response);
            }, error => {
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
