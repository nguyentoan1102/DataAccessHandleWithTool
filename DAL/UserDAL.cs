//////////////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                                  //
// Ngày tạo:5/27/2018 3:16:08 PM                                                     //
//                                                                                                  //
//////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Public;
using System.Reflection;

namespace DAL
{
    public class UserDAL
    {
        public int Insert_User(UserPublic p)
        {
            Database cn = new Database();
            SqlParameter[] prams = {
                cn.MakeOutParam("@Id_Output", SqlDbType.Int, 4),
                 cn.MakeInParam("@FirstName", SqlDbType.NVarChar, 100, p.FirstName),
                cn.MakeInParam("@LastName", SqlDbType.NVarChar, 100, p.LastName),
                cn.MakeInParam("@Dob", SqlDbType.DateTime, 20, p.Dob),
                cn.MakeInParam("@IsActive", SqlDbType.Bit, 1, p.IsActive)
                };
            cn.RunProc("User_Insert", prams);
            cn.Dispose();
            try
            {
                return (int)prams[0].Value;
            }
            catch (Exception ex)
            {
                return 1;
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }
        }

        public UserPublic GetUserById(int id)
        {
            UserPublic user = new UserPublic();
            Database cn = new Database();
            SqlParameter[] prams = { cn.MakeInParam("@UserID", SqlDbType.Int, 4, id), };
            try
            {
                cn.RunProc("User_GetById", prams, out SqlDataReader sqlDataReader);
                if (sqlDataReader.HasRows)
                {
                    if (sqlDataReader.Read())
                    {
                        user.Id = (int)sqlDataReader["Id"];
                        user.FirstName = (string)sqlDataReader["FirstName"];
                        user.LastName = (string)sqlDataReader["LastName"];
                        user.Dob = (DateTime)sqlDataReader["Dob"];
                        user.IsActive = (bool)sqlDataReader["IsActive"];
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error with GetUserById.\n" + ex);
            }

            return user;
        }

        public int Update_User(UserPublic p)
        {
            Database cn = new Database();
            SqlParameter[] prams = {
                cn.MakeInParam("@Id", SqlDbType.Int, 4, p.Id),
                cn.MakeInParam("@FirstName", SqlDbType.NVarChar, 100, p.FirstName),
                cn.MakeInParam("@LastName", SqlDbType.NVarChar, 100, p.LastName),
                cn.MakeInParam("@Dob", SqlDbType.DateTime, 20, p.Dob),
                cn.MakeInParam("@IsActive", SqlDbType.Bit, 1, p.IsActive)
                };
            cn.RunProc("User_Update", prams);
            cn.Dispose();
            try
            {
                return (int)prams[0].Value;
            }
            catch (Exception)
            {
                return 1;
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }
        }

        public int Delete_User(UserPublic p)
        {
            Database cn = new Database();
            SqlParameter[] prams = {
                cn.MakeInParam("@Id", SqlDbType.Int, 4,p.Id)
                };
            cn.RunProc("User_Delete", prams);
            cn.Dispose();
            try
            {
                return (int)prams[0].Value;
            }
            catch (Exception)
            {
                return 1;
            }
            finally
            {
                cn.Close();
                cn.Dispose();
            }
        }

        public DataTable All_User()
        {
            Database cn = new Database();
            DataTable dt = cn.RunExecProc("User_All").Tables[0];
            cn.Dispose();
            return dt;
        }
    }
}