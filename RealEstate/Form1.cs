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
    public partial class frmHome : Form
    {
        IRealEstateRepository repository;
        public frmHome()
        {
            InitializeComponent();
            repository = new RestateRepository();
        }
        private void BindGrid()
        {
            dgRealEstate.AutoGenerateColumns = false;
            dgRealEstate.Columns[0].Visible = false;
            dgRealEstate.DataSource = repository.SelectAll();

        }
        private void frmHome_Load(object sender, EventArgs e)
        {
            BindGrid();
            //dgRealEstate.DataSource = repository.SelectAll();
        }
        private void tsUpdate_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void tsAdd_Click(object sender, EventArgs e)
        {
            frmEdit frmEA = new frmEdit();
            frmEA.ShowDialog();
            if (frmEA.DialogResult == DialogResult.OK)
            {
                BindGrid();
            }
        }



        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            dgRealEstate.DataSource = repository.Search(txtSearch.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if (dgRealEstate.CurrentRow != null)
            //{
            //    int itemId = int.Parse(dgRealEstate.CurrentRow.Cells[0].Value.ToString());
            //    frmEdit frm = new frmEdit();
            //    frm.itemId = itemId;
            //    if (frm.ShowDialog() == DialogResult.OK)
            //    {
            //        BindGrid();
            //    }
            //}
        }

        private void deleteLable_Click(object sender, EventArgs e)
        {
            if (dgRealEstate.CurrentRow != null)
            {
                string itemName = dgRealEstate.CurrentRow.Cells[1].Value.ToString();
                string sellerName = dgRealEstate.CurrentRow.Cells[4].Value.ToString();
                string fullName = itemName + " " + sellerName;
                if (MessageBox.Show($"آیا از حذف {fullName} مطمعن هستید؟","توجه",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    int itemId = int.Parse(dgRealEstate.CurrentRow.Cells[0].Value.ToString());
                    repository.deleteItem(itemId);
                    BindGrid();
                }
                else
                {
                    MessageBox.Show("یک گزینه را برگزینید");
                }

            }
        }

        private void editLable_Click(object sender, EventArgs e)
        {
            if (dgRealEstate.CurrentRow != null)
            {
                int itemId = int.Parse(dgRealEstate.CurrentRow.Cells[0].Value.ToString());
                frmEdit frm = new frmEdit();
                frm.itemId = itemId;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }

        private void txtSearchX_TextChanged(object sender, EventArgs e)
        {
            dgRealEstate.DataSource = repository.Search(txtSearch.Text);
        }
    }
}
