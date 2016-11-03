namespace Lab2
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
            this.lblCost = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.rtBilling = new System.Windows.Forms.RichTextBox();
            this.btnBilling = new System.Windows.Forms.Button();
            this.btnShip = new System.Windows.Forms.Button();
            this.rtShipping = new System.Windows.Forms.RichTextBox();
            this.rtItem = new System.Windows.Forms.RichTextBox();
            this.btnItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(230, 249);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(61, 13);
            this.lblCost.TabIndex = 0;
            this.lblCost.Text = "Total Cost: ";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(220, 230);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(90, 13);
            this.lblItems.TabIndex = 1;
            this.lblItems.Text = "Number of Items: ";
            // 
            // rtBilling
            // 
            this.rtBilling.BackColor = System.Drawing.Color.Red;
            this.rtBilling.ForeColor = System.Drawing.SystemColors.Window;
            this.rtBilling.Location = new System.Drawing.Point(16, 114);
            this.rtBilling.Name = "rtBilling";
            this.rtBilling.Size = new System.Drawing.Size(513, 107);
            this.rtBilling.TabIndex = 2;
            this.rtBilling.Text = "";
            // 
            // btnBilling
            // 
            this.btnBilling.BackColor = System.Drawing.Color.HotPink;
            this.btnBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBilling.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBilling.Location = new System.Drawing.Point(233, 12);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(75, 127);
            this.btnBilling.TabIndex = 3;
            this.btnBilling.Text = "Get Billing Info";
            this.btnBilling.UseVisualStyleBackColor = false;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // btnShip
            // 
            this.btnShip.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnShip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShip.Location = new System.Drawing.Point(16, 463);
            this.btnShip.Name = "btnShip";
            this.btnShip.Size = new System.Drawing.Size(213, 23);
            this.btnShip.TabIndex = 4;
            this.btnShip.Text = "Get Shipping Info";
            this.btnShip.UseVisualStyleBackColor = false;
            this.btnShip.Click += new System.EventHandler(this.btnShip_Click);
            // 
            // rtShipping
            // 
            this.rtShipping.BackColor = System.Drawing.SystemColors.MenuText;
            this.rtShipping.ForeColor = System.Drawing.SystemColors.Window;
            this.rtShipping.Location = new System.Drawing.Point(16, 266);
            this.rtShipping.Name = "rtShipping";
            this.rtShipping.Size = new System.Drawing.Size(213, 191);
            this.rtShipping.TabIndex = 5;
            this.rtShipping.Text = "";
            // 
            // rtItem
            // 
            this.rtItem.BackColor = System.Drawing.SystemColors.WindowText;
            this.rtItem.ForeColor = System.Drawing.SystemColors.Window;
            this.rtItem.Location = new System.Drawing.Point(310, 266);
            this.rtItem.Name = "rtItem";
            this.rtItem.Size = new System.Drawing.Size(219, 191);
            this.rtItem.TabIndex = 6;
            this.rtItem.Text = "";
            // 
            // btnItem
            // 
            this.btnItem.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnItem.Location = new System.Drawing.Point(310, 463);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(219, 23);
            this.btnItem.TabIndex = 7;
            this.btnItem.Text = "Get Item Info";
            this.btnItem.UseVisualStyleBackColor = false;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(541, 520);
            this.Controls.Add(this.btnItem);
            this.Controls.Add(this.rtItem);
            this.Controls.Add(this.rtShipping);
            this.Controls.Add(this.btnShip);
            this.Controls.Add(this.btnBilling);
            this.Controls.Add(this.rtBilling);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.lblCost);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.RichTextBox rtBilling;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button btnShip;
        private System.Windows.Forms.RichTextBox rtShipping;
        private System.Windows.Forms.RichTextBox rtItem;
        private System.Windows.Forms.Button btnItem;
    }
}

