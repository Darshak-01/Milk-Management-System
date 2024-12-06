namespace mms
{
    partial class Payment
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cnm = new System.Windows.Forms.Label();
            this.tp = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.pay = new System.Windows.Forms.Button();
            this.can = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(231, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date";
            // 
            // cnm
            // 
            this.cnm.AutoSize = true;
            this.cnm.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnm.Location = new System.Drawing.Point(469, 247);
            this.cnm.Name = "cnm";
            this.cnm.Size = new System.Drawing.Size(259, 40);
            this.cnm.TabIndex = 0;
            this.cnm.Text = "Customer Name";
            // 
            // tp
            // 
            this.tp.AutoSize = true;
            this.tp.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp.Location = new System.Drawing.Point(469, 337);
            this.tp.Name = "tp";
            this.tp.Size = new System.Drawing.Size(234, 40);
            this.tp.TabIndex = 0;
            this.tp.Text = "Total Payment";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(460, 439);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(87, 40);
            this.date.TabIndex = 0;
            this.date.Text = "Date";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(467, 172);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(284, 45);
            this.txt_id.TabIndex = 1;
            this.txt_id.Leave += new System.EventHandler(this.txt_id_Leave);
            // 
            // pay
            // 
            this.pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay.Location = new System.Drawing.Point(251, 576);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(187, 60);
            this.pay.TabIndex = 2;
            this.pay.Text = "Payment";
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // can
            // 
            this.can.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.can.Location = new System.Drawing.Point(514, 576);
            this.can.Name = "can";
            this.can.Size = new System.Drawing.Size(187, 60);
            this.can.TabIndex = 2;
            this.can.Text = "cancel";
            this.can.UseVisualStyleBackColor = true;
            this.can.Click += new System.EventHandler(this.can_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 692);
            this.Controls.Add(this.can);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date);
            this.Controls.Add(this.tp);
            this.Controls.Add(this.cnm);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cnm;
        private System.Windows.Forms.Label tp;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.Button can;
    }
}