using System.Windows.Forms;

namespace BusinessCards
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblName;
        private TextBox txtName;
        private Label lblOccupation;
        private TextBox txtOccupation;
        private Label lblAge;
        private TextBox txtAge;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblHomePhone;
        private TextBox txtHomePhone;
        private Label lblBusinessPhone;
        private TextBox txtBusinessPhone;
        private Label lblCellPhone;
        private TextBox txtCellPhone;
        private Button btnGenerateCard;
        private RichTextBox rtbCardOutput;

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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.lblBusinessPhone = new System.Windows.Forms.Label();
            this.txtBusinessPhone = new System.Windows.Forms.TextBox();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.btnGenerateCard = new System.Windows.Forms.Button();
            this.rtbCardOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名:";

            // txtName
            this.txtName.Location = new System.Drawing.Point(120, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 20);
            this.txtName.TabIndex = 1;

            // lblOccupation
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Location = new System.Drawing.Point(20, 50);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(35, 13);
            this.lblOccupation.TabIndex = 2;
            this.lblOccupation.Text = "職業:";

            // txtOccupation
            this.txtOccupation.Location = new System.Drawing.Point(120, 47);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(150, 20);
            this.txtOccupation.TabIndex = 3;

            // lblAge
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(20, 80);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(35, 13);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "年齡:";

            // txtAge
            this.txtAge.Location = new System.Drawing.Point(120, 77);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(50, 20);
            this.txtAge.TabIndex = 5;

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 110);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(120, 107);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 20);
            this.txtEmail.TabIndex = 7;

            // lblHomePhone
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(20, 140);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(59, 13);
            this.lblHomePhone.TabIndex = 8;
            this.lblHomePhone.Text = "家用電話:";

            // txtHomePhone
            this.txtHomePhone.Location = new System.Drawing.Point(120, 137);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(150, 20);
            this.txtHomePhone.TabIndex = 9;

            // lblBusinessPhone
            this.lblBusinessPhone.AutoSize = true;
            this.lblBusinessPhone.Location = new System.Drawing.Point(20, 170);
            this.lblBusinessPhone.Name = "lblBusinessPhone";
            this.lblBusinessPhone.Size = new System.Drawing.Size(59, 13);
            this.lblBusinessPhone.TabIndex = 10;
            this.lblBusinessPhone.Text = "公司電話:";

            // txtBusinessPhone
            this.txtBusinessPhone.Location = new System.Drawing.Point(120, 167);
            this.txtBusinessPhone.Name = "txtBusinessPhone";
            this.txtBusinessPhone.Size = new System.Drawing.Size(150, 20);
            this.txtBusinessPhone.TabIndex = 11;

            // lblCellPhone
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Location = new System.Drawing.Point(20, 200);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(59, 13);
            this.lblCellPhone.TabIndex = 12;
            this.lblCellPhone.Text = "手機號碼:";

            // txtCellPhone
            this.txtCellPhone.Location = new System.Drawing.Point(120, 197);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(150, 20);
            this.txtCellPhone.TabIndex = 13;

            // btnGenerateCard
            this.btnGenerateCard.Location = new System.Drawing.Point(20, 230);
            this.btnGenerateCard.Name = "btnGenerateCard";
            this.btnGenerateCard.Size = new System.Drawing.Size(250, 30);
            this.btnGenerateCard.TabIndex = 14;
            this.btnGenerateCard.Text = "生成名片";
            this.btnGenerateCard.UseVisualStyleBackColor = true;
            this.btnGenerateCard.Click += new System.EventHandler(this.btnGenerateCard_Click);

            // rtbCardOutput
            this.rtbCardOutput.Location = new System.Drawing.Point(20, 270);
            this.rtbCardOutput.Name = "rtbCardOutput";
            this.rtbCardOutput.ReadOnly = true;
            this.rtbCardOutput.Size = new System.Drawing.Size(250, 150);
            this.rtbCardOutput.TabIndex = 15;
            this.rtbCardOutput.Text = "";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.rtbCardOutput);
            this.Controls.Add(this.btnGenerateCard);
            this.Controls.Add(this.txtCellPhone);
            this.Controls.Add(this.lblCellPhone);
            this.Controls.Add(this.txtBusinessPhone);
            this.Controls.Add(this.lblBusinessPhone);
            this.Controls.Add(this.txtHomePhone);
            this.Controls.Add(this.lblHomePhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtOccupation);
            this.Controls.Add(this.lblOccupation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "名片生成系統";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}