using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace Import_Test
{
   
    public static class CSVUtility
    {
        /// <summary>
        /// Sends the datatable to a CSV file on your desktop
        /// </summary>
        /// <param name="dTable">Datable containing the CSV information</param>
        /// <param name="strFilePath">Destination where the CSV will be created</param>
        public static void ExportToCSV(this DataTable dTable, string strFilePath)
        {
            StreamWriter sw = new StreamWriter(strFilePath, false);
            
            for (int i = 0; i < dTable.Columns.Count; i++)
            {
                sw.Write(dTable.Columns[i]);
                if (i < dTable.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dTable.Rows)
            {
                for (int i = 0; i < dTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dTable.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                    if (Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(""))
                        {
                            sw.Write(value);
                        }
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }

        public static void ExportCalToCSV(this DataTable dTable, string strFilePath)
        {
            StreamWriter sw = new StreamWriter(strFilePath, false);

            //headers            
            
            //dTable.Columns.Add("NewLocation", typeof(int));
            //dTable.Columns.Add("Location", typeof(string));
            //dTable.Columns.Add("Message", typeof(string));
            //dTable.Columns.Add("Speed", typeof(int));
            //dTable.Columns.Add("Latitude", typeof(string));
            //dTable.Columns.Add("Longitude", typeof(string));
            //dTable.Columns.Add("Odometer", typeof(int));
            //dTable.Columns.Add("Heading", typeof(string));
            //dTable.Columns.Add("Status", typeof(string));
            //dTable.Columns.Add("Group", typeof(string));
            //dTable.Columns.Add("Response", typeof(string));
            //dTable.Columns.Add("Type", typeof(string));
            //dTable.Columns.Add("Traks", typeof(int));
            //dTable.Columns.Add("Sats", typeof(int));
            //dTable.Columns.Add("Evolts", typeof(double));
            //dTable.Columns.Add("User", typeof(string));
            for (int i = 0; i < dTable.Columns.Count; i++)
            {
                sw.Write(dTable.Columns[i]);
                if (i < dTable.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dTable.Rows)
            {
                for (int i = 0; i < dTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dTable.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                    if (Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(""))
                        {
                            sw.Write(value);
                        }
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }

        public static void CleanGoldStarFile(this DataTable dTable)
        {
            foreach (DataRow dr in dTable.Rows)
            {
                foreach (DataColumn col in dTable.Columns)
                {
                    if (col.ColumnName == "Display Name")
                    {
                        dr[col] = dr[col].ToString().Replace("-1", "");
                        dr[col] = dr[col].ToString().Replace("-2", "");
                        dr[col] = dr[col].ToString().Replace("-3", "");
                        dr[col] = dr[col].ToString().Replace("- 1", "");
                        dr[col] = dr[col].ToString().Replace("- 2", "");
                        dr[col] = dr[col].ToString().Replace("- 3", "");
                        dr[col] = dr[col].ToString().Replace("-01", "");
                        dr[col] = dr[col].ToString().Replace("-02", "");
                        dr[col] = dr[col].ToString().Replace("-03", "");
                        dr[col] = dr[col].ToString().Replace("_1", "");
                        dr[col] = dr[col].ToString().Replace("_2", "");
                        dr[col] = dr[col].ToString().Replace("_3", "");
                    }
                    if (col.ColumnName == "Speed")
                    {
                        dr[col] = dr[col].ToString().Replace("mph", "");
                    }
                }

            }

        }

        public static void CleanCalampFile(this DataTable dTable)
        {
            foreach (DataRow dr in dTable.Rows)
            {
                foreach (DataColumn col in dTable.Columns)
                {
                    if (col.ColumnName == "Vehicle Name")
                    {
                        dr[col] = dr[col].ToString().Replace("-1", "");
                        dr[col] = dr[col].ToString().Replace("-2", "");
                        dr[col] = dr[col].ToString().Replace("-3", "");
                        dr[col] = dr[col].ToString().Replace("- 1", "");
                        dr[col] = dr[col].ToString().Replace("- 2", "");
                        dr[col] = dr[col].ToString().Replace("- 3", "");
                        dr[col] = dr[col].ToString().Replace("-01", "");
                        dr[col] = dr[col].ToString().Replace("-02", "");
                        dr[col] = dr[col].ToString().Replace("-03", "");
                        dr[col] = dr[col].ToString().Replace("_1", "");
                        dr[col] = dr[col].ToString().Replace("_2", "");
                        dr[col] = dr[col].ToString().Replace("_3", "");
                    }
                    if (col.ColumnName == "Speed")
                    {
                        dr[col] = dr[col].ToString().Replace("mph", "");
                    }
                    if (col.ColumnName == "Geo Address")
                    {
                        dr[col] = dr[col].ToString().Replace(" ", ",");
                    }

                    //if (col.ColumnName == "Group ID")
                    //{
                    //    dr[col] = dr[col].ToString().Replace("", " ");
                    //}
                    //if (col.ColumnName == "BornOn")
                    //{
                    //    dr[col] = dr[col].ToString().Replace("", " ");
                    //}
                    //if (col.ColumnName == "equipment_id")
                    //{
                    //    dr[col] = dr[col].ToString().Replace(""," ");
                    //}
                }

            }

        }
    }
}
