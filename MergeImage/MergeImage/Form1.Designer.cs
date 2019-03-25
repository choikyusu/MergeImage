namespace MergeImage
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
<<<<<<< HEAD
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
=======
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
>>>>>>> cac304c6d1a3851d1402618e93bd637d2917b1a6
            this.ThumbnailImage = new System.Windows.Forms.PictureBox();
            this.tbxFolderPath = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChangeFolder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbImagePosiont = new System.Windows.Forms.Label();
            this.btnM = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.gridMergeImage = new System.Windows.Forms.DataGridView();
            this.DataPanel = new System.Windows.Forms.PictureBox();
            this.imagePath = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.ZoomController = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMergeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPanel)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomController)).BeginInit();
            this.SuspendLayout();
            // 
            // ThumbnailImage
            // 
            this.ThumbnailImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ThumbnailImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThumbnailImage.Location = new System.Drawing.Point(1935, 912);
            this.ThumbnailImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ThumbnailImage.Name = "ThumbnailImage";
            this.ThumbnailImage.Size = new System.Drawing.Size(212, 273);
            this.ThumbnailImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ThumbnailImage.TabIndex = 213;
            this.ThumbnailImage.TabStop = false;
            //this.ThumbnailImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ThumbnailImage_MouseClick);
            this.ThumbnailImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThumbnailImage_MouseDown);
            this.ThumbnailImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThumbnailImage_MouseMove);
            this.ThumbnailImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThumbnailImage_MouseUp);
            // 
            // tbxFolderPath
            // 
            this.tbxFolderPath.Location = new System.Drawing.Point(1750, 8);
            this.tbxFolderPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxFolderPath.Name = "tbxFolderPath";
            this.tbxFolderPath.ReadOnly = true;
            this.tbxFolderPath.Size = new System.Drawing.Size(292, 25);
            this.tbxFolderPath.TabIndex = 211;
            this.tbxFolderPath.Text = "이미지 경로";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.Location = new System.Drawing.Point(2049, 224);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(90, 29);
            this.btnConfirm.TabIndex = 210;
            this.btnConfirm.Text = "확인";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(2049, 188);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 29);
            this.btnBack.TabIndex = 209;
            this.btnBack.Text = "실행취소";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "이후";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "이전";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Y";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 30;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "X";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 30;
            // 
            // btnChangeFolder
            // 
            this.btnChangeFolder.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnChangeFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeFolder.Location = new System.Drawing.Point(2049, 8);
            this.btnChangeFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangeFolder.Name = "btnChangeFolder";
            this.btnChangeFolder.Size = new System.Drawing.Size(90, 29);
            this.btnChangeFolder.TabIndex = 212;
            this.btnChangeFolder.Text = "폴더변경";
            this.btnChangeFolder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChangeFolder.UseVisualStyleBackColor = true;
            this.btnChangeFolder.Click += new System.EventHandler(this.btnFold_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
<<<<<<< HEAD
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
=======
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
>>>>>>> cac304c6d1a3851d1402618e93bd637d2917b1a6
            this.dataGridView1.ColumnHeadersHeight = 20;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.dataGridViewTextBoxColumn1,
            this.Column1});
<<<<<<< HEAD
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle26;
=======
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
>>>>>>> cac304c6d1a3851d1402618e93bd637d2917b1a6
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(147, 56);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
<<<<<<< HEAD
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
=======
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
>>>>>>> cac304c6d1a3851d1402618e93bd637d2917b1a6
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 20;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(186, 1130);
            this.dataGridView1.TabIndex = 208;
            // 
            // lbImagePosiont
            // 
            this.lbImagePosiont.AutoSize = true;
            this.lbImagePosiont.Location = new System.Drawing.Point(127, 16);
            this.lbImagePosiont.Name = "lbImagePosiont";
            this.lbImagePosiont.Size = new System.Drawing.Size(259, 15);
            this.lbImagePosiont.TabIndex = 207;
            this.lbImagePosiont.Text = "이미지 번호 X, Y 를 선택했습니다.....";
            // 
            // btnM
            // 
            this.btnM.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnM.ForeColor = System.Drawing.Color.Red;
            this.btnM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnM.Location = new System.Drawing.Point(2049, 151);
            this.btnM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(90, 29);
            this.btnM.TabIndex = 205;
            this.btnM.Text = "M";
            this.btnM.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnD.ForeColor = System.Drawing.Color.Blue;
            this.btnD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnD.Location = new System.Drawing.Point(2049, 115);
            this.btnD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(90, 29);
            this.btnD.TabIndex = 204;
            this.btnD.Text = "D";
            this.btnD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnA.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnA.Location = new System.Drawing.Point(2049, 79);
            this.btnA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(90, 29);
            this.btnA.TabIndex = 203;
            this.btnA.Text = "A";
            this.btnA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnN
            // 
            this.btnN.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnN.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnN.Location = new System.Drawing.Point(2049, 42);
            this.btnN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(90, 29);
            this.btnN.TabIndex = 202;
            this.btnN.Text = "N";
            this.btnN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "확인";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 30;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 80;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(9, 9);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(110, 25);
            this.dtpDate.TabIndex = 206;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // gridMergeImage
            // 
            this.gridMergeImage.AllowUserToAddRows = false;
            this.gridMergeImage.AllowUserToDeleteRows = false;
            this.gridMergeImage.AllowUserToResizeRows = false;
            this.gridMergeImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridMergeImage.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.gridMergeImage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
