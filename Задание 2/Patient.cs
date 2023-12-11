using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    public class Patient
    {
        public int TreatmentPlanCode { get; set; }

        public void AssignDoctorAccordingToTreatmentPlan(Doctor doctor)
        {
            doctor.Heal();
        }
    }
}
