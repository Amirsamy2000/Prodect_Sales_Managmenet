namespace Prodect_Managmenet.PL
{
    partial class FRM_CATS
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
            this.datacat = new System.Windows.Forms.DataGridView();
            this.lab = new System.Windows.Forms.Label();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnpe = new System.Windows.Forms.Button();
            this.buttobtnnextn2 = new System.Windows.Forms.Button();
            this.txtcatDes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnfirst = new System.Windows.Forms.Button();
            this.txtcatID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttobtnclosen13 = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnsaveall = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnprintall = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datacat)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datacat);
            this.groupBox1.Controls.Add(this.lab);
            this.groupBox1.Controls.Add(this.btnlast);
            this.groupBox1.Controls.Add(this.btnpe);
            this.groupBox1.Controls.Add(this.buttobtnnextn2);
            this.groupBox1.Controls.Add(this.txtcatDes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnfirst);
            this.groupBox1.Controls.Add(this.txtcatID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(776, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الصنف";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // datacat
            // 
            this.datacat.AllowUserToDeleteRows = false;
            this.datacat.AllowUserToOrderColumns = true;
            this.datacat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datacat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datacat.Location = new System.Drawing.Point(6, 15);
            this.datacat.Name = "datacat";
            this.datacat.Size = new System.Drawing.Size(334, 166);
            this.datacat.TabIndex = 0;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.Location = new System.Drawing.Point(541, 150);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(37, 16);
            this.lab.TabIndex = 8;
            this.lab.Text = "label";
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(361, 147);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(75, 23);
            this.btnlast.TabIndex = 7;
            this.btnlast.Text = ">>||";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnpe
            // 
            this.btnpe.Location = new System.Drawing.Point(442, 147);
            this.btnpe.Name = "btnpe";
            this.btnpe.Size = new System.Drawing.Size(75, 23);
            this.btnpe.TabIndex = 6;
            this.btnpe.Text = ">>";
            this.btnpe.UseVisualStyleBackColor = true;
            this.btnpe.Click += new System.EventHandler(this.btnpe_Click);
            // 
            // buttobtnnextn2
            // 
            this.buttobtnnextn2.Location = new System.Drawing.Point(600, 147);
            this.buttobtnnextn2.Name = "buttobtnnextn2";
            this.buttobtnnextn2.Size = new System.Drawing.Size(75, 23);
            this.buttobtnnextn2.TabIndex = 5;
            this.buttobtnnextn2.Text = "<<";
            this.buttobtnnextn2.UseVisualStyleBackColor = true;
            this.buttobtnnextn2.Click += new System.EventHandler(this.buttobtnnextn2_Click);
            // 
            // txtcatDes
            // 
            this.txtcatDes.Location = new System.Drawing.Point(361, 41);
            this.txtcatDes.Multiline = true;
            this.txtcatDes.Name = "txtcatDes";
            this.txtcatDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtcatDes.Size = new System.Drawing.Size(293, 83);
            this.txtcatDes.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(689, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "وصف الصنف:";
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(681, 147);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(75, 23);
            this.btnfirst.TabIndex = 2;
            this.btnfirst.Text = "||<<";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // txtcatID
            // 
            this.txtcatID.Location = new System.Drawing.Point(554, 15);
            this.txtcatID.Name = "txtcatID";
            this.txtcatID.ReadOnly = true;
            this.txtcatID.Size = new System.Drawing.Size(100, 20);
            this.txtcatID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(689, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "كود الصنف:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttobtnclosen13);
            this.groupBox2.Controls.Add(this.btnsave);
            this.groupBox2.Controls.Add(this.btnsaveall);
            this.groupBox2.Controls.Add(this.btnprint);
            this.groupBox2.Controls.Add(this.btndelete);
            this.groupBox2.Controls.Add(this.btnupdate);
            this.groupBox2.Controls.Add(this.btnprintall);
            this.groupBox2.Controls.Add(this.btnadd);
            this.groupBox2.Controls.Add(this.btnnew);
            this.groupBox2.Location = new System.Drawing.Point(6, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحة";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // buttobtnclosen13
            // 
            this.buttobtnclosen13.Location = new System.Drawing.Point(136, 63);
            this.buttobtnclosen13.Name = "buttobtnclosen13";
            this.buttobtnclosen13.Size = new System.Drawing.Size(75, 23);
            this.buttobtnclosen13.TabIndex = 8;
            this.buttobtnclosen13.Text = "خروج";
            this.buttobtnclosen13.UseVisualStyleBackColor = true;
            this.buttobtnclosen13.Click += new System.EventHandler(this.buttobtnclosen13_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(257, 63);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(179, 23);
            this.btnsave.TabIndex = 7;
            this.btnsave.Text = "حفظ الصنف المحدد في ملف pdf ";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnsaveall
            // 
            this.btnsaveall.Location = new System.Drawing.Point(486, 63);
            this.btnsaveall.Name = "btnsaveall";
            this.btnsaveall.Size = new System.Drawing.Size(179, 23);
            this.btnsaveall.TabIndex = 6;
            this.btnsaveall.Text = "حفظ اللائحة الاصناف  في ملف pdf";
            this.btnsaveall.UseVisualStyleBackColor = true;
            this.btnsaveall.Click += new System.EventHandler(this.btnsaveall_Click);
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(32, 20);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(179, 23);
            this.btnprint.TabIndex = 5;
            this.btnprint.Text = "طابعة الصنف المحدد";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(484, 20);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 4;
            this.btndelete.Text = "حذف";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(394, 20);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "تعديل";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnprintall
            // 
            this.btnprintall.Location = new System.Drawing.Point(230, 20);
            this.btnprintall.Name = "btnprintall";
            this.btnprintall.Size = new System.Drawing.Size(149, 23);
            this.btnprintall.TabIndex = 2;
            this.btnprintall.Text = "طابعة كل الاصناف";
            this.btnprintall.UseVisualStyleBackColor = true;
            this.btnprintall.Click += new System.EventHandler(this.btnprintall_Click);
            // 
            // btnadd
            // 
            this.btnadd.Enabled = false;
            this.btnadd.Location = new System.Drawing.Point(579, 20);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "اضافة ";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(679, 20);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 23);
            this.btnnew.TabIndex = 0;
            this.btnnew.Text = "جديد";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // FRM_CATS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 356);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_CATS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اداراة الاصناف";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datacat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.TextBox txtcatID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcatDes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnpe;
        private System.Windows.Forms.Button buttobtnnextn2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnprintall;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button buttobtnclosen13;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnsaveall;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.DataGridView datacat;
    }
}