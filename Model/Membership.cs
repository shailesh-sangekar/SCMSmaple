using System;

namespace CORE_TestAPP
{
    public class Membershitp
    {
        public int id { get; set; }
        public string MemberShipType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Client MemberClient { get; set; }
        public string Status { get; set; } = "Active";
        

    }
}