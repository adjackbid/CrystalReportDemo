namespace CrystalReportDemo
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ttbFrom = new System.Windows.Forms.TextBox();
            this.ttbTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ttbWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ttbItemNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // ttbFrom
            // 
            this.ttbFrom.Location = new System.Drawing.Point(111, 31);
            this.ttbFrom.Name = "ttbFrom";
            this.ttbFrom.Size = new System.Drawing.Size(287, 27);
            this.ttbFrom.TabIndex = 1;
            // 
            // ttbTo
            // 
            this.ttbTo.Location = new System.Drawing.Point(111, 81);
            this.ttbTo.Name = "ttbTo";
            this.ttbTo.Size = new System.Drawing.Size(287, 27);
            this.ttbTo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // ttbWeight
            // 
            this.ttbWeight.Location = new System.Drawing.Point(111, 133);
            this.ttbWeight.Name = "ttbWeight";
            this.ttbWeight.Size = new System.Drawing.Size(287, 27);
            this.ttbWeight.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Weight";
            // 
            // ttbItemNo
            // 
            this.ttbItemNo.Location = new System.Drawing.Point(111, 187);
            this.ttbItemNo.Name = "ttbItemNo";
            this.ttbItemNo.Size = new System.Drawing.Size(287, 27);
            this.ttbItemNo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Item No";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(311, 246);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(87, 42);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 321);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.ttbItemNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ttbWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ttbTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ttbFrom);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ttbFrom;
        private System.Windows.Forms.TextBox ttbTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttbWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ttbItemNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrint;
    }
}

