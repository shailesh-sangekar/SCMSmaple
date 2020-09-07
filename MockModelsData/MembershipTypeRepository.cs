using System;
using System.Collections.Generic;


namespace CORE_TestAPP
{
    public class MembershipTypeRepository
    {
        private List<MembershipType> _data;
        public List<MembershipType> Data
        {
            get { return _data; }
            set { _data = value; }
        }

        MembershipTypeRepository()
        {
            _data = new List<MembershipType>() {
                new MembershipType() { ID=1, Name = "ABC12" },
                new MembershipType() { ID=2, Name = "ABC13" },
                new MembershipType() { ID=3, Name = "ABC14" },
                new MembershipType() { ID=4, Name = "ABC15" },
                new MembershipType() { ID=5, Name = "ABC16" },
                new MembershipType() { ID=6, Name = "ABC17" },

            };
        }


    }
}