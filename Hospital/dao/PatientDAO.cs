using System;
using System.Data;
namespace Hospital
{
    class PatientDAO
    {
        private Database db = Database.getInstance();

        public bool updatePatient(Patient patient)
        {
            String queryCmd = "select * from patient where id = '" + patient.id + "'";
            bool exist = db.queryDataTable(queryCmd).Rows.Count == 1;

            String cmd = "insert into patient values ('" + patient.id + "', '" + patient.name + "', '" + patient.gender + "', '"
                + patient.comment + "', '" + DateTime.Now + "')";

            if (exist)
            {
                cmd = "update patient set name = '" + patient.name + "', gender = '" + patient.gender +
                    "', comment = '" + patient.comment + "', time = '" + DateTime.Now + "' where id = '" + patient.id + "'";
            }

            return db.update(cmd);
        }

        public Patient getPatientById(String id)
        {
            DataTable table = db.queryDataTable("select id, name, gender, comment, time from patient where id = '" + id + "'");
            if (table.Rows.Count == 0)
            {
                return null;
            }

            DataRow row = table.Rows[0];
            Patient patient = new Patient();

            patient.id = row.Field<String>("id");
            patient.name = row.Field<String>("name");
            patient.gender = row.Field<String>("gender");
            patient.comment = row.Field<String>("comment");
            patient.time = row.Field<DateTime>("time").ToString();

            return patient;
        }

        public DataTable getPatientDataTable()
        {
            String cmd = @"select id as 身份证号, name as 姓名, gender as 性别, comment as 备注, time as 时间 from patient order by time desc";
            return db.queryDataTable(cmd);
        }

        public int getPatientNumberByDepart(String depart)
        {
            String cmd = @"select count(*) as total from presc, patient, doctor where presc.patient = patient.id and presc.doctor = doctor.id and doctor.depart = '" + depart + "'";
            return db.queryDataTable(cmd).Rows[0].Field<int>("total");
        }
    }
}