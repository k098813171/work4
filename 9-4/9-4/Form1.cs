using System;
using System.Windows.Forms;

namespace BusinessCards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerateCard_Click(object sender, EventArgs e)
        {
            try
            { 
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("請輸入姓名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();
                    return;
                }

                PhoneList phone = new PhoneList
                {
                    HomePhone = txtHomePhone.Text,
                    BusinessPhone = txtBusinessPhone.Text,
                    CellPhone = txtCellPhone.Text
                };

                Cards card = new Cards
                {
                    Name = txtName.Text,
                    Occupation = txtOccupation.Text,
                    Age = string.IsNullOrWhiteSpace(txtAge.Text) ? 0 : int.Parse(txtAge.Text),
                    Phone = phone,
                    Email = txtEmail.Text
                };

     
                string cardInfo = card.GetCard();
                rtbCardOutput.Text = FormatCardOutput(cardInfo);
            }
            catch (FormatException)
            {
                MessageBox.Show("年齡必須是數字", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAge.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatCardOutput(string cardInfo)
        {
            return "════════ 名片 ════════\n" +
                   cardInfo.Replace("\n", "\n") +
                   "\n═════════════════";
        }
    }
}