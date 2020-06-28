using DAO.LoginDAO;
using DTO.LoginDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.LoginBLL
{
    public class DangNhapBLL
    {
        #region buttonDangNhap
        DangNhapDAO dao = new DangNhapDAO();
        public int  checkBLL(string user, string pass)
        {
            if (user != string.Empty && pass != string.Empty)
            {
                if (dao.Check(user, pass))
                    return 1;
                return 2;
            }
            else
                return 0;
        }
        #endregion

    }
}
