using QLPhongKhamTuNhan.DAO;
using QLPhongKhamTuNhan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongKhamTuNhan.BUS
{
    public class PatientBUS
    {
        PatientDAO patientDao = new PatientDAO();

        public int insertPatient(Patient p)
        {
            try
            {
                return patientDao.insertPatient(p);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int updatePatient(Patient p)
        {
            try
            {
                return patientDao.updatePatient(p);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Patient> getListPatient()
        {
            try
            {
                return patientDao.getListPatient();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
