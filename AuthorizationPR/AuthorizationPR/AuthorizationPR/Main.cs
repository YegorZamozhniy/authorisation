using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthorizationPR
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BtnAuthorization_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Authorization().Show();
        }

        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registration().Show();
        }
    }
}
