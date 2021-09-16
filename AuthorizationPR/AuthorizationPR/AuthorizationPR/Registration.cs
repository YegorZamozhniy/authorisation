using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthorizationPR
{
    public partial class Registration : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.ConnectionString);
        SqlCommand cum = new SqlCommand();

        public Registration()
        {
            InitializeComponent();
        }

        private void BoxLogin_Validated(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(BoxLogin.Text, @"^([\w\.-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Login введён не верно.\nФормат x@x.x", "Warning");
            }
        }

        private void BtnPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Filter = " File JPG|*.jpg|File png|*.png|All files|*.*";
            try
            {
                if (OpenFile.ShowDialog(this) == DialogResult.OK)
                {
                    PictureAvatar.Image = new Bitmap(OpenFile.FileName);
                    BoxPhotoPath.Text = OpenFile.FileName.Substring(OpenFile.FileName.LastIndexOf("\\") + 1);
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Warning");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (BoxLogin.Text != "" && BoxPassword.Text != "" && BoxName.Text != "" && BoxSurname.Text != "" && BoxPassword.Text == BoxCheckPassword.Text)
            {
                try
                {
                    using (cum = new SqlCommand("SELECT Count(*) FROM Users WHERE Login=@Login", con))
                    {
                        cum.Parameters.AddWithValue("@Login", BoxLogin.Text);
                        con.Open();
                        if ((int)cum.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("Данный Логин занят", "Warning");
                        }
                        else
                        {
                            cum = new SqlCommand("INSERT INTO Users(Name, Patronymic, Surname, Login, Password, [Role ID]) SELECT @Name, @Patronymic, @Surname, @Login, @Password, @RoleID", con);
                            cum.Parameters.AddWithValue("@Name", BoxName.Text);
                            cum.Parameters.AddWithValue("@Patronymic", BoxPatronymic.Text);
                            cum.Parameters.AddWithValue("@Surname", BoxSurname.Text);
                            cum.Parameters.AddWithValue("@Login", BoxLogin.Text);
                            cum.Parameters.AddWithValue("@Password", BoxPassword.Text);
                            cum.Parameters.AddWithValue("@RoleID", 1);
                            cum.ExecuteNonQuery();
                            MessageBox.Show("Регистрация прошла успешно", "Warning");
                        }
                    }
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message, "Warning");
                }

                finally
                {
                    con.Close();
                }
            }
            else MessageBox.Show("Одно из полей не было заполнено", "Warning");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            BoxName.Clear();
            BoxPatronymic.Clear();
            BoxSurname.Clear();
            BoxPassword.Clear();
            BoxCheckPassword.Clear();
            BoxLogin.Clear();
            BoxPhotoPath.Clear();
            PictureAvatar.Image = null;
        }

        private void BtnBackwards_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main().Show();
        }
    }
}
