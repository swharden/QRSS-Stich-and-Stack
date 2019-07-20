namespace QRSS_Stitch_and_Stack
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadImages = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbImages = new System.Windows.Forms.ListBox();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.gbDisplay = new System.Windows.Forms.GroupBox();
            this.btnSaveResult = new System.Windows.Forms.Button();
            this.rbStackMean = new System.Windows.Forms.RadioButton();
            this.rbStackMax = new System.Windows.Forms.RadioButton();
            this.rbStitch = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.gbResult.SuspendLayout();
            this.gbDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnLoadImages);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 440);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Images";
            // 
            // btnLoadImages
            // 
            this.btnLoadImages.Location = new System.Drawing.Point(6, 19);
            this.btnLoadImages.Name = "btnLoadImages";
            this.btnLoadImages.Size = new System.Drawing.Size(140, 23);
            this.btnLoadImages.TabIndex = 2;
            this.btnLoadImages.Text = "Select Images";
            this.btnLoadImages.UseVisualStyleBackColor = true;
            this.btnLoadImages.Click += new System.EventHandler(this.BtnLoadImages_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbImages);
            this.panel1.Location = new System.Drawing.Point(6, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 386);
            this.panel1.TabIndex = 9;
            // 
            // lbImages
            // 
            this.lbImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbImages.FormattingEnabled = true;
            this.lbImages.HorizontalScrollbar = true;
            this.lbImages.Location = new System.Drawing.Point(0, 0);
            this.lbImages.Name = "lbImages";
            this.lbImages.Size = new System.Drawing.Size(140, 386);
            this.lbImages.TabIndex = 10;
            this.lbImages.SelectedIndexChanged += new System.EventHandler(this.LbImages_SelectedIndexChanged);
            // 
            // pbResult
            // 
            this.pbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbResult.Location = new System.Drawing.Point(3, 16);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(647, 421);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResult.TabIndex = 4;
            this.pbResult.TabStop = false;
            // 
            // gbResult
            // 
            this.gbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResult.Controls.Add(this.pbResult);
            this.gbResult.Location = new System.Drawing.Point(170, 69);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(653, 440);
            this.gbResult.TabIndex = 5;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Result";
            // 
            // rbSingle
            // 
            this.rbSingle.AutoSize = true;
            this.rbSingle.Checked = true;
            this.rbSingle.Location = new System.Drawing.Point(11, 23);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(54, 17);
            this.rbSingle.TabIndex = 6;
            this.rbSingle.TabStop = true;
            this.rbSingle.Text = "Single";
            this.rbSingle.UseVisualStyleBackColor = true;
            this.rbSingle.Click += new System.EventHandler(this.RbSingle_Click);
            // 
            // gbDisplay
            // 
            this.gbDisplay.Controls.Add(this.btnSaveResult);
            this.gbDisplay.Controls.Add(this.rbStackMean);
            this.gbDisplay.Controls.Add(this.rbStackMax);
            this.gbDisplay.Controls.Add(this.rbStitch);
            this.gbDisplay.Controls.Add(this.rbSingle);
            this.gbDisplay.Enabled = false;
            this.gbDisplay.Location = new System.Drawing.Point(170, 12);
            this.gbDisplay.Name = "gbDisplay";
            this.gbDisplay.Size = new System.Drawing.Size(362, 51);
            this.gbDisplay.TabIndex = 7;
            this.gbDisplay.TabStop = false;
            this.gbDisplay.Text = "Display";
            // 
            // btnSaveResult
            // 
            this.btnSaveResult.Location = new System.Drawing.Point(304, 20);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(50, 23);
            this.btnSaveResult.TabIndex = 3;
            this.btnSaveResult.Text = "Save";
            this.btnSaveResult.UseVisualStyleBackColor = true;
            this.btnSaveResult.Click += new System.EventHandler(this.BtnSaveResult_Click);
            // 
            // rbStackMean
            // 
            this.rbStackMean.AutoSize = true;
            this.rbStackMean.Location = new System.Drawing.Point(210, 23);
            this.rbStackMean.Name = "rbStackMean";
            this.rbStackMean.Size = new System.Drawing.Size(88, 17);
            this.rbStackMean.TabIndex = 9;
            this.rbStackMean.Text = "Stack (mean)";
            this.rbStackMean.UseVisualStyleBackColor = true;
            this.rbStackMean.Click += new System.EventHandler(this.RbStackMean_Click);
            // 
            // rbStackMax
            // 
            this.rbStackMax.AutoSize = true;
            this.rbStackMax.Location = new System.Drawing.Point(125, 23);
            this.rbStackMax.Name = "rbStackMax";
            this.rbStackMax.Size = new System.Drawing.Size(81, 17);
            this.rbStackMax.TabIndex = 7;
            this.rbStackMax.Text = "Stack (max)";
            this.rbStackMax.UseVisualStyleBackColor = true;
            this.rbStackMax.Click += new System.EventHandler(this.RbStackMax_Click);
            // 
            // rbStitch
            // 
            this.rbStitch.AutoSize = true;
            this.rbStitch.Enabled = false;
            this.rbStitch.Location = new System.Drawing.Point(69, 23);
            this.rbStitch.Name = "rbStitch";
            this.rbStitch.Size = new System.Drawing.Size(52, 17);
            this.rbStitch.TabIndex = 8;
            this.rbStitch.Text = "Stitch";
            this.rbStitch.UseVisualStyleBackColor = true;
            this.rbStitch.Click += new System.EventHandler(this.RbStitch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "QRSS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Stich and Stack";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 521);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbDisplay);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "QRSS Stitch and Stack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.gbResult.ResumeLayout(false);
            this.gbDisplay.ResumeLayout(false);
            this.gbDisplay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.GroupBox gbDisplay;
        private System.Windows.Forms.RadioButton rbStackMean;
        private System.Windows.Forms.RadioButton rbStitch;
        private System.Windows.Forms.RadioButton rbStackMax;
        private System.Windows.Forms.Button btnLoadImages;
        private System.Windows.Forms.Button btnSaveResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbImages;
    }
}

