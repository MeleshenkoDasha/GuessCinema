namespace GuessCinema
{
    partial class fMainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMainWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMenuMusic = new System.Windows.Forms.Button();
            this.btnMenuVideo = new System.Windows.Forms.Button();
            this.pctVolume = new System.Windows.Forms.PictureBox();
            this.pctHelp = new System.Windows.Forms.PictureBox();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.041667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.20833F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.16667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.58333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.291667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.041667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.291667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.041667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.291667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.041667F));
            this.tableLayoutPanel1.Controls.Add(this.btnMenuMusic, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnMenuVideo, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.pctVolume, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.pctHelp, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.pctExit, 8, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1366, 768);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnMenuMusic
            // 
            this.btnMenuMusic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenuMusic.BackgroundImage")));
            this.btnMenuMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuMusic.Font = new System.Drawing.Font("Cambria", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnMenuMusic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMenuMusic.Location = new System.Drawing.Point(429, 378);
            this.btnMenuMusic.Name = "btnMenuMusic";
            this.btnMenuMusic.Size = new System.Drawing.Size(392, 132);
            this.btnMenuMusic.TabIndex = 0;
            this.btnMenuMusic.Text = "Мелодию";
            this.btnMenuMusic.UseVisualStyleBackColor = true;
            // 
            // btnMenuVideo
            // 
            this.btnMenuVideo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenuVideo.BackgroundImage")));
            this.btnMenuVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenuVideo.Font = new System.Drawing.Font("Cambria", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnMenuVideo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMenuVideo.Location = new System.Drawing.Point(429, 554);
            this.btnMenuVideo.Name = "btnMenuVideo";
            this.btnMenuVideo.Size = new System.Drawing.Size(392, 132);
            this.btnMenuVideo.TabIndex = 1;
            this.btnMenuVideo.Text = "Фильм";
            this.btnMenuVideo.UseVisualStyleBackColor = true;
            // 
            // pctVolume
            // 
            this.pctVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctVolume.Location = new System.Drawing.Point(1026, 18);
            this.pctVolume.Name = "pctVolume";
            this.pctVolume.Size = new System.Drawing.Size(93, 93);
            this.pctVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctVolume.TabIndex = 2;
            this.pctVolume.TabStop = false;
            // 
            // pctHelp
            // 
            this.pctHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctHelp.Image = ((System.Drawing.Image)(resources.GetObject("pctHelp.Image")));
            this.pctHelp.Location = new System.Drawing.Point(1139, 18);
            this.pctHelp.Name = "pctHelp";
            this.pctHelp.Size = new System.Drawing.Size(93, 93);
            this.pctHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHelp.TabIndex = 3;
            this.pctHelp.TabStop = false;
            // 
            // pctExit
            // 
            this.pctExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctExit.Image = ((System.Drawing.Image)(resources.GetObject("pctExit.Image")));
            this.pctExit.Location = new System.Drawing.Point(1252, 18);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(93, 93);
            this.pctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctExit.TabIndex = 4;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            // 
            // fMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnMenuMusic;
        private System.Windows.Forms.Button btnMenuVideo;
        private System.Windows.Forms.PictureBox pctVolume;
        private System.Windows.Forms.PictureBox pctHelp;
        private System.Windows.Forms.PictureBox pctExit;
    }
}

