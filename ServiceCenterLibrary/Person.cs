using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceCenterLibrary
{
    [Serializable]
    public abstract class Person
    {
        public abstract int Id { get; set; }

        public abstract string Name { get; set; }
        public abstract string Surname { get; set; }
        public abstract string PhoneNumbers { get; set; }
        


    }
}
