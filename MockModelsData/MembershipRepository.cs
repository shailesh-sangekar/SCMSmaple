using System;
using System.Collections.Generic;


namespace CORE_TestAPP
{
    public class MembershipRepository
    {
        private List<Membership> _data;
        public List<Membership> Data
        {
            get { return _data; }
            set { _data = value; }
        }

        MembershipRepository()
        {
            _data = new List<Membership>() {
                new Membership() { ID= Guid.NewGuid(),StartDate = DateTime.Now, EndDate = DateTime.Now },
                new Membership() { ID=Guid.NewGuid(), StartDate = DateTime.Now, EndDate = DateTime.Now },
                new Membership() { ID=Guid.NewGuid(), StartDate = DateTime.Now, EndDate = DateTime.Now },
                new Membership() { ID=Guid.NewGuid(), StartDate = DateTime.Now, EndDate = DateTime.Now },
                new Membership() { ID=Guid.NewGuid(), StartDate = DateTime.Now, EndDate = DateTime.Now },
                new Membership() { ID=Guid.NewGuid(), StartDate = DateTime.Now, EndDate = DateTime.Now },
            };
        }


    }
}