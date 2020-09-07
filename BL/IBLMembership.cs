using System;

namespace CORE_TestAPP
{
    public interface IBLMembership
    {
        void Membership(Membership membership, Client client);
        void Membership(Client client, MembershipType Type);
        void Membership(Client client, MembershipType Type, Boolean IsNotify);

    }
}