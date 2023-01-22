namespace GuessCinema
{
    partial class fMenuVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMenuVideo));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOurVideo = new System.Windows.Forms.Button();
            this.btnThemeVideo = new System.Windows.Forms.Button();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.btnOurVideo, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnThemeVideo, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.pctExit, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1366, 768);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnOurVideo
            // 
            this.btnOurVideo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOurVideo.BackgroundImage")));
            this.btnOurVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOurVideo.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold);
            this.btnOurVideo.Location = new System.Drawing.Point(547, 310);
            this.btnOurVideo.Name = "btnOurVideo";
            this.btnOurVideo.Size = new System.Drawing.Size(403, 147);
            this.btnOurVideo.TabIndex = 0;
            this.btnOurVideo.Text = "Своя игра";
            this.btnOurVideo.UseVisualStyleBackColor = true;
            // 
            // btnThemeVideo
            // 
            this.btnThemeVideo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemeVideo.BackgroundImage")));
            this.btnThemeVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemeVideo.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold);
            this.btnThemeVideo.Location = new System.Drawing.Point(547, 501);
            this.btnThemeVideo.Name = "btnThemeVideo";
            this.btnThemeVideo.Size = new System.Drawing.Size(403, 147);
            this.btnThemeVideo.TabIndex = 1;
            this.btnThemeVideo.Text = "Тематическая игра";
            this.btnThemeVideo.UseVisualStyleBackColor = true;
            // 
            // pctExit
            // 
            this.pctExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctExit.Image = ((System.Drawing.Image)(resources.GetObject("pctExit.Image")));
            this.pctExit.Location = new System.Drawing.Point(16, 654);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(103, 101);
            this.pctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctExit.TabIndex = 2;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            // 
            // fMenuVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fMenuVideo";
            this.Text = "fMenuVideo";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnOurVideo;
        private System.Windows.Forms.Button btnThemeVideo;
        private System.Windows.Forms.PictureBox pctExit;
    }
}