namespace THA_W8_Felicia.S
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playerDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMatchDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxteam = new System.Windows.Forms.ComboBox();
            this.comboBoxplayer = new System.Windows.Forms.ComboBox();
            this.comboBoxplayer2 = new System.Windows.Forms.ComboBox();
            this.comboBoxteam2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerDataToolStripMenuItem,
            this.showMatchDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1650, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playerDataToolStripMenuItem
            // 
            this.playerDataToolStripMenuItem.Name = "playerDataToolStripMenuItem";
            this.playerDataToolStripMenuItem.Size = new System.Drawing.Size(154, 36);
            this.playerDataToolStripMenuItem.Text = "Player Data";
            this.playerDataToolStripMenuItem.Click += new System.EventHandler(this.playerDataToolStripMenuItem_Click);
            // 
            // showMatchDetailsToolStripMenuItem
            // 
            this.showMatchDetailsToolStripMenuItem.Name = "showMatchDetailsToolStripMenuItem";
            this.showMatchDetailsToolStripMenuItem.Size = new System.Drawing.Size(245, 36);
            this.showMatchDetailsToolStripMenuItem.Text = "Show Match Details";
            this.showMatchDetailsToolStripMenuItem.Click += new System.EventHandler(this.showMatchDetailsToolStripMenuItem_Click);
            // 
            // comboBoxteam
            // 
            this.comboBoxteam.FormattingEnabled = true;
            this.comboBoxteam.Location = new System.Drawing.Point(21, 62);
            this.comboBoxteam.Name = "comboBoxteam";
            this.comboBoxteam.Size = new System.Drawing.Size(190, 33);
            this.comboBoxteam.TabIndex = 1;
            this.comboBoxteam.SelectionChangeCommitted += new System.EventHandler(this.comboBoxteam_SelectionChangeCommitted);
            // 
            // comboBoxplayer
            // 
            this.comboBoxplayer.FormattingEnabled = true;
            this.comboBoxplayer.Location = new System.Drawing.Point(21, 119);
            this.comboBoxplayer.Name = "comboBoxplayer";
            this.comboBoxplayer.Size = new System.Drawing.Size(190, 33);
            this.comboBoxplayer.TabIndex = 2;
            this.comboBoxplayer.SelectionChangeCommitted += new System.EventHandler(this.comboBoxplayer_SelectionChangeCommitted);
            // 
            // comboBoxplayer2
            // 
            this.comboBoxplayer2.FormattingEnabled = true;
            this.comboBoxplayer2.Location = new System.Drawing.Point(710, 62);
            this.comboBoxplayer2.Name = "comboBoxplayer2";
            this.comboBoxplayer2.Size = new System.Drawing.Size(462, 33);
            this.comboBoxplayer2.TabIndex = 4;
            this.comboBoxplayer2.SelectionChangeCommitted += new System.EventHandler(this.comboBoxplayer2_SelectionChangeCommitted);
            // 
            // comboBoxteam2
            // 
            this.comboBoxteam2.FormattingEnabled = true;
            this.comboBoxteam2.Location = new System.Drawing.Point(449, 62);
            this.comboBoxteam2.Name = "comboBoxteam2";
            this.comboBoxteam2.Size = new System.Drawing.Size(190, 33);
            this.comboBoxteam2.TabIndex = 3;
            this.comboBoxteam2.SelectionChangeCommitted += new System.EventHandler(this.comboBoxteam2_SelectionChangeCommitted);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(449, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(562, 364);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1062, 119);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(562, 364);
            this.dataGridView2.TabIndex = 6;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(449, 506);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 82;
            this.dataGridView3.RowTemplate.Height = 33;
            this.dataGridView3.Size = new System.Drawing.Size(1175, 518);
            this.dataGridView3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1650, 1050);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxplayer2);
            this.Controls.Add(this.comboBoxteam2);
            this.Controls.Add(this.comboBoxplayer);
            this.Controls.Add(this.comboBoxteam);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playerDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMatchDetailsToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxteam;
        private System.Windows.Forms.ComboBox comboBoxplayer;
        private System.Windows.Forms.ComboBox comboBoxplayer2;
        private System.Windows.Forms.ComboBox comboBoxteam2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}

