using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class ServerConnection
    {
        private SAPbobsCOM.Company company = new SAPbobsCOM.Company();
        private int connectionResult;
        private int errorCode = 0;
        private string errorMessage = "";

        public string Server {get; set;}
        public string CompanyDB { get; set; }
        public string DbUserName { get; set; }
        public string DbPassword { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string LicenseServer { get; set; }
        public string SLDServer { get; set; }

        public int intservertype { get; set; }
        public int intlanguaje { get; set; }
        public int inttrusted { get; set; }
        /// <summary>
        /// Initialises server settings, sets up connection credentials and attempts
        /// a new connection to SAP Business One server.
        /// </summary>
        /// <returns>Connection result as integer. Returns 0 if connection was successful</returns>
        ///
        public int Connect()
        {
            /*
            All the server settings and user credentials used below are stored in App.config file.
            ConfigurationManager is being used to read the App.config file. 
            You can store you own settings in App.config or use actual values directly in the code:
            company.Server = "sapb1server";
            Example.App.config is included in this project, rename it to App.config and populate it with your own values.
            */

            company.Server = Server;
            company.CompanyDB = CompanyDB;
            company.SLDServer = SLDServer;
            
            switch (intservertype)
            {
                case 0:
                    company.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL;
                    break;
                case 1:
                    company.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2005;
                    break;
                case 2:
                    company.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2008;
                    break;
                case 3:
                    company.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2012;
                    break;
                case 4:
                    company.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_HANADB;
                    break;
                default:
                    break;
            }

            company.DbUserName = DbUserName;
            company.DbPassword = DbPassword;
            company.UserName = UserName;
            company.Password = Password;

            switch (intlanguaje)
            {
                case 1:
                    company.language = SAPbobsCOM.BoSuppLangs.ln_Spanish_La;
                    break;
                case 2:
                    company.language = SAPbobsCOM.BoSuppLangs.ln_English_Gb;
                    break;
                default:
                    break;
            }

            switch (inttrusted)
            {
                case 1:
                    company.UseTrusted = false;
                    break;
                case 2:
                    company.UseTrusted = true;
                    break;
                default:
                    break;
            }

            company.LicenseServer = LicenseServer;

            connectionResult = company.Connect();

            if (connectionResult != 0)
            {
                company.GetLastError(out errorCode, out errorMessage);
            }

            return connectionResult;
        }
        /// <summary>
        /// Returns SAP Business One Company Object
        /// </summary>
        /// <returns>SAPbobsCOM.Company object</returns>
        public SAPbobsCOM.Company GetCompany()
        {
            return this.company;
        }

        /// <summary>
        /// Returns last error code
        /// </summary>
        /// <returns>Last error code as integer</returns>
        public int GetErrorCode()
        {
            return this.errorCode;
        }

        /// <summary>
        /// Returns last error message
        /// </summary>
        /// <returns>Last error message as String</returns>
        public String GetErrorMessage()
        {
            return this.errorMessage;
        }
    }
}
