using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_1
{
    public class Client
    {
        private int clientID;
        private string firstName;
        private string lastName;
        private double familyIncome;
        private string livingArrangement;
        private int noChildren;

        public int ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public double FamilyIncome
        {
            get { return familyIncome; }
            set { familyIncome = value; }
        }

        public string LivingArrangement
        {
            get { return livingArrangement; }
            set { livingArrangement = value; }
        }

        public int NoChildren
        {
            get { return noChildren; }
            set { noChildren = value; }
        }

        public Client() { }

        public Client(int cID, string fn, string ln, double fi, string la, int nc)
        {
            ClientID = cID;
            FirstName = fn;
            LastName = ln;
            FamilyIncome = fi;
            LivingArrangement = la;
            NoChildren = nc;
        }

         public Application applyAdoptionForm(int appID, string stat)
        {
            Application application = new Application(appID, stat);

            return application;
        }

        public Appointment bookAppointment(int appointID, DateTime ti) {

            Appointment appointment = new Appointment(appointID, ti);

            return appointment;
        
        }

        public Appointment cancalAppointment(int appointID, DateTime ti)
        {

            Appointment appointment = new Appointment(appointID, ti);
            return appointment;

        }
    }
}
