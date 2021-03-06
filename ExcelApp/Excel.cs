using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;
using System.Threading;
using WindowsDesktop;
using VirtualDesktop;
using ExcelApp;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ExcelApp
{


    internal class Excel : WindowsInt
    {
        public Thread TypingThread = null;
        private string nombre = null;
        private string link = null;
        private string sheet = null;
        private int zoom = 0;
        private int hand = 0;
        private int AjusteY = 0;
        private int AjusteX = 0;
        private int pantalla = 0;
        private bool modo = false;
        private bool abrir = false;
        private bool fullscrem = false;
        private IntPtr handle;
        private int escritorio = 0;
        private List<string> sheets;

        public Excel(string link, string sheet, bool abrir, bool fullsrem, bool modo, int zoom, int pantall, int esctritorio)
        {
            this.link = link;
            this.sheet = sheet;
            this.zoom = zoom;
            this.pantalla = pantall;
            this.modo = modo;
            this.abrir = abrir;
            this.fullscrem = fullsrem;
            this.escritorio = esctritorio;

        }

        public void setNewData(string link, string sheet, bool abrir, bool fullsrem, bool modo, int zoom, int pantall, int esctritorio)
        {
            this.link = link;
            this.sheet = sheet;
            this.zoom = zoom;
            this.pantalla = pantall;
            this.modo = modo;
            this.abrir = abrir;
            this.fullscrem = fullsrem;
            this.escritorio = esctritorio;
        }
        public void AbreConHilos()
        {
            this.TypingThread = new Thread(delegate () {

                AbreExel();


                // Change the status of the buttons inside the TypingThread
                // This won't throw an exception anymore !
            });
            this.TypingThread.Start();


        }

        public static List<string> GetName(string link)
        {
            List<string> sheets;
            sheets = new List<string>();
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(link);
            Microsoft.Office.Interop.Excel.Sheets excelSheets = excelWorkbook.Worksheets;
         //   this.nombre=excelWorkbook.Name;
            foreach(Microsoft.Office.Interop.Excel.Worksheet sheet in excelWorkbook.Worksheets)
            {
                sheets.Add(sheet.Name);
            }
            
            excelWorkbook.Close();
            return sheets;

        }
        public void AbreExel()
        {
            
            if (this.abrir)
            {
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                // if you want to make excel visible to user, set this property to true, false by default
                excelApp.DisplayAlerts = false;
                excelApp.Visible = true;
                excelApp.DisplayFullScreen = this.fullscrem;
                excelApp.DisplayScrollBars = false;

                // open an existing workbook
                try
                {
                    Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(this.link,
                        0, this.modo, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "",
                        true, false, 0, true, false, false);

                    excelWorkbook.Activate();

                    // get all sheets in workbook
                    Microsoft.Office.Interop.Excel.Sheets excelSheets = excelWorkbook.Worksheets;

                    Microsoft.Office.Interop.Excel.Worksheet excelWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)excelSheets.get_Item(sheet);
                    //  Microsoft.Office.Interop.Excel.Worksheet excelWorksheets = (Microsoft.Office.Interop.Excel.Worksheet)excelSheets;
                    //excelWorksheet.Activate();

                    Microsoft.Office.Interop.Excel.Range excelCell = (Microsoft.Office.Interop.Excel.Range)excelWorksheet.get_Range("A1", "A1");

                    excelWorksheet.Activate();

                    excelCell.Activate();
                    if (this.zoom != 0)
                    {
                        excelApp.ActiveWindow.Zoom = this.zoom;
                    }
                    this.handle = (IntPtr)excelApp.Hwnd;

                    this.nombre = excelWorkbook.Name;
                    excelApp.ActiveWindow.DisplayWorkbookTabs = false;
                    MueveVentana();
                   
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
                finally
                {
                //    this.mueve();
                }
            }
            

        }

        public void MueveVentana()
        {
            if (this.abrir ==true)
            {
                MakeExternalWindowBorderless(this.handle);
                SetWindowPos(this.handle, -2, Screen.AllScreens[this.pantalla].WorkingArea.X, Screen.AllScreens[this.pantalla].WorkingArea.Y + this.AjusteY, Screen.AllScreens[this.pantalla].WorkingArea.Width, Screen.AllScreens[this.pantalla].WorkingArea.Height, SWP_SHOWWINDOW);
                mueve();
            }

        }

        public void MuestraExcel()
        {
            ShowWindow(this.handle, 3);//error line
            SetForegroundWindow(this.handle);
        }

        public async void mueve()
        {
            VirtualDesktop.Desktop.FromIndex(this.escritorio).MoveWindow(this.handle);
        }

        public static void CierraExel()
        {
            System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcessesByName("Excel");
            foreach (System.Diagnostics.Process p in process)
            {
                if (!string.IsNullOrEmpty(p.ProcessName))
                {
                    try
                    {
                        p.Kill();
                    }
                    catch { }
                }
            }
        }
    }
}
