using System;

namespace CORE_TestAPP
{
    public class BLClient : IBLClient
    {
        public Client AddClient(Client Client)
        {
            try
            {
                Client.ID = Guid.NewGuid();
                // TODO :: Update new data to DB and return success mesage.
                return new Client();

            }
            catch (System.Exception)
            {

                // TODO :: add exception to log
                throw new Exception("Somthing Went Wrong !");
            }

        }

        public string UpdateClient(Client client, Guid id)
        {
            try
            {
                // TODO :: Get Client By id and update latest data

                return "Client " + id + " is updated Sucessfully !";
            }
            catch (System.Exception)
            {

                // TODO :: add exception to log

                return "Somthing Went Wrong !";

            }




        }
        public string DeleteClient(Client client, Guid id)
        {
            try
            {
                // TODO :: Get Client By id and perform Delete Operation

                return "Client " + id + " is Deleted Sucessfully !";
            }
            catch (System.Exception)
            {

                // TODO :: add exception to log

                return "Somthing Went Wrong !";

            }

        }
    }

}