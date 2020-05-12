namespace FinalAssignment
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
            this.Pnl_Draw = new System.Windows.Forms.Panel();
            this.txt_cmd = new System.Windows.Forms.TextBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_StartPosY = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_StartPosX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_multiCmd = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Draw
            // 
            this.Pnl_Draw.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Pnl_Draw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pnl_Draw.ForeColor = System.Drawing.Color.DarkBlue;
            this.Pnl_Draw.Location = new System.Drawing.Point(221, 66);
            this.Pnl_Draw.Name = "Pnl_Draw";
            this.Pnl_Draw.Size = new System.Drawing.Size(501, 370);
            this.Pnl_Draw.TabIndex = 0;
            this.Pnl_Draw.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_Draw_Paint);
            this.Pnl_Draw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pnl_Draw_MouseClick);
            this.Pnl_Draw.Move += new System.EventHandler(this.Pnl_Draw_Move);
            // 
            // txt_cmd
            // 
            this.txt_cmd.Location = new System.Drawing.Point(11, 181);
            this.txt_cmd.Multiline = true;
            this.txt_cmd.Name = "txt_cmd";
            this.txt_cmd.Size = new System.Drawing.Size(197, 51);
            this.txt_cmd.TabIndex = 1;
            this.txt_cmd.TextChanged += new System.EventHandler(this.txt_cmd_TextChanged);
            // 
            // btn_run
            // 
            this.btn_run.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_run.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_run.Location = new System.Drawing.Point(11, 277);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(88, 37);
            this.btn_run.TabIndex = 2;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = false;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_StartPosY);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_StartPosX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 70);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Co-ordinates";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_StartPosY
            // 
            this.lbl_StartPosY.AutoSize = true;
            this.lbl_StartPosY.Location = new System.Drawing.Point(139, 27);
            this.lbl_StartPosY.Name = "lbl_StartPosY";
            this.lbl_StartPosY.Size = new System.Drawing.Size(25, 13);
            this.lbl_StartPosY.TabIndex = 7;
            this.lbl_StartPosY.Text = "000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_StartPosX
            // 
            this.lbl_StartPosX.AutoSize = true;
            this.lbl_StartPosX.Location = new System.Drawing.Point(26, 27);
            this.lbl_StartPosX.Name = "lbl_StartPosX";
            this.lbl_StartPosX.Size = new System.Drawing.Size(25, 13);
            this.lbl_StartPosX.TabIndex = 5;
            this.lbl_StartPosX.Text = "000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(119, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Y";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(930, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem.Text = "About";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // txt_multiCmd
            // 
            this.txt_multiCmd.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txt_multiCmd.Location = new System.Drawing.Point(728, 66);
            this.txt_multiCmd.Multiline = true;
            this.txt_multiCmd.Name = "txt_multiCmd";
            this.txt_multiCmd.Size = new System.Drawing.Size(190, 273);
            this.txt_multiCmd.TabIndex = 5;
            this.txt_multiCmd.TextChanged += new System.EventHandler(this.txt_multiCmd_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(117, 277);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 40);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btn_exec_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnReset.Location = new System.Drawing.Point(728, 345);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(190, 53);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(930, 480);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txt_multiCmd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.txt_cmd);
            this.Controls.Add(this.Pnl_Draw);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Graphical Programming Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Draw;
        private System.Windows.Forms.TextBox txt_cmd;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_StartPosY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_StartPosX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_multiCmd;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReset;
    }
}

