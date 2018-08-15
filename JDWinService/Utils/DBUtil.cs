using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JDWinService.Utils
{
    public class DBUtil
    {
         
        public static string dbType = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["DBType"].Value; //数据库类型
        public static string connectionString = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["ConnectionString"].Value; //连接信息

        private static DbConnection conn;

        private static DbConnection getConn()
        {
            if (conn == null)
            {
                if (dbType == "Oracle")
                {
                    conn = new OracleConnection(connectionString);
                }
                else if (dbType == "SqlServer")
                {
                    conn = new SqlConnection(connectionString);
                }
                conn.Open();
            }
            return conn;
        }
        public static void BeginConn()
        {
            getConn();
        }
        public static void EndConn()
        {
            if (conn != null)
            {
                conn.Close();
                conn = null;
            }
        }


        public static bool Exists(string strSql)
        {
            object obj = GetSingle(strSql);
            int cmdresult;
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 执行存储过程，返回影响的行数		
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <param name="rowsAffected">影响的行数</param>
        /// <returns></returns>
        public static int RunProcedure(string storedProcName, IDataParameter[] parameters, out int rowsAffected)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int result;
                connection.Open();
                SqlCommand command = BuildIntCommand(connection, storedProcName, parameters);
                rowsAffected = command.ExecuteNonQuery();
                result = (int)command.Parameters["ReturnValue"].Value;
                //Connection.Close();
                return result;
            }
        }
        /// <summary>
        /// 创建 SqlCommand 对象实例(用来返回一个整数值)	
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>SqlCommand 对象实例</returns>
        private static SqlCommand BuildIntCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command = BuildQueryCommand(connection, storedProcName, parameters);
            command.Parameters.Add(new SqlParameter("ReturnValue",
                SqlDbType.Int, 4, ParameterDirection.ReturnValue,
                false, 0, 0, string.Empty, DataRowVersion.Default, null));
            return command;
        }
        /// <summary>
        /// 构建 SqlCommand 对象(用来返回一个结果集，而不是一个整数值)
        /// </summary>
        /// <param name="connection">数据库连接</param>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>SqlCommand</returns>
        private static SqlCommand BuildQueryCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(storedProcName, connection);
            command.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter parameter in parameters)
            {
                if (parameter != null)
                {
                    // 检查未分配值的输出参数,将其分配以DBNull.Value.
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    command.Parameters.Add(parameter);
                }
            }

            return command;
        }
        public static object GetSingle(string SQLString)
        {
            if (dbType == "SqlServer")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                    {
                        try
                        {
                            connection.Open();
                            object obj = cmd.ExecuteScalar();
                            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                            {
                                return null;
                            }
                            else
                            {
                                return obj;
                            }
                        }
                        catch (System.Data.SqlClient.SqlException e)
                        {
                            connection.Close();
                            throw e;
                        }
                    }
                }
            }
            else if (dbType == "Oracle")
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    using (OracleCommand cmd = new OracleCommand(SQLString, connection))
                    {
                        try
                        {
                            connection.Open();
                            object obj = cmd.ExecuteScalar();
                            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                            {
                                return null;
                            }
                            else
                            {
                                return obj;
                            }
                        }
                        catch (System.Data.OracleClient.OracleException e)
                        {
                            connection.Close();
                            throw e;
                        }
                    }
                }
            }
            else
            {
                return null;
            }
        }

        public static object GetSingle(string SQLString,string K3Connectionstring)
        {
            if (dbType == "SqlServer")
            {
                using (SqlConnection connection = new SqlConnection(K3Connectionstring))
                {
                    using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                    {
                        try
                        {
                            connection.Open();
                            object obj = cmd.ExecuteScalar();
                            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                            {
                                return null;
                            }
                            else
                            {
                                return obj;
                            }
                        }
                        catch (System.Data.SqlClient.SqlException e)
                        {
                            connection.Close();
                            throw e;
                        }
                    }
                }
            }
            else if (dbType == "Oracle")
            {
                using (OracleConnection connection = new OracleConnection(K3Connectionstring))
                {
                    using (OracleCommand cmd = new OracleCommand(SQLString, connection))
                    {
                        try
                        {
                            connection.Open();
                            object obj = cmd.ExecuteScalar();
                            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                            {
                                return null;
                            }
                            else
                            {
                                return obj;
                            }
                        }
                        catch (System.Data.OracleClient.OracleException e)
                        {
                            connection.Close();
                            throw e;
                        }
                    }
                }
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）。
        /// </summary>
        /// <param name="SQLString">计算查询结果语句</param>
        /// <returns>查询结果（object）</returns>
        public static object GetSingle(string SQLString, params OracleParameter[] cmdParms)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand cmd = new OracleCommand())
                {
                    try
                    {
                        OlePrepareCommand(cmd, connection, null, SQLString, cmdParms);
                        object obj = cmd.ExecuteScalar();
                        cmd.Parameters.Clear();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        throw e;
                    }
                }
            }
        }
        public static object GetSingle(string SQLString, params SqlParameter[] cmdParms)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                        object obj = cmd.ExecuteScalar();
                        cmd.Parameters.Clear();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        throw e;
                    }
                }
            }
        }

     

        private static void OlePrepareCommand(OracleCommand cmd, OracleConnection conn, OracleTransaction trans, string cmdText, OracleParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;//cmdType;
            if (cmdParms != null)
            {


                foreach (OracleParameter parameter in cmdParms)
                {
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(parameter);
                }
            }
        }
        private static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, string cmdText, SqlParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;//cmdType;
            if (cmdParms != null)
            {


                foreach (SqlParameter parameter in cmdParms)
                {
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(parameter);
                }
            }
        }

        public static ArrayList Select(string sql)
        {
            return Select(sql, null);
        }
        public static ArrayList Select(string sql, Hashtable args)
        {
            DataTable data = new DataTable();

            bool isConn = conn != null;

            DbConnection con = getConn();

            if (dbType == "Oracle")
            {
                OracleCommand cmd = new OracleCommand(sql, (OracleConnection)con);
                if (args != null) SetArgs(sql, args, cmd);

                OracleDataAdapter adapter = new OracleDataAdapter(sql, connectionString);
                adapter.Fill(data);
            }
            else if (dbType == "SqlServer")
            {
                SqlCommand cmd = new SqlCommand(sql, (SqlConnection)con);
                if (args != null) SetArgs(sql, args, cmd);

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connectionString);
                adapter.Fill(data);
            }

            if (isConn == false)
            {
                EndConn();
            }

            return DataTable2ArrayList(data);
        }
        public static void Execute(string sql)
        {
            Execute(sql, null);
        }
        public static void Execute(string sql, Hashtable args)
        {
            bool isConn = conn != null;
            DbConnection con = getConn();

            if (dbType == "Oracle")
            {
                OracleCommand cmd = new OracleCommand(sql, (OracleConnection)con);
                if (args != null) SetArgs(sql, args, cmd);
                cmd.ExecuteNonQuery();
            }
            else if (dbType == "SqlServer")
            {
                SqlCommand cmd = new SqlCommand(sql, (SqlConnection)con);
                if (args != null) SetArgs(sql, args, cmd);
                cmd.ExecuteNonQuery();
            }

            if (isConn == false)
            {
                EndConn();
            }
        }
        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public static DataSet Query(string SQLString)
        {
            if (dbType == "SqlServer")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    DataSet ds = new DataSet();
                    try
                    {
                        connection.Open();
                        SqlDataAdapter command = new SqlDataAdapter(SQLString, connection);
                        command.Fill(ds, "ds");
                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    return ds;
                }
            }
            else if (dbType == "Oracle")
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    DataSet ds = new DataSet();
                    try
                    {

                        connection.Open();
                        OracleDataAdapter command = new OracleDataAdapter(SQLString, connection);
                        command.Fill(ds, "ds");
                    }
                    catch (System.Data.OracleClient.OracleException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    return ds;
                }
            }
            else
            {
                return null;
            }
        }

        public static DataSet Query(string SQLString,string SetconnectionString)
        {
            if (dbType == "SqlServer")
            {
                using (SqlConnection connection = new SqlConnection(SetconnectionString))
                {
                    DataSet ds = new DataSet();
                    try
                    {
                        connection.Open();
                        SqlDataAdapter command = new SqlDataAdapter(SQLString, connection);
                        command.Fill(ds, "ds");
                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    return ds;
                }
            }
            else if (dbType == "Oracle")
            {
                using (OracleConnection connection = new OracleConnection(SetconnectionString))
                {
                    DataSet ds = new DataSet();
                    try
                    {

                        connection.Open();
                        OracleDataAdapter command = new OracleDataAdapter(SQLString, connection);
                        command.Fill(ds, "ds");
                    }
                    catch (System.Data.OracleClient.OracleException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    return ds;
                }
            }
            else
            {
                return null;
            }
        }
        #region 私有
        private static void SetArgs(string sql, Hashtable args, IDbCommand cmd)
        {
            if (dbType == "Oracle")
            {
                MatchCollection ms = Regex.Matches(sql, @"@\w+");
                int i = 1;
                foreach (Match m in ms)
                {
                    string key = m.Value;
                    string newKey = ":P" + i++;
                    sql = sql.Replace(key, newKey);

                    Object value = args[key];
                    if (value == null)
                    {
                        value = args[key.Substring(1)];
                    }
                    if (value == null)
                        cmd.Parameters.Add(new OracleParameter(newKey, DBNull.Value));
                    else
                        cmd.Parameters.Add(new OracleParameter(newKey, value));

                }
                cmd.CommandText = sql;
            }
            else if (dbType == "SqlServer")
            {
                MatchCollection ms = Regex.Matches(sql, @"@\w+");
                int i = 1;
                foreach (Match m in ms)
                {
                    string key = m.Value;

                    Object value = args[key];
                    if (value == null)
                    {
                        value = args[key.Substring(1)];
                    }
                    if (value == null) value = DBNull.Value;

                    cmd.Parameters.Add(new SqlParameter(key, value));
                }
                cmd.CommandText = sql;
            }
        }
        public static ArrayList DataTable2ArrayList(DataTable data)
        {
            ArrayList array = new ArrayList();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow row = data.Rows[i];

                Hashtable record = new Hashtable();
                for (int j = 0; j < data.Columns.Count; j++)
                {
                    object cellValue = row[j];
                    if (cellValue.GetType() == typeof(DBNull))
                    {
                        cellValue = null;
                    }
                    record[data.Columns[j].ColumnName] = cellValue;
                }
                array.Add(record);
            }
            return array;
        }
        /// <summary>
        /// 执行SQL语句，返回影响的记录数
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSql(string SQLString)
        {
            if (dbType == "SqlServer")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                    {
                        try
                        {
                            connection.Open();
                            int rows = cmd.ExecuteNonQuery();
                            return rows;
                        }
                        catch (System.Data.SqlClient.SqlException e)
                        {
                            connection.Close();
                            throw e;
                        }
                    }
                }
            }
            else if (dbType == "Oracle")
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    using (OracleCommand cmd = new OracleCommand(SQLString, connection))
                    {
                        try
                        {
                            connection.Open();
                            int rows = cmd.ExecuteNonQuery();
                            return rows;
                        }
                        catch (System.Data.OracleClient.OracleException e)
                        {
                            connection.Close();
                            throw e;
                        }
                    }
                }
            }
            else
            {
                return 0;
            }
        }


        
        public static int ExecuteSql(string SQLString,string SQLConnectstring)
        {
            if (dbType == "SqlServer")
            {
                using (SqlConnection connection = new SqlConnection(SQLConnectstring))
                {
                    using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                    {
                        try
                        {
                            connection.Open();
                            int rows = cmd.ExecuteNonQuery();
                            return rows;
                        }
                        catch (System.Data.SqlClient.SqlException e)
                        {
                            connection.Close();
                            throw e;
                        }
                    }
                }
            }
            else if (dbType == "Oracle")
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    using (OracleCommand cmd = new OracleCommand(SQLString, connection))
                    {
                        try
                        {
                            connection.Open();
                            int rows = cmd.ExecuteNonQuery();
                            return rows;
                        }
                        catch (System.Data.OracleClient.OracleException e)
                        {
                            connection.Close();
                            throw e;
                        }
                    }
                }
            }
            else
            {
                return 0;
            }
        }
        #endregion
    }
}
