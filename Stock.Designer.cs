using System;

namespace mms
{
    partial class Stock
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
            this.tm = new System.Windows.Forms.Label();
            this.ta = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.bm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.both = new System.Windows.Forms.Label();
            this.dot = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tm
            // 
            this.tm.AutoSize = true;
            this.tm.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tm.ForeColor = System.Drawing.Color.Red;
            this.tm.Location = new System.Drawing.Point(551, 458);
            this.tm.Name = "tm";
            this.tm.Size = new System.Drawing.Size(47, 51);
            this.tm.TabIndex = 1;
            this.tm.Text = "0";
            this.tm.Click += new System.EventHandler(this.label6_Click);
            // 
            // ta
            // 
            this.ta.AutoSize = true;
            this.ta.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ta.ForeColor = System.Drawing.Color.Red;
            this.ta.Location = new System.Drawing.Point(551, 536);
            this.ta.Name = "ta";
            this.ta.Size = new System.Drawing.Size(47, 51);
            this.ta.TabIndex = 2;
            this.ta.Text = "0";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.c.Location = new System.Drawing.Point(566, 242);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(31, 32);
            this.c.TabIndex = 3;
            this.c.Text = "0";
            this.c.Click += new System.EventHandler(this.label5_Click);
            // 
            // bm
            // 
            this.bm.AutoSize = true;
            this.bm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bm.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bm.Location = new System.Drawing.Point(566, 312);
            this.bm.Name = "bm";
            this.bm.Size = new System.Drawing.Size(31, 32);
            this.bm.TabIndex = 4;
            this.bm.Text = "0";
            this.bm.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "Buffalo Milk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cow Milk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(335, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 69);
            this.label1.TabIndex = 7;
            this.label1.Text = "Stock";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(157, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 42);
            this.label8.TabIndex = 5;
            this.label8.Text = "Both Milk";
            // 
            // both
            // 
            this.both.AutoSize = true;
            this.both.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.both.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.both.Location = new System.Drawing.Point(566, 393);
            this.both.Name = "both";
            this.both.Size = new System.Drawing.Size(31, 32);
            this.both.TabIndex = 4;
            this.both.Text = "0";
            this.both.Click += new System.EventHandler(this.label9_Click);
            // 
            // dot
            // 
            this.dot.Cursor = System.Windows.Forms.Cursors.Default;
            this.dot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.FormattingEnabled = true;
            this.dot.Items.AddRange(new object[] {
            "Morning",
            "Evening"});
            this.dot.Location = new System.Drawing.Point(306, 139);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(232, 50);
            this.dot.TabIndex = 8;
            this.dot.SelectedIndexChanged += new System.EventHandler(this.cmdDay_of_time_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(150, 458);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 42);
            this.label10.TabIndex = 5;
            this.label10.Text = "Total Milk";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(161, 542);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(251, 42);
            this.label11.TabIndex = 5;
            this.label11.Text = "Total Amount";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(306, 610);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 69);
            this.button1.TabIndex = 9;
            this.button1.Text = "save data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mms.Properties.Resources.stock2;
            this.pictureBox1.Location = new System.Drawing.Point(814, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(574, 691);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(28, 19);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(95, 42);
            this.date.TabIndex = 6;
            this.date.Text = "date";
            this.date.Visible = false;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1385, 691);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.tm);
            this.Controls.Add(this.ta);
            this.Controls.Add(this.c);
            this.Controls.Add(this.both);
            this.Controls.Add(this.bm);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label tm;
        private System.Windows.Forms.Label ta;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label bm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label both;
        private System.Windows.Forms.ComboBox dot;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label date;
    }
}