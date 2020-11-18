using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joker.DBUtility;
using Joker.Model;

namespace Joker.DAL
{
    public class Info_deviceDAL
    {
        public Info_deviceDAL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int deviceID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Info_device");
            strSql.Append(" where deviceID=SQL2012deviceID");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012deviceID", SqlDbType.Int,4)
            };
            parameters[0].Value = deviceID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Info_deviceModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Info_device(");
            strSql.Append("deviceNum,deviceCount,IsDelete)");
            strSql.Append(" values (");
            strSql.Append("SQL2012deviceNum,SQL2012deviceCount,SQL2012IsDelete)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012deviceNum", SqlDbType.VarChar,50),
                    new SqlParameter("SQL2012deviceCount", SqlDbType.Int,4),
                    new SqlParameter("SQL2012IsDelete", SqlDbType.Bit,1)};
            parameters[0].Value = model.deviceNum;
            parameters[1].Value = model.deviceCount;
            parameters[2].Value = model.IsDelete;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Info_deviceModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Info_device set ");
            strSql.Append("deviceNum=SQL2012deviceNum,");
            strSql.Append("deviceCount=SQL2012deviceCount,");
            strSql.Append("IsDelete=SQL2012IsDelete");
            strSql.Append(" where deviceID=SQL2012deviceID");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012deviceNum", SqlDbType.VarChar,50),
                    new SqlParameter("SQL2012deviceCount", SqlDbType.Int,4),
                    new SqlParameter("SQL2012IsDelete", SqlDbType.Bit,1),
                    new SqlParameter("SQL2012deviceID", SqlDbType.Int,4)};
            parameters[0].Value = model.deviceNum;
            parameters[1].Value = model.deviceCount;
            parameters[2].Value = model.IsDelete;
            parameters[3].Value = model.deviceID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int deviceID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Info_device ");
            strSql.Append(" where deviceID=SQL2012deviceID");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012deviceID", SqlDbType.Int,4)
            };
            parameters[0].Value = deviceID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string deviceIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Info_device ");
            strSql.Append(" where deviceID in (" + deviceIDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Info_deviceModel GetModel(int deviceID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 deviceID,deviceNum,deviceCount,IsDelete from Info_device ");
            strSql.Append(" where deviceID=SQL2012deviceID");
            SqlParameter[] parameters = {
                    new SqlParameter("SQL2012deviceID", SqlDbType.Int,4)
            };
            parameters[0].Value = deviceID;

            Info_deviceModel model = new Info_deviceModel();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Info_deviceModel DataRowToModel(DataRow row)
        {
            Info_deviceModel model = new Info_deviceModel();
            if (row != null)
            {
                if (row["deviceID"] != null && row["deviceID"].ToString() != "")
                {
                    model.deviceID = int.Parse(row["deviceID"].ToString());
                }
                if (row["deviceNum"] != null)
                {
                    model.deviceNum = row["deviceNum"].ToString();
                }
                if (row["deviceCount"] != null && row["deviceCount"].ToString() != "")
                {
                    model.deviceCount = int.Parse(row["deviceCount"].ToString());
                }
                if (row["IsDelete"] != null && row["IsDelete"].ToString() != "")
                {
                    if ((row["IsDelete"].ToString() == "1") || (row["IsDelete"].ToString().ToLower() == "true"))
                    {
                        model.IsDelete = true;
                    }
                    else
                    {
                        model.IsDelete = false;
                    }
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select deviceID,deviceNum,deviceCount,IsDelete ");
            strSql.Append(" FROM Info_device ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" deviceID,deviceNum,deviceCount,IsDelete ");
            strSql.Append(" FROM Info_device ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM Info_device ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.deviceID desc");
            }
            strSql.Append(")AS Row, T.*  from Info_device T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("SQL2012tblName", SqlDbType.VarChar, 255),
					new SqlParameter("SQL2012fldName", SqlDbType.VarChar, 255),
					new SqlParameter("SQL2012PageSize", SqlDbType.Int),
					new SqlParameter("SQL2012PageIndex", SqlDbType.Int),
					new SqlParameter("SQL2012IsReCount", SqlDbType.Bit),
					new SqlParameter("SQL2012OrderType", SqlDbType.Bit),
					new SqlParameter("SQL2012strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Info_device";
			parameters[1].Value = "deviceID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
