
namespace Tyuiu.VelizhaninIV.Sprint7.Project.V10.Forms
{
    partial class FormAbout_VIV
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
            this.BtnUserGuide_VIV = new System.Windows.Forms.Button();
            this.BtnAboutCreator_VIV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnUserGuide_VIV
            // 
            this.BtnUserGuide_VIV.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnUserGuide_VIV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(99)))));
            this.BtnUserGuide_VIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUserGuide_VIV.ForeColor = System.Drawing.Color.White;
            this.BtnUserGuide_VIV.Location = new System.Drawing.Point(394, 515);
            this.BtnUserGuide_VIV.Name = "BtnUserGuide_VIV";
            this.BtnUserGuide_VIV.Size = new System.Drawing.Size(92, 50);
            this.BtnUserGuide_VIV.TabIndex = 3;
            this.BtnUserGuide_VIV.Text = "Как пользоваться программой?";
            this.BtnUserGuide_VIV.UseVisualStyleBackColor = false;
            // 
            // BtnAboutCreator_VIV
            // 
            this.BtnAboutCreator_VIV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAboutCreator_VIV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(99)))));
            this.BtnAboutCreator_VIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAboutCreator_VIV.ForeColor = System.Drawing.Color.White;
            this.BtnAboutCreator_VIV.Location = new System.Drawing.Point(799, 515);
            this.BtnAboutCreator_VIV.Name = "BtnAboutCreator_VIV";
            this.BtnAboutCreator_VIV.Size = new System.Drawing.Size(85, 50);
            this.BtnAboutCreator_VIV.TabIndex = 4;
            this.BtnAboutCreator_VIV.Text = "О создателе.";
            this.BtnAboutCreator_VIV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAboutCreator_VIV.UseVisualStyleBackColor = false;
            // 
            // FormAbout_VIV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 568);
            this.Controls.Add(this.BtnAboutCreator_VIV);
            this.Controls.Add(this.BtnUserGuide_VIV);
            this.Name = "FormAbout_VIV";
            this.Text = "О программе";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnUserGuide_VIV;
        private System.Windows.Forms.Button BtnAboutCreator_VIV;
    }
}