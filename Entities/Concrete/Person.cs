using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete

{
    //ctrlk ctrld == kod düzeltme
    public class Person   //internal                       
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationalIdentity { get; set; }
        public int DateOfBirthYear { get; set; }
    }
}
