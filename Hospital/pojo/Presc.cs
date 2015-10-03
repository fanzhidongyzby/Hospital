using System;
using System.Collections.Generic;
namespace Hospital
{
    public class Presc
    {
        public int id;
        public String comment;
        public String time;

        public List<DrugCount> drugCountList = new List<DrugCount>();
        public Patient patient;
        public Doctor doctor;



        public Presc() { }

        //public Presc(Patient patient, Doctor doctor, List<DrugCount> drugCountList, String comment)
        //{
        //    this.patient = patient;
        //    this.doctor = doctor;
        //    this.drugCountList = drugCountList;
        //    this.comment = comment;
        //}
    }
}