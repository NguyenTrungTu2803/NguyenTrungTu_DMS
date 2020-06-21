using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DAO
{
    public class BorderTextbox : TextBox
    {
        //TextBox textBox;

        public Color DefaultBorderColor { get; set; }
        public Color FocusedBorderColor { get; set; }

        public override string Text
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
        public BorderTextbox()
        {
            BackColor = Color.White;
            this.Width = 150; this.Height = 50;
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
