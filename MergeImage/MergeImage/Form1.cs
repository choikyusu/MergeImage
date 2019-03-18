﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        int drawCount = 0;
        double zoomScale = 1;
        int startPointX = 99999;
        int startPointY = 99999;
        int top = 0;
        int left = 0;
        int splitWidth = 250;
        int splitHeight = 250;
        int wholeX;
        int wholeY;
        List<string> drawnImage = new List<string>();
        enum eMergeImageGridIndex
        {
            ID,
            CONFIRM
        }

        Image imgOriginal;
        //-- FirstPoint use to move image
        private Point firstPoint = new Point();
        private Boolean isMove = false;
        private string[] wordsName;
        private List<string> uniqName = new List<string>();
        private List<string> slidesFullName = new List<string>();
        private List<string> filterSlidesFullName = new List<string>();
        private Bitmap canvas;
        System.Drawing.Graphics g;
        private Boolean colorOnOff = true;
        Bitmap redColor = new Bitmap(Properties.Resources.red);
        Bitmap blueColor = new Bitmap(Properties.Resources.blue);
        Bitmap greenColor = new Bitmap(Properties.Resources.green);

        public int Top1
        {
            get
            {
                return top + startPointY;
            }

            set
            {
                top = value;
            }
        }

        public int Left1
        {
            get
            {
                return left + startPointX;
            }

            set
            {
                left = value;
            }
        }

        public Form1()
        {

            InitializeComponent();

            tbxFolderPath.Text = Properties.Settings.Default.imagePath;

            getDateImageList();
            readFileMergeImageStatus();

            drawnImage.Clear();
        }


        // 마우스 휠을 통한 이미지 확대 축소 함수 생성
        private void DataPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                if (zoomScale == 0.5)
                {
                    zoomScale = 1;
                }
                else if (zoomScale == 0.2)
                {
                    zoomScale = 0.5;
                }
                else if (zoomScale == 0.1)
                {
                    zoomScale = 0.2;
                }
                else if (zoomScale == 0.05)
                {
                    zoomScale = 0.2;
                }
                zoomScale = Math.Round(zoomScale * 100) / 100;
                drawImage(filterSlidesFullName);
            }
            else
            {
                if (zoomScale == 1)
                {
                    zoomScale = 0.5;
                }
                else if (zoomScale == 0.5)
                {
                    zoomScale = 0.2;
                }
                else if (zoomScale == 0.2)
                {
                    zoomScale = 0.1;
                }
                else if (zoomScale == 0.1)
                {
                    zoomScale = 0.05;
                }
                zoomScale = Math.Round(zoomScale * 100) / 100;
                drawImage(filterSlidesFullName);
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

                getDateImageList();
                readFileMergeImageStatus();
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

                lbImagePosiont.Text = "left : " + Left1 + " top : " + Top1;

            }

        }
        private void DataPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                left = left - (int)((DataPanel.Left + 500)/zoomScale) ;
                top = top - (int)((DataPanel.Top + 500) / zoomScale);
                //left = left - (DataPanel.Left + 500) - (int)((DataPanel.Left + 500) * 10 * (1.00 - zoomScale)) ;
                //top = top - (DataPanel.Top + 500) - (int)((DataPanel.Top + 500) * 10 * (1.00 - zoomScale));
                drawImage(filterSlidesFullName);
                DataPanel.Left = -500;
                DataPanel.Top = -500;
                isMove = false;

                
            }
        }

        private void DataPanel_MouseMove(object sender, MouseEventArgs e)
        {
            DataPanel.Focus();
            if (isMove)
            {
                int moveX, moveY;
                moveX = Cursor.Position.X - firstPoint.X;
                moveY = Cursor.Position.Y - firstPoint.Y;
                DataPanel.Location = new Point(DataPanel.Location.X + moveX, DataPanel.Location.Y + moveY);
                firstPoint.X = Cursor.Position.X;
                firstPoint.Y = Cursor.Position.Y;

                //gridMergeImageRowChange(null, null);

                lbImagePosiont.Text = "left : " + left + " top : " + top + " moveX : " + (Cursor.Position.X - firstPoint.X) + "moveY : " + (Cursor.Position.Y - firstPoint.Y);

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
            getDateImageList();
            readFileMergeImageStatus();
        }

        public void getDateImageList()
        {
            gridMergeImage.Rows.Clear();

            // Directory 아래 모든 하위 Direct를 검색하여 파일 이름 가져오기.
            string path = tbxFolderPath.Text + "\\" + dtpDate.Value.ToString("yyyy.MM.dd");
            DirectoryInfo dirPath = new DirectoryInfo(@path);
            if (dirPath.Exists == true)
            {
                DirectoryInfo[] dirs = dirPath.GetDirectories();
                string fullName;

                foreach (DirectoryInfo dir in dirs) // 하위 폴더목록을 스캔합니다.
                {
                    //폴더명이 N,A,D,M일때만 탐색
                    if (dir.Name == "N" || dir.Name == "A" || dir.Name == "D" || dir.Name == "M")
                    {
                        foreach (FileInfo File in dir.GetFiles()) // 선택 폴더의 파일 목록을 스캔합니다.
                        {
                            if (File.Name.Contains("_") == true)
                            {
                                slidesFullName.Add(File.FullName); // 타일 Full Name(Path+ Image Name) 저장
                                fullName = File.Name;              // 타일 Name(Image Name)
                                wordsName = fullName.Split('_', '-');   // 타일 Name Parsing
                                uniqName.Add(wordsName[0]);        // 타일 ID(Image ID) 저장
                            }
                        }
                    }
                }
                uniqName = uniqName.Distinct().ToList();
                uniqName.Sort();
                foreach (string uniq in uniqName) // 선택 폴더의 파일 목록을 스캔합니다.
                {
                    gridMergeImage.Rows.Add(uniq, "N");
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (gridMergeImage.CurrentRow == null)
                return;

            //선택한 병합이미지 리스트에서 확인을 했다는 의미의 Y로 변경
            gridMergeImage.CurrentRow.Cells[(int)eMergeImageGridIndex.CONFIRM].Value = "Y";
            saveFileMergeImageStatus();
        }

        public void readFileMergeImageStatus()
        {
            FileInfo fi = new FileInfo(tbxFolderPath.Text + "\\" + dtpDate.Value.ToString("yyyy.MM.dd") + "\\list.txt");

            if (fi.Exists == false)
                return;

            string id;
            System.IO.StreamReader file = fi.OpenText();
            while ((id = file.ReadLine()) != null)
            {
                if (id.Trim() == "")
                    continue;

                foreach (DataGridViewRow row in gridMergeImage.Rows)
                {
                    if (row.Cells[(int)eMergeImageGridIndex.ID].Value.ToString().Trim() == id)
                    {
                        row.Cells[(int)eMergeImageGridIndex.CONFIRM].Value = "Y";
                    }
                }
            }

            file.Close();
        }

        private void saveFileMergeImageStatus()
        {
            try
            {
                string path = tbxFolderPath.Text + "\\" + dtpDate.Value.ToString("yyyy.MM.dd") + "\\list.txt";
                string contents = "";

                File.WriteAllText(path, "");

                foreach (DataGridViewRow row in gridMergeImage.Rows)
                {
                    if (row.Cells[(int)eMergeImageGridIndex.CONFIRM].Value.ToString() == "Y")
                    {
                        contents += row.Cells[(int)eMergeImageGridIndex.ID].Value.ToString() + System.Environment.NewLine;
                    }
                }

                File.WriteAllText(path, contents.TrimEnd());
            }
            catch (Exception ex)
            {
                MessageBox.Show("저장하다 오류가 발생했습니다.");
            }
        }

        private void gridMergeImageRowChange(object sender, EventArgs e)
        {
            if (gridMergeImage.SelectedRows.Count > 0)
            {
                startPointX = 99999;
                startPointY = 99999;
                top = 0;
                left = 0;
                filterSlidesFullName.Clear();
                int rowindex = gridMergeImage.SelectedRows[0].Index;
                DataGridViewRow selectedRow = gridMergeImage.Rows[rowindex];
                string currentId = Convert.ToString(selectedRow.Cells[0].Value);

                Dictionary<string, int> tempSize = null;

                // 특정 ID에 해당 하는 타일 FullName 가져오기.
                foreach (string item in slidesFullName)
                {
                    if (item.Contains(currentId))
                    {
                        filterSlidesFullName.Add(item);

                        tempSize = parsingXY(item);

                        startPointX = startPointX > tempSize["pX"] ? tempSize["pX"] : startPointX;
                        startPointY = startPointY > tempSize["pY"] ? tempSize["pY"] : startPointY;
                    }
                }

                drawImage(filterSlidesFullName);

                drawThumbnailImage(filterSlidesFullName);


                //랜더링해야하는 이미지 리스트가 변화가 있는지 체크

                //List<string> newDrawnImage = new List<string>();


                //int movedLeft = Left1 - (DataPanel.Left - 3);
                //int movedTop = Top1 - (DataPanel.Top - 4);

                //foreach (string filename in filterSlidesFullName)
                //{
                //    Dictionary<string, int> location = parsingXY(filename);
                //    if (getIntersection(
                //        x1: (int)(location["pX"] * zoomScale), width1: (int)(splitWidth * zoomScale), y1: (int)(location["pY"] * zoomScale), height1: (int)(splitHeight * zoomScale), 
                //        x2: (int)(movedLeft * zoomScale), width2: DataPanel.Width, y2: (int)(movedTop * zoomScale),height2: DataPanel.Height) == true)
                //    {
                //        newDrawnImage.Add(filename);
                //    }
                //}
                //List<string> inter = drawnImage.Except(newDrawnImage).ToList();

                //if (drawnImage.Count == 0 || inter.Count > 0)
                //{
                //    drawCount++;
                //drawImage(filterSlidesFullName);
                //    System.Console.WriteLine("그림" + drawCount);
                //}

            }
        }

        public bool getIntersection(int x1, int width1, int y1, int height1, int x2, int width2, int y2, int height2)
        {
            if (x1 > x2 + width2) return false;
            if (x1 + width1 < x2) return false;
            if (y1 > y2 + height2) return false;
            if (y1 + height1 < y2) return false;
            return true;
        }


        public void drawImage(List<string> pathParams)
        {
            drawnImage.Clear();
            foreach (string filename in pathParams)
            {
                Dictionary<string, int> location = parsingXY(filename);

                if (getIntersection(x1: (int)(location["pX"] * zoomScale), width1: (int)(splitWidth * zoomScale), y1: (int)(location["pY"] * zoomScale),
                    height1: (int)(splitHeight * zoomScale), x2: (int)(Left1 * zoomScale), width2: DataPanel.Width, y2: (int)(Top1 * zoomScale),
                    height2: DataPanel.Height) == true)

                    drawnImage.Add(filename);
            }

            Dictionary<string, int> tempSize = null;
            Dictionary<string, int> imagePixels = null;

            string slideStyle;

            // 동일한 이미지에서  타일 Pixels size 같아서 한개 타일 Pixel size 구하면 됨.
            imagePixels = pixelsXY(pathParams[0]);

            // Whole Image 크기에 따라 canvas size 가변하게 설정.
            canvas = new Bitmap(DataPanel.Width, DataPanel.Height);
            g = System.Drawing.Graphics.FromImage(canvas);
            // 이미지 Merge 하여 그려주기.
            Stopwatch stopwatch = new Stopwatch(); //객체 선언
            stopwatch.Start(); // 시간측정 시작

            foreach (string filename in drawnImage)
            {

                slideStyle = new DirectoryInfo(filename).Parent.Name;  // slide 이미지 색상 주기 위한  N, A, D, M style 구하기.
                tempSize = parsingXY(filename);
                wholeX = tempSize["wholeX"];
                wholeY = tempSize["wholeY"];

                //System.Drawing.Image img = System.Drawing.Image.FromFile(filename);

                

                Bitmap img = new Bitmap(filename);

                //float w = (float)(imagePixels["width"] * 0.05);//border size，
                //Pen whitePen = new Pen(Color.White, w);
                //Pen greenPen = new Pen(Color.Green, w);
                //Pen bluePen = new Pen(Color.Blue, w);
                //Pen redPen = new Pen(Color.Red, w);

                g.DrawImage(img, (int)((tempSize["pX"] - Left1) * zoomScale), (int)((tempSize["pY"] - Top1) * zoomScale),
                    (int)(imagePixels["width"] * (zoomScale)), (int)(imagePixels["height"] * (zoomScale)));
                if (colorOnOff)
                {
                    switch (slideStyle)
                    {
                        case "N":
                            break;
                        case "A":
                            g.DrawImage(greenColor, (int)((tempSize["pX"] - Left1) * zoomScale), (int)((tempSize["pY"] - Top1) * zoomScale),
                               (int)(imagePixels["width"] * (zoomScale)), (int)(imagePixels["height"] * (zoomScale)));
                            break;
                        case "D":
                            g.DrawImage(blueColor, (int)((tempSize["pX"] - Left1) * zoomScale), (int)((tempSize["pY"] - Top1) * zoomScale),
                               (int)(imagePixels["width"] * (zoomScale)), (int)(imagePixels["height"] * (zoomScale)));
                            break;
                        case "M":
                            g.DrawImage(redColor, (int)((tempSize["pX"] - Left1) * zoomScale), (int)((tempSize["pY"] - Top1) * zoomScale),
                                (int)(imagePixels["width"] * (zoomScale)), (int)(imagePixels["height"] * (zoomScale)));
                            break;
                    }
                }
                

                // convert 방식이나 or Transparent red color image 시간 많이 소모.
                //for (int y = 0; y < imagePixels["height"]; y++)
                //{
                //    for (int x = 0; x < imagePixels["width"]; x++)
                //    {
                //        Color p = img.GetPixel(x, y);
                //        int a = p.A;
                //        int r = p.R;
                //        int g = p.G;
                //        int b = p.B;
                //        //img.SetPixel(x, y, Color.FromArgb(a, r, 0, 0));
                //        img.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));
                //        //img.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));
                //    }
                //}
                
            }

            stopwatch.Stop(); //시간측정 끝
            System.Console.WriteLine("time : " + stopwatch.ElapsedMilliseconds + "ms");

            if (DataPanel.Image != null)
                DataPanel.Image.Dispose();

            //DataPanel.Image = canvas.GetThumbnailImage(imagePixels["pixelX"] * (imageSize["maxX"] + 1), imagePixels["pixelY"] * (imageSize["maxY"] + 1), myCallback, IntPtr.Zero);
            //DataPanel.Image = canvas.GetThumbnailImage(wholeX, 20000, myCallback, IntPtr.Zero);
            DataPanel.Image = canvas as Image;
            //DataPanelSmar.Image = DataPanel.Image;
            imgOriginal = DataPanel.Image;

        }

        public void drawThumbnailImage(List<string> pathParams)
        {
            Dictionary<string, int> tempSize = null;
            Dictionary<string, int> imagePixels = null;

            string slideStyle;

            // 동일한 이미지에서  타일 Pixels size 같아서 한개 타일 Pixel size 구하면 됨.
            imagePixels = pixelsXY(pathParams[0]);

            // Whole Image 크기에 따라 canvas size 가변하게 설정.
            canvas = new Bitmap(ThumbnailImage.Width, ThumbnailImage.Height);
            g = System.Drawing.Graphics.FromImage(canvas);
            // 이미지 Merge 하여 그려주기.

            foreach (string filename in pathParams)
            {

                slideStyle = new DirectoryInfo(filename).Parent.Name;  // slide 이미지 색상 주기 위한  N, A, D, M style 구하기.
                tempSize = parsingXY(filename);
                wholeX = tempSize["wholeX"];
                wholeY = tempSize["wholeY"];

                Bitmap img = new Bitmap(filename);
                g.DrawImage(img, (int)((tempSize["pX"] - startPointX) * 0.01), (int)((tempSize["pY"] - startPointY) * 0.01),
                    (int)(imagePixels["width"] * (0.01)), (int)(imagePixels["height"] * (0.01)));
            }


            if (ThumbnailImage.Image != null)
                ThumbnailImage.Image.Dispose();

            ThumbnailImage.Image = canvas as Image;

        }

        // 전체 이미지 size  구하기 함수.
        public Dictionary<string, int> getMaxXY(List<string> pathParams)
        {
            Dictionary<string, int> imageSize = new Dictionary<string, int>();
            Dictionary<string, int> tempSize = new Dictionary<string, int>();
            int maxX = 0;
            int maxY = 0;
            int tempX;
            int tempY;
            Boolean firstCheck = true;

            foreach (string item in pathParams)
            {
                tempSize = parsingXY(item);
                tempY = tempSize["pY"];
                tempX = tempSize["pX"];
                if (maxX<= tempX)
                {
                    maxX = tempX;
                }
                if (maxY <= tempY)
                {
                    maxY = tempY;
                }
                if (firstCheck)
                {
                    maxX = tempX;
                    maxY = tempY;
                    firstCheck = false;
                }
                tempSize.Clear(); 
            }
            imageSize.Add("maxX", maxX);
            imageSize.Add("maxY", maxY);
            return imageSize;
        }

        // 이미지 좌표 파싱함수
        public Dictionary<string, int> parsingXY(string pathParams)
        {
            Dictionary<string, int> pXY = new Dictionary<string, int>();
            string itemName = pathParams;


            int wholeX = 0;
            int wholeY = 0;
            int pX = 0;
            int pY = 0;
            itemName = itemName.Split('\\').Last();
            itemName = itemName.Split('.')[0];
            wholeX = int.Parse(itemName.Split('-', '_')[2]);
            wholeY = int.Parse(itemName.Split('-', '_')[3]);
            pX = int.Parse(itemName.Split('-', '_')[4]);
            pY = int.Parse(itemName.Split('-', '_')[5]);

            pXY.Add("wholeX", wholeX);
            pXY.Add("wholeY", wholeY);
            pXY.Add("pX", pX);
            pXY.Add("pY", pY);
            return pXY;
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        // 이미지 get XY pixels 
        public Dictionary<string, int> pixelsXY(string pathParams)
        {
            Dictionary<string, int>  tempXY = new Dictionary<string, int>();
            Bitmap img = new Bitmap(pathParams);
            tempXY.Add("width", img.Width);
            tempXY.Add("height", img.Height);
            return tempXY;
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (colorOnOff)
            {
                colorOnOff = false;
                btnOnOff.Text = "Off";
            }
            else
            {
                colorOnOff = true;
                btnOnOff.Text = "On";
            }
            drawImage(filterSlidesFullName);
        }
    }
}
