//////////////////////////////////////////////////////////////////////////////////////////////////////
//                                                                                                  //
// Ngày tạo:5/27/2018 3:16:08 PM                                                     //
//                                                                                                  //
//////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Data.SqlClient;

namespace Public
{
    public class UserPublic
    {
        protected int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        protected string _FirstName;

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        protected string _LastName;

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        protected DateTime _Dob;

        public DateTime Dob
        {
            get { return _Dob; }
            set { _Dob = value; }
        }

        protected bool _IsActive;

        public bool IsActive
        {
            get { return _IsActive; }
            set { _IsActive = value; }
        }
    }
}