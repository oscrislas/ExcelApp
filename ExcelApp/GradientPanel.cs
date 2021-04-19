using System.Drawing;
using System.Drawing.Drawing2D;

using System.Windows.Forms;

namespace GradientPanelDemo
{
    class GradientPanel : Panel
    {
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }
        public Color ColorRigth { get; set; }

        public Color ColorLeft { get; set; }
        public Color ColorCenter { get; set; }

        public float Angle { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            int mitadWidth=this.ClientRectangle.Width / 2;
            int mitadHaight = this.ClientRectangle.Height / 2;
            Rectangle r = new Rectangle();
            r.X = this.ClientRectangle.X;
            r.Y = this.ClientRectangle.Y;
            r.Width = mitadWidth;
            r.Height = mitadHaight;
            Rectangle d = new Rectangle();
            d.X = r.X+mitadWidth -1;
            d.Y = this.ClientRectangle.Y;
            d.Width = mitadWidth;
            d.Height = mitadHaight;

            Rectangle rr = new Rectangle();
            rr.X = this.ClientRectangle.X -1;
            rr.Y = this.ClientRectangle.Y+mitadHaight-1;
            rr.Width = mitadWidth;
            rr.Height = mitadHaight;
            Rectangle dd = new Rectangle();
            dd.X = r.X + mitadWidth-1;
            dd.Y = this.ClientRectangle.Y+mitadHaight-1;
            dd.Width = mitadWidth;
            dd.Height = this.ClientRectangle.Height;
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, 45F);
            LinearGradientBrush llr = new LinearGradientBrush(this.ClientRectangle, this.ColorBottom, this.ColorRigth, 315F);
            LinearGradientBrush lgb2 = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, 315F);
            LinearGradientBrush llr2 = new LinearGradientBrush(this.ClientRectangle, this.ColorBottom, this.ColorRigth, 90F);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);
            g.FillRectangle(llr, this.ClientRectangle);
            g.FillRectangle(lgb2, this.ClientRectangle);
            g.FillRectangle(llr2, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
