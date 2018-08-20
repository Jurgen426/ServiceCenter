using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceCenterLibrary
{
    public class Order
    {
        public int Id { get; set; }
        public OrderStatus MyStatus { get; set; }
        public Client MyClient { get; set; }
        public Device MyDevice { get; set; }
        public string Description { get; set; }
        public DateTime TimeOfAcceptance { get; set; }
        public DateTime TimeOfReturn { get; set; }
        public Worker Repairer { get; set; }
        public string RepairmansComment { get; set; }
        public int CostOfRepair { get; set; }

    }
}
