
namespace WindowsFormsApp5
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
            this.tb_bad = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mi_restart = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bn_bad = new System.Windows.Forms.Button();
            this.lbx_main = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bn_good = new System.Windows.Forms.Button();
            this.tb_good = new System.Windows.Forms.TextBox();
            this.mi_msg = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_bad
            // 
            this.tb_bad.Location = new System.Drawing.Point(6, 38);
            this.tb_bad.Name = "tb_bad";
            this.tb_bad.Size = new System.Drawing.Size(261, 20);
            this.tb_bad.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_restart});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(569, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mi_restart
            // 
            this.mi_restart.Name = "mi_restart";
            this.mi_restart.Size = new System.Drawing.Size(55, 20);
            this.mi_restart.Text = "Restart";
            this.mi_restart.Click += new System.EventHandler(this.mi_restart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bn_bad);
            this.groupBox1.Controls.Add(this.tb_bad);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 98);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unsecured";
            // 
            // bn_bad
            // 
            this.bn_bad.Location = new System.Drawing.Point(6, 64);
            this.bn_bad.Name = "bn_bad";
            this.bn_bad.Size = new System.Drawing.Size(261, 23);
            this.bn_bad.TabIndex = 1;
            this.bn_bad.Text = "Create";
            this.bn_bad.UseVisualStyleBackColor = true;
            this.bn_bad.Click += new System.EventHandler(this.bn_bad_Click);
            // 
            // lbx_main
            // 
            this.lbx_main.FormattingEnabled = true;
            this.lbx_main.Location = new System.Drawing.Point(12, 162);
            this.lbx_main.Name = "lbx_main";
            this.lbx_main.Size = new System.Drawing.Size(552, 316);
            this.lbx_main.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bn_good);
            this.groupBox2.Controls.Add(this.tb_good);
            this.groupBox2.Location = new System.Drawing.Point(291, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 98);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Secured";
            // 
            // bn_good
            // 
            this.bn_good.Location = new System.Drawing.Point(6, 64);
            this.bn_good.Name = "bn_good";
            this.bn_good.Size = new System.Drawing.Size(261, 23);
            this.bn_good.TabIndex = 1;
            this.bn_good.Text = "Create";
            this.bn_good.UseVisualStyleBackColor = true;
            this.bn_good.Click += new System.EventHandler(this.bn_good_Click);
            // 
            // tb_good
            // 
            this.tb_good.Location = new System.Drawing.Point(6, 38);
            this.tb_good.Name = "tb_good";
            this.tb_good.Size = new System.Drawing.Size(261, 20);
            this.tb_good.TabIndex = 0;
            // 
            // mi_msg
            // 
            this.mi_msg.AutoSize = true;
            this.mi_msg.ForeColor = System.Drawing.Color.Red;
            this.mi_msg.Location = new System.Drawing.Point(15, 24);
            this.mi_msg.Name = "mi_msg";
            this.mi_msg.Size = new System.Drawing.Size(0, 13);
            this.mi_msg.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 489);
            this.Controls.Add(this.mi_msg);
            this.Controls.Add(this.lbx_main);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_bad;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mi_restart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbx_main;
        private System.Windows.Forms.Button bn_bad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bn_good;
        private System.Windows.Forms.TextBox tb_good;
        private System.Windows.Forms.Label mi_msg;
    }
}

