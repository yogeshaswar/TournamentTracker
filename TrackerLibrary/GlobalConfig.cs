using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {

        //public static string ConnString = "";
        public static List<IDataConnection> Connections = new List<IDataConnection>();

        public static void InitializeConnection(bool database, bool textFile) {

            if (database) {
                // TODO Connect with sql database
                SqlConnector sqlConnector = new SqlConnector();
                Connections.Add(sqlConnector);
            }

            if(textFile) { 
                // TODO Save TextFile
                TextFileConnector textFileConnector = new TextFileConnector();
                Connections.Add(textFileConnector); 
            }


            
        }

        public static string ConnString(string name) {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;    
        }
    }
}
