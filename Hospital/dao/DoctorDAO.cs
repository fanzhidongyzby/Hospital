using System;
using System.Data;
namespace Hospital
{
    class DoctorDAO
    {
        private Database db = Database.getInstance();

        public bool updateDoctor(Doctor doctor)
        {
            String queryCmd = "select * from doctor where id = '" + doctor.id + "'";
            bool exist = db.queryDataTable(queryCmd).Rows.Count == 1;

            String cmd = "insert into doctor values ('" + doctor.id + "', '" + doctor.name + "', '" + doctor.gender + "', '"
                + doctor.depart + "', '" + doctor.comment + "')";

            if (exist)
            {
                cmd = "update doctor set name = '" + doctor.name + "', gender = '" + doctor.gender +
                    "', comment = '" + doctor.comment + "', depart = '" + doctor.depart + "' where id = '" + doctor.id + "'";
            }

            return db.update(cmd);
        }

        public Doctor getDoctorById(String id)
        {
            DataTable table = db.queryDataTable("select id, name, gender, depart, comment from doctor where id = '" + id + "'");
            if (table.Rows.Count == 0)
            {
                return null;
            }

            DataRow row = table.Rows[0];
            Doctor doctor = new Doctor();

            doctor.id = row.Field<String>("id");
            doctor.name = row.Field<String>("name");
            doctor.gender = row.Field<String>("gender");
            doctor.depart = row.Field<String>("depart");
            doctor.comment = row.Field<String>("comment");

            return doctor;
        }

        public DataTable getDoctorDataTable()
        {
            String cmd = @"select id as 身份证号, name as 姓名, gender as 性别, depart as 科室, comment as 备注 from doctor order by name";
            return db.queryDataTable(cmd);
        }

        public int getDoctorNumberByDepart(String depart)
        {
            String cmd = @"select count(*) as total from doctor where depart = '" + depart + "'";
            return db.queryDataTable(cmd).Rows[0].Field<int>("total");
        }

    }
}