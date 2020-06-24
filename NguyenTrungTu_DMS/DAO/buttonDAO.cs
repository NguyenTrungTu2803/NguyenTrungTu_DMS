using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class buttonDAO : Button
    {
        public Color DefaultBorderColor { get; set; }
        public Color FocusedBorderColor { get; set; }

        public override string Text
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
        public buttonDAO()
        {
            BackColor = Color.DarkViolet;
            this.Width = 50; this.Height = 30;
        }

        protected override void OnEnter(EventArgs e)
        {
            BackColor = Color.White;
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            BackColor = SystemColors.ControlDark;
            base.OnLeave(e);
        }
    }
}
