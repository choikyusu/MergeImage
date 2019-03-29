﻿namespace MergeImage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbxFolderPath = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnChangeFolder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnM = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.gridMergeImage = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagePath = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataPanel = new System.Windows.Forms.PictureBox();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.ZoomController = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCursor = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.ThumbnailImage = new System.Windows.Forms.PictureBox();
            this.picPen = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPreOne = new System.Windows.Forms.Button();
            this.btnNextOne = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbUnChecked = new System.Windows.Forms.Label();
            this.lbChecked = new System.Windows.Forms.Label();
            this.lbTotalCount = new System.Windows.Forms.Label();
            this.lbCheckedCount = new System.Windows.Forms.Label();
            this.lbUnCheckedCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMergeImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPen)).BeginInit();
            this.SuspendLayout();
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
            this.btnConfirm.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.Location = new System.Drawing.Point(1995, 56);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(144, 44);
            this.btnConfirm.TabIndex = 210;
            this.btnConfirm.Text = "확인";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(1995, 461);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 44);
            this.btnBack.TabIndex = 209;
            this.btnBack.Text = "실행취소";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView1.ColumnHeadersHeight = 20;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.dataGridViewTextBoxColumn1,
            this.Column1});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(202, 56);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 20;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(163, 765);
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
            // btnM
            // 
            this.btnM.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnM.ForeColor = System.Drawing.Color.Red;
            this.btnM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnM.Location = new System.Drawing.Point(1995, 305);
            this.btnM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(144, 44);
            this.btnM.TabIndex = 205;
            this.btnM.Text = "M";
            this.btnM.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnD.ForeColor = System.Drawing.Color.Blue;
            this.btnD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnD.Location = new System.Drawing.Point(1995, 253);
            this.btnD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(144, 44);
            this.btnD.TabIndex = 204;
            this.btnD.Text = "D";
            this.btnD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnA.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnA.Location = new System.Drawing.Point(1995, 204);
            this.btnA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(144, 44);
            this.btnA.TabIndex = 203;
            this.btnA.Text = "A";
            this.btnA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnN
            // 
            this.btnN.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnN.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnN.Location = new System.Drawing.Point(1995, 156);
            this.btnN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(144, 44);
            this.btnN.TabIndex = 202;
            this.btnN.Text = "N";
            this.btnN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
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
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.gridMergeImage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.gridMergeImage.ColumnHeadersHeight = 20;
            this.gridMergeImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridMergeImage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column4});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMergeImage.DefaultCellStyle = dataGridViewCellStyle23;
            this.gridMergeImage.EnableHeadersVisualStyles = false;
            this.gridMergeImage.Location = new System.Drawing.Point(9, 55);
            this.gridMergeImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridMergeImage.MultiSelect = false;
            this.gridMergeImage.Name = "gridMergeImage";
            this.gridMergeImage.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMergeImage.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.gridMergeImage.RowHeadersVisible = false;
            this.gridMergeImage.RowTemplate.Height = 20;
            this.gridMergeImage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMergeImage.Size = new System.Drawing.Size(192, 766);
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
            this.panel1.Location = new System.Drawing.Point(373, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1587, 1130);
            this.panel1.TabIndex = 214;
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
            this.DataPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataPanel_MouseDown);
            this.DataPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DataPanel_MouseMove);
            this.DataPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DataPanel_MouseUp);
            this.DataPanel.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.DataPanel_MouseWheel);
            // 
            // btnOnOff
            // 
            this.btnOnOff.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOnOff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnOff.Location = new System.Drawing.Point(1995, 566);
            this.btnOnOff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(144, 44);
            this.btnOnOff.TabIndex = 215;
            this.btnOnOff.Text = "Mask on";
            this.btnOnOff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // ZoomController
            // 
            this.ZoomController.LargeChange = 1;
            this.ZoomController.Location = new System.Drawing.Point(2051, 775);
            this.ZoomController.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ZoomController.Maximum = 4;
            this.ZoomController.Name = "ZoomController";
            this.ZoomController.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ZoomController.Size = new System.Drawing.Size(56, 181);
            this.ZoomController.TabIndex = 216;
            this.ZoomController.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ZoomController.ValueChanged += new System.EventHandler(this.ZoomController_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2091, 929);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 217;
            this.label1.Text = "200X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2091, 897);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 218;
            this.label2.Text = "100X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2091, 859);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 218;
            this.label3.Text = "40X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2091, 821);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 218;
            this.label4.Text = "20X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2091, 787);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 218;
            this.label5.Text = "10X";
            // 
            // btnCursor
            // 
            this.btnCursor.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCursor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCursor.Location = new System.Drawing.Point(1995, 618);
            this.btnCursor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCursor.Name = "btnCursor";
            this.btnCursor.Size = new System.Drawing.Size(144, 44);
            this.btnCursor.TabIndex = 219;
            this.btnCursor.Text = "Cursor on";
            this.btnCursor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCursor.UseVisualStyleBackColor = true;
            this.btnCursor.Click += new System.EventHandler(this.btnCursor_Click);
            // 
            // btnMove
            // 
            this.btnMove.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMove.Location = new System.Drawing.Point(1995, 106);
            this.btnMove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(144, 44);
            this.btnMove.TabIndex = 220;
            this.btnMove.Text = "이동";
            this.btnMove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnType
            // 
            this.btnType.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnType.Location = new System.Drawing.Point(1995, 670);
            this.btnType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(144, 44);
            this.btnType.TabIndex = 220;
            this.btnType.Text = "A타입";
            this.btnType.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnType.UseVisualStyleBackColor = true;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // ThumbnailImage
            // 
            this.ThumbnailImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ThumbnailImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThumbnailImage.Location = new System.Drawing.Point(153, 829);
            this.ThumbnailImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ThumbnailImage.Name = "ThumbnailImage";
            this.ThumbnailImage.Size = new System.Drawing.Size(212, 357);
            this.ThumbnailImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ThumbnailImage.TabIndex = 213;
            this.ThumbnailImage.TabStop = false;
            this.ThumbnailImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ThumbnailImage_MouseDown);
            this.ThumbnailImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ThumbnailImage_MouseMove);
            this.ThumbnailImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ThumbnailImage_MouseUp);
            // 
            // picPen
            // 
            this.picPen.Location = new System.Drawing.Point(1997, 775);
            this.picPen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picPen.Name = "picPen";
            this.picPen.Size = new System.Drawing.Size(40, 346);
            this.picPen.TabIndex = 221;
            this.picPen.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(1995, 513);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 44);
            this.btnClear.TabIndex = 222;
            this.btnClear.Text = "전체초기화";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPreOne
            // 
            this.btnPreOne.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPreOne.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreOne.Location = new System.Drawing.Point(1995, 357);
            this.btnPreOne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPreOne.Name = "btnPreOne";
            this.btnPreOne.Size = new System.Drawing.Size(144, 44);
            this.btnPreOne.TabIndex = 223;
            this.btnPreOne.Text = "<";
            this.btnPreOne.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPreOne.UseVisualStyleBackColor = true;
            this.btnPreOne.Click += new System.EventHandler(this.btnPreOne_Click);
            // 
            // btnNextOne
            // 
            this.btnNextOne.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNextOne.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNextOne.Location = new System.Drawing.Point(1995, 409);
            this.btnNextOne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNextOne.Name = "btnNextOne";
            this.btnNextOne.Size = new System.Drawing.Size(144, 44);
            this.btnNextOne.TabIndex = 224;
            this.btnNextOne.Text = ">";
            this.btnNextOne.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNextOne.UseVisualStyleBackColor = true;
            this.btnNextOne.Click += new System.EventHandler(this.btnNextOne_Click);
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
            this.lbTotal.Location = new System.Drawing.Point(12, 850);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(62, 15);
            this.lbTotal.TabIndex = 226;
            this.lbTotal.Text = "TOTAL :";
            // 
            // lbUnChecked
            // 
            this.lbUnChecked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUnChecked.AutoSize = true;
            this.lbUnChecked.Location = new System.Drawing.Point(12, 941);
            this.lbUnChecked.Name = "lbUnChecked";
            this.lbUnChecked.Size = new System.Drawing.Size(38, 15);
            this.lbUnChecked.TabIndex = 226;
            this.lbUnChecked.Text = "NO :";
            // 
            // lbChecked
            // 
            this.lbChecked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbChecked.AutoSize = true;
            this.lbChecked.ForeColor = System.Drawing.Color.Red;
            this.lbChecked.Location = new System.Drawing.Point(12, 897);
            this.lbChecked.Name = "lbChecked";
            this.lbChecked.Size = new System.Drawing.Size(44, 15);
            this.lbChecked.TabIndex = 226;
            this.lbChecked.Text = "YES :";
            // 
            // lbTotalCount
            // 
            this.lbTotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTotalCount.AutoSize = true;
            this.lbTotalCount.Location = new System.Drawing.Point(91, 850);
            this.lbTotalCount.Name = "lbTotalCount";
            this.lbTotalCount.Size = new System.Drawing.Size(28, 15);
            this.lbTotalCount.TabIndex = 226;
            this.lbTotalCount.Text = "- -";
            // 
            // lbCheckedCount
            // 
            this.lbCheckedCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCheckedCount.AutoSize = true;
            this.lbCheckedCount.Location = new System.Drawing.Point(91, 897);
            this.lbCheckedCount.Name = "lbCheckedCount";
            this.lbCheckedCount.Size = new System.Drawing.Size(28, 15);
            this.lbCheckedCount.TabIndex = 226;
            this.lbCheckedCount.Text = "- -";
            // 
            // lbUnCheckedCount
            // 
            this.lbUnCheckedCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUnCheckedCount.AutoSize = true;
            this.lbUnCheckedCount.Location = new System.Drawing.Point(91, 941);
            this.lbUnCheckedCount.Name = "lbUnCheckedCount";
            this.lbUnCheckedCount.Size = new System.Drawing.Size(28, 15);
            this.lbUnCheckedCount.TabIndex = 226;
            this.lbUnCheckedCount.Text = "- -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2153, 1201);
            this.Controls.Add(this.lbChecked);
            this.Controls.Add(this.lbUnChecked);
            this.Controls.Add(this.lbUnCheckedCount);
            this.Controls.Add(this.lbCheckedCount);
            this.Controls.Add(this.lbTotalCount);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btnNextOne);
            this.Controls.Add(this.btnPreOne);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.picPen);
            this.Controls.Add(this.btnType);
            this.Controls.Add(this.ThumbnailImage);
            this.Controls.Add(this.btnCursor);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZoomController);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbxFolderPath);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnChangeFolder);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMergeImage)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion

        private System.Windows.Forms.PictureBox ThumbnailImage;
        private System.Windows.Forms.TextBox tbxFolderPath;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnChangeFolder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnN;
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
        private System.Windows.Forms.Button btnCursor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.PictureBox picPen;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPreOne;
        private System.Windows.Forms.Button btnNextOne;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbUnChecked;
        private System.Windows.Forms.Label lbChecked;
        private System.Windows.Forms.Label lbTotalCount;
        private System.Windows.Forms.Label lbCheckedCount;
        private System.Windows.Forms.Label lbUnCheckedCount;
    }
}

