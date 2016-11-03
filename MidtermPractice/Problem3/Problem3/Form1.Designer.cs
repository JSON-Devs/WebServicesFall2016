namespace Problem3
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
            this.btnGet = new System.Windows.Forms.Button();
            this.rtCal = new System.Windows.Forms.RichTextBox();
            this.rtMeat = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(176, 34);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "Get Info";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // rtCal
            // 
            this.rtCal.Location = new System.Drawing.Point(29, 63);
            this.rtCal.Name = "rtCal";
            this.rtCal.Size = new System.Drawing.Size(370, 96);
            this.rtCal.TabIndex = 1;
            this.rtCal.Text = "";
            // 
            // rtMeat
            // 
            this.rtMeat.Location = new System.Drawing.Point(29, 166);
            this.rtMeat.Name = "rtMeat";
            this.rtMeat.Size = new System.Drawing.Size(370, 96);
            this.rtMeat.TabIndex = 2;
            this.rtMeat.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 280);
            this.Controls.Add(this.rtMeat);
            this.Controls.Add(this.rtCal);
            this.Controls.Add(this.btnGet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.RichTextBox rtCal;
        private System.Windows.Forms.RichTextBox rtMeat;
    }
}

