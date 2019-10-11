using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Component_Application.Presentation_Layer
{
    public partial class MainWindow : Form
    {
        public static int componentIndex = 0;
        DataTable c;
        byte[] picArr;
        public MainWindow()
        {
            InitializeComponent();
            if (LoginWindow.isAdmin == false)
            {
                btnAddNew.Dispose();
                btnEditCurrent.Dispose();
                btnDelete.Dispose();
                btnCancel.Dispose();
                btnSave.Dispose();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchWindow sw = new SearchWindow(this);
            sw.Show();
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            Add a = new Add();
            a.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            refreshComponentTable();
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            componentIndex = 0;
            refreshComponentTable();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            c = Business_Layer.DataAccess.GetComponents();
            if (componentIndex != c.Rows.Count - 1)
            {
                componentIndex++;
                refreshComponentTable();
            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (componentIndex != 0)
            {
                componentIndex--;
                refreshComponentTable();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refreshComponentTable()
        {
            c = Business_Layer.DataAccess.GetComponents();

            if (componentIndex > c.Rows.Count - 1)
            {
                componentIndex = c.Rows.Count - 1; // Prevents out of bounds exception after deleting the last component in the table
            }
            txtSKU.Text = c.Rows[componentIndex]["SKU"].ToString();
            txtName.Text = c.Rows[componentIndex]["Name"].ToString();
            txtPrice.Text = Math.Round(double.Parse(c.Rows[componentIndex]["Price"].ToString()), 2).ToString();
            txtCategory.Text = c.Rows[componentIndex]["Category"].ToString();
            txtSubcategory.Text = c.Rows[componentIndex]["SubCategory"].ToString();
            dateTimePicker1.Value = DateTime.Parse(c.Rows[componentIndex]["DateFirstInStock"].ToString());
            txtDescription.Text = c.Rows[componentIndex]["Description"].ToString();
            chkAvailable.Checked = bool.Parse(c.Rows[componentIndex]["Available"].ToString());
            MemoryStream ms = new MemoryStream((byte[])c.Rows[componentIndex]["Com_Image"]);
            pictureBox1.Image = Image.FromStream(ms);
            txtItemLocation.Text = $"{componentIndex + 1} of {c.Rows.Count}";
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            c = Business_Layer.DataAccess.GetComponents();
            componentIndex = c.Rows.Count - 1;
            refreshComponentTable();
        }

        private void BtnEditCurrent_Click(object sender, EventArgs e)
        {
            txtName.ReadOnly = false;
            txtPrice.ReadOnly = false;
            txtCategory.ReadOnly = false;
            txtSubcategory.ReadOnly = false;
            dateTimePicker1.Enabled = true;
            txtDescription.ReadOnly = false;
            chkAvailable.AutoCheck = true;
            pictureBox1.Enabled = true;
            pictureBox1.AllowDrop = true;
            label1.Visible = true;

            btnSearch.Visible = false;
            btnEditCurrent.Visible = false;
            btnDelete.Visible = false;
            btnAddNew.Visible = false;
            btnCancel.Visible = true;
            btnSave.Visible = true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            refreshComponentTable();
            txtName.ReadOnly = true;
            txtPrice.ReadOnly = true;
            txtCategory.ReadOnly = true;
            txtSubcategory.ReadOnly = true;
            dateTimePicker1.Enabled = false;
            txtDescription.ReadOnly = true;
            chkAvailable.AutoCheck = false;
            pictureBox1.Enabled = false;
            pictureBox1.AllowDrop = false;
            label1.Visible = false;

            btnSearch.Visible= true;
            btnEditCurrent.Visible = true;
            btnDelete.Visible = true;
            btnAddNew.Visible = true;
            btnCancel.Visible = false;
            btnSave.Visible = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ImageConverter converter = new ImageConverter();
                picArr = (byte[])converter.ConvertTo(pictureBox1.Image, typeof(byte[]));

                if (Business_Layer.DataAccess.EditComponent(int.Parse(txtSKU.Text), txtName.Text, txtDescription.Text, double.Parse(txtPrice.Text), txtCategory.Text, txtSubcategory.Text, picArr, dateTimePicker1.Value, chkAvailable.Checked))
                {
                    MessageBox.Show("Component edited successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            refreshComponentTable();
            txtName.ReadOnly = true;
            txtPrice.ReadOnly = true;
            txtCategory.ReadOnly = true;
            txtSubcategory.ReadOnly = true;
            dateTimePicker1.Enabled = false;
            txtDescription.ReadOnly = true;
            chkAvailable.AutoCheck = false;
            pictureBox1.Enabled = false;
            pictureBox1.AllowDrop = false;
            label1.Visible = false;

            btnSearch.Visible = true;
            btnEditCurrent.Visible = true;
            btnDelete.Visible = true;
            btnAddNew.Visible = true;
            btnCancel.Visible = false;
            btnSave.Visible = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this component?",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (Business_Layer.DataAccess.DeleteComponent(int.Parse(txtSKU.Text)) == true)
                {
                    MessageBox.Show("Component successfully deleted!");
                    refreshComponentTable();
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void PictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);

            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                {
                    pictureBox1.Image = Image.FromFile(fileNames[0]); // Read image from file
                }
            }
        }

        private void PictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void BtnSearch_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ExitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewHelpScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Show();
        }
    }
}
