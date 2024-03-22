
namespace Tyuiu.VelizhaninIV.Sprint7.Project.V10
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.PanelMenu_VIV = new System.Windows.Forms.Panel();
            this.PanelLogo_VIV = new System.Windows.Forms.Panel();
            this.btnAbout_VIV = new System.Windows.Forms.Button();
            this.btnOrders_VIV = new System.Windows.Forms.Button();
            this.PanelMenu_VIV.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu_VIV
            // 
            this.PanelMenu_VIV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.PanelMenu_VIV.Controls.Add(this.btnAbout_VIV);
            this.PanelMenu_VIV.Controls.Add(this.btnOrders_VIV);
            this.PanelMenu_VIV.Controls.Add(this.PanelLogo_VIV);
            this.PanelMenu_VIV.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu_VIV.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu_VIV.Name = "PanelMenu_VIV";
            this.PanelMenu_VIV.Size = new System.Drawing.Size(200, 544);
            this.PanelMenu_VIV.TabIndex = 0;
            this.PanelMenu_VIV.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenu_VIV_Paint);
            // 
            // PanelLogo_VIV
            // 
            this.PanelLogo_VIV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.PanelLogo_VIV.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo_VIV.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo_VIV.Name = "PanelLogo_VIV";
            this.PanelLogo_VIV.Size = new System.Drawing.Size(200, 87);
            this.PanelLogo_VIV.TabIndex = 0;
            // 
            // btnAbout_VIV
            // 
            this.btnAbout_VIV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout_VIV.FlatAppearance.BorderSize = 0;
            this.btnAbout_VIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout_VIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAbout_VIV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAbout_VIV.Image = global::Tyuiu.VelizhaninIV.Sprint7.Project.V10.Properties.Resources.info_4_32;
            this.btnAbout_VIV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout_VIV.Location = new System.Drawing.Point(0, 162);
            this.btnAbout_VIV.Name = "btnAbout_VIV";
            this.btnAbout_VIV.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAbout_VIV.Size = new System.Drawing.Size(200, 75);
            this.btnAbout_VIV.TabIndex = 2;
            this.btnAbout_VIV.Text = "О программе";
            this.btnAbout_VIV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout_VIV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout_VIV.UseVisualStyleBackColor = true;
            // 
            // btnOrders_VIV
            // 
            this.btnOrders_VIV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrders_VIV.FlatAppearance.BorderSize = 0;
            this.btnOrders_VIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders_VIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOrders_VIV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrders_VIV.Image = global::Tyuiu.VelizhaninIV.Sprint7.Project.V10.Properties.Resources.search_3_32;
            this.btnOrders_VIV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders_VIV.Location = new System.Drawing.Point(0, 87);
            this.btnOrders_VIV.Name = "btnOrders_VIV";
            this.btnOrders_VIV.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnOrders_VIV.Size = new System.Drawing.Size(200, 75);
            this.btnOrders_VIV.TabIndex = 1;
            this.btnOrders_VIV.Text = "Заказы";
            this.btnOrders_VIV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders_VIV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrders_VIV.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(849, 544);
            this.Controls.Add(this.PanelMenu_VIV);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(190, 160);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.PanelMenu_VIV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu_VIV;
        private System.Windows.Forms.Panel PanelLogo_VIV;
        private System.Windows.Forms.Button btnOrders_VIV;
        private System.Windows.Forms.Button btnAbout_VIV;
    }
}