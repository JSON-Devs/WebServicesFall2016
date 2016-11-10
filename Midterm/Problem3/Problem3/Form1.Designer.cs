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
            this.rtDesc = new System.Windows.Forms.RichTextBox();
            this.rtItems = new System.Windows.Forms.RichTextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtDesc
            // 
            this.rtDesc.Location = new System.Drawing.Point(30, 149);
            this.rtDesc.Name = "rtDesc";
            this.rtDesc.Size = new System.Drawing.Size(370, 96);
            this.rtDesc.TabIndex = 5;
            this.rtDesc.Text = "";
            // 
            // rtItems
            // 
            this.rtItems.Location = new System.Drawing.Point(30, 46);
            this.rtItems.Name = "rtItems";
            this.rtItems.Size = new System.Drawing.Size(370, 96);
            this.rtItems.TabIndex = 4;
            this.rtItems.Text = "";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(177, 17);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 3;
            this.btnGet.Text = "Get Info";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 259);
            this.Controls.Add(this.rtDesc);
            this.Controls.Add(this.rtItems);
            this.Controls.Add(this.btnGet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtDesc;
        private System.Windows.Forms.RichTextBox rtItems;
        private System.Windows.Forms.Button btnGet;
    }
}

