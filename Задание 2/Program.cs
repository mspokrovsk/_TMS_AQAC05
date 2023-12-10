// See https://aka.ms/new-console-template for more information
using Задание_2;

Patient patient = new Patient();
Console.Write("Введите код лечения: ");
patient.TreatmentPlanCode = int.Parse(Console.ReadLine());

Doctor doctor;

if (patient.TreatmentPlanCode == 1)
{
    doctor = new Surgeon();
}
else if (patient.TreatmentPlanCode == 2)
{
    doctor = new Dentist();
}
else
{
    doctor = new Therapist();
}

patient.AssignDoctorAccordingToTreatmentPlan(doctor);

Console.ReadKey();
