namespace GetMagnet
{
    partial class MainUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnfhorcl = new Button();
            btnfh = new Button();
            btnOpen = new Button();
            btnmore = new Button();
            btnauto = new Button();
            tbURL3 = new TextBox();
            btnsetini = new Button();
            cbData = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            btntest = new Button();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            tbURL2 = new TextBox();
            tbURL = new TextBox();
            btnGo = new Button();
            panel2 = new Panel();
            rblog = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            清ToolStripMenuItem = new ToolStripMenuItem();
            复制ToolStripMenuItem = new ToolStripMenuItem();
            全选ToolStripMenuItem = new ToolStripMenuItem();
            剪切ToolStripMenuItem = new ToolStripMenuItem();
            pbrower = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnfhorcl);
            panel1.Controls.Add(btnfh);
            panel1.Controls.Add(btnOpen);
            panel1.Controls.Add(btnmore);
            panel1.Controls.Add(btnauto);
            panel1.Controls.Add(tbURL3);
            panel1.Controls.Add(btnsetini);
            panel1.Controls.Add(cbData);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btntest);
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(tbURL2);
            panel1.Controls.Add(tbURL);
            panel1.Controls.Add(btnGo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1173, 100);
            panel1.TabIndex = 0;
            // 
            // btnfhorcl
            // 
            btnfhorcl.Location = new Point(622, 71);
            btnfhorcl.Name = "btnfhorcl";
            btnfhorcl.Size = new Size(101, 23);
            btnfhorcl.TabIndex = 15;
            btnfhorcl.Text = "番号查找磁力";
            btnfhorcl.UseVisualStyleBackColor = true;
            btnfhorcl.Click += btnfhorcl_Click;
            // 
            // btnfh
            // 
            btnfh.Location = new Point(541, 71);
            btnfh.Name = "btnfh";
            btnfh.Size = new Size(75, 23);
            btnfh.TabIndex = 14;
            btnfh.Text = "获取番号";
            btnfh.UseVisualStyleBackColor = true;
            btnfh.Click += btnfh_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(460, 46);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 13;
            btnOpen.Text = "打开网址";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnmore
            // 
            btnmore.Location = new Point(670, 14);
            btnmore.Name = "btnmore";
            btnmore.Size = new Size(75, 23);
            btnmore.TabIndex = 12;
            btnmore.Text = "批量获取";
            btnmore.UseVisualStyleBackColor = true;
            btnmore.Click += btnmore_Click;
            // 
            // btnauto
            // 
            btnauto.Location = new Point(460, 71);
            btnauto.Name = "btnauto";
            btnauto.Size = new Size(75, 23);
            btnauto.TabIndex = 11;
            btnauto.Text = "自动识别";
            btnauto.UseVisualStyleBackColor = true;
            btnauto.Click += btnauto_Click;
            // 
            // tbURL3
            // 
            tbURL3.Location = new Point(541, 46);
            tbURL3.Name = "tbURL3";
            tbURL3.Size = new Size(397, 23);
            tbURL3.TabIndex = 10;
            // 
            // btnsetini
            // 
            btnsetini.Location = new Point(751, 14);
            btnsetini.Name = "btnsetini";
            btnsetini.Size = new Size(75, 23);
            btnsetini.TabIndex = 9;
            btnsetini.Text = "配置文件";
            btnsetini.UseVisualStyleBackColor = true;
            btnsetini.Click += btnsetini_Click;
            // 
            // cbData
            // 
            cbData.DisplayMember = "Section";
            cbData.FormattingEnabled = true;
            cbData.Location = new Point(541, 14);
            cbData.Name = "cbData";
            cbData.Size = new Size(121, 25);
            cbData.TabIndex = 8;
            cbData.SelectedIndexChanged += cbData_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(370, 45);
            label2.Name = "label2";
            label2.Size = new Size(15, 17);
            label2.TabIndex = 7;
            label2.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 46);
            label1.Name = "label1";
            label1.Size = new Size(15, 17);
            label1.TabIndex = 6;
            label1.Text = "0";
            // 
            // btntest
            // 
            btntest.Location = new Point(832, 14);
            btntest.Name = "btntest";
            btntest.Size = new Size(75, 23);
            btntest.TabIndex = 5;
            btntest.Text = "test";
            btntest.UseVisualStyleBackColor = true;
            btntest.Click += btntest_ClickAsync;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(160, 45);
            numericUpDown2.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 4;
            numericUpDown2.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(25, 45);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tbURL2
            // 
            tbURL2.Location = new Point(25, 74);
            tbURL2.Name = "tbURL2";
            tbURL2.Size = new Size(419, 23);
            tbURL2.TabIndex = 2;
            // 
            // tbURL
            // 
            tbURL.Location = new Point(25, 16);
            tbURL.Name = "tbURL";
            tbURL.Size = new Size(419, 23);
            tbURL.TabIndex = 1;
            // 
            // btnGo
            // 
            btnGo.Location = new Point(460, 14);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(75, 23);
            btnGo.TabIndex = 0;
            btnGo.Text = "Go";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(rblog);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(455, 596);
            panel2.TabIndex = 1;
            // 
            // rblog
            // 
            rblog.ContextMenuStrip = contextMenuStrip1;
            rblog.Dock = DockStyle.Fill;
            rblog.Location = new Point(0, 0);
            rblog.Name = "rblog";
            rblog.Size = new Size(455, 596);
            rblog.TabIndex = 0;
            rblog.Text = "";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { 清ToolStripMenuItem, 复制ToolStripMenuItem, 全选ToolStripMenuItem, 剪切ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(101, 92);
            // 
            // 清ToolStripMenuItem
            // 
            清ToolStripMenuItem.Name = "清ToolStripMenuItem";
            清ToolStripMenuItem.Size = new Size(100, 22);
            清ToolStripMenuItem.Text = "清空";
            清ToolStripMenuItem.Click += 清ToolStripMenuItem_Click;
            // 
            // 复制ToolStripMenuItem
            // 
            复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            复制ToolStripMenuItem.Size = new Size(100, 22);
            复制ToolStripMenuItem.Text = "复制";
            复制ToolStripMenuItem.Click += 复制ToolStripMenuItem_Click;
            // 
            // 全选ToolStripMenuItem
            // 
            全选ToolStripMenuItem.Name = "全选ToolStripMenuItem";
            全选ToolStripMenuItem.Size = new Size(100, 22);
            全选ToolStripMenuItem.Text = "全选";
            全选ToolStripMenuItem.Click += 全选ToolStripMenuItem_Click;
            // 
            // 剪切ToolStripMenuItem
            // 
            剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            剪切ToolStripMenuItem.Size = new Size(100, 22);
            剪切ToolStripMenuItem.Text = "剪切";
            剪切ToolStripMenuItem.Click += 剪切ToolStripMenuItem_Click;
            // 
            // pbrower
            // 
            pbrower.Dock = DockStyle.Fill;
            pbrower.Location = new Point(455, 100);
            pbrower.Name = "pbrower";
            pbrower.Size = new Size(718, 596);
            pbrower.TabIndex = 2;
            // 
            // MainUI
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 696);
            Controls.Add(pbrower);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainUI";
            Text = "Form1";
            Load += MainUI_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel2.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel pbrower;
        private RichTextBox rblog;
        private TextBox tbURL;
        private Button btnGo;
        private TextBox tbURL2;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Button btntest;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 清ToolStripMenuItem;
        private ToolStripMenuItem 复制ToolStripMenuItem;
        private Label label1;
        private Label label2;
        private ComboBox cbData;
        private Button btnsetini;
        private TextBox tbURL3;
        private Button btnauto;
        private Button btnmore;
        private Button btnOpen;
        private Button btnfh;
        private Button btnfhorcl;
        private ToolStripMenuItem 全选ToolStripMenuItem;
        private ToolStripMenuItem 剪切ToolStripMenuItem;
    }
}
