using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.VelizhaninIV.Sprint7.Project.V10.Lib;
using System.IO;
using System.Diagnostics;


namespace Tyuiu.VelizhaninIV.Sprint7.Project.V10.Forms
{
    public partial class FormOrders_VIV : Form
    {
        DataService ds = new DataService();
        static string openFilePath;

        public FormOrders_VIV()
        {
            InitializeComponent();
            openFileDialog_VIV.Filter = " Значения, разделенные запятыми (*.cvs)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_VIV.Filter = " Значения, разделенные запятыми (*.cvs)|*.csv|Все файлы(*.*)|*.*";
            ChartStats_VIV.Hide();
            BtnGetData_VIV.Enabled = false;
        }

        private void BtnOpenData_VIV_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_VIV.ShowDialog();
                openFilePath = openFileDialog_VIV.FileName;

                string[,] Matrix = ds.GetMatrix(openFilePath);
                int rows = Matrix.GetLength(0);
                int columns = Matrix.GetLength(1);

                
                DataGridView_VIV.ColumnCount = columns;
                DataGridView_VIV.RowCount = rows;
                int next = this.DataGridView_VIV.CurrentRow.Index + 1;

                for (int i = 0; i < columns; i++)
                {
                    DataGridView_VIV.Columns[i].Width = 120;
                }

                DataGridView_VIV.Columns[0].HeaderText = " ID ";
                DataGridView_VIV.Columns[1].HeaderText = " Дата ";
                DataGridView_VIV.Columns[2].HeaderText = " Заказчик ";
                DataGridView_VIV.Columns[3].HeaderText = " Номер телефона ";
                DataGridView_VIV.Columns[4].HeaderText = " Сумма заказа ";
                DataGridView_VIV.Columns[5].HeaderText = " Статус оплаты ";
                DataGridView_VIV.Columns[6].HeaderText = " Статус доставки ";
                DataGridView_VIV.Columns[7].HeaderText = " Вид оплаты ";

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        DataGridView_VIV.Rows[r].Cells[c].Value = Matrix[r, c];
                    }
                }
                Matrix = ds.GetMatrix(openFilePath);
            }
            catch
            {
                MessageBox.Show("Выберите файл!", "ФАЙЛ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSaveFile_VIV_Click(object sender, EventArgs e)
        {
            {
                saveFileDialog_VIV.FileName = "OrdersNew.csv";
                saveFileDialog_VIV.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialog_VIV.ShowDialog();

                string path = saveFileDialog_VIV.FileName;

                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;

                if (fileExists)
                {
                    File.Delete(path);
                }

                int rows = DataGridView_VIV.RowCount;
                int columns = DataGridView_VIV.ColumnCount;

                string str = "";

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (j != columns - 1)
                        {
                            str = str + DataGridView_VIV.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str = str + DataGridView_VIV.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine);
                    str = "";
                }
            }
        }

        private void BtrnFind_VIV_Click(object sender, EventArgs e)
        {
            try
            {
                var data = ds.GetMatrix(openFilePath);
                var searchText = textBoxFind_VIV.Text.ToLower();
                if (string.IsNullOrEmpty(searchText)) return;
                var filteredData = new List<string[]>();
                for (int i = 0; i < data.GetLength(0); i++)
                {
                    if (data[i, 0].ToLower().Contains(searchText) || data[i, 1].ToLower().Contains(searchText)
                    || data[i, 2].ToLower().Contains(searchText) || data[i, 3].ToLower().Contains(searchText)
                    || data[i, 4].ToLower().Contains(searchText) || data[i, 5].ToLower().Contains(searchText)
                    || data[i, 6].ToLower().Contains(searchText) || data[i, 7].ToLower().Contains(searchText))
                    {
                        var row = new string[data.GetLength(1)];
                        for (int j = 0; j < row.Length; j++)
                        {
                            row[j] = data[i, j];
                        }
                        filteredData.Add(row);
                    }
                }

                var filteredDataArray = filteredData.ToArray();
                DataGridView_VIV.RowCount = filteredDataArray.Length;
                DataGridView_VIV.ColumnCount = filteredDataArray.Length == 0 ? 0 : filteredDataArray[0].Length;

                for (int r = 0; r < filteredDataArray.Length; r++)
                {
                    for (int c = 0; c < filteredDataArray[0].Length; c++)
                    {
                        DataGridView_VIV.Rows[r].Cells[c].Value = filteredDataArray[r][c];
                    }
                }
            }

            catch
            {
                MessageBox.Show("Ошибка!", "ФАЙЛ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnAddOrder_VIV_Click(object sender, EventArgs e)
        {
            DataGridView_VIV.Rows.Add();
            BtnDeleteOrder_VIV.Enabled = true;
        }

        private void BtnDeleteOrder_VIV_Click(object sender, EventArgs e)
        {
            int ind = DataGridView_VIV.SelectedCells[0].RowIndex;
            DataGridView_VIV.Rows.RemoveAt(ind);
            if (DataGridView_VIV.Rows.Count == 0) { BtnDeleteOrder_VIV.Enabled = false; }
        }

        private void ShowChart_VIV_Click(object sender, EventArgs e)
        {
            if (ChartStats_VIV.Visible != false) 
            {
                ChartStats_VIV.Hide();
                BtnGetData_VIV.Enabled = false;
            }
            else 
            {
                ChartStats_VIV.Show();
                BtnGetData_VIV.Enabled = true;
            }
        }

        private void BtnGetData_VIV_Click(object sender, EventArgs e)
        {
            ChartStats_VIV.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Сумма заказов по дням");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            foreach (DataGridViewRow row in this.DataGridView_VIV.Rows)
            {
                if (!row.IsNewRow && row.Cells[1] != null && row.Cells[4].Value != null)
                {
                    string label = row.Cells[1].Value.ToString();
                    double hours = Convert.ToDouble(row.Cells[4].Value);
                    series.Points.AddXY(label, hours);
                }
            }
            this.ChartStats_VIV.Series.Add(series);
        }
    }
}
