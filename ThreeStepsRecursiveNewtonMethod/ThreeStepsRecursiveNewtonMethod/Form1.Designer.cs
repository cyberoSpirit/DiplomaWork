namespace ThreeStepsRecursiveNewtonMethod
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_n = new System.Windows.Forms.Label();
            this.comboBFunc = new System.Windows.Forms.ComboBox();
            this.textB_n = new System.Windows.Forms.NumericUpDown();
            this.butnExtend = new System.Windows.Forms.Button();
            this.dataG_x = new System.Windows.Forms.DataGridView();
            this.textB_eps = new System.Windows.Forms.TextBox();
            this.label_eps = new System.Windows.Forms.Label();
            this.label_depth = new System.Windows.Forms.Label();
            this.textB_depth = new System.Windows.Forms.NumericUpDown();
            this.labelGamma = new System.Windows.Forms.Label();
            this.textBGamma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textB_FDPCount = new System.Windows.Forms.TextBox();
            this.textB_FPCount = new System.Windows.Forms.TextBox();
            this.textB_FCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textB_IterNum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beiliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rosenbrokaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradient1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradient2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.розширенаФункціяВайтаІХолстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.функціяПауелаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioClassical = new System.Windows.Forms.RadioButton();
            this.radioRecursive = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textB_n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataG_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textB_depth)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Обчислити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(199, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Bright", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.Height = 44;
            this.dataGridView1.Size = new System.Drawing.Size(787, 491);
            this.dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "alpha";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "beta";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "uk";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 132;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "vk";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 132;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "xk+1";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 132;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "f(xk+1)";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 120;
            // 
            // label_n
            // 
            this.label_n.AutoSize = true;
            this.label_n.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_n.Location = new System.Drawing.Point(7, 46);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(71, 20);
            this.label_n.TabIndex = 7;
            this.label_n.Text = "Змінних :";
            // 
            // comboBFunc
            // 
            this.comboBFunc.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBFunc.FormattingEnabled = true;
            this.comboBFunc.Items.AddRange(new object[] {
            "Бейля",
            "Розенброка",
            "Штрафна (1)",
            "Штрафна (2)",
            "Вайта і Холста",
            "Пауела"});
            this.comboBFunc.Location = new System.Drawing.Point(6, 10);
            this.comboBFunc.Name = "comboBFunc";
            this.comboBFunc.Size = new System.Drawing.Size(179, 28);
            this.comboBFunc.TabIndex = 0;
            this.comboBFunc.Text = "Виберіть функцію";
            // 
            // textB_n
            // 
            this.textB_n.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_n.Location = new System.Drawing.Point(101, 41);
            this.textB_n.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textB_n.Name = "textB_n";
            this.textB_n.Size = new System.Drawing.Size(84, 28);
            this.textB_n.TabIndex = 1;
            this.textB_n.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.textB_n.Click += new System.EventHandler(this.textB_n_Click);
            // 
            // butnExtend
            // 
            this.butnExtend.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnExtend.Location = new System.Drawing.Point(8, 141);
            this.butnExtend.Name = "butnExtend";
            this.butnExtend.Size = new System.Drawing.Size(177, 27);
            this.butnExtend.TabIndex = 12;
            this.butnExtend.Text = "Поширити значення";
            this.butnExtend.UseVisualStyleBackColor = true;
            this.butnExtend.Click += new System.EventHandler(this.butnExtend_Click);
            // 
            // dataG_x
            // 
            this.dataG_x.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataG_x.Location = new System.Drawing.Point(6, 74);
            this.dataG_x.Name = "dataG_x";
            this.dataG_x.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataG_x.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataG_x.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataG_x.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataG_x.Size = new System.Drawing.Size(179, 62);
            this.dataG_x.TabIndex = 13;
            // 
            // textB_eps
            // 
            this.textB_eps.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_eps.Location = new System.Drawing.Point(84, 200);
            this.textB_eps.Name = "textB_eps";
            this.textB_eps.Size = new System.Drawing.Size(101, 28);
            this.textB_eps.TabIndex = 14;
            this.textB_eps.Text = "0,0000001";
            // 
            // label_eps
            // 
            this.label_eps.AutoSize = true;
            this.label_eps.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_eps.Location = new System.Drawing.Point(6, 209);
            this.label_eps.Name = "label_eps";
            this.label_eps.Size = new System.Drawing.Size(41, 20);
            this.label_eps.TabIndex = 15;
            this.label_eps.Text = "eps :";
            // 
            // label_depth
            // 
            this.label_depth.AutoSize = true;
            this.label_depth.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_depth.Location = new System.Drawing.Point(2, 177);
            this.label_depth.Name = "label_depth";
            this.label_depth.Size = new System.Drawing.Size(76, 20);
            this.label_depth.TabIndex = 16;
            this.label_depth.Text = "Глибина :";
            // 
            // textB_depth
            // 
            this.textB_depth.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_depth.Location = new System.Drawing.Point(84, 170);
            this.textB_depth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textB_depth.Name = "textB_depth";
            this.textB_depth.Size = new System.Drawing.Size(101, 28);
            this.textB_depth.TabIndex = 17;
            this.textB_depth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelGamma
            // 
            this.labelGamma.AutoSize = true;
            this.labelGamma.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGamma.Location = new System.Drawing.Point(3, 235);
            this.labelGamma.Name = "labelGamma";
            this.labelGamma.Size = new System.Drawing.Size(67, 20);
            this.labelGamma.TabIndex = 18;
            this.labelGamma.Text = "gamma :";
            // 
            // textBGamma
            // 
            this.textBGamma.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBGamma.Location = new System.Drawing.Point(84, 230);
            this.textBGamma.Name = "textBGamma";
            this.textBGamma.Size = new System.Drawing.Size(101, 28);
            this.textBGamma.TabIndex = 19;
            this.textBGamma.Text = "0,5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Функції :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Градієнта :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ітерацій :";
            // 
            // textB_FDPCount
            // 
            this.textB_FDPCount.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_FDPCount.Location = new System.Drawing.Point(109, 101);
            this.textB_FDPCount.Name = "textB_FDPCount";
            this.textB_FDPCount.ReadOnly = true;
            this.textB_FDPCount.Size = new System.Drawing.Size(67, 28);
            this.textB_FDPCount.TabIndex = 23;
            this.textB_FDPCount.Text = "0";
            // 
            // textB_FPCount
            // 
            this.textB_FPCount.BackColor = System.Drawing.SystemColors.Control;
            this.textB_FPCount.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_FPCount.Location = new System.Drawing.Point(109, 73);
            this.textB_FPCount.Name = "textB_FPCount";
            this.textB_FPCount.ReadOnly = true;
            this.textB_FPCount.Size = new System.Drawing.Size(68, 28);
            this.textB_FPCount.TabIndex = 24;
            this.textB_FPCount.Text = "0";
            // 
            // textB_FCount
            // 
            this.textB_FCount.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_FCount.Location = new System.Drawing.Point(108, 45);
            this.textB_FCount.Name = "textB_FCount";
            this.textB_FCount.ReadOnly = true;
            this.textB_FCount.Size = new System.Drawing.Size(69, 28);
            this.textB_FCount.TabIndex = 25;
            this.textB_FCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Гессіана :";
            // 
            // textB_IterNum
            // 
            this.textB_IterNum.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_IterNum.Location = new System.Drawing.Point(107, 17);
            this.textB_IterNum.Name = "textB_IterNum";
            this.textB_IterNum.ReadOnly = true;
            this.textB_IterNum.Size = new System.Drawing.Size(71, 28);
            this.textB_IterNum.TabIndex = 27;
            this.textB_IterNum.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataG_x);
            this.groupBox1.Controls.Add(this.label_n);
            this.groupBox1.Controls.Add(this.textB_n);
            this.groupBox1.Controls.Add(this.butnExtend);
            this.groupBox1.Controls.Add(this.textB_eps);
            this.groupBox1.Controls.Add(this.label_eps);
            this.groupBox1.Controls.Add(this.label_depth);
            this.groupBox1.Controls.Add(this.textB_depth);
            this.groupBox1.Controls.Add(this.labelGamma);
            this.groupBox1.Controls.Add(this.comboBFunc);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBGamma);
            this.groupBox1.Location = new System.Drawing.Point(3, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 295);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textB_IterNum);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textB_FDPCount);
            this.groupBox2.Controls.Add(this.textB_FCount);
            this.groupBox2.Controls.Add(this.textB_FPCount);
            this.groupBox2.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, 384);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 133);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Обчислення";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.demoToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(987, 26);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 22);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "Вихід";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // demoToolStripMenuItem
            // 
            this.demoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beiliaToolStripMenuItem,
            this.rosenbrokaToolStripMenuItem,
            this.gradient1ToolStripMenuItem,
            this.gradient2ToolStripMenuItem,
            this.розширенаФункціяВайтаІХолстаToolStripMenuItem,
            this.функціяПауелаToolStripMenuItem});
            this.demoToolStripMenuItem.Name = "demoToolStripMenuItem";
            this.demoToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.demoToolStripMenuItem.Text = "Демо";
            // 
            // beiliaToolStripMenuItem
            // 
            this.beiliaToolStripMenuItem.Name = "beiliaToolStripMenuItem";
            this.beiliaToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.beiliaToolStripMenuItem.Text = "Функція Бейля";
            this.beiliaToolStripMenuItem.Click += new System.EventHandler(this.beiliaToolStripMenuItem_Click);
            // 
            // rosenbrokaToolStripMenuItem
            // 
            this.rosenbrokaToolStripMenuItem.Name = "rosenbrokaToolStripMenuItem";
            this.rosenbrokaToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.rosenbrokaToolStripMenuItem.Text = "Функція Розенброка";
            this.rosenbrokaToolStripMenuItem.Click += new System.EventHandler(this.rosenbrokaToolStripMenuItem_Click);
            // 
            // gradient1ToolStripMenuItem
            // 
            this.gradient1ToolStripMenuItem.Name = "gradient1ToolStripMenuItem";
            this.gradient1ToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.gradient1ToolStripMenuItem.Text = "Штрафна функція (1)";
            this.gradient1ToolStripMenuItem.Click += new System.EventHandler(this.gradient1ToolStripMenuItem_Click);
            // 
            // gradient2ToolStripMenuItem
            // 
            this.gradient2ToolStripMenuItem.Name = "gradient2ToolStripMenuItem";
            this.gradient2ToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.gradient2ToolStripMenuItem.Text = "Штрафна функція (2)";
            this.gradient2ToolStripMenuItem.Click += new System.EventHandler(this.gradient2ToolStripMenuItem_Click);
            // 
            // розширенаФункціяВайтаІХолстаToolStripMenuItem
            // 
            this.розширенаФункціяВайтаІХолстаToolStripMenuItem.Name = "розширенаФункціяВайтаІХолстаToolStripMenuItem";
            this.розширенаФункціяВайтаІХолстаToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.розширенаФункціяВайтаІХолстаToolStripMenuItem.Text = "Розширена функція Вайта і Холста";
            this.розширенаФункціяВайтаІХолстаToolStripMenuItem.Click += new System.EventHandler(this.розширенаФункціяВайтаІХолстаToolStripMenuItem_Click);
            // 
            // функціяПауелаToolStripMenuItem
            // 
            this.функціяПауелаToolStripMenuItem.Name = "функціяПауелаToolStripMenuItem";
            this.функціяПауелаToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.функціяПауелаToolStripMenuItem.Text = "Функція Пауела";
            this.функціяПауелаToolStripMenuItem.Click += new System.EventHandler(this.функціяПауелаToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.aboutToolStripMenuItem.Text = "Про програму";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // radioClassical
            // 
            this.radioClassical.AutoSize = true;
            this.radioClassical.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioClassical.Location = new System.Drawing.Point(6, 24);
            this.radioClassical.Name = "radioClassical";
            this.radioClassical.Size = new System.Drawing.Size(90, 22);
            this.radioClassical.TabIndex = 31;
            this.radioClassical.Text = "Класичний";
            this.radioClassical.UseVisualStyleBackColor = true;
            // 
            // radioRecursive
            // 
            this.radioRecursive.AutoSize = true;
            this.radioRecursive.Checked = true;
            this.radioRecursive.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioRecursive.Location = new System.Drawing.Point(6, 44);
            this.radioRecursive.Name = "radioRecursive";
            this.radioRecursive.Size = new System.Drawing.Size(171, 22);
            this.radioRecursive.TabIndex = 32;
            this.radioRecursive.TabStop = true;
            this.radioRecursive.Text = "3-кроковий рекурсивний";
            this.radioRecursive.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioClassical);
            this.groupBox3.Controls.Add(this.radioRecursive);
            this.groupBox3.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(3, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 70);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Метод Ньютона";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 520);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Трикроковий рекурсивний метод Ньютона";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textB_n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataG_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textB_depth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.ComboBox comboBFunc;
        private System.Windows.Forms.NumericUpDown textB_n;
        private System.Windows.Forms.Button butnExtend;
        private System.Windows.Forms.DataGridView dataG_x;
        private System.Windows.Forms.TextBox textB_eps;
        private System.Windows.Forms.Label label_eps;
        private System.Windows.Forms.Label label_depth;
        private System.Windows.Forms.NumericUpDown textB_depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label labelGamma;
        private System.Windows.Forms.TextBox textBGamma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textB_FDPCount;
        private System.Windows.Forms.TextBox textB_FPCount;
        private System.Windows.Forms.TextBox textB_FCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textB_IterNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beiliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rosenbrokaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradient1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradient2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem розширенаФункціяВайтаІХолстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem функціяПауелаToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioClassical;
        private System.Windows.Forms.RadioButton radioRecursive;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

