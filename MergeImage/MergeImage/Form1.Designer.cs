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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataPanelSmar = new System.Windows.Forms.PictureBox();
            this.tbxFolderPath = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChangeFolder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbImagePosiont = new System.Windows.Forms.Label();
            this.btnD = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.gridMergeImage = new System.Windows.Forms.DataGridView();
            this.DataPanel = new System.Windows.Forms.PictureBox();
            this.imagePath = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DataPanelSmar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMergeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // DataPanelSmar
            // 
            this.DataPanelSmar.Location = new System.Drawing.Point(1160, 468);
            this.DataPanelSmar.Name = "DataPanelSmar";
            this.DataPanelSmar.Size = new System.Drawing.Size(131, 139);
            this.DataPanelSmar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DataPanelSmar.TabIndex = 213;
            this.DataPanelSmar.TabStop = false;
            // 
            // tbxFolderPath
            // 
            this.tbxFolderPath.Location = new System.Drawing.Point(950, 17);
            this.tbxFolderPath.Name = "tbxFolderPath";
            this.tbxFolderPath.ReadOnly = true;
            this.tbxFolderPath.Size = new System.Drawing.Size(256, 21);
            this.tbxFolderPath.TabIndex = 211;
            this.tbxFolderPath.Text = "이미지 경로";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.Location = new System.Drawing.Point(1212, 190);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(79, 23);
            this.btnConfirm.TabIndex = 210;
            this.btnConfirm.Text = "확인";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1212, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 23);
            this.button3.TabIndex = 209;
            this.button3.Text = "실행취소";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
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
            this.btnChangeFolder.Location = new System.Drawing.Point(1212, 17);
            this.btnChangeFolder.Name = "btnChangeFolder";
            this.btnChangeFolder.Size = new System.Drawing.Size(79, 23);
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
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 20;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.dataGridViewTextBoxColumn1,
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(129, 45);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 20;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(163, 562);
            this.dataGridView1.TabIndex = 208;
            // 
            // lbImagePosiont
            // 
            this.lbImagePosiont.AutoSize = true;
            this.lbImagePosiont.Location = new System.Drawing.Point(111, 13);
            this.lbImagePosiont.Name = "lbImagePosiont";
            this.lbImagePosiont.Size = new System.Drawing.Size(209, 12);
            this.lbImagePosiont.TabIndex = 207;
            this.lbImagePosiont.Text = "이미지 번호 X, Y 를 선택했습니다.....";
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnD.Location = new System.Drawing.Point(1212, 132);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(79, 23);
            this.btnD.TabIndex = 205;
            this.btnD.Text = "D";
            this.btnD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnD.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnC.Location = new System.Drawing.Point(1212, 103);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(79, 23);
            this.btnC.TabIndex = 204;
            this.btnC.Text = "C";
            this.btnC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnB.Location = new System.Drawing.Point(1212, 74);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(79, 23);
            this.btnB.TabIndex = 203;
            this.btnB.Text = "B";
            this.btnB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnB.UseVisualStyleBackColor = true;
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnA.Location = new System.Drawing.Point(1212, 45);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(79, 23);
            this.btnA.TabIndex = 202;
            this.btnA.Text = "A";
            this.btnA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnA.UseVisualStyleBackColor = true;
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
            this.gridMergeImage.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.gridMergeImage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.gridMergeImage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridMergeImage.ColumnHeadersHeight = 20;
            this.gridMergeImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridMergeImage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column4});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMergeImage.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridMergeImage.EnableHeadersVisualStyles = false;
            this.gridMergeImage.Location = new System.Drawing.Point(8, 44);
            this.gridMergeImage.MultiSelect = false;
            this.gridMergeImage.Name = "gridMergeImage";
            this.gridMergeImage.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMergeImage.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridMergeImage.RowHeadersVisible = false;
            this.gridMergeImage.RowTemplate.Height = 20;
            this.gridMergeImage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMergeImage.Size = new System.Drawing.Size(115, 562);
            this.gridMergeImage.TabIndex = 201;
            // 
            // DataPanel
            // 
            this.DataPanel.Location = new System.Drawing.Point(298, 44);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(856, 562);
            this.DataPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DataPanel.TabIndex = 200;
            this.DataPanel.TabStop = false;
            this.DataPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataPanel_MouseClick);
            this.DataPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataPanel_MouseDown);
            this.DataPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DataPanel_MouseMove);
            this.DataPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DataPanel_MouseUp);
            this.DataPanel.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.DataPanel_MouseWheel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 618);
            this.Controls.Add(this.DataPanelSmar);
            this.Controls.Add(this.tbxFolderPath);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnChangeFolder);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbImagePosiont);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.gridMergeImage);
            this.Controls.Add(this.DataPanel);
            this.Name = "Form1";
            this.Text = "이미지 병합";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DataPanelSmar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMergeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DataPanelSmar;
        private System.Windows.Forms.TextBox tbxFolderPath;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnChangeFolder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbImagePosiont;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView gridMergeImage;
        private System.Windows.Forms.PictureBox DataPanel;
        private System.Windows.Forms.FolderBrowserDialog imagePath;
    }
}

