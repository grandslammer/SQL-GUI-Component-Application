using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Component_Application.Presentation_Layer
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Click on the buttons to perform the desired action." +
                "\r\nChanges are saved immediately to the database." +
                "\r\n\r\nSearching - Select the search credentials from the dropdown lists and type what you want to search for into the textboxes. Click Run Search to see the results in the table. Start from the left and work your way to the right for each additional filter if you require them. Select a top option first." +
                "\r\nAdding - All required fields must be filled out and an image must be added." +
                "\r\nDeleting - Select the component you would like to delete and click the delete button" +
                "\r\nEditing - Select the component you would like to edit and click the edit button. Click the save button to save changes or cancel to stop editing.";
            txtSearch.Focus();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Find(txtSearch.Text, 0, richTextBox1.MaxLength, RichTextBoxFinds.None);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string[] words = txtSearch.Text.Split(',');
            foreach (string  word in words)
            {
                int startIndex = 0;
                while (startIndex < richTextBox1.TextLength)
                {
                    int wordStartIndex = richTextBox1.Find(word, startIndex, RichTextBoxFinds.None);

                    if (wordStartIndex != -1)
                    {
                        richTextBox1.SelectionStart = wordStartIndex;
                        richTextBox1.SelectionLength = word.Length;
                        richTextBox1.SelectionBackColor = Color.Red;
                    }
                    else
                        break;
                    startIndex += wordStartIndex + word.Length;
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White;
            txtSearch.Clear();
        }
    }
}
