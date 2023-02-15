namespace Login
{
    partial class sum
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblN1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.btnSum);
            this.groupBox1.Controls.Add(this.txtN2);
            this.groupBox1.Controls.Add(this.txtN1);
            this.groupBox1.Controls.Add(this.lblN2);
            this.groupBox1.Controls.Add(this.lblN1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 149);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(326, 83);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 33);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSum
            // 
            this.btnSum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSum.Location = new System.Drawing.Point(326, 19);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(85, 33);
            this.btnSum.TabIndex = 3;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(137, 60);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(149, 20);
            this.txtN2.TabIndex = 2;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(137, 25);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(149, 20);
            this.txtN1.TabIndex = 1;
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Location = new System.Drawing.Point(33, 67);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(61, 13);
            this.lblN2.TabIndex = 1;
            this.lblN2.Text = "Second int:";
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Location = new System.Drawing.Point(33, 28);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(43, 13);
            this.lblN1.TabIndex = 0;
            this.lblN1.Text = "First int:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(137, 96);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(149, 20);
            this.txtResult.TabIndex = 5;
            this.txtResult.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(33, 103);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(64, 13);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result Sum:";
            // 
            // sum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 179);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "sum";
            this.Text = "sum";
            this.Load += new System.EventHandler(this.sum_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
    }
}