
namespace AuthorizationPR
{
    partial class User
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.FormLogoLabel.TabIndex = 9;
            this.FormLogoLabel.Text = "Меню пользователя";
            this.FormLogoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(214, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "в разработке...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FormLogoLabel);
            this.Controls.Add(this.LabelLogo);
            this.Controls.Add(this.ImgDecor2);
            this.Controls.Add(this.ImgDecor1);
            this.MaximizeBox = false;
            this.Name = "User";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню Пользователя";
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
        private System.Windows.Forms.Label label1;
    }
}