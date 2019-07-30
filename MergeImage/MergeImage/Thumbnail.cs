using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergeImage
{
    public partial class Thumbnail : Form
    {
        private Point mousePoint;

        public delegate void ThumbnailImage_MouseDown(object sender, MouseEventArgs e);
        public ThumbnailImage_MouseDown thumbnailImage_MouseDown;

        public delegate void ThumbnailImage_MouseMove(object sender, MouseEventArgs e);
        public ThumbnailImage_MouseMove thumbnailImage_MouseMove;

        public delegate void ThumbnailImage_MouseUp(object sender, MouseEventArgs e);
        public ThumbnailImage_MouseUp thumbnailImage_MouseUp;


        public Thumbnail(ThumbnailImage_MouseDown thumbnailImage_MouseDown, ThumbnailImage_MouseMove thumbnailImage_MouseMove, ThumbnailImage_MouseUp thumbnailImage_MouseUp)
        {
            InitializeComponent();
            this.TopMost = true;
            this.thumbnailImage_MouseDown = thumbnailImage_MouseDown;
            this.thumbnailImage_MouseMove = thumbnailImage_MouseMove;
            this.thumbnailImage_MouseUp = thumbnailImage_MouseUp;

            this.ThumbnailImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.thumbnailImage_MouseDown);
            this.ThumbnailImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.thumbnailImage_MouseMove);
            this.ThumbnailImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.thumbnailImage_MouseUp);
        }

        public PictureBox getPictureBoxThumbnailImage()
        {
            return ThumbnailImage;
        }

        private void form_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }
        // 마우스 클릭시 먼저 선언된 mousePoint변수에 현재 마우스 위치값이 들어갑니다.

        private void form_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }
        
    }
}