<<<<<<< HEAD
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.gridMergeImage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
=======
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.gridMergeImage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
>>>>>>> cac304c6d1a3851d1402618e93bd637d2917b1a6
            this.gridMergeImage.ColumnHeadersHeight = 20;
            this.gridMergeImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridMergeImage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column4});
<<<<<<< HEAD
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMergeImage.DefaultCellStyle = dataGridViewCellStyle29;
=======
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMergeImage.DefaultCellStyle = dataGridViewCellStyle17;
>>>>>>> cac304c6d1a3851d1402618e93bd637d2917b1a6
            this.gridMergeImage.EnableHeadersVisualStyles = false;
            this.gridMergeImage.Location = new System.Drawing.Point(9, 55);
            this.gridMergeImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridMergeImage.MultiSelect = false;
            this.gridMergeImage.Name = "gridMergeImage";
            this.gridMergeImage.ReadOnly = true;
<<<<<<< HEAD
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMergeImage.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
=======
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMergeImage.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
>>>>>>> cac304c6d1a3851d1402618e93bd637d2917b1a6
            this.gridMergeImage.RowHeadersVisible = false;
            this.gridMergeImage.RowTemplate.Height = 20;
            this.gridMergeImage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMergeImage.Size = new System.Drawing.Size(131, 1131);
            this.gridMergeImage.TabIndex = 201;
            this.gridMergeImage.SelectionChanged += new System.EventHandler(this.gridMergeImageRowChange);
            // 
            // DataPanel
            // 
            this.DataPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataPanel.Location = new System.Drawing.Point(-571, -625);
            this.DataPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(2731, 2380);
            this.DataPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DataPanel.TabIndex = 200;
            this.DataPanel.TabStop = false;
            this.DataPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataPanel_MouseClick);
            this.DataPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataPanel_MouseDown);
            this.DataPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DataPanel_MouseMove);
            this.DataPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DataPanel_MouseUp);
            this.DataPanel.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.DataPanel_MouseWheel);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DataPanel);
            this.panel1.Location = new System.Drawing.Point(341, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1587, 1130);
            this.panel1.TabIndex = 214;
            // 
            // btnOnOff
            // 
            this.btnOnOff.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOnOff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnOff.Location = new System.Drawing.Point(2050, 261);
            this.btnOnOff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(90, 29);
            this.btnOnOff.TabIndex = 215;
            this.btnOnOff.Text = "On";
            this.btnOnOff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // ZoomController
            // 
            this.ZoomController.Location = new System.Drawing.Point(1967, 305);
            this.ZoomController.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ZoomController.Maximum = 4;
            this.ZoomController.Name = "ZoomController";
            this.ZoomController.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ZoomController.Size = new System.Drawing.Size(56, 181);
            this.ZoomController.TabIndex = 216;
            this.ZoomController.ValueChanged += new System.EventHandler(this.ZoomController_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2007, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 217;
            this.label1.Text = "200X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2007, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 218;
            this.label2.Text = "100X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2007, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 218;
            this.label3.Text = "40X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2007, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 218;
            this.label4.Text = "20X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2007, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 218;
            this.label5.Text = "10X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2153, 1201);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZoomController);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.ThumbnailImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbxFolderPath);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnChangeFolder);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbImagePosiont);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.gridMergeImage);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "이미지 병합";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMergeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPanel)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ZoomController)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ThumbnailImage;
        private System.Windows.Forms.TextBox tbxFolderPath;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnChangeFolder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbImagePosiont;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView gridMergeImage;
        private System.Windows.Forms.PictureBox DataPanel;
        private System.Windows.Forms.FolderBrowserDialog imagePath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.TrackBar ZoomController;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

