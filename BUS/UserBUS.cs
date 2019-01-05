using QLPhongKhamTuNhan.DAO;
using QLPhongKhamTuNhan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongKhamTuNhan.BUS
{
    public class UserBUS
    {
        UserDAO userDao = new UserDAO();

        public User login(string username, string password)
        {
            try
            {
                return userDao.login(username, password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<int> getRoleFunction(int roleid)
        {
            try
            {
                return userDao.getRoleFunction(roleid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
