using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_1
{
    public class MedicalHistory
    {
        private string diabetes;
        private string allergy;
        private string oralInfection;

        public string Diabetes
        {
            get { return diabetes; }
            set { diabetes = value; }
        }

        public string Allergy
        {
            get { return allergy; }
            set { allergy = value; }
        }

        public string OralInfection
        {
            get { return oralInfection; }
            set { oralInfection = value; }
        }

        public MedicalHistory() { }

        public MedicalHistory(string d, string a, string oi)
        {
            Diabetes = d;
            Allergy = a;
            OralInfection = oi;
        }
    }
}
