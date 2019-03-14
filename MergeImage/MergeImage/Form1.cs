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


        public Form1()
        {
            InitializeComponent();

            tbxFolderPath.Text = Properties.Settings.Default.imagePath;

            getDateImageList();
            readFileMergeImageStatus();
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
                //최소 사이즈 설정
                if (DataPanel.Height >= 100 && DataPanel.Width >= 100)
                {
                    DataPanel.Width = DataPanel.Width - 50;
                    DataPanel.Height = DataPanel.Height - 50;
                }

                
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
                filterSlidesFullName.Clear();
                int rowindex = gridMergeImage.SelectedRows[0].Index;
                DataGridViewRow selectedRow = gridMergeImage.Rows[rowindex];
                string currentId = Convert.ToString(selectedRow.Cells[0].Value);

                // 특정 ID에 해당 하는 타일 FullName 가져오기.
                foreach (string item in slidesFullName)
                {
                    if (item.Contains(currentId))
                    {
                        filterSlidesFullName.Add(item);
                    }

                }
                drawImage(filterSlidesFullName);
            }
        }
        
        public void drawImage(List<string> pathParams){

            Dictionary<string, Int32> imageSize= new Dictionary<string, Int32>();
            Dictionary<string, Int32> tempSize = new Dictionary<string, Int32>();
            Dictionary<string, Int32> imagePixels= new Dictionary<string, Int32>();
            Int32 X;
            Int32 Y;
            string slideStyle;
            imageSize = getMaxXY(pathParams);


            // 동일한 이미지에서  타일 Pixels size 같아서 한개 타일 Pixel size 구하면 됨.
            imagePixels = pixelsXY(pathParams[0]);

            // Whole Image 크기에 따라 canvas size 가변하게 설정.
            Bitmap canvas = new Bitmap(imagePixels["pixelX"] * (imageSize["maxX"] +1), imagePixels["pixelY"] * (imageSize["maxY"] + 1));
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(canvas);

            // 이미지 Merge 하여 그려주기.
            foreach (string filename in pathParams)
            {
                slideStyle = new DirectoryInfo(filename).Parent.Name;  // slide 이미지 색상 주기 위한  N, A, D, M style 구하기.
                tempSize = parsingXY(filename);
                Y = tempSize["pY"];
                X = tempSize["pX"];
                //System.Drawing.Image img = System.Drawing.Image.FromFile(filename);
                Bitmap img = new Bitmap(filename);
                g.DrawImage(img, X* imagePixels["pixelX"], Y* imagePixels["pixelY"], imagePixels["pixelX"], imagePixels["pixelY"]);
            }
            Image.GetThumbnailImageAbort myCallback = new Image.GetThumbnailImageAbort(thumbnailCallback);
            if (DataPanel.Image != null)
                DataPanel.Image.Dispose();

            DataPanel.Image = canvas.GetThumbnailImage(imagePixels["pixelX"] * (imageSize["maxX"] + 1), imagePixels["pixelY"] * (imageSize["maxY"] + 1), myCallback, IntPtr.Zero);
            DataPanelSmar.Image = DataPanel.Image;
            imgOriginal = DataPanel.Image;
        }

        // 전체 이미지 size  구하기 함수.
        public Dictionary<string, Int32> getMaxXY(List<string> pathParams)
        {
            Dictionary<string, Int32> imageSize = new Dictionary<string, Int32>();
            Dictionary<string, Int32> tempSize = new Dictionary<string, Int32>();
            Int32 maxX = 0;
            Int32 maxY = 0;
            Int32 tempX;
            Int32 tempY;
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
        public Dictionary<string, Int32> parsingXY(string pathParams)
        {
            Dictionary<string, Int32> pXY = new Dictionary<string, Int32>();
            string itemName = pathParams;
            Int32 pX = 0;
            Int32 pY = 0;
            itemName = itemName.Split('\\').Last();
            itemName = itemName.Split('.')[0];
            pY = Convert.ToInt32(itemName.Split('_')[1]);
            pX = Convert.ToInt32(itemName.Split('_')[2]);
            pXY.Add("pX", pX);
            pXY.Add("pY", pY);
            return pXY;
        }

        // 이미지 get XY pixels 
        public Dictionary<string, Int32> pixelsXY(string pathParams)
        {
            Dictionary<string, Int32>  tempXY = new Dictionary<string, Int32>();
            Bitmap img = new Bitmap(pathParams);
            tempXY.Add("pixelX", img.Width);
            tempXY.Add("pixelY", img.Height);
            return tempXY;
        }


    }
}
