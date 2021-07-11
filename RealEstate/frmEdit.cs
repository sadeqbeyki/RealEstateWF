using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstate
{
    public partial class frmEdit : Form
    {
        IRealEstateRepository repository;
        public int itemId = 0;
        public frmEdit()
        {
            InitializeComponent();
            repository = new RestateRepository();

        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            if (itemId == 0)
            {
                this.Text = "افزودن ملک جدید";
            }
            else
            {
                this.Text = "ویرایش ملک";
                DataTable dt = repository.SelectRow(itemId);
                txtItemName.Text = dt.Rows[0][1].ToString();
                txtSquareMeters.Text = dt.Rows[0][2].ToString();
                txtOptions.Text = dt.Rows[0][3].ToString();
                txtSellerName.Text = dt.Rows[0][4].ToString();
                txtSellerMobile.Text = dt.Rows[0][5].ToString();
                txtPrice.Text = dt.Rows[0][6].ToString();
                btnSubmit.Text = "ویرایش";
            }
        }

        bool ValidateInputs()
        {
            if (txtItemName.Text == "")
            {
                MessageBox.Show("نوع ملک را وارد نمایید", "مشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtSquareMeters.Text == "")
            {
                MessageBox.Show("متراژ ملک را وارد نمایید", "مشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtOptions.Text == "")
            {
                MessageBox.Show("گزینه ها را وارد نمایید", "مشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtSellerName.Text == "")
            {
                MessageBox.Show("نام مالک را وارد نمایید", "مشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtSellerMobile.Text == "")
            {
                MessageBox.Show("شماره تماس مالک را وارد نمایید", "مشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("قیمت را وارد نمایید", "مشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                bool isSuccess;
                if (itemId == 0)
                {
                    isSuccess = repository.insertItem(txtItemName.Text,int.Parse(txtSquareMeters.Text),txtOptions.Text,txtSellerName.Text,txtSellerMobile.Text,int.Parse(txtPrice.Text));
                }
                else
                {
                    isSuccess = repository.updateItem(itemId, txtItemName.Text, int.Parse(txtSquareMeters.Text), txtOptions.Text, txtSellerName.Text, txtSellerMobile.Text, int.Parse(txtPrice.Text));
                }

                if (isSuccess == true)
                {
                    MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("عملیات با شکست مواجه شد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
