using QLPhongKhamTuNhan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongKhamTuNhan.DAO
{
    public class UserDAO
    {
        DataProcessing dataProcessing = new DataProcessing();

        public User Login(string username, string password)
        {
            string sql = string.Format("SELECT id, role_id FROM [user] WHERE username = '{0}' and password = '{1}' and is_delete = 0", username, password);
            DataTable dt = dataProcessing.Load(sql);

            User user = new User();
            for (int i = 0; i < dt.Rows.Count && dt != null; i++)
            {
                user.id = Convert.ToInt32(dt.Rows[i]["id"]);
                user.role_id = Convert.ToInt32(dt.Rows[i]["role_id"]);
            }
            return user;
        }
    }
}
