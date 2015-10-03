using System;
namespace Hospital
{
    public class Doctor
    {
        public String id;
        public String name;
        public String gender;
        public String depart;
        public String comment;

        public Doctor() { }

        public Doctor(String id, String name, String gender, String depart, String comment) 
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.depart = depart;
            this.comment = comment;
        }

        public override String ToString()
        {
            return id + ", " + name + ", " + gender + ", " + depart + ", " + comment;
        }
    }
}