using System;
using System.Data;
namespace Hospital
{
    class PrescDAO
    {
        private Database db = Database.getInstance();

        private PatientDAO patientDAO = new PatientDAO();
        private DoctorDAO doctorDAO = new DoctorDAO();
        private DrugCountDAO drugCountDAO = new DrugCountDAO();

        private int getInsertId()
        {
            String queryCmd = "SELECT IDENT_CURRENT ('presc')";
            DataTable table = db.queryDataTable(queryCmd);
            return Convert.ToInt32((table.Rows[0].ItemArray[0].ToString()));
        }

        public bool insertPresc(Presc presc)
        {
            bool ret = false;
            db.beginTransaction();
            String cmd = "insert into presc values ('" + presc.patient.id + "', '" + presc.doctor.id
                + "', '" + DateTime.Now + "', '" + presc.comment + "')";

            if (db.update(cmd))
            {
                presc.id = getInsertId();

                //插入映射
                ret = drugCountDAO.insertDrugCountList(presc.drugCountList);
                
            }
            db.endTransaction(ret);

            return ret;
        }

        public Presc getPrescById(String id)
        {
            String cmd = "select * from presc where id = '" + id + "'";
            DataTable table = db.queryDataTable("select * from presc where id = '" + id + "'");
            if (table.Rows.Count == 0)
            {
                return null;
            }

            DataRow row = table.Rows[0];
            object[] items = table.Rows[0].ItemArray;
            Presc presc = new Presc();

            presc.id = row.Field<int>("id");
            String patientId = row.Field<String>("patient");
            String doctorId = row.Field<String>("doctor");
            presc.time = row.Field<DateTime>("time").ToString();
            presc.comment = row.Field<String>("comment");

            presc.patient = patientDAO.getPatientById(patientId);
            presc.doctor = doctorDAO.getDoctorById(doctorId);
            presc.drugCountList = drugCountDAO.getDrugCountById(presc);

            return presc;
        }

        public DataTable getPrescDataTable(int id)
        {
            String cmd = @"select id as 编号, name as 名称, price as '价格（RMB）', drugcount.count as 数量 from drugcount, drug where drugcount.drug = drug.id and presc = '" + id + "'";
            return db.queryDataTable(cmd);
        }

        public Double getIncomeByDepart(String depart)
        {
            String cmd = @"select sum(drugcount.count * drug.price) as total from presc, drug, drugcount, doctor where presc.id = drugcount.presc and drugcount.drug = drug.id and presc.doctor = doctor.id and doctor.depart = '" + depart + "'";
            return db.queryDataTable(cmd).Rows[0].Field<Double>("total");
        }

        public Double getTotalPrice(int id)
        {
            String cmd = @"select sum(price * drugcount.count) as total from drugcount, drug where drugcount.drug = drug.id and presc = '" + id + "'";
            return db.queryDataTable(cmd).Rows[0].Field<Double>("total");
        }
    }
}