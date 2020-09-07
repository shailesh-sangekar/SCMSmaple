using System;

namespace CORE_TestAPP
{
    public interface IBLMembership
    {
        void Membership(Client client);
        void Membership(Client client, MembershipType Type);
        void Membership(Client client, MembershipType Type, Boolean IsNotify);

    }
}