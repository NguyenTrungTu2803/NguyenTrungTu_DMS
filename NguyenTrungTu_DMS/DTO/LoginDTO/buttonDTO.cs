using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTO.LoginDTO
{
    public class buttonDTO : Button
    {
        public buttonDTO()
        {
            BackColor = Color.DimGray;
            this.Width = 150; this.Height = 50;
           
        }

        //protected override void OnEnter(EventArgs e)
        //{
        //    BackColor = Color.White;
        //    base.OnEnter(e);
        //}

        protected override void OnLeave(EventArgs e)
        {
            BackColor = SystemColors.ControlDark;
            base.OnLeave(e);
        }
    }
}
