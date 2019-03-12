using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergeImage
{
    public partial class Form1 : Form
    {

        Image imgOriginal;
        //-- FirstPoint use to move image
        private Point firstPoint = new Point();
        private Boolean isMove = false;
        private string[] wordsName;
        private List<string> uniqName = new List<string>();


        public Form1()
        {
            InitializeComponent();

            tbxFolderPath.Text = imagePath.SelectedPath;
            tbxFolderPath.Text = Properties.Settings.Default.imagePath;


            // Directory 아래 모든 하위 Direct를 검색하여 파일 이름 가져오기.
            string path = "C:\\Users\\tgHan\\Desktop\\HistopathologicalImage\\2019.03.12";
            DirectoryInfo dirPath = new DirectoryInfo(@path);
            DirectoryInfo[] dirs = dirPath.GetDirectories();
            string fullName;



            foreach (DirectoryInfo dir in dirs) // 하위 폴더목록을 스캔합니다.
            {
                foreach (FileInfo File in dir.GetFiles()) // 선택 폴더의 파일 목록을 스캔합니다.
                {

                    fullName = File.Name;
                    wordsName = fullName.Split('_');
                    uniqName.Add(wordsName[0]);
                }

            }
            uniqName = uniqName.Distinct().ToList();
            foreach (string uniq in uniqName) // 선택 폴더의 파일 목록을 스캔합니다.
            {
                gridIMG.Rows.Add(uniq, "N");
            }
        }


        // 마우스 휠을 통한 이미지 확대 축소 함수 생성
        private void DataPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                DataPanel.Width = DataPanel.Width + 50;
                DataPanel.Height = DataPanel.Height + 50;
            }
            else
            {
                DataPanel.Width = DataPanel.Width - 50;
                DataPanel.Height = DataPanel.Height - 50;
            }

        }

        private void btnFold_Click(object sender, EventArgs e)
        {
            //select files...
            imagePath.ShowDialog();

            if (imagePath.SelectedPath.Length > 0)
            {
                tbxFolderPath.Text = imagePath.SelectedPath;
                Properties.Settings.Default.imagePath = tbxFolderPath.Text = imagePath.SelectedPath;
                Properties.Settings.Default.Save();
                //Bitmap canvas = new Bitmap(224, 224 * openFileDialog1.FileNames.Length);
                //int index = 0;
                //System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(canvas);
                //foreach (string filename in openFileDialog1.FileNames)
                //{
                //    System.Drawing.Image img = System.Drawing.Image.FromFile(filename);
                //    g.DrawImage(img, 0, 224 * index, 224, 224);
                //    index++;
                //}

                //Image.GetThumbnailImageAbort myCallback = new Image.GetThumbnailImageAbort(thumbnailCallback);

                //DataPanel.Image = canvas.GetThumbnailImage(224, 224 * openFileDialog1.FileNames.Length, myCallback, IntPtr.Zero);
                //DataPanelSmar.Image = DataPanel.Image;
                //imgOriginal = DataPanel.Image;
            }
        }

        public bool thumbnailCallback()
        {
            return false;
        }
        /**
        * 마우스를 이용한 이미지 Move 힘수
        *  - DataPanel :최도 마우스 Cursor 취치 확정.
        *  - DataPanel : 마우스 up하였을때 이미지 이동 하지 않음
        *  - DataPanel : 마우스 이동 거리에  계산
        **/
        private void DataPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                firstPoint.X = Cursor.Position.X;
                firstPoint.Y = Cursor.Position.Y;
                isMove = true;
                DataPanel.Focus();

            }

        }

        private void DataPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMove = false;
            }
        }

        private void DataPanel_MouseMove(object sender, MouseEventArgs e)
        {
            DataPanel.Focus();
            if (isMove)
            {
                int x, y;
                int moveX, moveY;
                moveX = Cursor.Position.X - firstPoint.X;
                moveY = Cursor.Position.Y - firstPoint.Y;
                x = DataPanel.Location.X + moveX;
                y = DataPanel.Location.Y + moveY;
                DataPanel.Location = new Point(x, y);
                firstPoint.X = Cursor.Position.X;
                firstPoint.Y = Cursor.Position.Y;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DataPanel.Image != null)
            {
                DataPanel.Dispose();
            }
        }

        private void DataPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                lbImagePosiont.Text = "이미지 Position : X =  " + e.X + "; Y = " + e.Y;
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            //이미지 리스트 다시 불러오기
        }
    }
}
