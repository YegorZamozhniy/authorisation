
namespace AuthorizationPR
{
    partial class Admin
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
            this.ImgDecor1 = new System.Windows.Forms.PictureBox();
            this.ImgDecor2 = new System.Windows.Forms.PictureBox();
            this.LabelLogo = new System.Windows.Forms.Label();
            this.FormLogoLabel = new System.Windows.Forms.Label();
            this.BtnDetails = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDisLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDecor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDecor2)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgDecor1
            // 
            this.ImgDecor1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ImgDecor1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ImgDecor1.Location = new System.Drawing.Point(0, 0);
            this.ImgDecor1.Name = "ImgDecor1";
            this.ImgDecor1.Size = new System.Drawing.Size(800, 88);
            this.ImgDecor1.TabIndex = 4;
            this.ImgDecor1.TabStop = false;
            // 
            // ImgDecor2
            // 
            this.ImgDecor2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ImgDecor2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ImgDecor2.Location = new System.Drawing.Point(0, 398);
            this.ImgDecor2.Name = "ImgDecor2";
            this.ImgDecor2.Size = new System.Drawing.Size(800, 52);
            this.ImgDecor2.TabIndex = 6;
            this.ImgDecor2.TabStop = false;
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
            this.LabelLogo.TabIndex = 7;
            this.LabelLogo.Text = "Marathon Skills 2017";
            // 
            // FormLogoLabel
            // 
            this.FormLogoLabel.BackColor = System.Drawing.Color.White;
            this.FormLogoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FormLogoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormLogoLabel.ForeColor = System.Drawing.Color.Black;
            this.FormLogoLabel.Location = new System.Drawing.Point(214, 122);
            this.FormLogoLabel.Name = "FormLogoLabel";
            this.FormLogoLabel.Size = new System.Drawing.Size(360, 33);
            this.FormLogoLabel.TabIndex = 8;
            this.FormLogoLabel.Text = "Меню администратора";
            this.FormLogoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnDetails
            // 
            this.BtnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDetails.Location = new System.Drawing.Point(214, 188);
            this.BtnDetails.Name = "BtnDetails";
            this.BtnDetails.Size = new System.Drawing.Size(360, 42);
            this.BtnDetails.TabIndex = 13;
            this.BtnDetails.Text = "Детальная информация о пользователях (CSV)";
            this.BtnDetails.UseVisualStyleBackColor = true;
            this.BtnDetails.Click += new System.EventHandler(this.BtnDetails_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(214, 236);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(360, 42);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.Text = "Добавление волонтеров (Импорт из CSV)";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDisLogin
            // 
            this.BtnDisLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDisLogin.Location = new System.Drawing.Point(214, 284);
            this.BtnDisLogin.Name = "BtnDisLogin";
            this.BtnDisLogin.Size = new System.Drawing.Size(360, 42);
            this.BtnDisLogin.TabIndex = 15;
            this.BtnDisLogin.Text = "Выход";
            this.BtnDisLogin.UseVisualStyleBackColor = true;
            this.BtnDisLogin.Click += new System.EventHandler(this.BtnDisLogin_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDisLogin);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnDetails);
            this.Controls.Add(this.FormLogoLabel);
            this.Controls.Add(this.LabelLogo);
            this.Controls.Add(this.ImgDecor2);
            this.Controls.Add(this.ImgDecor1);
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню Администратора";
            ((System.ComponentModel.ISupportInitialize)(this.ImgDecor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDecor2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgDecor1;
        private System.Windows.Forms.PictureBox ImgDecor2;
        private System.Windows.Forms.Label LabelLogo;
        private System.Windows.Forms.Label FormLogoLabel;
        private System.Windows.Forms.Button BtnDetails;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDisLogin;
    }
}