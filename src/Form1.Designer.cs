namespace SortVisualizer
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            lbl_algorithm = new Label();
            cbb_algorithm = new ComboBox();
            btn_start = new Button();
            btn_reset = new Button();
            btn_pause = new Button();
            btn_resume = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            trackBarSpeed = new TrackBar();
            trackBarLabel = new Label();
            txt_trackBarValue = new TextBox();
            txt_numEntities = new TextBox();
            label1 = new Label();
            panelVisualizer = new DoubleBufferedPanel();
            cb_animation = new CheckBox();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarSpeed).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(821, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // lbl_algorithm
            // 
            lbl_algorithm.AutoSize = true;
            lbl_algorithm.Location = new Point(12, 34);
            lbl_algorithm.Name = "lbl_algorithm";
            lbl_algorithm.Size = new Size(61, 15);
            lbl_algorithm.TabIndex = 1;
            lbl_algorithm.Text = "Algorithm";
            // 
            // cbb_algorithm
            // 
            cbb_algorithm.FormattingEnabled = true;
            cbb_algorithm.Location = new Point(81, 29);
            cbb_algorithm.Name = "cbb_algorithm";
            cbb_algorithm.Size = new Size(176, 23);
            cbb_algorithm.TabIndex = 2;
            // 
            // btn_start
            // 
            btn_start.Location = new Point(84, 3);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(75, 23);
            btn_start.TabIndex = 5;
            btn_start.Text = "Start";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(3, 3);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(75, 23);
            btn_reset.TabIndex = 3;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_pause
            // 
            btn_pause.Location = new Point(165, 3);
            btn_pause.Name = "btn_pause";
            btn_pause.Size = new Size(75, 23);
            btn_pause.TabIndex = 3;
            btn_pause.Text = "Pause";
            btn_pause.UseVisualStyleBackColor = true;
            btn_pause.Click += btn_pause_Click;
            // 
            // btn_resume
            // 
            btn_resume.Location = new Point(246, 3);
            btn_resume.Name = "btn_resume";
            btn_resume.Size = new Size(75, 23);
            btn_resume.TabIndex = 5;
            btn_resume.Text = "Resumse";
            btn_resume.UseVisualStyleBackColor = true;
            btn_resume.Click += btn_resume_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(btn_reset, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_start, 1, 0);
            tableLayoutPanel1.Controls.Add(btn_pause, 2, 0);
            tableLayoutPanel1.Controls.Add(btn_resume, 3, 0);
            tableLayoutPanel1.Location = new Point(482, 29);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(327, 32);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // trackBarSpeed
            // 
            trackBarSpeed.Location = new Point(298, 29);
            trackBarSpeed.Minimum = 1;
            trackBarSpeed.Name = "trackBarSpeed";
            trackBarSpeed.Size = new Size(104, 45);
            trackBarSpeed.TabIndex = 7;
            trackBarSpeed.Value = 1;
            trackBarSpeed.ValueChanged += trackBarSpeed_ValueChanged;
            // 
            // trackBarLabel
            // 
            trackBarLabel.AutoSize = true;
            trackBarLabel.Location = new Point(271, 75);
            trackBarLabel.Name = "trackBarLabel";
            trackBarLabel.Size = new Size(105, 15);
            trackBarLabel.TabIndex = 8;
            trackBarLabel.Text = "Current delay(ms):";
            // 
            // txt_trackBarValue
            // 
            txt_trackBarValue.Location = new Point(382, 69);
            txt_trackBarValue.Name = "txt_trackBarValue";
            txt_trackBarValue.Size = new Size(100, 23);
            txt_trackBarValue.TabIndex = 9;
            txt_trackBarValue.TextChanged += txt_trackBarValue_TextChanged;
            // 
            // txt_numEntities
            // 
            txt_numEntities.Location = new Point(81, 70);
            txt_numEntities.Name = "txt_numEntities";
            txt_numEntities.Size = new Size(176, 23);
            txt_numEntities.TabIndex = 10;
            txt_numEntities.TextChanged += txt_numEntities_TextChanged;
            txt_numEntities.KeyPress += txt_numEntities_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 76);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Quantity";
            // 
            // panelVisualizer
            // 
            panelVisualizer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelVisualizer.BackColor = SystemColors.ControlLightLight;
            panelVisualizer.Location = new Point(12, 138);
            panelVisualizer.Name = "panelVisualizer";
            panelVisualizer.Size = new Size(797, 417);
            panelVisualizer.TabIndex = 11;
            // 
            // cb_animation
            // 
            cb_animation.AutoSize = true;
            cb_animation.Location = new Point(547, 73);
            cb_animation.Name = "cb_animation";
            cb_animation.Size = new Size(82, 19);
            cb_animation.TabIndex = 12;
            cb_animation.Text = "Animation";
            cb_animation.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 567);
            Controls.Add(cb_animation);
            Controls.Add(panelVisualizer);
            Controls.Add(txt_numEntities);
            Controls.Add(txt_trackBarValue);
            Controls.Add(trackBarLabel);
            Controls.Add(trackBarSpeed);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(cbb_algorithm);
            Controls.Add(label1);
            Controls.Add(lbl_algorithm);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBarSpeed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Label lbl_algorithm;
        private ComboBox cbb_algorithm;
        private Button btn_start;
        private Button btn_reset;
        private Button btn_pause;
        private Button btn_resume;
        private TableLayoutPanel tableLayoutPanel1;
        private TrackBar trackBarSpeed;
        private Label trackBarLabel;
        private TextBox txt_trackBarValue;
        private TextBox txt_numEntities;
        private Label label1;
        private DoubleBufferedPanel panelVisualizer;
        private CheckBox cb_animation;
    }
}
