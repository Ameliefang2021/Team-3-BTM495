using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_1
{
    public class Application
    {
        private int appID;
        private string status;
        private Client client;
        private Animal animal;

        public int AppID
        {
            get { return appID; }
            set { appID = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public Client Client { get => client; set => client = value; }
        public Animal Animal { get => animal; set => animal = value; }

        public Application() { }

        public Application(int appID, string stat)
        {
            AppID = appID;
            Status = stat;
        }
    }
}
