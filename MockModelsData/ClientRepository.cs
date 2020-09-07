using System;
using System.Collections.Generic;


namespace CORE_TestAPP
{
    public class ClientRepository
    {
        private List<Client> _data;
        public List<Client> Data
        {
            get { return _data; }
            set { _data = value; }
        }

        ClientRepository()
        {
            _data = new List<Client>() {
                new Client() { ID= Guid.NewGuid(),Name = "Client 1", Conacts = new Contact(){ ID=1, FirstName = "ABC", LastName = "XYZ", Email ="abc@xyz.com"},PrimaryEmail ="Client1@email.com" },
                new Client() { ID= Guid.NewGuid(),Name = "Client 2", Conacts = new Contact(){ ID=2, FirstName = "ABC", LastName = "XYZ", Email ="abc@xyz.com"},PrimaryEmail ="Client1@email.com" },
                new Client() { ID= Guid.NewGuid(),Name = "Client 3", Conacts = new Contact(){ ID=3, FirstName = "ABC", LastName = "XYZ", Email ="abc@xyz.com"},PrimaryEmail ="Client1@email.com" },
                new Client() { ID= Guid.NewGuid(),Name = "Client 4", Conacts = new Contact(){ ID=4, FirstName = "ABC", LastName = "XYZ", Email ="abc@xyz.com"},PrimaryEmail ="Client1@email.com" },
                new Client() { ID= Guid.NewGuid(),Name = "Client 5", Conacts = new Contact(){ ID=5, FirstName = "ABC", LastName = "XYZ", Email ="abc@xyz.com"},PrimaryEmail ="Client1@email.com" },
                new Client() { ID= Guid.NewGuid(),Name = "Client 6", Conacts = new Contact(){ ID=6, FirstName = "ABC", LastName = "XYZ", Email ="abc@xyz.com"},PrimaryEmail ="Client1@email.com" },

            };
        }


    }
}