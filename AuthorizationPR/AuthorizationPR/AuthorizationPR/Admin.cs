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
    public partial class Admin : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.ConnectionString);
        //
        string SRC = null;

        public Admin()
        {
            InitializeComponent();
        }

        private void BtnDisLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main().Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog CSV = new OpenFileDialog();
                CSV.Filter = "CSV Files(*.csv)|.csv|All Files (*.*)|*.*";

                if (CSV.ShowDialog(this) == DialogResult.OK)
                { SRC = CSV.FileName; }

                con.Open();
                SqlCommand cum = con.CreateCommand();
                cum.CommandText = "BULK INSERT [Volunteer] FROM '" + SRC + "' WITH (FIELDTERMINATOR = ',' , ROWTERMINATOR = '\n', FIRSTROW = 2);";
                cum.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception Error)
            { MessageBox.Show(Error.Message, "Warning"); }
        }

        private void BtnDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Details().Show();
        }
    }
}
