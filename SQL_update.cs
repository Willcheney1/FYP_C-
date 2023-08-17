using NLog;

using System;
using System.Data;
using System.Text;
using QRCoder;
using Microsoft.Data.SqlClient;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration.Ini;
//code windows packages:
using System.Threading;
using System;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using static System.Net.WebRequestMethods;




namespace FYP_Alert_Server
{
    public class SQL_update
    {
        private Logger log = LogManager.GetCurrentClassLogger();
        public void SQL_Get()
        {
            //SQL

            /* For SQL - First connect to the Microsoft SQL Server
             * "TrustServerCertificate" allows bypass of authentication by trusting the certificate without validation
            */
            string connectionString = "Data Source=DESKTOP-5UQ2P7L\\SQLEXPRESS_2019;Initial Catalog=MAC_ADDRESS;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    log.Info("connected to SQL Server");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    log.Warn("Connection failed: " + ex.Message);
                }
            }

            //SQL END
        }
    }
}
