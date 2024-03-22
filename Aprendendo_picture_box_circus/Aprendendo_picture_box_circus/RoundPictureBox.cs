using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Aprendendo_picture_box_circus
{
    class RoundPictureBox : PictureBox
    {
        private GraphicsPath _roundPath;

        public RoundPictureBox()
        {
            _roundPath = new GraphicsPath();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            _roundPath.Reset();
            _roundPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(_roundPath);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(Pens.Black, _roundPath);
        }
    }
}