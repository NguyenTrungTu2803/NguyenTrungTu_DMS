using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.LoginDTO
{
    public class DangNhapDTO
    {
        public string user;
        public string pass;

        //public DangNhapDTO(string user, string pass)
        //{
        //    this.user = user;
        //    this.pass = pass;
        //}
        public DangNhapDTO() { }
        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }
    }
}
