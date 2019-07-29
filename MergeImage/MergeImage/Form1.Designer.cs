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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbxFolderPath = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.gridMergeImage = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagePath = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataPanel = new System.Windows.Forms.PictureBox();
            this.ZoomController = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnType = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbUnChecked = new System.Windows.Forms.Label();
            this.lbChecked = new System.Windows.Forms.Label();
            this.lbTotalCount = new System.Windows.Forms.Label();
            this.lbCheckedCount = new System.Windows.Forms.Label();
            this.lbUnCheckedCount = new System.Windows.Forms.Label();
            this.btnCursor = new System.Windows.Forms.PictureBox();
            this.btnOnOff = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.PictureBox();
            this.btnConfirm = new System.Windows.Forms.PictureBox();
            this.btnNextOne = new System.Windows.Forms.PictureBox();
            this.btnPreOne = new System.Windows.Forms.PictureBox();
            this.btnM = new System.Windows.Forms.PictureBox();
            this.btnN = new System.Windows.Forms.PictureBox();
            this.btnD = new System.Windows.Forms.PictureBox();
            this.btnA = new System.Windows.Forms.PictureBox();
            this.btnPen = new System.Windows.Forms.PictureBox();
            this.btnMove = new System.Windows.Forms.PictureBox();
            this.picPen = new System.Windows.Forms.PictureBox();
            this.ThumbnailImage = new System.Windows.Forms.PictureBox();
            this.btnChangeFolder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMergeImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCursor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOnOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNextOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPreOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeFolder)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxFolderPath
            // 
            this.tbxFolderPath.Location = new System.Drawing.Point(134, 7);
            this.tbxFolderPath.Name = "tbxFolderPath";
            this.tbxFolderPath.ReadOnly = true;
            this.tbxFolderPath.Size = new System.Drawing.Size(256, 21);
            this.tbxFolderPath.TabIndex = 211;
            this.tbxFolderPath.Text = "이미지 경로";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(1746, 369);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 35);
            this.btnBack.TabIndex = 209;
            this.btnBack.Text = "실행취소";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.ColumnHeadersHeight = 20;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.dataGridViewTextBoxColumn1,
            this.Column1});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(177, 45);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 20;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(143, 612);
            this.dataGridView1.TabIndex = 208;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "X";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 30;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Y";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "이전";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "이후";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(8, 7);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(97, 21);
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.gridMergeImage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.gridMergeImage.ColumnHeadersHeight = 20;
            this.gridMergeImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridMergeImage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column4});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMergeImage.DefaultCellStyle = dataGridViewCellStyle17;
            this.gridMergeImage.EnableHeadersVisualStyles = false;
            this.gridMergeImage.Location = new System.Drawing.Point(8, 44);
            this.gridMergeImage.MultiSelect = false;
            this.gridMergeImage.Name = "gridMergeImage";
            this.gridMergeImage.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMergeImage.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.gridMergeImage.RowHeadersVisible = false;
            this.gridMergeImage.RowTemplate.Height = 20;
            this.gridMergeImage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMergeImage.Size = new System.Drawing.Size(168, 613);
            this.gridMergeImage.TabIndex = 201;
            this.gridMergeImage.SelectionChanged += new System.EventHandler(this.gridMergeImageRowChange);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 130;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "확인";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 30;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DataPanel);
            this.panel1.Location = new System.Drawing.Point(326, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1389, 904);
            this.panel1.TabIndex = 214;
            // 
            // DataPanel
            // 
            this.DataPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataPanel.Location = new System.Drawing.Point(-500, -500);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(2390, 1904);
            this.DataPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DataPanel.TabIndex = 200;
            this.DataPanel.TabStop = false;
            this.DataPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataPanel_MouseDown);
            this.DataPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DataPanel_MouseMove);
            this.DataPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DataPanel_MouseUp);
            this.DataPanel.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.DataPanel_MouseWheel);
            // 
            // ZoomController
            // 
            this.ZoomController.LargeChange = 1;
            this.ZoomController.Location = new System.Drawing.Point(1795, 620);
            this.ZoomController.Maximum = 4;
            this.ZoomController.Name = "ZoomController";
            this.ZoomController.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ZoomController.Size = new System.Drawing.Size(45, 145);
            this.ZoomController.TabIndex = 216;
            this.ZoomController.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ZoomController.ValueChanged += new System.EventHandler(this.ZoomController_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1830, 743);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 217;
            this.label1.Text = "200X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1830, 718);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 218;
            this.label2.Text = "100X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1830, 687);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 12);
            this.label3.TabIndex = 218;
            this.label3.Text = "40X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1830, 657);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 12);
            this.label4.TabIndex = 218;
            this.label4.Text = "20X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1830, 630);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 12);
            this.label5.TabIndex = 218;
            this.label5.Text = "10X";
            // 
            // btnType
            // 
            this.btnType.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnType.Location = new System.Drawing.Point(1746, 536);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(126, 35);
            this.btnType.TabIndex = 220;
            this.btnType.Text = "A타입";
            this.btnType.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnType.UseVisualStyleBackColor = true;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(10, 680);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(53, 12);
            this.lbTotal.TabIndex = 226;
            this.lbTotal.Text = "TOTAL :";
            // 
            // lbUnChecked
            // 
            this.lbUnChecked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUnChecked.AutoSize = true;
            this.lbUnChecked.Location = new System.Drawing.Point(10, 753);
            this.lbUnChecked.Name = "lbUnChecked";
            this.lbUnChecked.Size = new System.Drawing.Size(31, 12);
            this.lbUnChecked.TabIndex = 226;
            this.lbUnChecked.Text = "NO :";
            // 
            // lbChecked
            // 
            this.lbChecked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbChecked.AutoSize = true;
            this.lbChecked.ForeColor = System.Drawing.Color.Red;
            this.lbChecked.Location = new System.Drawing.Point(10, 718);
            this.lbChecked.Name = "lbChecked";
            this.lbChecked.Size = new System.Drawing.Size(37, 12);
            this.lbChecked.TabIndex = 226;
            this.lbChecked.Text = "YES :";
            // 
            // lbTotalCount
            // 
            this.lbTotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTotalCount.AutoSize = true;
            this.lbTotalCount.Location = new System.Drawing.Point(80, 680);
            this.lbTotalCount.Name = "lbTotalCount";
            this.lbTotalCount.Size = new System.Drawing.Size(21, 12);
            this.lbTotalCount.TabIndex = 226;
            this.lbTotalCount.Text = "- -";
            // 
            // lbCheckedCount
            // 
            this.lbCheckedCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCheckedCount.AutoSize = true;
            this.lbCheckedCount.Location = new System.Drawing.Point(80, 718);
            this.lbCheckedCount.Name = "lbCheckedCount";
            this.lbCheckedCount.Size = new System.Drawing.Size(21, 12);
            this.lbCheckedCount.TabIndex = 226;
            this.lbCheckedCount.Text = "- -";
            // 
            // lbUnCheckedCount
            // 
            this.lbUnCheckedCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUnCheckedCount.AutoSize = true;
            this.lbUnCheckedCount.Location = new System.Drawing.Point(80, 753);
            this.lbUnCheckedCount.Name = "lbUnCheckedCount";
            this.lbUnCheckedCount.Size = new System.Drawing.Size(21, 12);
            this.lbUnCheckedCount.TabIndex = 226;
            this.lbUnCheckedCount.Text = "- -";
            // 
            // btnCursor
            // 
            this.btnCursor.Image = global::MergeImage.Properties.Resources.커서눌린거;
            this.btnCursor.Location = new System.Drawing.Point(1772, 329);
            this.btnCursor.Name = "btnCursor";
            this.btnCursor.Size = new System.Drawing.Size(47, 34);
            this.btnCursor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCursor.TabIndex = 238;
            this.btnCursor.TabStop = false;
            this.btnCursor.Click += new System.EventHandler(this.btnCursor_Click);
            // 
            // btnOnOff
            // 
            this.btnOnOff.Image = global::MergeImage.Properties.Resources.마스크눌린거;
            this.btnOnOff.Location = new System.Drawing.Point(1772, 286);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(47, 34);
            this.btnOnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnOnOff.TabIndex = 237;
            this.btnOnOff.TabStop = false;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::MergeImage.Properties.Resources.초기화;
            this.btnClear.Location = new System.Drawing.Point(1772, 246);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(47, 34);
            this.btnClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClear.TabIndex = 236;
            this.btnClear.TabStop = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClear_MouseDown);
            this.btnClear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnClear_MouseUp);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = global::MergeImage.Properties.Resources.확인버튼;
            this.btnConfirm.Location = new System.Drawing.Point(1772, 46);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(47, 34);
            this.btnConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnConfirm.TabIndex = 235;
            this.btnConfirm.TabStop = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            this.btnConfirm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnConfirm_MouseDown);
            this.btnConfirm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnConfirm_MouseUp);
            // 
            // btnNextOne
            // 
            this.btnNextOne.Image = global::MergeImage.Properties.Resources.앞으로가기;
            this.btnNextOne.Location = new System.Drawing.Point(1825, 206);
            this.btnNextOne.Name = "btnNextOne";
            this.btnNextOne.Size = new System.Drawing.Size(47, 34);
            this.btnNextOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnNextOne.TabIndex = 234;
            this.btnNextOne.TabStop = false;
            this.btnNextOne.Click += new System.EventHandler(this.btnNextOne_Click);
            this.btnNextOne.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnNextOne_MouseDown);
            this.btnNextOne.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnNextOne_MouseUp);
            // 
            // btnPreOne
            // 
            this.btnPreOne.Image = global::MergeImage.Properties.Resources.뒤로가기;
            this.btnPreOne.Location = new System.Drawing.Point(1772, 206);
            this.btnPreOne.Name = "btnPreOne";
            this.btnPreOne.Size = new System.Drawing.Size(47, 34);
            this.btnPreOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnPreOne.TabIndex = 233;
            this.btnPreOne.TabStop = false;
            this.btnPreOne.Click += new System.EventHandler(this.btnPreOne_Click);
            this.btnPreOne.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPreOne_MouseDown);
            this.btnPreOne.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnPreOne_MouseUp);
            // 
            // btnM
            // 
            this.btnM.Image = global::MergeImage.Properties.Resources.라인빨간색;
            this.btnM.Location = new System.Drawing.Point(1825, 166);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(47, 34);
            this.btnM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnM.TabIndex = 232;
            this.btnM.TabStop = false;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnN
            // 
            this.btnN.Image = global::MergeImage.Properties.Resources.라인흰색;
            this.btnN.Location = new System.Drawing.Point(1772, 126);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(47, 34);
            this.btnN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnN.TabIndex = 229;
            this.btnN.TabStop = false;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnD
            // 
            this.btnD.Image = global::MergeImage.Properties.Resources.라인파란색;
            this.btnD.Location = new System.Drawing.Point(1772, 166);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(47, 34);
            this.btnD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnD.TabIndex = 231;
            this.btnD.TabStop = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnA
            // 
            this.btnA.Image = global::MergeImage.Properties.Resources.라인녹색;
            this.btnA.Location = new System.Drawing.Point(1825, 126);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(47, 34);
            this.btnA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnA.TabIndex = 230;
            this.btnA.TabStop = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnPen
            // 
            this.btnPen.Image = global::MergeImage.Properties.Resources.펜;
            this.btnPen.Location = new System.Drawing.Point(1825, 85);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(47, 34);
            this.btnPen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnPen.TabIndex = 228;
            this.btnPen.TabStop = false;
            this.btnPen.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // btnMove
            // 
            this.btnMove.Image = global::MergeImage.Properties.Resources.이동눌린거;
            this.btnMove.Location = new System.Drawing.Point(1772, 86);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(47, 34);
            this.btnMove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMove.TabIndex = 227;
            this.btnMove.TabStop = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // picPen
            // 
            this.picPen.Location = new System.Drawing.Point(1747, 620);
            this.picPen.Name = "picPen";
            this.picPen.Size = new System.Drawing.Size(35, 277);
            this.picPen.TabIndex = 221;
            this.picPen.TabStop = false;
            // 
            // ThumbnailImage
            // 
            this.ThumbnailImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ThumbnailImage.BackColor = System.Drawing.Color.White;
            this.ThumbnailImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThumbnailImage.Location = new System.Drawing.Point(134, 663);
            this.ThumbnailImage.Name = "ThumbnailImage";
            this.ThumbnailImage.Size = new System.Drawing.Size(186, 286);
            this.ThumbnailImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ThumbnailImage.TabIndex = 213;
            this.ThumbnailImage.TabStop = false;
            this.ThumbnailImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThumbnailImage_MouseDown);
            this.ThumbnailImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThumbnailImage_MouseMove);
            this.ThumbnailImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThumbnailImage_MouseUp);
            // 
            // btnChangeFolder
            // 
            this.btnChangeFolder.Image = global::MergeImage.Properties.Resources.폴더;
            this.btnChangeFolder.Location = new System.Drawing.Point(396, 5);
            this.btnChangeFolder.Name = "btnChangeFolder";
            this.btnChangeFolder.Size = new System.Drawing.Size(47, 34);
            this.btnChangeFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnChangeFolder.TabIndex = 239;
            this.btnChangeFolder.TabStop = false;
            this.btnChangeFolder.Click += new System.EventHandler(this.btnFold_Click);
            this.btnChangeFolder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFolder_MouseDown);
            this.btnChangeFolder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnChangeFolder_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1884, 849);
            this.Controls.Add(this.btnChangeFolder);
            this.Controls.Add(this.btnCursor);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnNextOne);
            this.Controls.Add(this.btnPreOne);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnPen);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.lbChecked);
            this.Controls.Add(this.lbUnChecked);
            this.Controls.Add(this.lbUnCheckedCount);
            this.Controls.Add(this.lbCheckedCount);
            this.Controls.Add(this.lbTotalCount);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.picPen);
            this.Controls.Add(this.btnType);
            this.Controls.Add(this.ThumbnailImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZoomController);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbxFolderPath);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.gridMergeImage);
            this.Name = "Form1";
            this.Text = "이미지 병합";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMergeImage)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCursor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOnOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNextOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPreOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeFolder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion

        private System.Windows.Forms.PictureBox ThumbnailImage;
        private System.Windows.Forms.TextBox tbxFolderPath;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView gridMergeImage;
        private System.Windows.Forms.PictureBox DataPanel;
        private System.Windows.Forms.FolderBrowserDialog imagePath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar ZoomController;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.PictureBox picPen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbUnChecked;
        private System.Windows.Forms.Label lbChecked;
        private System.Windows.Forms.Label lbTotalCount;
        private System.Windows.Forms.Label lbCheckedCount;
        private System.Windows.Forms.Label lbUnCheckedCount;
        private System.Windows.Forms.PictureBox btnMove;
        private System.Windows.Forms.PictureBox btnPen;
        private System.Windows.Forms.PictureBox btnN;
        private System.Windows.Forms.PictureBox btnA;
        private System.Windows.Forms.PictureBox btnD;
        private System.Windows.Forms.PictureBox btnM;
        private System.Windows.Forms.PictureBox btnPreOne;
        private System.Windows.Forms.PictureBox btnNextOne;
        private System.Windows.Forms.PictureBox btnConfirm;
        private System.Windows.Forms.PictureBox btnClear;
        private System.Windows.Forms.PictureBox btnOnOff;
        private System.Windows.Forms.PictureBox btnCursor;
        private System.Windows.Forms.PictureBox btnChangeFolder;
    }
}

