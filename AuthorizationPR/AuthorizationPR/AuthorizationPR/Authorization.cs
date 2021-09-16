using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthorizationPR
{
    public partial class Authorization : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.ConnectionString);
        SqlCommand cum = new SqlCommand();
        //
        int RoleID;

        public Authorization()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (BoxLogin.Text != "" && BoxPassword.Text != "")
            {
                cum = new SqlCommand($"SELECT [Role ID] FROM Users WHERE Login = '" + BoxLogin.Text + "'", con);
                //
                con.Open();
                RoleID = Convert.ToInt32(cum.ExecuteScalar());
                //
                cum = new SqlCommand("SELECT Login FROM Users WHERE Login LIKE @Login AND Password LIKE @Password", con);
                cum.Parameters.AddWithValue("@Login", BoxLogin.Text);
                cum.Parameters.AddWithValue("@Password", BoxPassword.Text);
                //
                SqlDataReader Reader = cum.ExecuteReader();
                try
                {
                    Reader.Read();
                    if (Reader.HasRows)
                    {
                        if (RoleID == 0)
                        { this.Hide(); new Admin().Show(); }
                        else { this.Hide(); new User().Show(); }
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден", "Warning");
                    }
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Warning");
                }
                finally
                {
                    Reader.Close();
                    con.Close();
                }
            }
            else MessageBox.Show("Поле Логин и/или Пароль не заполнены", "Warning");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            BoxLogin.Clear();
            BoxPassword.Clear();
        }

        private void BtnBackwards_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main().Show();
        }
    }
}
