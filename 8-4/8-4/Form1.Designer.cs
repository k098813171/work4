namespace ArrayMinMaxFinder
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtNumber3 = new System.Windows.Forms.TextBox();
            this.txtNumber4 = new System.Windows.Forms.TextBox();
            this.txtNumber5 = new System.Windows.Forms.TextBox();
            this.txtNumber6 = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.txtNumber1.Location = new System.Drawing.Point(20, 20);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 20);

            this.txtNumber2.Location = new System.Drawing.Point(20, 50);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 20);

            this.txtNumber3.Location = new System.Drawing.Point(20, 80);
            this.txtNumber3.Name = "txtNumber3";
            this.txtNumber3.Size = new System.Drawing.Size(100, 20);

            this.txtNumber4.Location = new System.Drawing.Point(20, 110);
            this.txtNumber4.Name = "txtNumber4";
            this.txtNumber4.Size = new System.Drawing.Size(100, 20);

            this.txtNumber5.Location = new System.Drawing.Point(20, 140);
            this.txtNumber5.Name = "txtNumber5";
            this.txtNumber5.Size = new System.Drawing.Size(100, 20);

            this.txtNumber6.Location = new System.Drawing.Point(20, 170);
            this.txtNumber6.Name = "txtNumber6";
            this.txtNumber6.Size = new System.Drawing.Size(100, 20);

            this.btnFind.Location = new System.Drawing.Point(140, 100);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.Text = "尋找";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);

            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(20, 210);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 250);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtNumber6);
            this.Controls.Add(this.txtNumber5);
            this.Controls.Add(this.txtNumber4);
            this.Controls.Add(this.txtNumber3);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Name = "MainForm";
            this.Text = "陣列最小最大值尋找";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtNumber3;
        private System.Windows.Forms.TextBox txtNumber4;
        private System.Windows.Forms.TextBox txtNumber5;
        private System.Windows.Forms.TextBox txtNumber6;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblResult;
    }
}