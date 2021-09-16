
namespace AuthorizationPR
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImgDecor1 = new System.Windows.Forms.PictureBox();
            this.ImgDecor2 = new System.Windows.Forms.PictureBox();
            this.LabelLogo = new System.Windows.Forms.Label();
            this.BtnRegistration = new System.Windows.Forms.Button();
            this.BtnAuthorization = new System.Windows.Forms.Button();
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
            this.ImgDecor1.TabIndex = 0;
            this.ImgDecor1.TabStop = false;
            // 
            // ImgDecor2
            // 
            this.ImgDecor2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ImgDecor2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ImgDecor2.Location = new System.Drawing.Point(0, 398);
            this.ImgDecor2.Name = "ImgDecor2";
            this.ImgDecor2.Size = new System.Drawing.Size(800, 52);
            this.ImgDecor2.TabIndex = 1;
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
            this.LabelLogo.TabIndex = 2;
            this.LabelLogo.Text = "Marathon Skills 2017";
            // 
            // BtnRegistration
            // 
            this.BtnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnRegistration.Location = new System.Drawing.Point(214, 151);
            this.BtnRegistration.Name = "BtnRegistration";
            this.BtnRegistration.Size = new System.Drawing.Size(360, 67);
            this.BtnRegistration.TabIndex = 3;
            this.BtnRegistration.Text = "Регистрация";
            this.BtnRegistration.UseVisualStyleBackColor = true;
            this.BtnRegistration.Click += new System.EventHandler(this.BtnRegistration_Click);
            // 
            // BtnAuthorization
            // 
            this.BtnAuthorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAuthorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAuthorization.Location = new System.Drawing.Point(214, 235);
            this.BtnAuthorization.Name = "BtnAuthorization";
            this.BtnAuthorization.Size = new System.Drawing.Size(360, 67);
            this.BtnAuthorization.TabIndex = 4;
            this.BtnAuthorization.Text = "Вход";
            this.BtnAuthorization.UseVisualStyleBackColor = true;
            this.BtnAuthorization.Click += new System.EventHandler(this.BtnAuthorization_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAuthorization);
            this.Controls.Add(this.BtnRegistration);
            this.Controls.Add(this.LabelLogo);
            this.Controls.Add(this.ImgDecor2);
            this.Controls.Add(this.ImgDecor1);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.ImgDecor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDecor2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgDecor1;
        private System.Windows.Forms.PictureBox ImgDecor2;
        private System.Windows.Forms.Label LabelLogo;
        private System.Windows.Forms.Button BtnRegistration;
        private System.Windows.Forms.Button BtnAuthorization;
    }
}

