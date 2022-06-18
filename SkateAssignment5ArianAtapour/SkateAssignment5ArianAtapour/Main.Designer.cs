namespace SkateAssignment5ArianAtapour
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabCM = new System.Windows.Forms.TabControl();
            this.Skater = new System.Windows.Forms.TabPage();
            this.conEr = new System.Windows.Forms.Label();
            this.lblSk = new System.Windows.Forms.Label();
            this.btnSk = new System.Windows.Forms.Button();
            this.txtNSk = new System.Windows.Forms.TextBox();
            this.nSk = new System.Windows.Forms.Label();
            this.Distance = new System.Windows.Forms.TabPage();
            this.distCon = new System.Windows.Forms.Label();
            this.lblDist = new System.Windows.Forms.Label();
            this.btnDist = new System.Windows.Forms.Button();
            this.txtDistD = new System.Windows.Forms.TextBox();
            this.distD = new System.Windows.Forms.Label();
            this.timeD = new System.Windows.Forms.DateTimePicker();
            this.lblTimeD = new System.Windows.Forms.Label();
            this.dropSkD = new System.Windows.Forms.ComboBox();
            this.lblSkND = new System.Windows.Forms.Label();
            this.Championship = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.winner10000 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.winner5000 = new System.Windows.Forms.Label();
            this.label5000 = new System.Windows.Forms.Label();
            this.winner1500 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.winner500 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabCM.SuspendLayout();
            this.Skater.SuspendLayout();
            this.Distance.SuspendLayout();
            this.Championship.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCM
            // 
            this.tabCM.Controls.Add(this.Skater);
            this.tabCM.Controls.Add(this.Distance);
            this.tabCM.Controls.Add(this.Championship);
            this.tabCM.Location = new System.Drawing.Point(13, 13);
            this.tabCM.Name = "tabCM";
            this.tabCM.SelectedIndex = 0;
            this.tabCM.Size = new System.Drawing.Size(409, 321);
            this.tabCM.TabIndex = 0;
            // 
            // Skater
            // 
            this.Skater.Controls.Add(this.conEr);
            this.Skater.Controls.Add(this.lblSk);
            this.Skater.Controls.Add(this.btnSk);
            this.Skater.Controls.Add(this.txtNSk);
            this.Skater.Controls.Add(this.nSk);
            this.Skater.Location = new System.Drawing.Point(4, 22);
            this.Skater.Name = "Skater";
            this.Skater.Padding = new System.Windows.Forms.Padding(3);
            this.Skater.Size = new System.Drawing.Size(401, 295);
            this.Skater.TabIndex = 0;
            this.Skater.Text = "Skater";
            this.Skater.UseVisualStyleBackColor = true;
            // 
            // conEr
            // 
            this.conEr.AutoSize = true;
            this.conEr.Location = new System.Drawing.Point(13, 198);
            this.conEr.Name = "conEr";
            this.conEr.Size = new System.Drawing.Size(0, 13);
            this.conEr.TabIndex = 4;
            // 
            // lblSk
            // 
            this.lblSk.AutoSize = true;
            this.lblSk.Location = new System.Drawing.Point(10, 113);
            this.lblSk.Name = "lblSk";
            this.lblSk.Size = new System.Drawing.Size(0, 13);
            this.lblSk.TabIndex = 3;
            // 
            // btnSk
            // 
            this.btnSk.Location = new System.Drawing.Point(10, 73);
            this.btnSk.Name = "btnSk";
            this.btnSk.Size = new System.Drawing.Size(75, 23);
            this.btnSk.TabIndex = 2;
            this.btnSk.Text = "Submit";
            this.btnSk.UseVisualStyleBackColor = true;
            this.btnSk.Click += new System.EventHandler(this.btnSk_Click);
            // 
            // txtNSk
            // 
            this.txtNSk.Location = new System.Drawing.Point(59, 29);
            this.txtNSk.Name = "txtNSk";
            this.txtNSk.Size = new System.Drawing.Size(100, 20);
            this.txtNSk.TabIndex = 1;
            // 
            // nSk
            // 
            this.nSk.AutoSize = true;
            this.nSk.Location = new System.Drawing.Point(7, 37);
            this.nSk.Name = "nSk";
            this.nSk.Size = new System.Drawing.Size(38, 13);
            this.nSk.TabIndex = 0;
            this.nSk.Text = "Name:";
            // 
            // Distance
            // 
            this.Distance.Controls.Add(this.distCon);
            this.Distance.Controls.Add(this.lblDist);
            this.Distance.Controls.Add(this.btnDist);
            this.Distance.Controls.Add(this.txtDistD);
            this.Distance.Controls.Add(this.distD);
            this.Distance.Controls.Add(this.timeD);
            this.Distance.Controls.Add(this.lblTimeD);
            this.Distance.Controls.Add(this.dropSkD);
            this.Distance.Controls.Add(this.lblSkND);
            this.Distance.Location = new System.Drawing.Point(4, 22);
            this.Distance.Name = "Distance";
            this.Distance.Padding = new System.Windows.Forms.Padding(3);
            this.Distance.Size = new System.Drawing.Size(401, 295);
            this.Distance.TabIndex = 1;
            this.Distance.Text = "Distance";
            this.Distance.UseVisualStyleBackColor = true;
            // 
            // distCon
            // 
            this.distCon.AutoSize = true;
            this.distCon.Location = new System.Drawing.Point(335, 267);
            this.distCon.Name = "distCon";
            this.distCon.Size = new System.Drawing.Size(0, 13);
            this.distCon.TabIndex = 8;
            // 
            // lblDist
            // 
            this.lblDist.AutoSize = true;
            this.lblDist.Location = new System.Drawing.Point(6, 156);
            this.lblDist.Name = "lblDist";
            this.lblDist.Size = new System.Drawing.Size(0, 13);
            this.lblDist.TabIndex = 7;
            // 
            // btnDist
            // 
            this.btnDist.Location = new System.Drawing.Point(6, 115);
            this.btnDist.Name = "btnDist";
            this.btnDist.Size = new System.Drawing.Size(75, 23);
            this.btnDist.TabIndex = 6;
            this.btnDist.Text = "Submit";
            this.btnDist.UseVisualStyleBackColor = true;
            this.btnDist.Click += new System.EventHandler(this.btnDist_Click);
            // 
            // txtDistD
            // 
            this.txtDistD.Location = new System.Drawing.Point(63, 77);
            this.txtDistD.Name = "txtDistD";
            this.txtDistD.Size = new System.Drawing.Size(119, 20);
            this.txtDistD.TabIndex = 5;
            // 
            // distD
            // 
            this.distD.AutoSize = true;
            this.distD.Location = new System.Drawing.Point(4, 85);
            this.distD.Name = "distD";
            this.distD.Size = new System.Drawing.Size(52, 13);
            this.distD.TabIndex = 4;
            this.distD.Text = "Distance:";
            // 
            // timeD
            // 
            this.timeD.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.timeD.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeD.Location = new System.Drawing.Point(61, 49);
            this.timeD.Name = "timeD";
            this.timeD.Size = new System.Drawing.Size(121, 20);
            this.timeD.TabIndex = 3;
            this.timeD.ValueChanged += new System.EventHandler(this.timeD_ValueChanged);
            // 
            // lblTimeD
            // 
            this.lblTimeD.AutoSize = true;
            this.lblTimeD.Location = new System.Drawing.Point(7, 53);
            this.lblTimeD.Name = "lblTimeD";
            this.lblTimeD.Size = new System.Drawing.Size(33, 13);
            this.lblTimeD.TabIndex = 2;
            this.lblTimeD.Text = "Time:";
            // 
            // dropSkD
            // 
            this.dropSkD.FormattingEnabled = true;
            this.dropSkD.Location = new System.Drawing.Point(61, 22);
            this.dropSkD.Name = "dropSkD";
            this.dropSkD.Size = new System.Drawing.Size(121, 21);
            this.dropSkD.TabIndex = 1;
            this.dropSkD.SelectedIndexChanged += new System.EventHandler(this.dropSkD_SelectedIndexChanged);
            // 
            // lblSkND
            // 
            this.lblSkND.AutoSize = true;
            this.lblSkND.Location = new System.Drawing.Point(4, 25);
            this.lblSkND.Name = "lblSkND";
            this.lblSkND.Size = new System.Drawing.Size(41, 13);
            this.lblSkND.TabIndex = 0;
            this.lblSkND.Text = "Skater:";
            // 
            // Championship
            // 
            this.Championship.Controls.Add(this.label5);
            this.Championship.Controls.Add(this.dataGridView1);
            this.Championship.Controls.Add(this.winner10000);
            this.Championship.Controls.Add(this.label4);
            this.Championship.Controls.Add(this.winner5000);
            this.Championship.Controls.Add(this.label5000);
            this.Championship.Controls.Add(this.winner1500);
            this.Championship.Controls.Add(this.label3);
            this.Championship.Controls.Add(this.winner500);
            this.Championship.Controls.Add(this.label2);
            this.Championship.Controls.Add(this.label1);
            this.Championship.Location = new System.Drawing.Point(4, 22);
            this.Championship.Name = "Championship";
            this.Championship.Padding = new System.Windows.Forms.Padding(3);
            this.Championship.Size = new System.Drawing.Size(401, 295);
            this.Championship.TabIndex = 2;
            this.Championship.Text = "Championship";
            this.Championship.UseVisualStyleBackColor = true;
            this.Championship.Click += new System.EventHandler(this.Championship_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Times contestants:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(155, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 117);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // winner10000
            // 
            this.winner10000.AutoSize = true;
            this.winner10000.Location = new System.Drawing.Point(61, 140);
            this.winner10000.Name = "winner10000";
            this.winner10000.Size = new System.Drawing.Size(0, 13);
            this.winner10000.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "10000m:";
            // 
            // winner5000
            // 
            this.winner5000.AutoSize = true;
            this.winner5000.Location = new System.Drawing.Point(61, 105);
            this.winner5000.Name = "winner5000";
            this.winner5000.Size = new System.Drawing.Size(0, 13);
            this.winner5000.TabIndex = 6;
            // 
            // label5000
            // 
            this.label5000.AutoSize = true;
            this.label5000.Location = new System.Drawing.Point(12, 105);
            this.label5000.Name = "label5000";
            this.label5000.Size = new System.Drawing.Size(42, 13);
            this.label5000.TabIndex = 5;
            this.label5000.Text = "5000m:";
            // 
            // winner1500
            // 
            this.winner1500.AutoSize = true;
            this.winner1500.Location = new System.Drawing.Point(58, 79);
            this.winner1500.Name = "winner1500";
            this.winner1500.Size = new System.Drawing.Size(0, 13);
            this.winner1500.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "1500m:";
            // 
            // winner500
            // 
            this.winner500.AutoSize = true;
            this.winner500.Location = new System.Drawing.Point(54, 48);
            this.winner500.Name = "winner500";
            this.winner500.Size = new System.Drawing.Size(0, 13);
            this.winner500.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "500m: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Winners for:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.hideToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 92);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.showToolStripMenuItem.Text = "Open";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.hideToolStripMenuItem.Text = "Close";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Skating Champtionship";
            this.notifyIcon1.BalloonTipTitle = "Skating Champtionship";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Skating Champtionship";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 336);
            this.Controls.Add(this.tabCM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            this.tabCM.ResumeLayout(false);
            this.Skater.ResumeLayout(false);
            this.Skater.PerformLayout();
            this.Distance.ResumeLayout(false);
            this.Distance.PerformLayout();
            this.Championship.ResumeLayout(false);
            this.Championship.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCM;
        private System.Windows.Forms.TabPage Skater;
        private System.Windows.Forms.TabPage Distance;
        private System.Windows.Forms.TabPage Championship;
        private System.Windows.Forms.Button btnSk;
        private System.Windows.Forms.TextBox txtNSk;
        private System.Windows.Forms.Label nSk;
        private System.Windows.Forms.Label lblSk;
        private System.Windows.Forms.Label lblDist;
        private System.Windows.Forms.Button btnDist;
        private System.Windows.Forms.TextBox txtDistD;
        private System.Windows.Forms.Label distD;
        private System.Windows.Forms.DateTimePicker timeD;
        private System.Windows.Forms.Label lblTimeD;
        private System.Windows.Forms.ComboBox dropSkD;
        private System.Windows.Forms.Label lblSkND;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label winner1500;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label winner500;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5000;
        private System.Windows.Forms.Label winner10000;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label winner5000;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.Label conEr;
        private System.Windows.Forms.Label distCon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

