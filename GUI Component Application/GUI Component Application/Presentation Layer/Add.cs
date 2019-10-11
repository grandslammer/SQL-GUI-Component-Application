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
    public partial class Add : Form
    {
        byte[] picArr;
        public Add()
        {
            InitializeComponent();
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

                    label8.Dispose(); // Disposes the "drop image here" label
                }
            }
        }

        private void PictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPrice.Text != "" && txtDescription.Text != "" && txtCategory.Text != "" && txtSubcategory.Text != "" && pictureBox1.Image != null)
            {
                try
                {
                    ImageConverter converter = new ImageConverter();
                    picArr = (byte[])converter.ConvertTo(pictureBox1.Image, typeof(byte[]));

                    if (Business_Layer.DataAccess.AddComponent(txtName.Text, txtDescription.Text, double.Parse(txtPrice.Text), txtCategory.Text, txtSubcategory.Text, picArr, dateTimePicker1.Value, chkAvailable.Checked))
                    {
                        MessageBox.Show("Component successfully added!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill out all required fields and add an image!");
            }
        }
    }
}
