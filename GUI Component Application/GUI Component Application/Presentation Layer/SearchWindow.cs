using GUI_Component_Application.Business_Layer;
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
    public partial class SearchWindow : Form
    {
        MainWindow mainWin;
        public SearchWindow(MainWindow mw)
        {
            mainWin = mw;
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // Reads all filter text, builds SQL query string, and passes it to dataccess method
            string SQLString = "";

            if (cboField1.Text != "" && cboOperators1.Text != "" && txtFilter1.Text != "")
                SQLString = "select * from Components where " + FormatComboForSQL(cboField1) + " " + cboOperators1.Text + " " + ParseStringForSQL(cboOperators1, txtFilter1);

            if (cboField2.Text != "" && cboOperators2.Text != "" && txtFilter2.Text != "")
                SQLString = SQLString + " and " + FormatComboForSQL(cboField2) + " " + cboOperators2.Text + " " + ParseStringForSQL(cboOperators2, txtFilter2);

            if (cboField3.Text != "" && cboOperators3.Text != "" && txtFilter3.Text != "")
                SQLString = SQLString + " and " + FormatComboForSQL(cboField3) + " " + cboOperators3.Text + " " + ParseStringForSQL(cboOperators3, txtFilter3);

            dataGridView1.DataSource = DataAccess.SearchAllComponents(SQLString);
        }

        private void assignOperators(ComboBox cbColumn, ComboBox cbOperators)
        {
            // Changes operator combobox options depending on what filter is selected in cboField associated with it
            cbOperators.Items.Clear();
            switch (cbColumn.Text)
            {
                case "SKU":
                case "Price":
                case "Date First In Stock":
                    cbOperators.Items.Add("=");
                    cbOperators.Items.Add(">");
                    cbOperators.Items.Add("<");
                    cbOperators.Items.Add(">=");
                    cbOperators.Items.Add("<="); break;

                case "Name":
                case "Description":
                case "Category":
                case "SubCategory":
                    cbOperators.Items.Add("=");
                    cbOperators.Items.Add("Like"); break;

                case "Available":
                    cbOperators.Items.Add("="); break;
            }
        }

        private void CboField1_SelectedIndexChanged(object sender, EventArgs e)
        {
            assignOperators(cboField1, cboOperators1);
        }

        private void CboField2_SelectedIndexChanged(object sender, EventArgs e)
        {
            assignOperators(cboField2, cboOperators2);
        }

        private void CboField3_SelectedIndexChanged(object sender, EventArgs e)
        {
            assignOperators(cboField3, cboOperators3);
        }

        private void SearchWindow_Load(object sender, EventArgs e)
        {
            DataTable returnedComponentsTable = DataAccess.GetComponents();
            dataGridView1.DataSource = returnedComponentsTable = DataAccess.GetComponents();

            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            dateTimePicker3.Visible = false;
            txtFilter1.Visible = false;
            txtFilter2.Visible = false;
            txtFilter3.Visible = false;

            txtFilter1.Text = "";
            txtFilter2.Text = "";
            txtFilter3.Text = "";

            cboField1.SelectedIndex = -1;
            cboField2.SelectedIndex = -1;
            cboField3.SelectedIndex = -1;

            cboOperators1.SelectedIndex = -1;
            cboOperators2.SelectedIndex = -1;
            cboOperators3.SelectedIndex = -1;

            cboAvailable.SelectedIndex = -1;

            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            dateTimePicker3.Value = DateTime.Today;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private string ParseStringForSQL(ComboBox cbo, TextBox tb)
        {
            // Parse part of SQL string to transact SQL server format
            string returnString = "";

            if (cbo.Text == "Like")
                returnString = "'" + tb.Text + "%'";
            else if (cbo.Text == "=" && !int.TryParse(tb.Text, out int result))
                returnString = "'" + tb.Text + "'";
            else
                returnString = tb.Text;

            return returnString;
        }

        private string FormatComboForSQL(ComboBox cbo)
        {
            // Adjust SQL query to SQL server format
            string returnString = "";

            if (cbo.Text == "Date First In Stock")
                returnString = "DateFirstInStock";
            else
                returnString = cbo.Text;

            return returnString;
        }

        private void CboField2_SelectedValueChanged(object sender, EventArgs e)
        {
            cboOperators2.Text = "";
            assignOperators(cboField2, cboOperators2);

            if (cboField2.Text == "Date First In Stock")
            {
                dateTimePicker2.Visible = true;
                txtFilter2.Visible = false;
            }
            else
            {
                dateTimePicker2.Visible = false;
                txtFilter2.Text = "";
                txtFilter2.Visible = true;
            }
        }

        private void CboField3_SelectedValueChanged(object sender, EventArgs e)
        {
            cboOperators3.Text = "";
            assignOperators(cboField3, cboOperators3);

            if (cboField3.Text == "Date First In Stock")
            {
                dateTimePicker3.Visible = true;
                txtFilter3.Visible = false;
            }
            else
            {
                dateTimePicker3.Visible = false;
                txtFilter3.Text = "";
                txtFilter3.Visible = true;
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Grabs the date and formats it for the SQL string
            txtFilter1.Text = "'" + dateTimePicker1.Value.Year + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day + "'";
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            txtFilter2.Text = "'" + dateTimePicker2.Value.Year + "/" + dateTimePicker2.Value.Month + "/" + dateTimePicker2.Value.Day + "'";
        }

        private void DateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            txtFilter3.Text = "'" + dateTimePicker3.Value.Year + "/" + dateTimePicker3.Value.Month + "/" + dateTimePicker3.Value.Day + "'";
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            SearchWindow_Load(null, null);
        }

        private void CboField1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cboOperators1.Text = "";
            assignOperators(cboField1, cboOperators1);

            if (cboField1.Text == "Date First In Stock")
            {
                dateTimePicker1.Visible = true;
                txtFilter1.Visible = false;
            }
            else
            {
                dateTimePicker1.Visible = false;
                txtFilter1.Text = "";
                txtFilter1.Visible = true;
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mainWin.txtSKU.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            mainWin.txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            mainWin.txtDescription.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            mainWin.txtPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            mainWin.txtCategory.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            mainWin.txtSubcategory.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            mainWin.dateTimePicker1.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            MemoryStream ms = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[7].Value);
            mainWin.pictureBox1.Image = Image.FromStream(ms);
            mainWin.chkAvailable.Checked = bool.Parse(dataGridView1.CurrentRow.Cells[8].Value.ToString());
            mainWin.txtItemLocation.Text = "Item found in search";
        }
    }
}
