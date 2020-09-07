using System;

namespace CORE_TestAPP
{
    public interface IBLClient
    {
        Client AddClient(Client clients);
        string UpdateClient(Client clients, Guid id);
        string DeleteClient(Client clients, Guid id);
    }
}