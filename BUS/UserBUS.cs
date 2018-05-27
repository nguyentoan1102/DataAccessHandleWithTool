//////////////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                                  //
// Ngày tạo:5/27/2018 3:16:08 PM                                                     //
//                                                                                                  //
//////////////////////////////////////////////////////////////////////////////////////////////////////

using DAL;
using Public;
using System.Data;

namespace BUS
{
    public class UserBUS
    {
        private UserDAL cls = new UserDAL();

        public int Insert_User(UserPublic p)
        {
            return cls.Insert_User(p);
        }

        public int Update_User(UserPublic p)
        {
            return cls.Update_User(p);
        }

        public int Delete_User(UserPublic p)
        {
            return cls.Delete_User(p);
        }

        public DataTable All_User()
        {
            return cls.All_User();
        }

        public UserPublic GetUserById(int id)
        {
            return cls.GetUserById(id);
        }
    }
}