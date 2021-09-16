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

namespace AuthorizationPR
{
    public partial class Details : Form
    {
        TextWriter Writer;

        public Details()
        {
            InitializeComponent();
        }

        private void volunteerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.volunteerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.authorizationDB);

        }

        private void Details_Load(object sender, EventArgs e)
        {
            this.volunteerTableAdapter.Fill(this.authorizationDB.Volunteer);
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog SD = new SaveFileDialog();
            SD.Filter = "txt files (*.txt)|*.txt|CSV files|*.csv|All Files (*.*)|*.*";
            if (SD.ShowDialog(this) == DialogResult.OK)
            { Writer = new StreamWriter(SD.FileName); }

            Writer.Write("VolunteerID;Name;Patronymic;Surname;CountryCode;Gender");
            Writer.Write("\n");
            for (int i = 0; i < VolunteerTable.Rows.Count - 1; i++)
            {
                for (int j = 0; j < VolunteerTable.Columns.Count; j++)
                {
                    Writer.Write(VolunteerTable.Rows[i].Cells[j].Value.ToString() + ";");
                }
                Writer.WriteLine();
            }
            Writer.Close();
        }

        private void BtnBackwards_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin().Show();
        }
    }
}
