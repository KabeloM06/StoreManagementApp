namespace StoreManagementApp
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.btnRemoveItems = new System.Windows.Forms.Button();
            this.btnEditItems = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLogOut = new System.Windows.Forms.LinkLabel();
            this.welcome1 = new StoreManagementApp.UserControls.Welcome();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.lblLogOut);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnEditItems);
            this.panel1.Controls.Add(this.btnRemoveItems);
            this.panel1.Controls.Add(this.btnAddItems);
            this.panel1.Controls.Add(this.btnPlaceOrder);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 520);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.welcome1);
            this.panel2.Location = new System.Drawing.Point(210, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(755, 520);
            this.panel2.TabIndex = 0;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnPlaceOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(39, 51);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(175, 52);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            // 
            // btnAddItems
            // 
            this.btnAddItems.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAddItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.Location = new System.Drawing.Point(39, 126);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(175, 52);
            this.btnAddItems.TabIndex = 1;
            this.btnAddItems.Text = "Add Items";
            this.btnAddItems.UseVisualStyleBackColor = false;
            // 
            // btnRemoveItems
            // 
            this.btnRemoveItems.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRemoveItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItems.Location = new System.Drawing.Point(39, 277);
            this.btnRemoveItems.Name = "btnRemoveItems";
            this.btnRemoveItems.Size = new System.Drawing.Size(175, 52);
            this.btnRemoveItems.TabIndex = 2;
            this.btnRemoveItems.Text = "Remove Items";
            this.btnRemoveItems.UseVisualStyleBackColor = false;
            // 
            // btnEditItems
            // 
            this.btnEditItems.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEditItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditItems.Location = new System.Drawing.Point(39, 202);
            this.btnEditItems.Name = "btnEditItems";
            this.btnEditItems.Size = new System.Drawing.Size(175, 52);
            this.btnEditItems.TabIndex = 3;
            this.btnEditItems.Text = "Edit Items";
            this.btnEditItems.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblLogOut.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.LinkColor = System.Drawing.Color.Black;
            this.lblLogOut.Location = new System.Drawing.Point(64, 470);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(72, 19);
            this.lblLogOut.TabIndex = 5;
            this.lblLogOut.TabStop = true;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLogOut_LinkClicked);
            // 
            // welcome1
            // 
            this.welcome1.BackColor = System.Drawing.Color.White;
            this.welcome1.Location = new System.Drawing.Point(0, 0);
            this.welcome1.Name = "welcome1";
            this.welcome1.Size = new System.Drawing.Size(765, 520);
            this.welcome1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(977, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEditItems;
        private System.Windows.Forms.Button btnRemoveItems;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel lblLogOut;
        private UserControls.Welcome welcome1;
    }
}