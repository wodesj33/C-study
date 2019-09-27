namespace caipiao
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum3 = new System.Windows.Forms.Label();
            this.lblNum6 = new System.Windows.Forms.Label();
            this.lblNum5 = new System.Windows.Forms.Label();
            this.lblNum4 = new System.Windows.Forms.Label();
            this.lblNum7 = new System.Windows.Forms.Label();
            this.lbNumberList = new System.Windows.Forms.ListBox();
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.textNum3 = new System.Windows.Forms.TextBox();
            this.textNum6 = new System.Windows.Forms.TextBox();
            this.textNum5 = new System.Windows.Forms.TextBox();
            this.textNum4 = new System.Windows.Forms.TextBox();
            this.textnum7 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.btnGroupSelect = new System.Windows.Forms.Button();
            this.btnWriteSelf = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.RandomTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(62)))), ((int)(((byte)(123)))));
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnSelect);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Controls.Add(this.btnWriteSelf);
            this.panel2.Controls.Add(this.btnGroupSelect);
            this.panel2.Controls.Add(this.txtGroup);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textnum7);
            this.panel2.Controls.Add(this.textNum6);
            this.panel2.Controls.Add(this.textNum5);
            this.panel2.Controls.Add(this.textNum4);
            this.panel2.Controls.Add(this.textNum3);
            this.panel2.Controls.Add(this.textNum2);
            this.panel2.Controls.Add(this.textNum1);
            this.panel2.Controls.Add(this.lbNumberList);
            this.panel2.Controls.Add(this.lblNum7);
            this.panel2.Controls.Add(this.lblNum6);
            this.panel2.Controls.Add(this.lblNum5);
            this.panel2.Controls.Add(this.lblNum4);
            this.panel2.Controls.Add(this.lblNum3);
            this.panel2.Controls.Add(this.lblNum2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblNum1);
            this.panel2.Location = new System.Drawing.Point(13, 59);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 582);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 49);
            this.panel1.TabIndex = 23;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(67, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "练习彩票";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnMin
            // 
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.Location = new System.Drawing.Point(741, 11);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(39, 29);
            this.btnMin.TabIndex = 3;
            this.btnMin.Text = "＿";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.Location = new System.Drawing.Point(788, 11);
            this.btnMax.Margin = new System.Windows.Forms.Padding(4);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(39, 29);
            this.btnMax.TabIndex = 3;
            this.btnMax.Text = "□";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(835, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 29);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblNum1
            // 
            this.lblNum1.BackColor = System.Drawing.Color.White;
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(36, 145);
            this.lblNum1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(64, 56);
            this.lblNum1.TabIndex = 16;
            this.lblNum1.Text = "0";
            this.lblNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(123)))));
            this.label2.Font = new System.Drawing.Font("微软雅黑", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(231, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 50);
            this.label2.TabIndex = 17;
            this.label2.Text = "6+1 体育彩票选号器";
            // 
            // lblNum2
            // 
            this.lblNum2.BackColor = System.Drawing.Color.White;
            this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(147, 145);
            this.lblNum2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(64, 56);
            this.lblNum2.TabIndex = 18;
            this.lblNum2.Text = "0";
            this.lblNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum3
            // 
            this.lblNum3.BackColor = System.Drawing.Color.White;
            this.lblNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum3.Location = new System.Drawing.Point(258, 145);
            this.lblNum3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum3.Name = "lblNum3";
            this.lblNum3.Size = new System.Drawing.Size(64, 56);
            this.lblNum3.TabIndex = 19;
            this.lblNum3.Text = "0";
            this.lblNum3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum6
            // 
            this.lblNum6.BackColor = System.Drawing.Color.White;
            this.lblNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum6.Location = new System.Drawing.Point(591, 145);
            this.lblNum6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum6.Name = "lblNum6";
            this.lblNum6.Size = new System.Drawing.Size(64, 56);
            this.lblNum6.TabIndex = 22;
            this.lblNum6.Text = "0";
            this.lblNum6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum5
            // 
            this.lblNum5.BackColor = System.Drawing.Color.White;
            this.lblNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum5.Location = new System.Drawing.Point(480, 145);
            this.lblNum5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum5.Name = "lblNum5";
            this.lblNum5.Size = new System.Drawing.Size(64, 56);
            this.lblNum5.TabIndex = 21;
            this.lblNum5.Text = "0";
            this.lblNum5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum4
            // 
            this.lblNum4.BackColor = System.Drawing.Color.White;
            this.lblNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum4.Location = new System.Drawing.Point(369, 145);
            this.lblNum4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum4.Name = "lblNum4";
            this.lblNum4.Size = new System.Drawing.Size(64, 56);
            this.lblNum4.TabIndex = 20;
            this.lblNum4.Text = "0";
            this.lblNum4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum7
            // 
            this.lblNum7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum7.Location = new System.Drawing.Point(775, 145);
            this.lblNum7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum7.Name = "lblNum7";
            this.lblNum7.Size = new System.Drawing.Size(64, 56);
            this.lblNum7.TabIndex = 23;
            this.lblNum7.Text = "0";
            this.lblNum7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNumberList
            // 
            this.lbNumberList.AllowDrop = true;
            this.lbNumberList.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbNumberList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbNumberList.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNumberList.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbNumberList.FormattingEnabled = true;
            this.lbNumberList.ItemHeight = 32;
            this.lbNumberList.Location = new System.Drawing.Point(26, 249);
            this.lbNumberList.Margin = new System.Windows.Forms.Padding(0);
            this.lbNumberList.Name = "lbNumberList";
            this.lbNumberList.Size = new System.Drawing.Size(404, 288);
            this.lbNumberList.TabIndex = 2;
            // 
            // textNum1
            // 
            this.textNum1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textNum1.Location = new System.Drawing.Point(443, 249);
            this.textNum1.Margin = new System.Windows.Forms.Padding(4);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(37, 34);
            this.textNum1.TabIndex = 21;
            this.textNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textNum2
            // 
            this.textNum2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textNum2.Location = new System.Drawing.Point(507, 249);
            this.textNum2.Margin = new System.Windows.Forms.Padding(4);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(37, 34);
            this.textNum2.TabIndex = 24;
            this.textNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textNum3
            // 
            this.textNum3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textNum3.Location = new System.Drawing.Point(565, 249);
            this.textNum3.Margin = new System.Windows.Forms.Padding(4);
            this.textNum3.Name = "textNum3";
            this.textNum3.Size = new System.Drawing.Size(37, 34);
            this.textNum3.TabIndex = 25;
            this.textNum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textNum6
            // 
            this.textNum6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textNum6.Location = new System.Drawing.Point(740, 249);
            this.textNum6.Margin = new System.Windows.Forms.Padding(4);
            this.textNum6.Name = "textNum6";
            this.textNum6.Size = new System.Drawing.Size(37, 34);
            this.textNum6.TabIndex = 28;
            this.textNum6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textNum5
            // 
            this.textNum5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textNum5.Location = new System.Drawing.Point(682, 249);
            this.textNum5.Margin = new System.Windows.Forms.Padding(4);
            this.textNum5.Name = "textNum5";
            this.textNum5.Size = new System.Drawing.Size(37, 34);
            this.textNum5.TabIndex = 27;
            this.textNum5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textNum4
            // 
            this.textNum4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textNum4.Location = new System.Drawing.Point(618, 249);
            this.textNum4.Margin = new System.Windows.Forms.Padding(4);
            this.textNum4.Name = "textNum4";
            this.textNum4.Size = new System.Drawing.Size(37, 34);
            this.textNum4.TabIndex = 26;
            this.textNum4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textnum7
            // 
            this.textnum7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textnum7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textnum7.Location = new System.Drawing.Point(802, 249);
            this.textnum7.Margin = new System.Windows.Forms.Padding(4);
            this.textnum7.Name = "textnum7";
            this.textnum7.Size = new System.Drawing.Size(37, 34);
            this.textnum7.TabIndex = 29;
            this.textnum7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(439, 347);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "组个数：";
            // 
            // txtGroup
            // 
            this.txtGroup.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGroup.Location = new System.Drawing.Point(520, 340);
            this.txtGroup.Margin = new System.Windows.Forms.Padding(4);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(37, 34);
            this.txtGroup.TabIndex = 30;
            this.txtGroup.Text = "5";
            this.txtGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGroupSelect
            // 
            this.btnGroupSelect.BackColor = System.Drawing.Color.Silver;
            this.btnGroupSelect.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGroupSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGroupSelect.Location = new System.Drawing.Point(565, 334);
            this.btnGroupSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnGroupSelect.Name = "btnGroupSelect";
            this.btnGroupSelect.Size = new System.Drawing.Size(124, 45);
            this.btnGroupSelect.TabIndex = 17;
            this.btnGroupSelect.Text = "随机组选";
            this.btnGroupSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGroupSelect.UseVisualStyleBackColor = false;
            this.btnGroupSelect.Click += new System.EventHandler(this.BtnGroupSelect_Click);
            // 
            // btnWriteSelf
            // 
            this.btnWriteSelf.BackColor = System.Drawing.Color.Silver;
            this.btnWriteSelf.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWriteSelf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWriteSelf.Location = new System.Drawing.Point(715, 335);
            this.btnWriteSelf.Margin = new System.Windows.Forms.Padding(4);
            this.btnWriteSelf.Name = "btnWriteSelf";
            this.btnWriteSelf.Size = new System.Drawing.Size(124, 45);
            this.btnWriteSelf.TabIndex = 31;
            this.btnWriteSelf.Text = "手写号码";
            this.btnWriteSelf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWriteSelf.UseVisualStyleBackColor = false;
            this.btnWriteSelf.Click += new System.EventHandler(this.BtnWriteSelf_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Silver;
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(433, 426);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(124, 45);
            this.btnStart.TabIndex = 32;
            this.btnStart.Text = "随机选号";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Silver;
            this.btnDel.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(433, 492);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(124, 45);
            this.btnDel.TabIndex = 33;
            this.btnDel.Text = "删除";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Silver;
            this.btnSelect.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(565, 426);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(124, 45);
            this.btnSelect.TabIndex = 34;
            this.btnSelect.Text = "确认选号";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Silver;
            this.btnClear.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(565, 492);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 45);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "清空";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Silver;
            this.btnPrint.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(715, 426);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(124, 114);
            this.btnPrint.TabIndex = 18;
            this.btnPrint.Text = "打    印";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // RandomTimer
            // 
            this.RandomTimer.Interval = 50;
            this.RandomTimer.Tick += new System.EventHandler(this.RandomTimer_Tick);
            // 
            // FrmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(889, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "体育彩票选号器";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum6;
        private System.Windows.Forms.Label lblNum5;
        private System.Windows.Forms.Label lblNum4;
        private System.Windows.Forms.Label lblNum3;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbNumberList;
        private System.Windows.Forms.Label lblNum7;
        private System.Windows.Forms.Button btnWriteSelf;
        private System.Windows.Forms.Button btnGroupSelect;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textnum7;
        private System.Windows.Forms.TextBox textNum6;
        private System.Windows.Forms.TextBox textNum5;
        private System.Windows.Forms.TextBox textNum4;
        private System.Windows.Forms.TextBox textNum3;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Timer RandomTimer;
    }
}

