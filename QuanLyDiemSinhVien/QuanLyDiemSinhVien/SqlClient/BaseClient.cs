using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyDiemSinhVien.Sql
{
    //  Delegates
    public delegate void SuccessBlock(List<Object> response);
    public delegate void SuccessNonParamBlock();
    public delegate void FailureBlock(string error);

    //  BaseClient
    class BaseClient
    {
        public string sqlRootServerConnectString;
        public string sqlConnectString;

        //  Functions
        public void execSql(string sql, SuccessBlock success, FailureBlock failure)
        {
            try
            {
                //  Open connection
                SqlConnection conn = new SqlConnection(sqlConnectString);
                conn.Open();

                //  Execute Sql Command
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                //  Parse DataReader to Dictionary
                List<Object> response = new List<object>();
                while (dataReader.Read())
                {
                    Dictionary<string, object> dict = new Dictionary<string, object>();
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        dict.Add(dataReader.GetName(i), dataReader.GetValue(i));
                    }

                    response.Add(dict);
                }

                //  Success block
                success(response);

                //  Close all connection
                conn.Close();
                dataReader.Close();
            }
            catch (Exception e)
            {
                failure(e.Message);
            }
        }
    }
}
