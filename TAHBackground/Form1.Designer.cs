﻿namespace TAHBackground
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.diaOpen1 = new System.Windows.Forms.OpenFileDialog();
            this.bwCompress = new System.ComponentModel.BackgroundWorker();
            this.staStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.btnCompress = new System.Windows.Forms.Button();
            this.gvEntries = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Offset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoad = new System.Windows.Forms.Button();
            this.staStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // diaOpen1
            // 
            this.diaOpen1.FileName = "base_xp.tah";
            this.diaOpen1.Filter = "tah Files|*.tah|All Files|*.*";
            // 
            // bwCompress
            // 
            this.bwCompress.WorkerReportsProgress = true;
            this.bwCompress.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwCompress_DoWork);
            this.bwCompress.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwCompress_RunWorkerCompleted);
            this.bwCompress.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwCompress_ProgressChanged);
            // 
            // staStrip1
            // 
            this.staStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatus,
            this.pbStatus});
            this.staStrip1.Location = new System.Drawing.Point(0, 550);
            this.staStrip1.Name = "staStrip1";
            this.staStrip1.Size = new System.Drawing.Size(794, 23);
            this.staStrip1.TabIndex = 4;
            this.staStrip1.Text = "statusStrip1";
            // 
            // lbStatus
            // 
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(44, 18);
            this.lbStatus.Text = "Ready";
            // 
            // pbStatus
            // 
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(100, 17);
            // 
            // btnCompress
            // 
            this.btnCompress.Enabled = false;
            this.btnCompress.Location = new System.Drawing.Point(707, 524);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(75, 23);
            this.btnCompress.TabIndex = 7;
            this.btnCompress.Text = "&Compress";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // gvEntries
            // 
            this.gvEntries.AllowUserToAddRows = false;
            this.gvEntries.AllowUserToDeleteRows = false;
            this.gvEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEntries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.Offset,
            this.Length});
            this.gvEntries.Location = new System.Drawing.Point(266, 12);
            this.gvEntries.Name = "gvEntries";
            this.gvEntries.ReadOnly = true;
            this.gvEntries.RowTemplate.Height = 21;
            this.gvEntries.Size = new System.Drawing.Size(516, 506);
            this.gvEntries.TabIndex = 6;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "File name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 250;
            // 
            // Offset
            // 
            this.Offset.HeaderText = "Offset";
            this.Offset.Name = "Offset";
            this.Offset.ReadOnly = true;
            // 
            // Length
            // 
            this.Length.HeaderText = "Length";
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(626, 524);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 573);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.gvEntries);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.staStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "tah background";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.staStrip1.ResumeLayout(false);
            this.staStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEntries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog diaOpen1;
        private System.ComponentModel.BackgroundWorker bwCompress;
        private System.Windows.Forms.StatusStrip staStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
        private System.Windows.Forms.ToolStripProgressBar pbStatus;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.DataGridView gvEntries;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Offset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.Button btnLoad;
    }
}

