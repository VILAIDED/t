using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class DoHoa : Form
    {
        Point PS;
        public DoHoa()
        {
            InitializeComponent();
        }

        private void DoHoa_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PS = e.Location;
            }
        }

        private void DoHoa_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = CreateGraphics();
                Pen p = new Pen(Color.Red, 2f);
                Point pn = e.Location;
                g.DrawLine(p, PS, pn);
            }
        }

        private void DoHoa_MouseUp(object sender, MouseEventArgs e)
        {
          /*  if (e.Button == MouseButtons.Left)
            {
                Graphics g = CreateGraphics();
                Pen p = new Pen(Color.Red, 2f);
                Point pn = e.Location;
                g.DrawLine(p, PS, pn);
            }*/
        }
    }
}
