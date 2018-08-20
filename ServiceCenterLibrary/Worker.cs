using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceCenterLibrary
{
    [Serializable]
    public class Worker:Person
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Surname { get; set; }
        public override string PhoneNumbers { get; set; }
        public Position Position { get; set; }


        public bool Equals(Worker worker)
        {
            if (this.Name == worker.Name && this.Surname == worker.Surname)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
    
}
