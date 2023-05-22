using LibrarySystem.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Entities
{
    public class Member : Person
    {
        public DateTime RegisterDate { get; set; }
    }
}
