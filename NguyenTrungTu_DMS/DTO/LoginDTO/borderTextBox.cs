using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTO.LoginDTO
{
    public class borderTextBox : TextBox
    {
        //TextBox textBox;
        #region Atrributes
        public borderTextBox()
            : base()
        {
            //this.SetStyle(ControlStyles.UserPaint, true);
            BackColor = Color.White;
            this.Width = 250; this.Height = 30;
            ForeColor = Color.Black;
           
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Pen penBorder = new Pen(Color.Gray, 1);
            Rectangle rectBorder = new Rectangle(e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
            e.Graphics.DrawRectangle(penBorder, rectBorder);
        }        
        #endregion

    }
}
