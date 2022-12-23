namespace Prodect_Managmenet.PL
{
    partial class FRM_CUSTOMERS_LIST
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
            this.data_cust = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_cust)).BeginInit();
            this.SuspendLayout();
            // 
            // data_cust
            // 
            this.data_cust.AllowUserToAddRows = false;
            this.data_cust.AllowUserToDeleteRows = false;
            this.data_cust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_cust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_cust.Location = new System.Drawing.Point(0, 0);
            this.data_cust.Name = "data_cust";
            this.data_cust.Size = new System.Drawing.Size(597, 307);
            this.data_cust.TabIndex = 0;
            this.data_cust.DoubleClick += new System.EventHandler(this.data_cust_DoubleClick);
            // 
            // FRM_CUSTOMERS_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 307);
            this.Controls.Add(this.data_cust);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_CUSTOMERS_LIST";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لائحة جميع العملاء";
            this.Load += new System.EventHandler(this.FRM_CUSTOMERS_LIST_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_cust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView data_cust;
    }
}