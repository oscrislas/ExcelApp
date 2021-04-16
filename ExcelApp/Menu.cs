using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExcelApp
{

    public partial class Menu : Form
    {
        List<Excel> lista = new List<Excel>();
        public Menu()
        {
            InitializeComponent();
            List<string> lista = new List<string>();
            lista.Insert(0, "1");
            lista.Insert(1, "2");
            lista.Insert(2, "3");
            lista.Insert(3, "4");

            pantallasBindingSource.Add(new Pantallas() { Value = 0, Text = "1" });
            pantallasBindingSource.Add(new Pantallas() { Value = 1, Text = "2" });
            pantallasBindingSource.Add(new Pantallas() { Value = 2, Text = "3" });
            pantallasBindingSource.Add(new Pantallas() { Value = 3, Text = "4" });

        }

        private void pantallaExcelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pantallaExcelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventoryDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.pantallaExcelTableAdapter.Fill(this.inventoryDataSet.pantallaExcel);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                excelInit();
            }
            // TODO: This line of code loads data into the 'inventoryDataSet.pantallaExcel' table. You can move, or remove it, as needed.


        }

        private async void button1_Click(object sender, EventArgs e)
        {
            AbrirExcel();
        }

        public void AbrirExcel()
        {
            ActualizaExcelListTodo();
            foreach (Excel excel in lista)
            {
                excel.AbreConHilos();
            }

           // revisa();

        }

        private void excelInit()
        {
            lista.Clear();
            for (int i = 0; i < this.pantallaExcelDataGridView.Rows.Count; i++)
            {

                int abrir = 0;
                int modo = 0;
                int fullscrem = 0;
                int.TryParse(this.pantallaExcelDataGridView.Rows[i].Cells[3].Value.ToString(), out abrir);
                int.TryParse(this.pantallaExcelDataGridView.Rows[i].Cells[4].Value.ToString(), out modo);
                int.TryParse(this.pantallaExcelDataGridView.Rows[i].Cells[5].Value.ToString(), out fullscrem);

                lista.Add(new Excel(this.pantallaExcelDataGridView.Rows[i].Cells[1].Value.ToString(), this.pantallaExcelDataGridView.Rows[i].Cells[2].Value.ToString(),
                abrir == 1, modo == 1, fullscrem == 1,
                (int)this.pantallaExcelDataGridView.Rows[i].Cells[6].Value, (int)this.pantallaExcelDataGridView.Rows[i].Cells[7].Value, (int)this.pantallaExcelDataGridView.Rows[i].Cells[8].Value));



                //        

            }
        }

        private void ActualizaExcelList()
        {
            int i = 0;
            i = pantallaExcelDataGridView.CurrentRow.Index;
            int abrir = 0;
            int modo = 0;
            int fullscrem = 0;
            int.TryParse(this.pantallaExcelDataGridView.Rows[i].Cells[3].Value.ToString(), out abrir);
            int.TryParse(this.pantallaExcelDataGridView.Rows[i].Cells[4].Value.ToString(), out modo);
            int.TryParse(this.pantallaExcelDataGridView.Rows[i].Cells[5].Value.ToString(), out fullscrem);
            this.lista[i].setNewData(this.pantallaExcelDataGridView.Rows[i].Cells[1].Value.ToString(), this.pantallaExcelDataGridView.Rows[i].Cells[2].Value.ToString(),
                abrir == 1, modo == 1, fullscrem == 1,
                (int)this.pantallaExcelDataGridView.Rows[i].Cells[6].Value, (int)this.pantallaExcelDataGridView.Rows[i].Cells[7].Value, (int)this.pantallaExcelDataGridView.Rows[i].Cells[8].Value);

        }

        private void ActualizaExcelListTodo()
        {
            for (int i = 0; i < this.pantallaExcelDataGridView.Rows.Count; i++)
            {

                int abrir = 0;
                int modo = 0;
                int fullscrem = 0;
                int.TryParse(this.pantallaExcelDataGridView.Rows[i].Cells[3].Value.ToString(), out abrir);
                int.TryParse(this.pantallaExcelDataGridView.Rows[i].Cells[4].Value.ToString(), out modo);
                int.TryParse(this.pantallaExcelDataGridView.Rows[i].Cells[5].Value.ToString(), out fullscrem);

                this.lista[i].setNewData(this.pantallaExcelDataGridView.Rows[i].Cells[1].Value.ToString(), this.pantallaExcelDataGridView.Rows[i].Cells[2].Value.ToString(),
                    abrir == 1, modo == 1, fullscrem == 1,
                    (int)this.pantallaExcelDataGridView.Rows[i].Cells[6].Value, (int)this.pantallaExcelDataGridView.Rows[i].Cells[7].Value, (int)this.pantallaExcelDataGridView.Rows[i].Cells[8].Value);  

            }
        }

        private void revisa()
        {
            for (int i = 0; i < lista.Count; i++)
            {
                while (lista[i].TypingThread.IsAlive) ;
                lista[i].mueve();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Excel.CierraExel();
        }

        private void pantallaExcelDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                this.ActualizaExcelList();
                lista[pantallaExcelDataGridView.CurrentRow.Index].AbreExel();

            }


        }

        private void pantallasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void seleccion_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                dir.Text = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }

        public string getDirText()
        {
            return dir.Text;
        }

        private void dir_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void cerrarExcel()
        {
            Excel.CierraExel();
        }

        public int countDataGridViewOpen()
        {
            int res = 0;
            for(int i=0;i< this.pantallaExcelDataGridView.Rows.Count; i++)
            {
                if (this.pantallaExcelDataGridView.Rows[i].Cells[3].Value.Equals(1))
                {
                    res++;
                }
            }
            return res;
        }
    }
}
