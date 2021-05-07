using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExcelApp
{

    public partial class Menu : Form
    {
        List<Excel> lista = new List<Excel>();
        public float cargaPorcentaje = 0;
        
        public Menu()
        {
            InitializeComponent();
            
            pantallasBindingSource.Add(new Pantallas() { Value = 0, Text = "1" });
            pantallasBindingSource.Add(new Pantallas() { Value = 1, Text = "2" });
            pantallasBindingSource.Add(new Pantallas() { Value = 2, Text = "3" });
            pantallasBindingSource.Add(new Pantallas() { Value = 3, Text = "4" });
            DrawCursorsOnForm(this.Cursor);
            ActualizaDataGridView();
           


        }

        private void ActualizaDataGridView()
        {
            try
            {
                this.pantallaExcelTableAdapter.Fill(this.inventoryDataSet.pantallaExcel);
                excelInit();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void pantallaExcelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.pantallaExcelBindingSource.EndEdit();
                
                this.tableAdapterManager.UpdateAll(this.inventoryDataSet);
                this.pantallaExcelTableAdapter.Fill(this.inventoryDataSet.pantallaExcel);
                excelInit();
                MessageBox.Show("Se a guardado los datos");

            }
            catch(Exception err)
            {
                MessageBox.Show("guaradar "+err.Message);
            }




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
            try
            {
                //   Thread carga = new Thread(() => new CargaPantalla().ShowDialog());
                //   carga.Start();
                this.Cursor = Cursors.WaitCursor;
                
                this.cerrarExcel();
                this.AbrirExcel();
                this.Cursor = Cursors.Arrow;
            //    carga.Abort();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        public void AbrirExcel()
        {
            ActualizaExcelListTodo();
            int i = 0;
            foreach (Excel excel in lista)
            {
                i++;
                cargaPorcentaje = ((i * 100) / lista.Count);
                excel.AbreConHilos();
            }

            revisa();
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
                cargaPorcentaje = ((i * 100) / lista.Count);
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
                try
                {
                    Thread mihilo = new Thread(() => new CargaPantalla().ShowDialog());
                    mihilo.Start();
                    lista[pantallaExcelDataGridView.CurrentRow.Index].AbreExel();
                    mihilo.Abort();

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
                

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

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> lista = Excel.GetName(this.textBox1.Text);
            foreach(string list in lista)
            {
                sheetBindingSource.Add(new Sheet() { Value = "0", Nombre = list });
            }
            
            
        }

        public void ActulizaExceles()
        {
            for(int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Modo == false&&lista[i].Abrir==true)
                {
                    lista[i].GuardaExcel();
                }
                if (lista[i].Modo == true && lista[i].Abrir == true)
                {
                    lista[i].AbreConHilos();
                }
                
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActulizaExceles();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            i = pantallaExcelDataGridView.Rows.Count-1;

            this.pantallaExcelDataGridView.Rows[i].Cells[3].Value = 1;
            this.pantallaExcelDataGridView.Rows[i].Cells[4].Value = 1;
            this.pantallaExcelDataGridView.Rows[i].Cells[5].Value = 1;
            this.pantallaExcelDataGridView.Rows[i].Cells[6].Value = 100;
            this.pantallaExcelDataGridView.Rows[i].Cells[7].Value = 0;
            this.pantallaExcelDataGridView.Rows[i].Cells[8].Value = 0;
        }

        private void DrawCursorsOnForm(Cursor cursor)
        {
            // If the form's cursor is not the Hand cursor and the 
            // Current cursor is the Default, Draw the specified 
            // cursor on the form in normal size and twice normal size.
            if (this.Cursor != Cursors.Hand &
              Cursor.Current == Cursors.Default)
            {
                // Draw the cursor stretched.
                Graphics graphics = this.CreateGraphics();
                Rectangle rectangle = new Rectangle(
                  new Point(10, 10), new Size(cursor.Size.Width * 2,
                  cursor.Size.Height * 2));
                cursor.DrawStretched(graphics, rectangle);

                // Draw the cursor in normal size.
                rectangle.Location = new Point(
                rectangle.Width + rectangle.Location.X,
                  rectangle.Height + rectangle.Location.Y);
                rectangle.Size = cursor.Size;
                cursor.Draw(graphics, rectangle);

                // Dispose of the cursor.
                cursor.Dispose();
            }
        }


    }
}
