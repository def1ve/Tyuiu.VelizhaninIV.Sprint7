
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_VIV));
            this.lblAbout_VIV = new System.Windows.Forms.Label();
            this.BtnAboutCreator_VIV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAbout_VIV
            // 
            this.lblAbout_VIV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAbout_VIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAbout_VIV.Location = new System.Drawing.Point(0, 2);
            this.lblAbout_VIV.Name = "lblAbout_VIV";
            this.lblAbout_VIV.Size = new System.Drawing.Size(811, 482);
            this.lblAbout_VIV.TabIndex = 3;
            this.lblAbout_VIV.Text = resources.GetString("lblAbout_VIV.Text");
            // 
            // BtnAboutCreator_VIV
            // 
            this.BtnAboutCreator_VIV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAboutCreator_VIV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(99)))));
            this.BtnAboutCreator_VIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAboutCreator_VIV.ForeColor = System.Drawing.Color.White;
            this.BtnAboutCreator_VIV.Location = new System.Drawing.Point(726, 465);
            this.BtnAboutCreator_VIV.Name = "BtnAboutCreator_VIV";
            this.BtnAboutCreator_VIV.Size = new System.Drawing.Size(85, 50);
            this.BtnAboutCreator_VIV.TabIndex = 4;
            this.BtnAboutCreator_VIV.Text = "О создателе.";
            this.BtnAboutCreator_VIV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAboutCreator_VIV.UseVisualStyleBackColor = false;
            this.BtnAboutCreator_VIV.Click += new System.EventHandler(this.BtnAboutCreator_VIV_Click);
            // 
            // FormAbout_VIV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 517);
            this.Controls.Add(this.BtnAboutCreator_VIV);
            this.Controls.Add(this.lblAbout_VIV);
            this.Name = "FormAbout_VIV";
            this.Text = "О программе";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblAbout_VIV;
        public System.Windows.Forms.Button BtnAboutCreator_VIV;
    }
}