using GUI_Component_Application.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Component_Application
{
    public partial class LoginWindow : Form
    {
        public static bool isAdmin = false;
        DataTable userTable;
        public LoginWindow()
        {
            InitializeComponent();
            userTable = Business_Layer.DataAccess.GetUsers();
            textBox1.Text = "Credentials for assessment purposes:\r\n\r\nAdmin User:\r\nUsername: admin\r\nPassword: 1234\r\n\r\nStandard User:\r\nUsername: employee\r\nPassword: abcd";
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            bool loginIncorrect = true;
            foreach (DataRow dr in userTable.Rows)
            {
                if (dr["UserName"].ToString() == txtUsername.Text && dr["User_Password"].ToString() == txtPassword.Text)
                {
                    loginIncorrect = false;
                    if (bool.Parse(dr["Is_Admin"].ToString()) == true)
                    {
                        isAdmin = true;
                    }

                    timer1.Enabled = true;
                }
            }
            if (loginIncorrect == true)
            {
                MessageBox.Show("Incorrect login details. Try again!");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 95)
            {
                progressBar1.Value += 5;
            }
            else if (progressBar1.Value >= 95)
            {
                timer1.Enabled = false;
                this.Hide();
                MainWindow mw = new MainWindow();
                mw.Show();
            }
        }
    }
}
