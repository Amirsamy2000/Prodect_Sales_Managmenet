namespace Prodect_Managmenet.PL
{
    partial class FRM_SETIT
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
            this.label1 = new System.Windows.Forms.Label();
            this.server = new System.Windows.Forms.TextBox();
            this.database = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbwindows = new System.Windows.Forms.RadioButton();
            this.rbsql = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم السيرفر";
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(13, 25);
            this.server.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.server.Multiline = true;
            this.server.Name = "server";
            this.server.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.server.Size = new System.Drawing.Size(359, 35);
            this.server.TabIndex = 1;
            // 
            // database
            // 
            this.database.Location = new System.Drawing.Point(13, 88);
            this.database.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.database.Multiline = true;
            this.database.Name = "database";
            this.database.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.database.Size = new System.Drawing.Size(359, 35);
            this.database.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "قاعدة البايانات";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(13, 337);
            this.password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.password.Size = new System.Drawing.Size(359, 35);
            this.password.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 337);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "كلمة المرور";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(13, 274);
            this.username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.username.Size = new System.Drawing.Size(359, 35);
            this.username.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 274);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "اسم المستتحدم";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "طريقة الدخول";
            // 
            // rbwindows
            // 
            this.rbwindows.AutoSize = true;
            this.rbwindows.Checked = true;
            this.rbwindows.Location = new System.Drawing.Point(158, 163);
            this.rbwindows.Name = "rbwindows";
            this.rbwindows.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbwindows.Size = new System.Drawing.Size(220, 24);
            this.rbwindows.TabIndex = 9;
            this.rbwindows.TabStop = true;
            this.rbwindows.Text = "Windows Authentication";
            this.rbwindows.UseVisualStyleBackColor = true;
            // 
            // rbsql
            // 
            this.rbsql.AutoSize = true;
            this.rbsql.Location = new System.Drawing.Point(143, 214);
            this.rbsql.Name = "rbsql";
            this.rbsql.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbsql.Size = new System.Drawing.Size(235, 24);
            this.rbsql.TabIndex = 10;
            this.rbsql.Text = "Sql Server authentication ";
            this.rbsql.UseVisualStyleBackColor = true;
            this.rbsql.CheckedChanged += new System.EventHandler(this.rbsql_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 431);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(190, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "حفظ الاعدادات";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(33, 431);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button3.Size = new System.Drawing.Size(190, 36);
            this.button3.TabIndex = 12;
            this.button3.Text = "خروج";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FRM_SETIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 499);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rbsql);
            this.Controls.Add(this.rbwindows);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.database);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.server);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_SETIT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "الاعدادات الاتصال بالسيرفر";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.TextBox database;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbwindows;
        private System.Windows.Forms.RadioButton rbsql;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}