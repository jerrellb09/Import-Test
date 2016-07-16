using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Xml.Linq;
using GenericParsing;
using Com.StellmanGreene.CSVReader;
using System.Dynamic;
using System.Security.Principal;

namespace Import_Test
{
    public partial class Form1 : Form
    {
        private DataGridView dataGridView = new DataGridView();
        private BindingSource bindingSource1 = new BindingSource();

        public  DataTable dt;

        public  DataTable gldTable; //Goldstar Table
        public  DataTable calTable; //Calamp Table
        public  DataTable skyTable; //SkyPatrol Table

        string username = WindowsIdentity.GetCurrent().Name;
        string userName = Environment.UserName;

        public Form1()
        {
            InitializeComponent();
        }
        
        //Button to show the Goldstar history table
        private void btnShowGLDTbl_Click(object sender, EventArgs e)
        {
            //MyConn = new OleDbConnection(connString);
            //MyConn.ConnectionString = connString;
            string strProvider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\jerrell.NAL\\Desktop\\GPS stuff\\Jerrell Test Database.accdb";
            string strSql = "Select * from Test_Goldstar_History";
            OleDbConnection con = new OleDbConnection(strProvider);
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            con.Open();
            //cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Test_Goldstar_History");
            con.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Test_Goldstar_History";
        }

        //Button to locate the Goldstar Locate History CSV
        private void btnGldLocateHist_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dataGridView3.DataSource = null;
            var csv = "";

            OpenFileDialog dlg = new OpenFileDialog();
           
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                csv = fileName;
            }

            gldTable = CSVReader.ReadCSVFile(csv, true);
            dataGridView3.DataSource = gldTable.DefaultView;
            dataGridView3.AutoGenerateColumns = false;

            dt = gldTable;
        }


        //Button to locate the Calamp Locate History CSV
        private void btnCalampLocateHist_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dataGridView3.DataSource= null;
            var csv = "";

            
            OpenFileDialog dlg = new OpenFileDialog();
            
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                csv = fileName;
            }

            calTable = CSVReader.ReadCSVFile(csv, true);
            dataGridView3.DataSource = calTable.DefaultView;
            dataGridView3.AutoGenerateColumns = false;

            dt = calTable;
        }

        private void btnSkyPatrolLocateHist_Click(object sender, EventArgs e)
        {
            var csv = "";

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            
            OpenFileDialog dlg = new OpenFileDialog();
            fbd.SelectedPath = "\\\\files\\Production\\GpsStore\\SkyPatrol\\SkyPatrol history downloads";
            //fbd.SelectedPath = "C:\\Users\\jerrell.nal\\Desktop";
            //dlg.ShowDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string foldername;
                foldername = fbd.SelectedPath;
                
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string fileName;
                    fileName = dlg.FileName;
                    csv = fileName;
                }
            }
            

            skyTable = CSVReader.ReadCSVFile(csv, true);
            dataGridView3.DataSource = skyTable.DefaultView;
            dataGridView3.AutoGenerateColumns = false;
            

        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            //this.dt.Clear();
            //this.dataGridView3.DataSource = null;
            //this.dataGridView3.Rows.Clear();
            //this.dataGridView3.Columns.Clear();

            //this.dataGridView3.Refresh();
            //this.dataGridView3.DataBindings.Clear();


            //    if (calTable.Columns.Count >= 1)
            //    {
            //        calTable.Clear();
            //    }
            //    //else
            //    //{
            //    //    calTable = null;
            //    //}

            //    else if (gldTable.Columns.Count >= 1)
            //    {
            //        gldTable.Clear();
            //    }
            //    //else
            //    //{
            //    //    gldTable = null;
            //    //}

            //    else if (skyTable.Columns.Count >= 1)
            //    {
            //        skyTable.Clear();
            //    }
            //    else
            //    {
            //        skyTable = null;
            //    }

            //Application.Restart();
            //InitializeComponent();
            




            //dataGridView3.Rows.Clear();

            //OperationsUtility.createCalampDataTable(calTable).Clear();
            //OperationsUtility.createGoldStarDataTable().Clear();
        }

        //Button to Export the information in the Datagrid to a CSV
        //and saving it to your desktop
        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            //if (!Convert.IsDBNull(gldTable))
            //{
            //if (dataGridView3.DataSource.Equals(gldTable.DefaultView))
            //if (!Convert.IsDBNull(gldTable))
            
            if (this.dt.IsInitialized)
            {
                if(this.dt.Equals(gldTable))
 
            {
                    //DataTable dt = OperationsUtlity.createDataTable();
                    string filename = "C:\\Users\\" + userName + "\\Desktop\\GoldstarLocateHistoryTest.csv";
                    OperationsUtility.createGoldStarDataTable(gldTable);
                    gldTable.CleanGoldStarFile();
                    gldTable.ExportToCSV(filename);


                    //gldTable.Rows.Clear();
                    //gldTable.Columns.Clear();
                    //dataGridView3.Columns.Clear();
                    //dataGridView3.Dispose();                    
                    //dt.Clear();
                    
                    //dataGridView3.Rows.Clear();
                    //gldTable.Reset();
                }          
                    else if (dt.Equals(calTable))
                    //{
                    //else if (dataGridView3.DataSource.Equals(calTable.DefaultView))
                    {
                    //DataTable dt = OperationsUtlity.createDataTable();
                    string filename = "C:\\Users\\" + userName + "\\Desktop\\CalampLocateHistoryTest.csv";
                    OperationsUtility.createCalampDataTable(calTable);
                    calTable.CleanCalampFile();
                    calTable.ExportCalToCSV(filename);
                    //calTable.Rows.Clear();
                    //calTable.Columns.Clear();
                    //dataGridView3.Columns.Clear();
                    //calTable.Clear();
                    //dt.Clear();
                }
                else if (dt.Equals(skyTable))
                {
                    string filename = "C:\\Users\\jerrell.nal\\Desktop\\SkyPatrolLocateHistoryTest.csv";
                    //OperationsUtility.createGoldStarDataTable();
                    skyTable.CleanGoldStarFile();
                    skyTable.ExportToCSV(filename);
                    skyTable.Clear();                   
                }
                else
                {
                    var message = "There is nothing to show";
                    MessageBox.Show(message);
                }
            }
        }
    }
}

