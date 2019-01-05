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

        public User Login(string username, string password)
        {
            try
            {
                return userDao.Login(username, password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
