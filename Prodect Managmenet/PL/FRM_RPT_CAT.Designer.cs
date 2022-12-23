namespace Prodect_Managmenet.PL
{
    partial class FRM_RPT_CAT
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
            this.RPT_CATS = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // RPT_CATS
            // 
            this.RPT_CATS.ActiveViewIndex = -1;
            this.RPT_CATS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RPT_CATS.Cursor = System.Windows.Forms.Cursors.Default;
            this.RPT_CATS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RPT_CATS.Location = new System.Drawing.Point(0, 0);
            this.RPT_CATS.Name = "RPT_CATS";
            this.RPT_CATS.Size = new System.Drawing.Size(800, 450);
            this.RPT_CATS.TabIndex = 0;
            // 
            // FRM_RPT_CAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RPT_CATS);
            this.Name = "FRM_RPT_CAT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير الصنف";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer RPT_CATS;
    }
}