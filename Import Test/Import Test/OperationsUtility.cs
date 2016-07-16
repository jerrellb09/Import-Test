using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Import_Test
{
    public static class OperationsUtility
    {

        //public static DataTable gldTable; //Goldstar Table
        //public static DataTable calTable; //Calamp Table
        public static DataTable skyTable; //SkyPatrol Table


        public static DataTable createGoldStarDataTable(this DataTable gldTable)
        {
            //columns  
            gldTable.SetColumnsOrder("Date Time", "Serial", "Display Name", "New Location", "Address", "Event", "Speed", "Latitude", "Longitude");

            //data
            return gldTable;
        }

        public static DataTable createCalampDataTable(this DataTable calTable)
        {
            //columns  
            calTable.Columns.Add("Group ID", typeof(string));
            calTable.Columns.Add("equipment_id", typeof(string));
            calTable.Columns.Add("BornOn", typeof(string));
            calTable.Columns.Add("Event Code", typeof(string));
            calTable.Columns.Remove("GPS Timestamp");
            calTable.Columns.Remove("Device Logged Timestamp");
            calTable.Columns.Remove("Command");
            calTable.Columns.Remove("Rssi");
            calTable.Columns.Remove("Satellites");

            calTable.SetColumnsOrder("Group ID", "Account Name", "Air ID", "ESN", "equipment_id", "BornOn", "Vehicle Name", "Latitude", "Longitude", "Speed", "Received Timestamp", "Event Code", "Alert Type", "Geo Address");
            //calTable.SetColumnsOrder("Account Name", "Air ID", "ESN","Vehicle Name", "Latitude", "Longitude", "Speed", "Received Timestamp", "Alert Type", "Geo Address");

            //data 
            return calTable;
        }

        public static DataTable createSkyPatrolTable()
        {
            //columns  
            skyTable.SetColumnsOrder("Date Time", "Serial", "Display Name", "New Location", "Address", "Event", "Speed", "Latitude", "Longitude");

            //data 
            return skyTable;
        }

    }
}
