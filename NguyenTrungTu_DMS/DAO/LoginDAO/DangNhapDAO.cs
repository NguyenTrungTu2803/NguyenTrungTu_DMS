using DTO.LoginDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.LoginDAO
{
    public class DangNhapDAO : DBConnect
    {
        public List<DangNhapDTO> SearchNV(string pUser , string pPass)
        {
            var query = from dn in context.NHANVIENs                       
                        where  dn.hoten.Equals(pUser)
                        select new
                        {
                            dn.hoten, dn.matkhau
                        };
            var kq = query.ToList().ConvertAll(t => new DangNhapDTO
            {
                User = t.hoten,
                Pass = t.matkhau,
            });
            return kq.ToList<DangNhapDTO>();
        }
        // kiem tra nhan vien co ton tai
        public bool Check(string pUser, string pPass)
        {
               NHANVIEN check = context.NHANVIENs.Where(t => t.hoten.Equals(pUser) && t.matkhau.Equals(pPass)).FirstOrDefault();
                if (check != null)
                {
                    return true;
                }
                return false;
        }

    }
}
