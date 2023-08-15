namespace Pic_To_Array
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
            this.img1 = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnConvert2Arr = new System.Windows.Forms.Button();
            this.btnConvert2Img = new System.Windows.Forms.Button();
            this.btntxt2pic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            this.SuspendLayout();
            // 
            // img1
            // 
            this.img1.Location = new System.Drawing.Point(24, 13);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(134, 168);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img1.TabIndex = 0;
            this.img1.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(83, 187);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnConvert2Arr
            // 
            this.btnConvert2Arr.Location = new System.Drawing.Point(33, 286);
            this.btnConvert2Arr.Name = "btnConvert2Arr";
            this.btnConvert2Arr.Size = new System.Drawing.Size(170, 45);
            this.btnConvert2Arr.TabIndex = 2;
            this.btnConvert2Arr.Text = "img 2 => []";
            this.btnConvert2Arr.UseVisualStyleBackColor = true;
            this.btnConvert2Arr.Click += new System.EventHandler(this.btnConvert2Arr_Click);
            // 
            // btnConvert2Img
            // 
            this.btnConvert2Img.Location = new System.Drawing.Point(224, 286);
            this.btnConvert2Img.Name = "btnConvert2Img";
            this.btnConvert2Img.Size = new System.Drawing.Size(170, 45);
            this.btnConvert2Img.TabIndex = 2;
            this.btnConvert2Img.Text = "[ ] => img";
            this.btnConvert2Img.UseVisualStyleBackColor = true;
            this.btnConvert2Img.Click += new System.EventHandler(this.btnConvert2Img_Click);
            // 
            // btntxt2pic
            // 
            this.btntxt2pic.Location = new System.Drawing.Point(401, 308);
            this.btntxt2pic.Name = "btntxt2pic";
            this.btntxt2pic.Size = new System.Drawing.Size(75, 23);
            this.btntxt2pic.TabIndex = 3;
            this.btntxt2pic.Text = "test txt2pic";
            this.btntxt2pic.UseVisualStyleBackColor = true;
            this.btntxt2pic.Click += new System.EventHandler(this.btntxt2pic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 366);
            this.Controls.Add(this.btntxt2pic);
            this.Controls.Add(this.btnConvert2Img);
            this.Controls.Add(this.btnConvert2Arr);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.img1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnConvert2Arr;
        private System.Windows.Forms.Button btnConvert2Img;
        private System.Windows.Forms.Button btntxt2pic;
    }
}

