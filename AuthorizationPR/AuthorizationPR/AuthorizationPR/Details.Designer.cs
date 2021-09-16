
namespace AuthorizationPR
{
    partial class Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.VolunteerTable = new System.Windows.Forms.DataGridView();
            this.ImgDecor1 = new System.Windows.Forms.PictureBox();
            this.LabelLogo = new System.Windows.Forms.Label();
            this.ImgDecor2 = new System.Windows.Forms.PictureBox();
            this.BtnExport = new System.Windows.Forms.Button();
            this.BtnBackwards = new System.Windows.Forms.Button();
            this.volunteerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorizationDB = new AuthorizationPR.AuthorizationDB();
            this.volunteerTableAdapter = new AuthorizationPR.AuthorizationDBTableAdapters.VolunteerTableAdapter();
            this.tableAdapterManager = new AuthorizationPR.AuthorizationDBTableAdapters.TableAdapterManager();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolunteerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolunteerPatronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolunteerSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolunteerCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolunteerGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.VolunteerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDecor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDecor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volunteerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationDB)).BeginInit();
            this.SuspendLayout();
            // 
            // VolunteerTable
            // 
            this.VolunteerTable.AllowUserToAddRows = false;
            this.VolunteerTable.AllowUserToDeleteRows = false;
            this.VolunteerTable.AutoGenerateColumns = false;
            this.VolunteerTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VolunteerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VolunteerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.VolunteerName,
            this.VolunteerPatronymic,
            this.VolunteerSurname,
            this.VolunteerCountry,
            this.VolunteerGender});
            this.VolunteerTable.DataSource = this.volunteerBindingSource;
            this.VolunteerTable.Location = new System.Drawing.Point(0, 87);
            this.VolunteerTable.Name = "VolunteerTable";
            this.VolunteerTable.ReadOnly = true;
            this.VolunteerTable.Size = new System.Drawing.Size(800, 317);
            this.VolunteerTable.TabIndex = 1;
            // 
            // ImgDecor1
            // 
            this.ImgDecor1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ImgDecor1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ImgDecor1.Location = new System.Drawing.Point(0, 0);
            this.ImgDecor1.Name = "ImgDecor1";
            this.ImgDecor1.Size = new System.Drawing.Size(800, 88);
            this.ImgDecor1.TabIndex = 6;
            this.ImgDecor1.TabStop = false;
            // 
            // LabelLogo
            // 
            this.LabelLogo.AutoSize = true;
            this.LabelLogo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LabelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLogo.ForeColor = System.Drawing.Color.White;
            this.LabelLogo.Location = new System.Drawing.Point(207, 23);
            this.LabelLogo.Name = "LabelLogo";
            this.LabelLogo.Size = new System.Drawing.Size(367, 42);
            this.LabelLogo.TabIndex = 11;
            this.LabelLogo.Text = "Marathon Skills 2017";
            // 
            // ImgDecor2
            // 
            this.ImgDecor2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ImgDecor2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ImgDecor2.Location = new System.Drawing.Point(0, 398);
            this.ImgDecor2.Name = "ImgDecor2";
            this.ImgDecor2.Size = new System.Drawing.Size(800, 52);
            this.ImgDecor2.TabIndex = 12;
            this.ImgDecor2.TabStop = false;
            // 
            // BtnExport
            // 
            this.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExport.Location = new System.Drawing.Point(12, 411);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(144, 28);
            this.BtnExport.TabIndex = 28;
            this.BtnExport.Text = "Экспорт";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // BtnBackwards
            // 
            this.BtnBackwards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackwards.Location = new System.Drawing.Point(162, 411);
            this.BtnBackwards.Name = "BtnBackwards";
            this.BtnBackwards.Size = new System.Drawing.Size(144, 28);
            this.BtnBackwards.TabIndex = 29;
            this.BtnBackwards.Text = "Назад";
            this.BtnBackwards.UseVisualStyleBackColor = true;
            this.BtnBackwards.Click += new System.EventHandler(this.BtnBackwards_Click);
            // 
            // volunteerBindingSource
            // 
            this.volunteerBindingSource.DataMember = "Volunteer";
            this.volunteerBindingSource.DataSource = this.authorizationDB;
            // 
            // authorizationDB
            // 
            this.authorizationDB.DataSetName = "AuthorizationDB";
            this.authorizationDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // volunteerTableAdapter
            // 
            this.volunteerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AuthorizationPR.AuthorizationDBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.VolunteerTableAdapter = this.volunteerTableAdapter;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "VolunteerID";
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // VolunteerName
            // 
            this.VolunteerName.DataPropertyName = "Name";
            this.VolunteerName.HeaderText = "Имя";
            this.VolunteerName.Name = "VolunteerName";
            this.VolunteerName.ReadOnly = true;
            this.VolunteerName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // VolunteerPatronymic
            // 
            this.VolunteerPatronymic.DataPropertyName = "Patronymic";
            this.VolunteerPatronymic.HeaderText = "Отчество";
            this.VolunteerPatronymic.Name = "VolunteerPatronymic";
            this.VolunteerPatronymic.ReadOnly = true;
            this.VolunteerPatronymic.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // VolunteerSurname
            // 
            this.VolunteerSurname.DataPropertyName = "Surname";
            this.VolunteerSurname.HeaderText = "Фамилия";
            this.VolunteerSurname.Name = "VolunteerSurname";
            this.VolunteerSurname.ReadOnly = true;
            this.VolunteerSurname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // VolunteerCountry
            // 
            this.VolunteerCountry.DataPropertyName = "CountryCode";
            this.VolunteerCountry.HeaderText = "CountryCode";
            this.VolunteerCountry.Name = "VolunteerCountry";
            this.VolunteerCountry.ReadOnly = true;
            this.VolunteerCountry.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // VolunteerGender
            // 
            this.VolunteerGender.DataPropertyName = "Gender";
            this.VolunteerGender.HeaderText = "Пол";
            this.VolunteerGender.Name = "VolunteerGender";
            this.VolunteerGender.ReadOnly = true;
            this.VolunteerGender.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBackwards);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.ImgDecor2);
            this.Controls.Add(this.LabelLogo);
            this.Controls.Add(this.ImgDecor1);
            this.Controls.Add(this.VolunteerTable);
            this.MaximizeBox = false;
            this.Name = "Details";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Детальная информация о пользователях";
            this.Load += new System.EventHandler(this.Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VolunteerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDecor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDecor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volunteerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorizationDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AuthorizationDB authorizationDB;
        private System.Windows.Forms.BindingSource volunteerBindingSource;
        private AuthorizationDBTableAdapters.VolunteerTableAdapter volunteerTableAdapter;
        private AuthorizationDBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView VolunteerTable;
        private System.Windows.Forms.PictureBox ImgDecor1;
        private System.Windows.Forms.Label LabelLogo;
        private System.Windows.Forms.PictureBox ImgDecor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolunteerID;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.Button BtnBackwards;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolunteerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolunteerPatronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolunteerSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolunteerCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolunteerGender;
    }
}