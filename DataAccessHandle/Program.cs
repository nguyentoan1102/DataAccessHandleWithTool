using Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS;
using System.Data;
using DAL;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessHandle
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            int id = 0;
            var user = new UserPublic
            {
                FirstName = "ToanTest2",
                LastName = "Nguyen",
                Dob = DateTime.Now,
                IsActive = true
            };
            UserBUS userBus = new UserBUS();
            try
            {
                //1.Insert
                // id = userBus.Insert_User(user);

                //2. Update
                //user.Id = 6;
                //id = userBus.Update_User(user);

                //Delete
                //user.Id = 5;
                //userBus.Delete_User(user);

                //Get All User as Table
                //  DataTable dbTable = userBus.All_User();

                //
                var userGetById = userBus.GetUserById(2);

                Console.WriteLine(userGetById.FirstName);
                // con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
            }

            Console.WriteLine("Insert Success with ID:" + id.ToString());
            Console.ReadLine();
        }
    }
}