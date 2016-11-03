namespace Lab3
{
    partial class Part1
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
            this.rtForecast = new System.Windows.Forms.RichTextBox();
            this.btnGetForecast = new System.Windows.Forms.Button();
            this.rtInfo = new System.Windows.Forms.RichTextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.btnNearby = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtForecast
            // 
            this.rtForecast.Location = new System.Drawing.Point(12, 41);
            this.rtForecast.Name = "rtForecast";
            this.rtForecast.Size = new System.Drawing.Size(491, 166);
            this.rtForecast.TabIndex = 0;
            this.rtForecast.Text = "";
            // 
            // btnGetForecast
            // 
            this.btnGetForecast.Location = new System.Drawing.Point(12, 12);
            this.btnGetForecast.Name = "btnGetForecast";
            this.btnGetForecast.Size = new System.Drawing.Size(89, 23);
            this.btnGetForecast.TabIndex = 1;
            this.btnGetForecast.Text = "Get Forecast";
            this.btnGetForecast.UseVisualStyleBackColor = true;
            this.btnGetForecast.Click += new System.EventHandler(this.btnGetForcast_Click);
            // 
            // rtInfo
            // 
            this.rtInfo.Location = new System.Drawing.Point(12, 256);
            this.rtInfo.Name = "rtInfo";
            this.rtInfo.Size = new System.Drawing.Size(491, 128);
            this.rtInfo.TabIndex = 7;
            this.rtInfo.Text = "";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(12, 229);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 20);
            this.txtZip.TabIndex = 6;
            // 
            // btnNearby
            // 
            this.btnNearby.Location = new System.Drawing.Point(199, 227);
            this.btnNearby.Name = "btnNearby";
            this.btnNearby.Size = new System.Drawing.Size(75, 23);
            this.btnNearby.TabIndex = 5;
            this.btnNearby.Text = "Get Nearby";
            this.btnNearby.UseVisualStyleBackColor = true;
            this.btnNearby.Click += new System.EventHandler(this.btnNearby_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Get for Zip";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Part1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 400);
            this.Controls.Add(this.rtInfo);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.btnNearby);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGetForecast);
            this.Controls.Add(this.rtForecast);
            this.Name = "Part1";
            this.Text = "Part 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtForecast;
        private System.Windows.Forms.Button btnGetForecast;
        private System.Windows.Forms.RichTextBox rtInfo;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Button btnNearby;
        private System.Windows.Forms.Button button1;
    }
}

