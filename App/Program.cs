using App.Dictionary;
using MySql.Data.MySqlClient;
using System;
using System.Data.OleDb;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;

namespace App {
	static class Program {
		public static OleDbConnection oleDbConnection = new OleDbConnection();
		public static SqlConnection mssqlConn = new SqlConnection();
		public static OracleConnection oracleConn = new OracleConnection();
		public static MySqlConnection mySqlConn = new MySqlConnection();

		public static string strAppName;
		public static string strDbType, strDbHost, strDbProt, strDbPath, strDbName, strDbUsername, strDbPassword, strDbPrefix;

		public static int intWorkerId = 0;
		public static int intHospitalId = 0;
		public static int intWorkerDepartmentId = 0;

		public static string strHospitalName = "";
		public static string strDepartmentName = "";
		public static string strUsername = "";
		public static string strRealname = "";

		public static XmlDocument xmlApp = new XmlDocument();
		//****************************************************************************************************
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() {
			string strXmlPath = "app.config";
			xmlApp.Load(strXmlPath);

			strAppName = xmlApp.SelectSingleNode("/config/system/appName").InnerText;

			strDbType = xmlApp.SelectSingleNode("/config/database/dbType").InnerText.ToLower();
			strDbHost = xmlApp.SelectSingleNode("/config/database/dbHost").InnerText;
			strDbProt = xmlApp.SelectSingleNode("/config/database/dbProt").InnerText;
			strDbPath = xmlApp.SelectSingleNode("/config/database/dbPath").InnerText;
			strDbName = xmlApp.SelectSingleNode("/config/database/dbName").InnerText;
			strDbUsername = xmlApp.SelectSingleNode("/config/database/dbUsername").InnerText;
			strDbPassword = xmlApp.SelectSingleNode("/config/database/dbPassword").InnerText;
			strDbPrefix = xmlApp.SelectSingleNode("/config/database/dbPrefix").InnerText;

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			//Application.Run(new App.FrmLogin());
			///Application.Run(new App.FrmMain());

			//Application.Run(new App.DrugHouse.FrmDrugSellRefundSearch());

			//Application.Run(new App.Dictionary.FrmPart());
			//Application.Run(new App.Dictionary.FrmUnit());
			//Application.Run(new App.Dictionary.FrmSample());
			//Application.Run(new App.Dictionary.FrmCureEdit());

			//Application.Run(new FrmPassword());

			Application.Run(new FrmHospital());
			//Application.Run(new FrmHospitalEdit(3));

			//Application.Run(new FrmDepartment());
			//Application.Run(new FrmDepartmentEdit(20));

			//Application.Run(new FrmWorker());
			//Application.Run(new FrmWorkerEdit(0));

			//Application.Run(new FrmDepartmentType());
			//Application.Run(new FrmDepartmentTypeEdit(0));

			//Application.Run(new FrmSmsTemplate());
			//Application.Run(new FrmSayTemplate());
			//Application.Run(new FrmRemarkTemplate());
			//Application.Run(new FrmWorkerType());

			//Application.Run(new FrmCardType());
			//Application.Run(new FrmEntity());
			//Application.Run(new FrmCertificateType());
			//Application.Run(new FrmUserSource());

			//Application.Run(new FrmUserType());
			//Application.Run(new FrmUserType(0));

			//Application.Run(new FrmJobType());
			//Application.Run(new FrmJobTypeEdit(0));

			//Application.Run(new FrmRegisterType());
			//Application.Run(new FrmRegisterType(0));

			//Application.Run(new FrmRelation());
			//Application.Run(new FrmRelationTypeEdit(0));

			//Application.Run(new FrmUserLevel());
			//Application.Run(new FrmUserLevelEdit(0));

			//预约
			//Application.Run(new FrmReserver());
			//Application.Run(new FrmReserverEdit(1));

			//导诊
			//Application.Run(new FrmCard());
			//Application.Run(new FrmCardEdit(1));

			//Application.Run(new FrmCity());
		}
		//****************************************************************************************************
	}
}
