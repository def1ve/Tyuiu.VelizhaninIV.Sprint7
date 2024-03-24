
namespace Tyuiu.VelizhaninIV.Sprint7.Project.V10.Forms
{
    partial class FormCreator_VIV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreator_VIV));
            this.BtnAboutOK_VIV = new System.Windows.Forms.Button();
            this.pictureBox_VIV = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_VIV)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAboutOK_VIV
            // 
            this.BtnAboutOK_VIV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(99)))));
            this.BtnAboutOK_VIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAboutOK_VIV.ForeColor = System.Drawing.Color.White;
            this.BtnAboutOK_VIV.Location = new System.Drawing.Point(374, 129);
            this.BtnAboutOK_VIV.Name = "BtnAboutOK_VIV";
            this.BtnAboutOK_VIV.Size = new System.Drawing.Size(67, 36);
            this.BtnAboutOK_VIV.TabIndex = 1;
            this.BtnAboutOK_VIV.Text = "OK";
            this.BtnAboutOK_VIV.UseVisualStyleBackColor = false;
            this.BtnAboutOK_VIV.Click += new System.EventHandler(this.BtnAboutOK_VIV_Click);
            // 
            // pictureBox_VIV
            // 
            this.pictureBox_VIV.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBox_VIV.Image = global::Tyuiu.VelizhaninIV.Sprint7.Project.V10.Properties.Resources._2024_03_08;
            this.pictureBox_VIV.Location = new System.Drawing.Point(7, 3);
            this.pictureBox_VIV.Name = "pictureBox_VIV";
            this.pictureBox_VIV.Size = new System.Drawing.Size(144, 162);
            this.pictureBox_VIV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_VIV.TabIndex = 2;
            this.pictureBox_VIV.TabStop = false;
            this.pictureBox_VIV.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 117);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // FormCreator_VIV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 167);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_VIV);
            this.Controls.Add(this.BtnAboutOK_VIV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCreator_VIV";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_VIV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAboutOK_VIV;
        private System.Windows.Forms.PictureBox pictureBox_VIV;
        private System.Windows.Forms.Label label1;
    }
}