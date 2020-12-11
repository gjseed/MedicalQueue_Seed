using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalQueue_Seed
{
    class Patient
    {
        public string fullname;
        public int Priority;
        public Patient()
        {

        }

        public Patient(string name, int priority)
        {
            fullname = name;
            Priority = priority;
        }
    }
}
