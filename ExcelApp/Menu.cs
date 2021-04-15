using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ExcelApp
{

    public partial class Menu : Form
    {
        List<Excel> lista = new List<Excel>();
        public Menu()
        {
                   InitializeComponent();
            
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
            // TODO: This line of code loads data into the 'inventoryDataSet.pantallaExcel' table. You can move, or remove it, as needed.
           

        }

        private  async void button1_Click(object sender, EventArgs e)
        {
            for(int i =0; i< this.pantallaExcelDataGridView.Rows.Count; i++)
            {
                
                int abrir = 0;
                int modo = 0;
                int fullscrem = 0;
                int.TryParse(this.pantallaExcelDataGridView.Rows[i].Cells[3].Value.ToString(), out abrir);
                int.TryParse(this.pantallaExcelDataGridView.Rows[i].Cells[4].Value.ToString(), out modo);
                int.TryParse(this.pantallaExcelDataGridView.Rows[i].Cells[5].Value.ToString(), out fullscrem);
                lista.Add(new Excel(this.pantallaExcelDataGridView.Rows[i].Cells[1].Value.ToString(), this.pantallaExcelDataGridView.Rows[i].Cells[2].Value.ToString(),
                abrir == 1, modo == 1, fullscrem == 1,
                (int)this.pantallaExcelDataGridView.Rows[i].Cells[6].Value, (int)this.pantallaExcelDataGridView.Rows[i].Cells[7].Value,(int)this.pantallaExcelDataGridView.Rows[i].Cells[8].Value));

                this.lista[i].AbreConHilos();

            }

            revisa();

        }

        private void revisa()
        {
            for(int i =0; i < lista.Count; i++)
            {
                while (lista[i].TypingThread.IsAlive) ;
                lista[i].mueve();
            }
            
        }


    }
}
