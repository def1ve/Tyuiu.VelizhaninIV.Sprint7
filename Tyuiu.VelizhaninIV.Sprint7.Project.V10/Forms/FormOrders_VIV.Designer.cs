
namespace Tyuiu.VelizhaninIV.Sprint7.Project.V10.Forms
{
    partial class FormOrders_VIV
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BtnOpenData_VIV = new System.Windows.Forms.Button();
            this.DataGridView_VIV = new System.Windows.Forms.DataGridView();
            this.openFileDialog_VIV = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_VIV = new System.Windows.Forms.SaveFileDialog();
            this.BtnSaveFile_VIV = new System.Windows.Forms.Button();
            this.textBoxFind_VIV = new System.Windows.Forms.TextBox();
            this.BtnFind_VIV = new System.Windows.Forms.Button();
            this.BtnAddOrder_VIV = new System.Windows.Forms.Button();
            this.BtnDeleteOrder_VIV = new System.Windows.Forms.Button();
            this.ChartStats_VIV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ShowChart_VIV = new System.Windows.Forms.Button();
            this.BtnGetData_VIV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_VIV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartStats_VIV)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOpenData_VIV
            // 
            this.BtnOpenData_VIV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(99)))));
            this.BtnOpenData_VIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpenData_VIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnOpenData_VIV.ForeColor = System.Drawing.Color.White;
            this.BtnOpenData_VIV.Location = new System.Drawing.Point(12, 12);
            this.BtnOpenData_VIV.Name = "BtnOpenData_VIV";
            this.BtnOpenData_VIV.Size = new System.Drawing.Size(83, 40);
            this.BtnOpenData_VIV.TabIndex = 0;
            this.BtnOpenData_VIV.Text = "Открыть файл";
            this.BtnOpenData_VIV.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnOpenData_VIV.UseVisualStyleBackColor = false;
            this.BtnOpenData_VIV.Click += new System.EventHandler(this.BtnOpenData_VIV_Click);
            // 
            // DataGridView_VIV
            // 
            this.DataGridView_VIV.AllowUserToAddRows = false;
            this.DataGridView_VIV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_VIV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridView_VIV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.DataGridView_VIV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_VIV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_VIV.Location = new System.Drawing.Point(101, 40);
            this.DataGridView_VIV.Name = "DataGridView_VIV";
            this.DataGridView_VIV.Size = new System.Drawing.Size(760, 514);
            this.DataGridView_VIV.TabIndex = 1;
            // 
            // openFileDialog_VIV
            // 
            this.openFileDialog_VIV.FileName = "openFileDialog_VIV";
            // 
            // BtnSaveFile_VIV
            // 
            this.BtnSaveFile_VIV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(99)))));
            this.BtnSaveFile_VIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveFile_VIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSaveFile_VIV.ForeColor = System.Drawing.Color.White;
            this.BtnSaveFile_VIV.Location = new System.Drawing.Point(12, 58);
            this.BtnSaveFile_VIV.Name = "BtnSaveFile_VIV";
            this.BtnSaveFile_VIV.Size = new System.Drawing.Size(83, 40);
            this.BtnSaveFile_VIV.TabIndex = 2;
            this.BtnSaveFile_VIV.Text = "Сохранить файл";
            this.BtnSaveFile_VIV.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSaveFile_VIV.UseVisualStyleBackColor = false;
            this.BtnSaveFile_VIV.Click += new System.EventHandler(this.BtnSaveFile_VIV_Click);
            // 
            // textBoxFind_VIV
            // 
            this.textBoxFind_VIV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFind_VIV.Location = new System.Drawing.Point(101, 14);
            this.textBoxFind_VIV.Name = "textBoxFind_VIV";
            this.textBoxFind_VIV.Size = new System.Drawing.Size(678, 20);
            this.textBoxFind_VIV.TabIndex = 3;
            // 
            // BtnFind_VIV
            // 
            this.BtnFind_VIV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFind_VIV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(99)))));
            this.BtnFind_VIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFind_VIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFind_VIV.ForeColor = System.Drawing.Color.White;
            this.BtnFind_VIV.Location = new System.Drawing.Point(785, 12);
            this.BtnFind_VIV.Name = "BtnFind_VIV";
            this.BtnFind_VIV.Size = new System.Drawing.Size(75, 22);
            this.BtnFind_VIV.TabIndex = 4;
            this.BtnFind_VIV.Text = "Поиск";
            this.BtnFind_VIV.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnFind_VIV.UseVisualStyleBackColor = false;
            this.BtnFind_VIV.Click += new System.EventHandler(this.BtrnFind_VIV_Click);
            // 
            // BtnAddOrder_VIV
            // 
            this.BtnAddOrder_VIV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(99)))));
            this.BtnAddOrder_VIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddOrder_VIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAddOrder_VIV.ForeColor = System.Drawing.Color.White;
            this.BtnAddOrder_VIV.Location = new System.Drawing.Point(12, 104);
            this.BtnAddOrder_VIV.Name = "BtnAddOrder_VIV";
            this.BtnAddOrder_VIV.Size = new System.Drawing.Size(83, 40);
            this.BtnAddOrder_VIV.TabIndex = 5;
            this.BtnAddOrder_VIV.Text = "Добавить заказ";
            this.BtnAddOrder_VIV.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAddOrder_VIV.UseVisualStyleBackColor = false;
            this.BtnAddOrder_VIV.Click += new System.EventHandler(this.BtnAddOrder_VIV_Click);
            // 
            // BtnDeleteOrder_VIV
            // 
            this.BtnDeleteOrder_VIV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(99)))));
            this.BtnDeleteOrder_VIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteOrder_VIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDeleteOrder_VIV.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteOrder_VIV.Location = new System.Drawing.Point(12, 150);
            this.BtnDeleteOrder_VIV.Name = "BtnDeleteOrder_VIV";
            this.BtnDeleteOrder_VIV.Size = new System.Drawing.Size(83, 40);
            this.BtnDeleteOrder_VIV.TabIndex = 6;
            this.BtnDeleteOrder_VIV.Text = "Удалить заказ";
            this.BtnDeleteOrder_VIV.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnDeleteOrder_VIV.UseVisualStyleBackColor = false;
            this.BtnDeleteOrder_VIV.Click += new System.EventHandler(this.BtnDeleteOrder_VIV_Click);
            // 
            // ChartStats_VIV
            // 
            this.ChartStats_VIV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartStats_VIV.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.ChartStats_VIV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartStats_VIV.Legends.Add(legend1);
            this.ChartStats_VIV.Location = new System.Drawing.Point(101, 40);
            this.ChartStats_VIV.Name = "ChartStats_VIV";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartStats_VIV.Series.Add(series1);
            this.ChartStats_VIV.Size = new System.Drawing.Size(759, 513);
            this.ChartStats_VIV.TabIndex = 7;
            this.ChartStats_VIV.Text = "chart1";
            // 
            // ShowChart_VIV
            // 
            this.ShowChart_VIV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(99)))));
            this.ShowChart_VIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowChart_VIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowChart_VIV.ForeColor = System.Drawing.Color.White;
            this.ShowChart_VIV.Location = new System.Drawing.Point(12, 196);
            this.ShowChart_VIV.Name = "ShowChart_VIV";
            this.ShowChart_VIV.Size = new System.Drawing.Size(83, 40);
            this.ShowChart_VIV.TabIndex = 8;
            this.ShowChart_VIV.Text = "Статистика продаж";
            this.ShowChart_VIV.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShowChart_VIV.UseVisualStyleBackColor = false;
            this.ShowChart_VIV.Click += new System.EventHandler(this.ShowChart_VIV_Click);
            // 
            // BtnGetData_VIV
            // 
            this.BtnGetData_VIV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(99)))));
            this.BtnGetData_VIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGetData_VIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnGetData_VIV.ForeColor = System.Drawing.Color.White;
            this.BtnGetData_VIV.Location = new System.Drawing.Point(12, 242);
            this.BtnGetData_VIV.Name = "BtnGetData_VIV";
            this.BtnGetData_VIV.Size = new System.Drawing.Size(83, 40);
            this.BtnGetData_VIV.TabIndex = 9;
            this.BtnGetData_VIV.Text = "Получить данные";
            this.BtnGetData_VIV.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGetData_VIV.UseVisualStyleBackColor = false;
            this.BtnGetData_VIV.Click += new System.EventHandler(this.BtnGetData_VIV_Click);
            // 
            // FormOrders_VIV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(863, 557);
            this.ControlBox = false;
            this.Controls.Add(this.BtnGetData_VIV);
            this.Controls.Add(this.ShowChart_VIV);
            this.Controls.Add(this.ChartStats_VIV);
            this.Controls.Add(this.BtnDeleteOrder_VIV);
            this.Controls.Add(this.BtnAddOrder_VIV);
            this.Controls.Add(this.BtnFind_VIV);
            this.Controls.Add(this.textBoxFind_VIV);
            this.Controls.Add(this.BtnSaveFile_VIV);
            this.Controls.Add(this.DataGridView_VIV);
            this.Controls.Add(this.BtnOpenData_VIV);
            this.Name = "FormOrders_VIV";
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_VIV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartStats_VIV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOpenData_VIV;
        private System.Windows.Forms.DataGridView DataGridView_VIV;
        private System.Windows.Forms.OpenFileDialog openFileDialog_VIV;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_VIV;
        private System.Windows.Forms.Button BtnSaveFile_VIV;
        private System.Windows.Forms.TextBox textBoxFind_VIV;
        private System.Windows.Forms.Button BtnFind_VIV;
        private System.Windows.Forms.Button BtnAddOrder_VIV;
        private System.Windows.Forms.Button BtnDeleteOrder_VIV;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartStats_VIV;
        private System.Windows.Forms.Button ShowChart_VIV;
        private System.Windows.Forms.Button BtnGetData_VIV;
    }
}