using LibrarySystem.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Entities
{
    public class Librarian : Person
    {
        public Guid PersonalityCode { get; set; }

    }
}
