using QLPhongKhamTuNhan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongKhamTuNhan.DAO
{
    public class PatientDAO
    {
        DataProcessing dataProcessing = new DataProcessing();

        public int insertPatient(Patient p)
        {
            string sql = string.Format("INSERT INTO patient(name, sex, yob, address, date_exam, is_delete) VALUES (N'{0}', {1}, {2}, N'{3}', {4}, 0)", p.name, p.sex, p.yob, p.address, DateTime.Now.ToString("yyyy-MM-dd"));
            int id = dataProcessing.Execute(sql);

            return id;
        }

        public int updatePatient(Patient p)
        {
            string sql = string.Format("UPDATE patient SET name = N'{0}', sex = {1}, yob = {2}, address = N'{3}' WHERE id = {4}", p.name, p.sex, p.yob, p.address, p.id);
            int id = dataProcessing.Execute(sql);

            return id;
        }

        public List<Patient> getListPatient()
        {
            string sql = string.Format("SELECT * FROM patient WHERE date_exam = {0}", DateTime.Now.ToString("yyyy-MM-dd"));
            DataTable dt = dataProcessing.Load(sql);

            List<Patient> listPatient = new List<Patient>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Patient p = new Patient();
                p.id = Convert.ToInt32(dt.Rows[i]["id"]);
                p.name = dt.Rows[i]["name"].ToString();
                p.sex = Convert.ToInt32(dt.Rows[i]["sex"]);
                p.yob = Convert.ToInt32(dt.Rows[i]["yob"]);
                p.address = dt.Rows[i]["address"].ToString();
                listPatient.Add(p);
            }

            return listPatient;
        }
    }
}
