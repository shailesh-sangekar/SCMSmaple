using System;

namespace CORE_TestAPP
{
    public class Membership
    {
        public Guid ID { get; set; }
        public MembershipType MemberShipType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Client MemberClient { get; set; }
        public string Status { get; set; } = "Active";


    }
}