using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Lab_2
{
    /// <summary>
    /// Represents a base class for users.
    /// </summary>
    class User
    {
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }
    }
}
