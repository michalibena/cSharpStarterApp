using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cSharpStarterApp
{
    class Employee
    {
        long _id;
        string _firstName;
        string _lastName;

        // ctors
        public Employee(long id, string fname, string lname)
        {
            ID = id;
            FirstName = fname;
            LastName = lname;
        }

        long ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append(": ");
            sb.Append(LastName);
            sb.Append(", ");
            sb.Append(FirstName);
            return sb.ToString();
        }
    }
}
