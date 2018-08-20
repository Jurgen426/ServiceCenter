using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceCenterLibrary
{
    //[Serializable]
    public class Client : Person
    {
        public override int Id { get ; set; }
        public override string Name { get; set; }
        public override string Surname { get; set; }
        public override string PhoneNumbers { get; set; }
        public string Notes { get; set; }

    }
}
