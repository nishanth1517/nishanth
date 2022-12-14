using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SaiYogaTraining.Model
{
    class Session : Connection
    {
        public string SessionID;
        private bool flag;

        public Session(string loginID)
        {
            try
            {
                if (loginID != null)
                {
                    var conn = GetConnect();
                    string query = "INSERT INTO Session (loginid) VALUES (@loginID)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add(new SqlParameter("@loginID", loginID));
                    int num = cmd.ExecuteNonQuery();
                    query = "SELECT sid FROM Session WHERE loginid = @loginID";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add(new SqlParameter("@loginID", loginID));
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        SessionID = rdr[0].ToString();
                    }

                    if (num != -1 && SessionID != null)
                        flag = true;
                    else
                        flag = false;
                }
                else
                {
                    flag = false;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                flag = false;
            }
            finally
            {
                CloseConnect();
            }
        }

        public bool hasSession()
        {
            return flag;
        }
        public bool DeleteSession(Session s1)
        {
            try
            {
                var conn = GetConnect();
                var query = "DELETE FROM Session where sid=@sid";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@sid", s1.SessionID));
                int row = cmd.ExecuteNonQuery();
                if (row != -1)
                    return true;
                else
                    return false;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                CloseConnect();
            }
        }
    }
}
