using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergeImage
{
    public partial class Form1 : Form
    {
        public enum eMergeImageGridIndex
        {
            ID,
            CONFIRM
        }

        public enum eZoomScale
        {
            NONE,
            ZOOM_IN,
            ZOOM_OUT
        }

        
        double zoomScale = 1;
        int startPointX = 99999;
        int startPointY = 99999;
        int top = 0;
        int left = 0;
        int splitWidth = 250;
        int splitHeight = 250;
        int wholeX;
        int wholeY;
        int preZoomScale = 0;
        float scales = 0;
        Image thumbOriginalimg = null;
        string tailsStatus = "";

        const int hiddenLeft = 500;
        const int hiddenTop = 500;

        bool moveThumbnail = false;

        ConcurrentDictionary<string, Bitmap> dicBitmap100 = new ConcurrentDictionary<string, Bitmap>();
        ConcurrentDictionary<string, Bitmap> dicBitmap50 = new ConcurrentDictionary<string, Bitmap>();
        ConcurrentDictionary<string, Bitmap> dicBitmap20 = new ConcurrentDictionary<string, Bitmap>();
        ConcurrentDictionary<string, Bitmap> dicBitmap10 = new ConcurrentDictionary<string, Bitmap>();
        ConcurrentDictionary<string, Bitmap> dicBitmap5 = new ConcurrentDictionary<string, Bitmap>();


        List<string> selectedCursor = new List<string>();

        List<string> drawnImage = new List<string>();
        List<string> tailsImagesLog = new List<string>();
        List<string> backTailsImagesLog = new List<string>();
        string pStyle="";
        Point slidePiont;
        List<Point> modifyPointList = new List<Point>();
        int modifyFirstX, modifyFirstY;


       

        Image imgOriginal;
        //-- FirstPoint use to move image
        private Point firstPoint = new Point();
        private Boolean isMove = false;
        private Boolean isModifyMove = false;
        private string[] wordsName;
        private List<string> uniqName = new List<string>();
        private List<string> slidesFullName = new List<string>();
        private List<string> filterSlidesFullName = new List<string>();
        private Dictionary<string, int> thumbImageSize = new Dictionary<string, int>();

        private Bitmap canvas;
        System.Drawing.Graphics g;
        private Boolean colorOnOff = true;
        private Boolean isFirst = true;
        private Boolean checkTailsLog = false;
        private Boolean firstLoadTailsLog = true;

        Dictionary<string, Bitmap> dicMask = new Dictionary<string, Bitmap>();

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
            getDateModifyImageList();
            loadMaskColor();
            drawnImage.Clear();
        }

        private void loadMaskColor()
        {
            Bitmap img = new Bitmap(Properties.Resources.blue100);
            dicMask.Add("blue100", img);

            img = new Bitmap(Properties.Resources.red100);
            dicMask.Add("red100", img);

            img = new Bitmap(Properties.Resources.green100);
            dicMask.Add("green100", img);

            img = new Bitmap(Properties.Resources.blue100);
            int width = (int)(img.Width * 0.5);
            int height = (int)(img.Height * 0.5);
            Size resize = new Size(width, height);
            Bitmap image50 = new Bitmap(img, resize);
            dicMask.Add("blue50", image50);

            img = new Bitmap(Properties.Resources.red100);
            width = (int)(img.Width * 0.5);
            height = (int)(img.Height * 0.5);
            resize = new Size(width, height);
            image50 = new Bitmap(img, resize);
            dicMask.Add("red50", image50);

            img = new Bitmap(Properties.Resources.green100);
            width = (int)(img.Width * 0.5);
            height = (int)(img.Height * 0.5);
            resize = new Size(width, height);
            image50 = new Bitmap(img, resize);
            dicMask.Add("green50", image50);

            img = new Bitmap(Properties.Resources.blue100);
            width = (int)(img.Width * 0.2);
            height = (int)(img.Height * 0.2);
            resize = new Size(width, height);
            Bitmap image20 = new Bitmap(img, resize);
            dicMask.Add("blue20", image20);

            img = new Bitmap(Properties.Resources.red100);
            width = (int)(img.Width * 0.2);
            height = (int)(img.Height * 0.2);
            resize = new Size(width, height);
            image20 = new Bitmap(img, resize);
            dicMask.Add("red20", image20);

            img = new Bitmap(Properties.Resources.green100);
            width = (int)(img.Width * 0.2);
            height = (int)(img.Height * 0.2);
            resize = new Size(width, height);
            image20 = new Bitmap(img, resize);
            dicMask.Add("green20", image20);

            img = new Bitmap(Properties.Resources.blue100);
            width = (int)(img.Width * 0.1);
            height = (int)(img.Height * 0.1);
            resize = new Size(width, height);
            Bitmap image10 = new Bitmap(img, resize);
            dicMask.Add("blue10", image10);

            img = new Bitmap(Properties.Resources.red100);
            width = (int)(img.Width * 0.1);
            height = (int)(img.Height * 0.1);
            resize = new Size(width, height);
            image10 = new Bitmap(img, resize);
            dicMask.Add("red10", image10);

            img = new Bitmap(Properties.Resources.green100);
            width = (int)(img.Width * 0.1);
            height = (int)(img.Height * 0.1);
            resize = new Size(width, height);
            image10 = new Bitmap(img, resize);
            dicMask.Add("green10", image10);

            img = new Bitmap(Properties.Resources.blue100);
            width = (int)(img.Width * 0.05);
            height = (int)(img.Height * 0.05);
            resize = new Size(width, height);
            Bitmap image5 = new Bitmap(img, resize);
            dicMask.Add("blue5", image5);

            img = new Bitmap(Properties.Resources.red100);
            width = (int)(img.Width * 0.05);
            height = (int)(img.Height * 0.05);
            resize = new Size(width, height);
            image5 = new Bitmap(img, resize);
            dicMask.Add("red5", image5);

            img = new Bitmap(Properties.Resources.green100);
            width = (int)(img.Width * 0.05);
            height = (int)(img.Height * 0.05);
            resize = new Size(width, height);
            image5 = new Bitmap(img, resize);
            dicMask.Add("green5", image5);
        }


        // 마우스 휠을 통한 이미지 확대 축소 함수 생성
        private void DataPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            this.ZoomController.ValueChanged -= new System.EventHandler(this.ZoomController_ValueChanged);
#if Surface
            if (e.Delta > 0)
#else
            if (e.Delta < 0)
#endif
            {
                //확대

                if (zoomScale == 0.5)
                {
                    ZoomController.Value = 0;
                    zoomScale = 1;
                    top += (int)((e.Y ) / zoomScale);
                    left += (int)((e.X ) / zoomScale);
                    preZoomScale = ZoomController.Value;
                    zoomScale = Math.Round(zoomScale * 100) / 100;
                    drawImage(filterSlidesFullName);
                }
                else if (zoomScale == 0.2)
                {
                    ZoomController.Value = 1;
                    zoomScale = 0.5;
                    top += (int)((e.Y ) / 0.33);
                    left += (int)((e.X ) / 0.33);
                    preZoomScale = ZoomController.Value;
                    zoomScale = Math.Round(zoomScale * 100) / 100;
                    drawImage(filterSlidesFullName);
                }
                else if (zoomScale == 0.1)
                {
                    ZoomController.Value = 2;
                    zoomScale = 0.2;
                    top += (int)((e.Y ) / zoomScale);
                    left += (int)((e.X ) / zoomScale);
                    preZoomScale = ZoomController.Value;
                    zoomScale = Math.Round(zoomScale * 100) / 100;
                    drawImage(filterSlidesFullName);
                }
                else if (zoomScale == 0.05)
                {
                    ZoomController.Value = 3;
                    zoomScale = 0.1;
                    top += (int)((e.Y ) / zoomScale);
                    left += (int)((e.X ) / zoomScale);
                    preZoomScale = ZoomController.Value;
                    zoomScale = Math.Round(zoomScale * 100) / 100;
                    drawImage(filterSlidesFullName);
                }
            }
            else
            {
                //축소
                if (zoomScale == 1)
                {
                    top -= (int)((e.Y) / zoomScale);
                    left -= (int)((e.X) / zoomScale);
                    zoomScale = 0.5;
                    ZoomController.Value = 1;
                    preZoomScale = ZoomController.Value;
                    zoomScale = Math.Round(zoomScale * 100) / 100;
                    drawImage(filterSlidesFullName);

                }
                else if (zoomScale == 0.5)
                {
                    top -= (int)((e.Y) / 0.33);
                    left -= (int)((e.X) / 0.33);
                    zoomScale = 0.2;
                    ZoomController.Value = 2;
                    preZoomScale = ZoomController.Value;
                    zoomScale = Math.Round(zoomScale * 100) / 100;
                    drawImage(filterSlidesFullName);

                }
                else if (zoomScale == 0.2)
                {
                    top -= (int)((e.Y) / zoomScale);
                    left -= (int)((e.X) / zoomScale);
                    zoomScale = 0.1;
                    ZoomController.Value = 3;
                    preZoomScale = ZoomController.Value;
                    zoomScale = Math.Round(zoomScale * 100) / 100;
                    drawImage(filterSlidesFullName);
                }
                else if (zoomScale == 0.1)
                {
                    top -= (int)((e.Y) / zoomScale);
                    left -= (int)((e.X) / zoomScale);
                    zoomScale = 0.05;
                    ZoomController.Value = 4;
                    preZoomScale = ZoomController.Value;
                    zoomScale = Math.Round(zoomScale * 100) / 100;
                    drawImage(filterSlidesFullName);
                }
               
            }
            this.ZoomController.ValueChanged += new System.EventHandler(this.ZoomController_ValueChanged);
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
                //readTailsImagesLog();
                getDateImageList();
                readFileMergeImageStatus();

            }
        }

        /**
        * 마우스를 이용한 이미지 Move 힘수
        *  - DataPanel :최도 마우스 Cursor 취치 확정.
        *  - DataPanel : 마우스 up하였을때 이미지 이동 하지 않음
        *  - DataPanel : 마우스 이동 거리에  계산
        **/
        private void DataPanel_MouseDown(object sender, MouseEventArgs e)
        {

#if Surface
            if (e.Button == MouseButtons.Left && btnMove.Text == "이동")
#else
            if (e.Button == MouseButtons.Left)
#endif
            {
                firstPoint.X = Cursor.Position.X;
                firstPoint.Y = Cursor.Position.Y;
                isMove = true;
                DataPanel.Focus();

                lbImagePosiont.Text = "left : " + Left1 + " top : " + Top1;

            }
#if Surface
            if (e.Button == MouseButtons.Left && btnMove.Text == "선택")
#else
            if (e.Button == MouseButtons.Right)
#endif
            {
                if (tailsStatus != "")
                {
                    isModifyMove = true;
                }
            }
        }

        private void DataPanel_MouseUp(object sender, MouseEventArgs e)
        {
            List<string> slectedImage = new List<string>();
            List<string> tempsSlide = new List<string>();
#if Surface
            if (e.Button == MouseButtons.Left && btnMove.Text =="이동")
#else
            if (e.Button == MouseButtons.Left)
#endif
            {
                left = left - (int)((DataPanel.Left + hiddenLeft) / zoomScale);
                top = top - (int)((DataPanel.Top + hiddenTop) / zoomScale);
                drawImage(filterSlidesFullName);
                DataPanel.Left = -hiddenLeft;
                DataPanel.Top = -hiddenTop;
                isMove = false;
            }
#if Surface
            if (e.Button == MouseButtons.Left && btnMove.Text == "선택")
#else
            if (e.Button == MouseButtons.Right)
#endif
            {
                if (tailsStatus != "")
                {
                    slidePiont = new Point((int)(e.X / zoomScale + Left1), (int)(e.Y / zoomScale + Top1));
                    modifyPointList.Add(slidePiont);

                    foreach (Point iPoint in modifyPointList)
                    {
                        tempsSlide = pointSlides(iPoint);
                        slectedImage.AddRange(tempsSlide);
                    }
                     
                    slectedImage =  slectedImage.Distinct().ToList();

                    saveSelectedTailsImages(slectedImage);
#if Surface
#else
                    tailsStatus = "";
#endif
                    addModifyImageListToDataGridView1();
                    drawImage(filterSlidesFullName);
                    modifyPointList.Clear();
                }

            }
        }

        private void DataPanel_MouseMove(object sender, MouseEventArgs e)
        {
            DataPanel.Focus();
            Boolean modifyFirst = true;
            if (isMove)
            {
                int moveX, moveY;
                moveX = Cursor.Position.X - firstPoint.X;
                moveY = Cursor.Position.Y - firstPoint.Y;
                DataPanel.Location = new Point(DataPanel.Location.X + moveX, DataPanel.Location.Y + moveY);
                firstPoint.X = Cursor.Position.X;
                firstPoint.Y = Cursor.Position.Y;

                lbImagePosiont.Text = "left : " + left + " top : " + top + " moveX : " + (Cursor.Position.X - firstPoint.X) + "moveY : " + (Cursor.Position.Y - firstPoint.Y);

            }
#if Surface
            else if (e.Button == MouseButtons.Left && isModifyMove && tailsStatus != "")
#else

            else if(e.Button == MouseButtons.Right && isModifyMove && tailsStatus != "")
#endif
            {
                if (modifyFirst)
                {
                    modifyFirstX = e.X;
                    modifyFirstY = e.Y;
                    modifyFirst = false;
                    slidePiont = new Point((int)(e.X / zoomScale + Left1), (int)(e.Y / zoomScale + Top1));
                    modifyPointList.Add(slidePiont);
                }
                if(modifyFirstX != Cursor.Position.X || modifyFirstY != Cursor.Position.Y)
                {
                    modifyFirstX = Cursor.Position.X;
                    modifyFirstY = Cursor.Position.Y;
                    slidePiont = new Point((int)(e.X / zoomScale + Left1), (int)(e.Y / zoomScale + Top1));
                    modifyPointList.Add(slidePiont);
                }
            }
            else
            {
                if (btnCursor.Text == "Cursor on")
                    drawCursor(e.X, e.Y);
            }



        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DataPanel.Image != null)
            {
                DataPanel.Dispose();
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            //readTailsImagesLog();
            //이미지 리스트 다시 불러오기
            dataGridView1.Rows.Clear();
            getDateImageList();
            readFileMergeImageStatus();

        }

        public void getDateImageList()
        {
            gridMergeImage.Rows.Clear();
            slidesFullName.Clear();
            filterSlidesFullName.Clear();
            uniqName.Clear();

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
                                wordsName = fullName.Split('_');   // 타일 Name Parsing
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
                foreach (Bitmap bitmap in dicBitmap100.Values)
                    bitmap.Dispose();

                foreach (Bitmap bitmap in dicBitmap50.Values)
                    bitmap.Dispose();

                foreach (Bitmap bitmap in dicBitmap20.Values)
                    bitmap.Dispose();

                foreach (Bitmap bitmap in dicBitmap10.Values)
                    bitmap.Dispose();

                foreach (Bitmap bitmap in dicBitmap5.Values)
                    bitmap.Dispose();

                dicBitmap100.Clear();
                dicBitmap50.Clear();
                dicBitmap20.Clear();
                dicBitmap10.Clear();
                dicBitmap5.Clear();
                isFirst = true;
                thumbImageSize.Clear();
                zoomScale = 1;
                startPointX = 99999;
                startPointY = 99999;
                top = 0;
                left = 0;
                filterSlidesFullName.Clear();
                int rowindex = gridMergeImage.SelectedRows[0].Index;
                DataGridViewRow selectedRow = gridMergeImage.Rows[rowindex];
                string currentId = Convert.ToString(selectedRow.Cells[0].Value);

                Dictionary<string, int> tempSize = null;

                Stopwatch stopwatch = new Stopwatch(); //객체 선언
                stopwatch.Start(); // 시간측정 시작
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

                Parallel.ForEach(filterSlidesFullName, (item) =>
                //foreach (string item in slidesFullName)
                {
                        Bitmap img = new Bitmap(item);
                        dicBitmap100.TryAdd(item, img);

                        int width = (int)(img.Width * 0.5);
                        int height = (int)(img.Height * 0.5);
                        Size resize = new Size(width, height);
                        Bitmap image50 = new Bitmap(img, resize);
                        dicBitmap50.TryAdd(item, image50);

                        width = (int)(img.Width * 0.2);
                        height = (int)(img.Height * 0.2);
                        resize = new Size(width, height);
                        Bitmap image20 = new Bitmap(img, resize);
                        dicBitmap20.TryAdd(item, image20);

                        width = (int)(img.Width * 0.1);
                        height = (int)(img.Height * 0.1);
                        resize = new Size(width, height);
                        Bitmap image10 = new Bitmap(img, resize);
                        dicBitmap10.TryAdd(item, image10);

                        width = (int)(img.Width * 0.05);
                        height = (int)(img.Height * 0.05);
                        resize = new Size(width, height);
                        Bitmap image5 = new Bitmap(img, resize);
                        dicBitmap5.TryAdd(item, image5);
                }
                );

               
                stopwatch.Stop(); //시간측정 끝
                System.Console.WriteLine("total time : " + stopwatch.ElapsedMilliseconds + "ms");

                getDateModifyImageList();
                addModifyImageListToDataGridView1();
                drawImage(filterSlidesFullName);
                drawThumbnailImage(filterSlidesFullName);
                drawThumbnailImageViewborder();
                
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
            Stopwatch stopwatch = new Stopwatch(); //객체 선언
            stopwatch.Start(); // 시간측정 시작
            Dictionary<string, int> tempSize = null;
            Dictionary<string, int> imagePixels = null;
            //readTailsImagesLog();
            if (pathParams.Count == 0)
                return;

            drawnImage.Clear();
            //getDateModifyImageList(); // get modify Image Lisge

            foreach (string filename in pathParams)
            {
                Dictionary<string, int> location = parsingXY(filename);

                if (getIntersection(x1: (int)(location["pX"] * zoomScale), width1: (int)(splitWidth * zoomScale), y1: (int)(location["pY"] * zoomScale),
                    height1: (int)(splitHeight * zoomScale), x2: (int)(Left1 * zoomScale), width2: DataPanel.Width, y2: (int)(Top1 * zoomScale),
                    height2: DataPanel.Height) == true)
                    drawnImage.Add(filename);

            }

            if (isFirst)
            {
                thumbImageSize = getMinMaxXY(pathParams);
                isFirst = false;
            }

            // 동일한 이미지에서  타일 Pixels size 같아서 한개 타일 Pixel size 구하면 됨.
            imagePixels = pixelsXY(pathParams[0]);

            if (canvas != null)
                canvas.Dispose();


            // Whole Image 크기에 따라 canvas size 가변하게 설정.
            canvas = new Bitmap(DataPanel.Width, DataPanel.Height);
            g = System.Drawing.Graphics.FromImage(canvas);

            foreach (string filename in drawnImage)
            {
                string slideStyle = new DirectoryInfo(filename).Parent.Name;  // slide 이미지 색상 주기 위한  N, A, D, M style 구하기.

                foreach (string item in tailsImagesLog)
                {
                    if (item.Contains(filename.Split('\\').Last()))
                    {
                        slideStyle = new DirectoryInfo(item).Parent.Name;  // modify slide 이미지 색상 주기 위한  N, A, D, M style 구하기.
                        break;
                    }
                }

                tempSize = parsingXY(filename);
                Bitmap img = getSplitImage(filename);

                if (img == null)
                    continue;

                g.DrawImage(img, (int)((tempSize["pX"] - Left1) * zoomScale), (int)((tempSize["pY"] - Top1) * zoomScale), img.Width, img.Height);

                //분할이미지에 NADM으로 색칠하기.
                setMaskNADM(slideStyle, tempSize, imagePixels);
            }

           

            if (DataPanel.Image != null)
                DataPanel.Image.Dispose();

            DataPanel.Image = canvas as Image;
            imgOriginal = DataPanel.Image.Clone() as Image;
            if (ThumbnailImage.Image != null)
            {
                drawThumbnailImageViewborder();
            }

            g.Dispose();

            stopwatch.Stop(); //시간측정 끝
            System.Console.WriteLine("total time : " + stopwatch.ElapsedMilliseconds + "ms");

        }
        public void drawCursor(int x, int y)
        {
            Point slidePiont = new Point((int)(x / zoomScale + Left1), (int)(y / zoomScale + Top1));
            List<string> slectedImage = pointSlides(slidePiont);

            if (slectedImage.Except(selectedCursor).ToList().Count == 0 && selectedCursor.Except(slectedImage).ToList().Count == 0)
                return;

            selectedCursor = slectedImage;

            if (DataPanel.Image == null)
                return;
            Bitmap canvas = new Bitmap(imgOriginal.Clone() as Bitmap);
            g = System.Drawing.Graphics.FromImage(canvas);

            foreach (string filename in slectedImage)
            {
                Dictionary<string, int> tempSize = parsingXY(filename);
                Bitmap img = getSplitImage(filename);

                if (img == null)
                    continue;

                Rectangle rect = new Rectangle((int)((tempSize["pX"] - Left1) * zoomScale), (int)((tempSize["pY"] - Top1) * zoomScale), img.Width, img.Height);
                Pen RedPen = new Pen(Color.AntiqueWhite, 3);
                g.DrawRectangle(RedPen, rect);
                RedPen.Dispose();

            }

            if (DataPanel.Image != null)
                DataPanel.Image.Dispose();

            DataPanel.Image = canvas;
            g.Dispose();
        }

        public Bitmap getSplitImage(string filename)
        {
            if (zoomScale == 1)
            {
                return dicBitmap100[filename];
            }
            else if (zoomScale == 0.5)
            {
                return dicBitmap50[filename];
            }
            else if (zoomScale == 0.2)
            {
                return dicBitmap20[filename];
            }
            else if (zoomScale == 0.1)
            {
                return dicBitmap10[filename];
            }
            else if (zoomScale == 0.05)
            {
                return dicBitmap5[filename];
            }

            return null;
        }

        public void setMaskNADM(string slideStyle, Dictionary<string, int> tempSize, Dictionary<string, int> imagePixels)
        {
            Bitmap mask = null;
            if (colorOnOff)
            {
                switch (slideStyle)
                {
                    case "N":
                        break;
                    case "A":
                        mask = getMaskImage("green");
                        break;
                    case "D":
                        mask = getMaskImage("blue");
                        break;
                    case "M":
                        mask = getMaskImage("red");
                        break;
                }

                if (mask == null)
                    return;

                g.DrawImage(mask, (int)((tempSize["pX"] - Left1) * zoomScale), (int)((tempSize["pY"] - Top1) * zoomScale),
                   mask.Width, mask.Height);
            }
        }
        public Bitmap getMaskImage(string color)
        {
            return dicMask.ContainsKey(color + (zoomScale * 100)) ? dicMask[color + (zoomScale * 100)] : null;
        }

        public void drawThumbnailImage(List<string> pathParams)
        {
            Dictionary<string, int> tempSize = null;
            Dictionary<string, int> imagePixels = null;

            string slideStyle;

            // 동일한 이미지에서  타일 Pixels size 같아서 한개 타일 Pixel size 구하면 됨.
            imagePixels = pixelsXY(pathParams[0]);

            Bitmap canvas = new Bitmap(ThumbnailImage.Width, ThumbnailImage.Height);
            g = System.Drawing.Graphics.FromImage(canvas);
            // 이미지 Merge 하여 그려주기.
            float scalesX = (float)(ThumbnailImage.Width) / (thumbImageSize["maxX"] - thumbImageSize["minX"]);
            float scalesY = (float)(ThumbnailImage.Height) / (thumbImageSize["maxY"] - thumbImageSize["minY"]);

            if (scalesX <= scalesY)
            {
                scales = scalesX;
            }
            else
            {
                scales = scalesY;

            }
            foreach (string filename in pathParams)
            {

                slideStyle = new DirectoryInfo(filename).Parent.Name;  // slide 이미지 색상 주기 위한  N, A, D, M style 구하기.
                tempSize = parsingXY(filename);
                wholeX = tempSize["wholeX"];
                wholeY = tempSize["wholeY"];
                Bitmap img = dicBitmap100[filename];
                g.DrawImage(img, (int)((tempSize["pX"] - startPointX) * scales), (int)((tempSize["pY"] - startPointY) * scales),
                    (int)(imagePixels["width"] * (scales)), (int)(imagePixels["height"] * (scales)));
            }


            if (ThumbnailImage.Image != null)
                ThumbnailImage.Image.Dispose();

            ThumbnailImage.Image = canvas as Image;
            thumbOriginalimg = canvas.Clone() as Image;
            g.Dispose();

        }

        // max size  구하기 함수.
        public Dictionary<string, int> getMinMaxXY(List<string> pathParams)
        {
            Dictionary<string, int> tempSize = new Dictionary<string, int>();
            Dictionary<string, int> tempImageSize = new Dictionary<string, int>();
            int maxX = 0;
            int maxY = 0;
            int minX = 0;
            int minY = 0;

            int tempX;
            int tempY;
            Boolean firstCheck = true;

            foreach (string item in pathParams)
            {
                tempSize = parsingXY(item);
                tempY = tempSize["pY"];
                tempX = tempSize["pX"];
                if (maxX <= tempX)
                {
                    maxX = tempX;
                }
                else if (maxY <= tempY)
                {
                    maxY = tempY;
                }
                if (minX >= tempX)
                {
                    minX = tempX;
                }
                else if (minY >= tempY)
                {
                    minY = tempY;
                }
                if (firstCheck)
                {
                    maxX = tempX;
                    maxY = tempY;
                    minX = tempX;
                    minY = tempY;
                    firstCheck = false;
                }
                tempSize.Clear();
            }
            tempImageSize.Add("maxX", maxX + splitWidth);
            tempImageSize.Add("maxY", maxY + splitHeight);
            tempImageSize.Add("minX", minX);
            tempImageSize.Add("minY", minY);
            return tempImageSize;
        }

        // 이미지 좌표 파싱함수
        public Dictionary<string, int> parsingXY(string pathParams)
        {
            Dictionary<string, int> pXY = new Dictionary<string, int>();
            string itemName = "";
            itemName = pathParams;

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
            Dictionary<string, int> tempXY = new Dictionary<string, int>();
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

        public void drawThumbnailImageViewborder()
        {
            Bitmap tempBitmap = new Bitmap(thumbOriginalimg);
            Graphics g = Graphics.FromImage(tempBitmap);
            //float w = (float)(wholeX * 0.5);//border size，
            Pen RedPen = new Pen(Color.Red, 2);
            int xFloat = (int)((left + hiddenLeft / zoomScale) * scales);//border size，
            int yFloat = (int)((top + hiddenTop / zoomScale) * scales);//border size，

            int xmFloat = 0;
            int ymFloat = 0;
            if (xFloat < 0)
            {
                xmFloat = (int)((DataPanel.Width - hiddenLeft * 2) / zoomScale * scales) + xFloat;//border size，
                xFloat = 0;
            }
            else if (xFloat > ThumbnailImage.Width)
            {
                xmFloat = ThumbnailImage.Width;
                xFloat = ThumbnailImage.Width - 1;
            }
            else
            {
                xmFloat = (int)((DataPanel.Width - hiddenLeft * 2) / zoomScale * scales);//border size，
            }

            if (yFloat < 0)
            {
                ymFloat = (int)((DataPanel.Height - hiddenTop * 2) / zoomScale * scales) + yFloat;//border size，
                yFloat = 0;
            }
            else if (yFloat > ThumbnailImage.Height)
            {
                ymFloat = ThumbnailImage.Height;
                yFloat = ThumbnailImage.Height - 1;
            }
            else
            {
                ymFloat = (int)((DataPanel.Height - hiddenTop * 2) / zoomScale * scales);//border size，
            }

            if (xmFloat < 0)
            {
                xmFloat = 1;
            }
            else if (xmFloat + xFloat > ThumbnailImage.Width)
            {
                xmFloat = ThumbnailImage.Width - xFloat;
            }

            if (ymFloat < 0)
            {
                ymFloat = 1;
            }
            else if (ymFloat + yFloat > ThumbnailImage.Height)
            {
                ymFloat = ThumbnailImage.Height - yFloat;
            }

            g.DrawRectangle(RedPen, new Rectangle(xFloat, yFloat, xmFloat, ymFloat));//border추가
            //g.DrawRectangle(RedPen, new Rectangle(0, 0, 10, 10));//border추가


            if (ThumbnailImage.Image != null)
                ThumbnailImage.Image.Dispose();

            ThumbnailImage.InitialImage = null;
            ThumbnailImage.Image = tempBitmap;
            ThumbnailImage.Refresh();


            RedPen.Dispose();
            g.Dispose();
        }

        private void ZoomController_ValueChanged(object sender, EventArgs e)
        {

            //축소
            if (preZoomScale < ZoomController.Value)
            {
                for (int i = preZoomScale; i < ZoomController.Value; i++)
                {
                    if (i == 0)
                    {
                        top -= (int)((DataPanel.Height / 2) / zoomScale);
                        left -= (int)((DataPanel.Width / 2) / zoomScale);
                        zoomScale = 0.5;

                    }
                    else if (i == 1)
                    {
                        top -= (int)((DataPanel.Height / 2) / 0.33);
                        left -= (int)((DataPanel.Width / 2) / 0.33);
                        zoomScale = 0.2;

                    }
                    else if (i == 2)
                    {
                        top -= (int)((DataPanel.Height / 2) / zoomScale);
                        left -= (int)((DataPanel.Width / 2) / zoomScale);
                        zoomScale = 0.1;

                    }
                    else if (i == 3)
                    {
                        top -= (int)((DataPanel.Height / 2) / zoomScale);
                        left -= (int)((DataPanel.Width / 2) / zoomScale);
                        zoomScale = 0.05;

                    }
                }
                preZoomScale = ZoomController.Value;
                zoomScale = Math.Round(zoomScale * 100) / 100;
                drawImage(filterSlidesFullName);
            }
            //확대
            else if (preZoomScale > ZoomController.Value)
            {
                for (int i = preZoomScale; i > ZoomController.Value; i--)
                {
                    if (i == 1)
                    {
                        zoomScale = 1;
                        top += (int)((DataPanel.Height / 2) / zoomScale);
                        left += (int)((DataPanel.Width / 2) / zoomScale);
                    }
                    else if (i == 2)
                    {
                        zoomScale = 0.5;
                        top += (int)((DataPanel.Height / 2) / 0.33);
                        left += (int)((DataPanel.Width / 2) / 0.33);
                    }
                    else if (i == 3)
                    {
                        zoomScale = 0.2;
                        top += (int)((DataPanel.Height / 2) / zoomScale);
                        left += (int)((DataPanel.Width / 2) / zoomScale);

                    }
                    else if (i == 4)
                    {
                        zoomScale = 0.1;
                        top += (int)((DataPanel.Height / 2) / zoomScale);
                        left += (int)((DataPanel.Width / 2) / zoomScale);

                    }
                }
                preZoomScale = ZoomController.Value;
                zoomScale = Math.Round(zoomScale * 100) / 100;
                drawImage(filterSlidesFullName);
            }
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            tailsStatus = "N";

#if Surface
            btnMove.Text = "선택";
#endif
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            tailsStatus = "A";
#if Surface
            btnMove.Text = "선택";
#endif
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            tailsStatus = "D";
#if Surface
            btnMove.Text = "선택";
#endif
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            tailsStatus = "M";
#if Surface
            btnMove.Text = "선택";
#endif
        }

        // 이미지 Click Position tails 가져오기함수
        public List<string> pointSlides(Point pParam)
        {
            List<string> slectedImage = new List<string>();
            Dictionary<string, int> tempSize = null;
            string seletedStyle;

            foreach (string filename in drawnImage)
            {
                seletedStyle = new DirectoryInfo(filename).Parent.Name;  // slide 이미지 색상 주기 위한  N, A, D, M style 구하기.
                tempSize = parsingXY(filename);
                if (pParam.X >= tempSize["pX"] && pParam.Y >= tempSize["pY"] && pParam.X <= tempSize["pX"] + splitWidth && pParam.Y <= tempSize["pY"] + splitHeight)
                {
                    slectedImage.Add(filename);
                }
            }
            return slectedImage;
        }

        //
        private void saveSelectedTailsImages(List<string> pTails)
        {
            try
            {
                string basePath = tbxFolderPath.Text + "\\" + dtpDate.Value.ToString("yyyy.MM.dd") + "\\modify";
                string path;
                string destImage;
                backTailsImagesLog.Clear();

                foreach (string item in pTails)
                {
                    string preStatus = new DirectoryInfo(item).Parent.Name;
                    path = basePath + "\\" + tailsStatus;
                    if (!System.IO.Directory.Exists(path))
                    {
                        System.IO.Directory.CreateDirectory(path);
                    }
                    CheckLog(item);

                    if (preStatus == tailsStatus)
                        continue;

                    destImage = System.IO.Path.Combine(path, item.Split('\\').Last());
                    backTailsImagesLog.Add(destImage);
                    System.IO.File.Copy(item, destImage, true);
                }

                getDateModifyImageList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("저장하다 오류가 발생했습니다.");
            }
        }

        public void CheckLog(string pTail)
        {
            for (int i = 0; i < tailsImagesLog.Count; i++)
            {
                if (tailsImagesLog[i].Contains(pTail.Split('\\').Last()))
                {
                    deleteTailsImages(tailsImagesLog[i]);
                }
            }

        }

        /// <summary>
        /// 2019.03.24
        /// 동일 tails 중복 작업시 ID 이미지를 삭제.
        /// </summary>
        /// <param name="item">삭제할 파일</param>


        private void deleteTailsImages(string item)
        {
            try
            {
                if (System.IO.File.Exists(item))
                {
                    try
                    {
                        System.IO.File.Delete(item);
                    }
                    catch (System.IO.IOException e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("삭제하다 오류가 발생했습니다.");
            }
        }

        /// <summary>
        /// 2019.03.24
        /// Modify 이미지 List 가져오기.
        /// </summary>
        public void getDateModifyImageList()
        {
            //dataGridView1.Rows.Clear();
            tailsImagesLog.Clear();

            // Directory 아래 모든 하위 Direct를 검색하여 파일 이름 가져오기.
            string path = tbxFolderPath.Text + "\\" + dtpDate.Value.ToString("yyyy.MM.dd") + "\\modify";
            DirectoryInfo dirPath = new DirectoryInfo(@path);
            if (dirPath.Exists == true)
            {
                DirectoryInfo[] dirs = dirPath.GetDirectories();

                foreach (DirectoryInfo dir in dirs) // 하위 폴더목록을 스캔합니다.
                {
                    //폴더명이 N,A,D,M일때만 탐색
                    if (dir.Name == "N" || dir.Name == "A" || dir.Name == "D" || dir.Name == "M")
                    {
                        foreach (FileInfo File in dir.GetFiles()) // 선택 폴더의 파일 목록을 스캔합니다.
                        {
                            if (File.Name.Contains("_") == true)
                            {
                                tailsImagesLog.Add(File.FullName);              // 타일 Name(Image Name)
                            }
                        }
                    }
                }
            }
            
        }
        public void addModifyImageListToDataGridView1()
        {
            this.dataGridView1.SelectionChanged -= new System.EventHandler(this.dataGridView1_SelectionChanged);
            Stopwatch stopwatch2 = new Stopwatch(); //객체 선언
            stopwatch2.Start(); // 시간측정 시작
            
            dataGridView1.Rows.Clear();
            int rowindex = gridMergeImage.SelectedRows[0].Index;
            DataGridViewRow selectedRow = gridMergeImage.Rows[rowindex];
            string currentId = Convert.ToString(selectedRow.Cells[0].Value);
            Dictionary<string, int> location;
            string modifySlideStyle;

            foreach (string item in tailsImagesLog)
            {
                if (!item.Contains(currentId))
                    continue;
                location = parsingXY(item);
                modifySlideStyle = new DirectoryInfo(item).Parent.Name;  // slide 이미지 색상 주기 위한  N, A, D, M style 구하기.

                foreach (string line in filterSlidesFullName)
                {
                    if (line.Contains(item.Split('\\').Last()))
                    {
                        pStyle = new DirectoryInfo(line).Parent.Name;
                    }  
                }
                if(pStyle== modifySlideStyle)
                {
                    continue;
                }
                dataGridView1.Rows.Add(location["pX"], location["pY"], pStyle, modifySlideStyle);
            }

            stopwatch2.Stop();
            System.Console.WriteLine("addModifyImageListToDataGridView1 time : " + stopwatch2.ElapsedMilliseconds + "ms");
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            left = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()) - (int)(hiddenLeft / zoomScale) - startPointX;
            top = Int32.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()) - (int)(hiddenTop / zoomScale) - startPointY;
            drawImage(filterSlidesFullName);
        }


        private void ThumbnailImage_MouseDown(object sender, MouseEventArgs e)
        {
            moveThumbnail = true;
        }

        private void ThumbnailImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveThumbnail == true)
            {
                int xFloat = (int)(e.Location.X / scales) - (int)((DataPanel.Width / 2) / zoomScale);
                int yFloat = (int)(e.Location.Y / scales) - (int)((DataPanel.Height / 2) / zoomScale);
                left = xFloat;
                top = yFloat;
                drawImage(filterSlidesFullName);
            }
        }

        private void ThumbnailImage_MouseUp(object sender, MouseEventArgs e)
        {
            moveThumbnail = false;

            int xFloat = (int)(e.Location.X / scales) - (int)((DataPanel.Width / 2) / zoomScale);
            int yFloat = (int)(e.Location.Y / scales) - (int)((DataPanel.Height / 2) / zoomScale);
            left = xFloat;
            top = yFloat;
            drawImage(filterSlidesFullName);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            foreach (string item in backTailsImagesLog)
            {
                deleteTailsImages(item);
                
            }
            
            getDateModifyImageList();
            addModifyImageListToDataGridView1();
            drawImage(filterSlidesFullName);
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
#if Surface
            if (btnMove.Text == "이동")
            {
                btnMove.Text = "선택";
                tailsStatus = "";
            }
            else
            {
                btnMove.Text = "이동";
                tailsStatus = "";
            }
#endif
        }

        private void btnCursor_Click(object sender, EventArgs e)
        {
            if (btnCursor.Text == "Cursor on")
            {
                btnCursor.Text = "Cursor off";
                drawImage(filterSlidesFullName);
            }
            else
            {
                btnCursor.Text = "Cursor on";
            }
        }
    }
}
