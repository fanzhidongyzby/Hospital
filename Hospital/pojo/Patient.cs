using System;
namespace Hospital
{
    public class Patient
    {
        public String id;
        public String name;
        public String gender;
        public String comment;
        public String time;

        public Patient() { }

        public Patient(String id, String name, String gender, String comment) 
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.comment = comment;
        }

        public override String ToString()
        {
            return id + ", " + name + ", " + gender + ", " + comment + ", " + time;
        }
    }
}