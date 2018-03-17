using System;
using System.Collections;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Reflection;

namespace App.Common {
	class DbHelper {
		private string strField = "*";
		private bool bolRelation = false;

		protected int intNumber = 100;
		protected string strTable = "";
		protected string strFindField = "";
		protected string strSelectField = "";
		protected string strWhere = "";
		protected string strOrder = "id asc";
		protected ArrayList arrRelation = new ArrayList();
		//****************************************************************************************************
		public DbHelper() {
			switch (Program.strDbType) {
				case "access":

					break;
				case "mssql":
					openMssqlConn();

					break;
				case "oracle":
					openOracleConn();

					break;
				case "mysql":

					break;
			}
		}
		//****************************************************************************************************
		//打开 mssql 数据库
		private SqlConnection openMssqlConn() {
			if (Program.mssqlConn.State == ConnectionState.Closed) {
				string strConn = "Data Source=" + Program.strDbHost + "; Initial Catalog=" + Program.strDbName + "; User ID=" + Program.strDbUsername + "; Password=" + Program.strDbPassword + ";";
				SqlConnection mssqlConn = new SqlConnection(strConn);
				Program.mssqlConn = mssqlConn;

				try {
					Program.mssqlConn.Open();
				} catch (Exception ex) {
					//Console.WriteLine(ex.Message.ToString());
				} finally {
					//Program.mssqlConn.Close();
				}
			}

			return (Program.mssqlConn);
		}
		//****************************************************************************************************
		//打开 oracle 数据库
		private OracleConnection openOracleConn() {
			if (Program.oracleConn.State == ConnectionState.Closed) {
				string connString = "User ID=" + Program.strDbUsername + "; Password=" + Program.strDbPassword + "; Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=" + Program.strDbHost + ")(PORT=" + Program.strDbProt + ")))(CONNECT_DATA=(SERVICE_NAME=" + Program.strDbName + ")));";
				OracleConnection oracleConn = new OracleConnection(connString);
				Program.oracleConn = oracleConn;

				try {
					Program.oracleConn.Open();
				} catch (Exception ex) {
					//Console.WriteLine(ex.Message.ToString());
				} finally {
					//Program.oracleConn.Close();
				}
			}

			return (Program.oracleConn);
		}
		//****************************************************************************************************
		//关闭数据库
		public void closeConn() {
			switch (Program.strDbType) {
				case "access":

					break;
				case "mssql":
					Program.mssqlConn.Close();

					break;
				case "oracle":
					Program.oracleConn.Close();

					break;
				case "mysql":

					break;
			}
		}
		//****************************************************************************************************
		//设置 查询字段
		public DbHelper setField(string strField, string strFieldType = "select") {
			if (strField != "") {
				if (strFieldType == "select") {
					this.strField = strField;
				} else if (strFieldType == "find") {
					this.strField = strField;
				}
			}

			return (this);
		}
		//****************************************************************************************************
		//设置 关联模型
		public DbHelper setRelation(bool bol) {
			bolRelation = true;

			return (this);
		}
		//****************************************************************************************************
		//设置 查询条件
		public DbHelper setWhere(string strWhere, bool isCover = false) {
			if (strWhere != "") {
				if (isCover) {
					this.strWhere = strWhere;
				} else {
					if (this.strWhere == "") {
						this.strWhere = strWhere;
					} else {
						this.strWhere += " and " + strWhere;
					}
				}
			}

			return (this);
		}
		//****************************************************************************************************
		//设置 查询排序
		public DbHelper setOrder(string strOrder) {
			if (strOrder != "") {
				this.strOrder = strOrder;
			}

			return (this);
		}
		//****************************************************************************************************
		//批量保存
		public void setSaveAll() {

		}
		//****************************************************************************************************
		//删除
		public int setDelete(int intId) {
			int n = 0;

			string strSql = "delete from " + Program.strDbPrefix + strTable + " where id = " + intId.ToString();

			switch (Program.strDbType) {
				case "access":

					break;
				case "mssql":
					SqlCommand mssqlCommand = new SqlCommand(strSql, Program.mssqlConn);
					n = mssqlCommand.ExecuteNonQuery();

					break;
				case "oracle":
					OracleCommand oracleCommand = new OracleCommand(strSql, Program.oracleConn);
					n = oracleCommand.ExecuteNonQuery();

					break;
				case "mysql":

					break;
			}

			return (n);
		}
		//****************************************************************************************************
		//查询多笔记录
		public DataTable getSelect() {
			DataSet ds = new DataSet();

			switch (Program.strDbType) {
				case "access":

					break;
				case "mssql":
					SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(parseSelectSql("select"), Program.mssqlConn);
					sqlDataAdapter.Fill(ds);

					break;
				case "oracle":
					OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(parseSelectSql("select"), Program.oracleConn);
					oracleDataAdapter.Fill(ds);

					break;
				case "mysql":

					break;
			}

			if (ds.Tables[0].Rows.Count == 0) {
				return (null);
			} else {
				return (ds.Tables[0]);
			}
		}
		//****************************************************************************************************
		//查询单笔记录
		public DataRow getFind(int intId = 0) {
			if (intId > 0) {
				setWhere("id = " + intId.ToString());
			}

			DataSet ds = new DataSet();

			switch (Program.strDbType) {
				case "access":

					break;
				case "mssql":
					SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(parseSelectSql("find"), Program.mssqlConn);
					sqlDataAdapter.Fill(ds);

					break;
				case "oracle":
					OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(parseSelectSql("find"), Program.oracleConn);
					oracleDataAdapter.Fill(ds);

					break;
				case "mysql":

					break;
			}

			if (ds.Tables[0].Rows.Count == 0) {
				return (null);
			} else {
				return (ds.Tables[0].Rows[0]);
			}
		}
		//****************************************************************************************************
		//保存
		public int setSave(Hashtable ht) {
			int n = 0;
			string strSql = "";

			strTable = Program.strDbPrefix + strTable;

			if (Convert.ToInt32(ht["id"]) == 0) {
				strSql = "insert into " + strTable + " (";

				foreach (DictionaryEntry de in ht) {
					if (de.Key.ToString() != "id") {
						if (n > 0) {
							strSql += ", ";
						}

						strSql += de.Key;
						n++;
					}
				}

				n = 0;
				strSql += ") values (";

				foreach (DictionaryEntry de in ht) {
					if (de.Key.ToString() != "id") {
						if (n > 0) {
							strSql += ", ";
						}

						strSql += "'" + de.Value + "'";
						n++;
					}
				}

				strSql += ")";
			} else {
				strSql = "update " + strTable + " set ";

				foreach (DictionaryEntry de in ht) {
					if (de.Key.ToString() != "id") {
						if (n > 0) {
							strSql += ", ";
						}

						strSql += de.Key + " = '" + de.Value + "'";
						n++;
					}
				}

				strSql += " where id = " + ht["id"].ToString();
			}

			int intRows = 0;

			switch (Program.strDbType) {
				case "access":

					break;
				case "mssql":
					SqlCommand sqlCommand = new SqlCommand(strSql, Program.mssqlConn);
					intRows = sqlCommand.ExecuteNonQuery();

					break;
				case "oracle":
					OracleCommand oracleCommand = new OracleCommand(strSql, Program.oracleConn);
					intRows = oracleCommand.ExecuteNonQuery();

					break;
				case "mysql":

					break;
			}

			return (intRows);
		}
		//****************************************************************************************************
		//查找字段
		public string getField(string strField) {
			DataSet ds = new DataSet();

			switch (Program.strDbType) {
				case "access":

					break;
				case "mssql":
					SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(parseSelectSql("find"), Program.mssqlConn);
					sqlDataAdapter.Fill(ds);

					break;
				case "oracle":
					OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(parseSelectSql("find"), Program.oracleConn);
					oracleDataAdapter.Fill(ds);

					break;
				case "mysql":

					break;
			}

			if (ds.Tables[0].Rows.Count == 0) {
				return ("");
			} else {
				return (ds.Tables[0].Rows[0][strField].ToString());
			}
		}
		//****************************************************************************************************
		//统计数量
		public int getCount() {
			return (0);
		}
		//****************************************************************************************************
		//合计
		public float getSum(string strField, int intDecimal = 2) {
			return (0);
		}
		//****************************************************************************************************
		//最大值
		public float getMax(string strField) {
			return (0);
		}
		//****************************************************************************************************
		//最小值
		public float getMin(string strField) {
			return (0);
		}
		//****************************************************************************************************
		//平均值
		public float getAvg(string strField) {
			return (0);
		}
		//****************************************************************************************************
		//执行 sql 语句
		public int getQuery(string strSql) {
			int n = 0;

			switch (Program.strDbType) {
				case "access":

					break;
				case "mssql":
					SqlCommand sqlCommand = new SqlCommand(strSql, Program.mssqlConn);
					n = sqlCommand.ExecuteNonQuery();

					break;
				case "oracle":
					OracleCommand oracleCommand = new OracleCommand(strSql, Program.oracleConn);
					n = oracleCommand.ExecuteNonQuery();

					break;
				case "mysql":

					break;
			}

			return (n);
		}
		//****************************************************************************************************
		private string parseSelectSql(string strSelectType = "select") {
			string strSql = "select ";

			if ((Program.strDbType == "access") || (Program.strDbType == "mssql")) {
				if (strSelectType == "find") {
					strSql += " top 1 ";
				}
			}

			strSql += parseField();
			strSql += parseTable();
			strSql += parseWhere(strSelectType);
			strSql += parseOrder();

			return (strSql);
		}
		//****************************************************************************************************
		private string parseField() {
			string str = strField;

			if (bolRelation) {
				foreach (string[] arrModel in this.arrRelation) {
					str += ", " + arrModel[2];
				}
			}

			return (str);
		}
		//****************************************************************************************************
		private string parseTable() {
			string str = " from " + Program.strDbPrefix + this.strTable;

			if (bolRelation) {
				foreach (string[] arrModel in this.arrRelation) {
					Assembly assm = Assembly.GetAssembly(this.GetType());
					DbHelper db = (DbHelper)assm.CreateInstance("App.Model." + arrModel[0]);

					string strModelTable = Program.strDbPrefix + db.strTable;

					str += " inner join " + strModelTable + " on " + Program.strDbPrefix + this.strTable + "." + arrModel[1] + " = " + strModelTable + ".id";
				}
			}

			return (str);
		}
		//****************************************************************************************************
		private string parseWhere(string strSelectType = "select") {
			string str = "";

			if (strWhere.Trim() != "") {
				if (bolRelation) {
					str = " where " + Program.strDbPrefix + strTable + "." + strWhere;
				} else {
					str = " where " + strWhere;
				}
			}

			if (Program.strDbType == "oracle") {
				if (strSelectType == "find") {
					if (str == "") {
						str = " where ";
					} else {
						str += " and ";
					}
					
					str += "(rownum <= 1)";
				}
			}

			return (str);
		}
		//****************************************************************************************************
		private string parseOrder() {
			string str = " order by ";

			if (bolRelation) {
				str += Program.strDbPrefix + this.strTable + "." + strOrder;
			} else {
				str += strOrder;
			}

			return (str);
		}
		//****************************************************************************************************
	}
}
