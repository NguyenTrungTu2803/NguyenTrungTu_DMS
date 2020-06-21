using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class buttomDAO : UserControl
    {
        Button button;
        public Color DefaultBorderColor { get; set; }
        public Color FocusedBorderColor { get; set; }
        public buttomDAO()
        {
            button = new Button()
            {                
                Height=60, Width=80,
                Location = new Point(-1, -1),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                         AnchorStyles.Left | AnchorStyles.Right
            };
            Control container = new ContainerControl()
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(-1)
            };
            container.Controls.Add(button);
            this.Controls.Add(container);

            DefaultBorderColor = SystemColors.ControlDark;
            FocusedBorderColor = Color.Red;
            BackColor = DefaultBorderColor;
            Padding = new Padding(1);
            Size = button.Size;
            button.Text = "Đăng nhập";
           
        }

        protected override void OnEnter(EventArgs e)
        {
            BackColor = FocusedBorderColor;
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            BackColor = DefaultBorderColor;
            base.OnLeave(e);
        }
    }
}
